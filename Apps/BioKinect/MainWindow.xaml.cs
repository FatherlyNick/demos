namespace BioKinect
{
    using System.IO;
    using System.Windows;
    using System.Windows.Media;
    using Microsoft.Kinect;
    using Microsoft.Kinect.Toolkit;
    using System;
    using System.Text;
    using System.Windows.Threading;


    public partial class MainWindow : Window {
        //global vars
        private KinectSensorChooser sensorChooser;

        public bool aDebug = false; //advanced debug mode
        public bool sDebug = false;// simple debug mode
        public int range = 7; //debug int to use in the random midpoint generator, will determine which bones to ask for

        //timer variables
        public DispatcherTimer timer; //timer used in the game
        public TimeSpan time;
        public bool skeletonVisible = false; //if skeleton is visible or not. Used to start the timer only when skeleton frame is detected


        private int requestCoordInt = 0; //used in the random int generator
        private string requestCoordStr = ""; //this will be displayed on the mainWindow as the requested joint
        private Point pointerCoord = new Point(); //will store the coordinates of the pointing hand (right hand) - no need for this
        private bool boneFound = true; //will toggle when joint is found.
        private Random rnd = new Random(); //random number for the question purpose
        private Point midpoint = new Point(); //stores the X Y of the requested bone's midpoint
        private Point uSkullMid = new Point(); //special point used only in case of skull [update skull midpoint]
        private double[] error = new double[2];//used to see how far is the pointer off the requested coordinates
        
        private int scoreCount = 0;//the score of the game.
        public int difficultyLevel; //this is set via the Main Menu screen

        private Joint jPointer = new Joint();//under test for pointer
        private Point jPoint1 = new Point();//used in Midpoint method as (x1, y1)
        private Point jPoint2 = new Point();//used in Midpoint method as (x2, y2)

                
        private const float RenderWidth = 640.0f; //used as the render boarder as per the resolution
        private const float RenderHeight = 480.0f; //render boarder as per the resolution
        private DrawingGroup drawingGroup;
        private DrawingImage imageSource;


        private const double JointThickness = 3;
        private const double BodyCenterThickness = 10;
        private const double ClipBoundsThickness = 10;

        private readonly Brush trackedJointBrush = new SolidColorBrush(Color.FromArgb(255, 128, 128, 128)); //alpha, R, G, B on joints (grey)
        private readonly Brush gridBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); //brush used for the pointer

        private readonly Brush inferredJointBrush = Brushes.Yellow; //sprite to draw on inferred joints
        private readonly Pen trackedBonePen = new Pen(Brushes.White, 6); //bone color
        private readonly Pen inferredBonePen = new Pen(Brushes.Gray, 2); //bone color used to fill inferred bones (invisible bones)

        private KinectSensor sensor; //kinect sensor

        
        public MainWindow() {
            InitializeComponent(); 
        }


        //#### PROCEDURES AT STARTUP ####
        //anything that can be pre-processed/cached should be placed in here
        private void WindowLoaded(object sender, RoutedEventArgs e) {
            //timer
            time = TimeSpan.FromSeconds(difficultyLevel); //start the timer depending on the difficulty set
            
            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate {
                if (time == TimeSpan.Zero) { //if zero is reached
                    timer.Stop(); //stop counting
                    timer.IsEnabled = false; //disable the timer when time is 0
                    try{
                        Close();
                    }catch(Exception exception) {
                        //in case the shut down procedure did not succ
                    }
                    //this.sensorChooser.Stop(); //stop the sensor chooser in this window
                } 
                else if(skeletonVisible == true && timerMode.IsChecked.Value == true) {
                    time = time.Add(TimeSpan.FromSeconds(-1));
                    timerWindow.Text = time.TotalSeconds.ToString();//show the seconds remaining
                } //not zero, keep counting down
            }, Application.Current.Dispatcher);
            timer.IsEnabled = false; //prevent the timer ticking prematurely

            requestedBone.Text = ""; //text box hardcoded text
            scoreBoard.Text = "0"; //initial score count
            timerWindow.Text = " ##"; //inserts some symbols into the timer display.

            //find the Kinect
            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start(); //start up the sensor


            // Create the drawing group we'll use for drawing
            this.drawingGroup = new DrawingGroup();

            // Create an image source that we can use in our image control
            this.imageSource = new DrawingImage(this.drawingGroup);

            // Display the drawing using our image control
            Image.Source = this.imageSource;

            //assigning a Kinect
            foreach(var potentialSensor in KinectSensor.KinectSensors) {
                if(potentialSensor.Status == KinectStatus.Connected) {
                    this.sensor = potentialSensor;
                    break;
                }
            }

            //starting up the Kinect
            if(null != this.sensor) {
                // Turn on the skeleton stream to receive skeleton frames
                this.sensor.SkeletonStream.Enable();

                // Add an event handler to be called whenever there is new color frame data
                this.sensor.SkeletonFrameReady += this.SensorSkeletonFrameReady;

                try{
                    this.sensor.Start();
                }catch (IOException) {
                    this.sensor = null;
                }
            }
        }


        //#### PROCEDURES WHEN THE WINDOW IS CLOSING ####
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            
            if (null != this.sensor) {
                this.sensor.Stop(); //let go of the sensor
                this.sensor.SkeletonStream.Disable();
                //this.sensorChooser.Stop();
            }
            StopKinectStreams(); //shut down all Kinect streams
            
            if(time.TotalSeconds == 0) {
                MessageBox.Show("Times up!\nYour Final score was: " + scoreCount, "Game Over", MessageBoxButton.OK);
            }
            Window1 mainMenuScreen = new Window1();
            mainMenuScreen.Show(); //open the appScreen window
        }

        //#### PROCEDURES TO CLOSE KINECT STREAMS ####
        public void StopKinectStreams() {
   
            if (this.sensor == null) {
                return;
            }

            if (this.sensor.SkeletonStream.IsEnabled) {
                this.sensor.SkeletonStream.Disable();
            }

            if (this.sensor.ColorStream.IsEnabled) {
                this.sensor.ColorStream.Disable();
            }

            if (this.sensor.DepthStream.IsEnabled) {
                this.sensor.DepthStream.Disable();
            }

            // detach event handlers for skeletal stream
            this.sensor.SkeletonFrameReady -= this.SensorSkeletonFrameReady;

            try {
                this.sensor.Stop();
            }
            catch (Exception e) {
                MessageBox.Show("Exception while shutting down the Kinect Streams\n"+e.ToString());
            }
}

        //#### VIEW THE KINECT CONNECTION STATUS ####
        private void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args) {

            bool error = false;

            if (args.OldSensor != null) {
                try {
                    args.OldSensor.DepthStream.Range = DepthRange.Default;
                    args.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    args.OldSensor.DepthStream.Disable();
                    args.OldSensor.SkeletonStream.Disable();
                }
                catch (InvalidOperationException) {

                    //Something went wrong
                    error = true;
                }
            }
            //new sensor detected
            if(args.NewSensor != null) {

                try {

                    args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    args.NewSensor.SkeletonStream.Enable();

                }
                catch (InvalidOperationException) {

                    //something went wrong
                    error = true;
                }

                if(error) {
                    //something went wrong, display an error
                    MessageBox.Show("Something went wrong during Kinect Init");
                   
                }
            }//end if
        }


        //#### GET SKELETAL DATA FROM A FRAME ####
        private void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e) {
            Skeleton[] skeletons = new Skeleton[0];

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame()) {
                if (skeletonFrame != null) {
                    
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);

                }else{skeletonVisible = false;}
            }
            
            using (DrawingContext dc = this.drawingGroup.Open()) {
                //Drawing a background as per the set resolution
                dc.DrawRectangle(Brushes.Black, null, new Rect(0.0, 0.0, RenderWidth, RenderHeight));
                
                if (skeletons.Length != 0) {
                    
                    foreach (Skeleton skel in skeletons) {

                        if (skel.TrackingState == SkeletonTrackingState.Tracked) {
                            skeletonVisible = true;
                            this.DrawBonesAndJoints(skel, dc);
                        }
                    }
                }

                // prevent drawing outside of our render area
                this.drawingGroup.ClipGeometry = new RectangleGeometry(new Rect(0.0, 0.0, RenderWidth, RenderHeight));
                
            }
            
        }


        //drawing bones between the joints
        private void DrawBonesAndJoints(Skeleton skeleton, DrawingContext drawingContext) {
            jPointer = skeleton.Joints[JointType.HandRight];
            // Render Torso
            this.DrawBone(skeleton, drawingContext, JointType.Head, JointType.ShoulderCenter);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.ShoulderLeft);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.ShoulderRight);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.Spine);
            this.DrawBone(skeleton, drawingContext, JointType.Spine, JointType.HipCenter);
            this.DrawBone(skeleton, drawingContext, JointType.HipCenter, JointType.HipLeft);
            this.DrawBone(skeleton, drawingContext, JointType.HipCenter, JointType.HipRight);

            // Left Arm
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderLeft, JointType.ElbowLeft);
            this.DrawBone(skeleton, drawingContext, JointType.ElbowLeft, JointType.WristLeft);
            this.DrawBone(skeleton, drawingContext, JointType.WristLeft, JointType.HandLeft);

            // Right Arm
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderRight, JointType.ElbowRight);
            this.DrawBone(skeleton, drawingContext, JointType.ElbowRight, JointType.WristRight);
            this.DrawBone(skeleton, drawingContext, JointType.WristRight, JointType.HandRight);

            // Left Leg
            this.DrawBone(skeleton, drawingContext, JointType.HipLeft, JointType.KneeLeft);
            this.DrawBone(skeleton, drawingContext, JointType.KneeLeft, JointType.AnkleLeft);
            this.DrawBone(skeleton, drawingContext, JointType.AnkleLeft, JointType.FootLeft);

            // Right Leg
            this.DrawBone(skeleton, drawingContext, JointType.HipRight, JointType.KneeRight);
            this.DrawBone(skeleton, drawingContext, JointType.KneeRight, JointType.AnkleRight);
            this.DrawBone(skeleton, drawingContext, JointType.AnkleRight, JointType.FootRight);
            
            boneFound = findBone(boneFound, skeleton); //all of the 'game' logic in here

            jointCoords.Text = returnCoords(skeleton); //add the coords for debug depending on the debug level set
            drawingContext.DrawEllipse(gridBrush, null, SkeletonPointToScreen(jPointer.Position), 10, 10); //draw pointer brush

            if(aDebug ==true){
                drawingContext.DrawEllipse(gridBrush, null, midpoint, 15, 15); //draw the midpoint
            }
            pointerCoord.X = SkeletonPointToScreen(jPointer.Position).X; //sets the pointerCoord = X
            pointerCoord.Y = SkeletonPointToScreen(jPointer.Position).Y; //sets the pointerCoord = Y
            
            // Render Joints
            foreach (Joint joint in skeleton.Joints) {
                Brush drawBrush = null;

                if (joint.TrackingState == JointTrackingState.Tracked) {
                    drawBrush = this.trackedJointBrush;                    
                }
                else if (joint.TrackingState == JointTrackingState.Inferred) {
                    drawBrush = this.inferredJointBrush;
                }
                if (drawBrush != null) {
                    drawingContext.DrawEllipse(drawBrush, null, this.SkeletonPointToScreen(joint.Position), JointThickness, JointThickness);
                    
                }
            }
        }


        //#### a debug method to display coordinates and other debug information ####
        private string returnCoords(Skeleton skeleton) {
            StringBuilder dump = new StringBuilder(); //similar to string stream in C++
            if(aDebug == true) { //Advanced Debug mode ON

                //pointer coordinates
                dump.Append("Pointer:" + SkeletonPointToScreen(jPointer.Position).ToString());

                //the coordinates of the two joints that represent the bone
                dump.AppendLine("Joint1" + jPoint1.ToString()); //X1,Y1 
                dump.Append("Joint2" + jPoint2.ToString()); //X2,Y2

                //request coordinates
                dump.AppendLine("ReqPX:" + midpoint.X.ToString());
                dump.Append("\nReqPY:" + midpoint.Y.ToString());

                //Head coordinates
                dump.AppendLine("Head:"+( SkeletonPointToScreen((skeleton.Joints[JointType.Head].Position))).ToString());

                //WristLeft
                dump.AppendLine("lWrist:"+(SkeletonPointToScreen( (skeleton.Joints[JointType.WristLeft].Position) )).ToString());

                //WristRight
                dump.AppendLine("rWrist:"+(SkeletonPointToScreen( (skeleton.Joints[JointType.WristRight].Position) )).ToString());

                //KneeRight
                dump.AppendLine("rKneeX:"+(SkeletonPointToScreen( (skeleton.Joints[JointType.KneeRight].Position) )).ToString());

                //KneeLeft
                dump.AppendLine("lKnee X:"+(SkeletonPointToScreen( (skeleton.Joints[JointType.KneeLeft].Position) )).ToString());
                
                //display the set difficulty level
                dump.AppendLine("Diff lvl:" + difficultyLevel);

            return dump.ToString();

            }else if(sDebug == true) { //simple Debug mode ON

                //pointer coords
                dump.Append("Pointer:" + SkeletonPointToScreen(jPointer.Position).ToString());

                //request coordinates
                dump.AppendLine("ReqPX:" + midpoint.X.ToString());
                dump.Append("\nReqPY:" + midpoint.Y.ToString());

                //difficulty level
                dump.AppendLine("diff lvl:" + difficultyLevel);

                return dump.ToString();
            }
            else { 
                
                return ""; //All debug OFF
            }
        }


        //#### ASSIGN A BONE USING A RANDOM INT # CHECK IF THE REQUESTED BONE WAS FOUND ####
        private bool findBone(bool status, Skeleton skeleton) {

            if(status == false) {
                //bone still not found
                timer.IsEnabled = true;//timer starts when skeleton is detected
                midpoint = updateMidPoint(requestCoordInt, skeleton);
                //check if the user is pointing at the bone
                if(inRange(midpoint, pointerCoord)) {
                    requestedBone.Text = "";//reset the requested bone text box
                    scoreCount++; //give points for bone found
                    scoreBoard.Text = scoreCount.ToString();//display the score 
                    status = true; //bone is found
                    //MessageBox.Show("Correct!"); //***system breaker***
                }
            }

            //init status or the requested bone was found
            if(status == true) {

                requestCoordInt = rnd.Next(1,range); //random int for a request joint. range is set by the difficulty
                midpoint = updateMidPoint(requestCoordInt, skeleton);
                if (requestCoordInt == 1) {
                    requestCoordStr = "Skull";
                }else if(requestCoordInt == 2) {
                    requestCoordStr = "Left Humerus";
                }else if(requestCoordInt == 3) {
                    requestCoordStr = "Left Radius+Ulna";
                }else if(requestCoordInt == 4) {
                    requestCoordStr = "Left Femur";
                }else if(requestCoordInt == 5) {
                    requestCoordStr = "Rib cage";
                }else if(requestCoordInt == 6) {
                    requestCoordStr = "Right Femur";
                }else if(requestCoordInt == 7) {
                    requestCoordStr = "Left Tibia+Fibula";
                }else if(requestCoordInt == 8) {
                    requestCoordStr = "Right Tibia+Fibula";
                }

                //set the textbox to say the requested bone name
                status = false; //reset the bone found status to false
                requestedBone.Text = requestCoordStr; //set the contents of the requested bone box
            }
            return status; //return if the bone was found in this frame or not
        }


        //#### GETS JOINTS AND CALCULATES THE MIDPOINT BETWEEN THEM ####
        private Point getMidPoint(Joint joint1, Joint joint2) {

            jPoint1 = SkeletonPointToScreen(joint1.Position); //(x1, y1)
            jPoint2 = SkeletonPointToScreen(joint2.Position); //(x2, y2)

            midpoint.X = ((jPoint1.X + jPoint2.X) / 2); // X
            midpoint.Y = ((jPoint1.Y + jPoint2.Y) / 2); // Y

            return midpoint;
        }


        //#### UPDATES THE MIDPOINT DEPENDING ON WHICH BONE WAS REQUESTED ####
        private Point updateMidPoint(int boneInt, Skeleton skeleton) {

            if(boneInt == 1) {
                //skull
                uSkullMid = SkeletonPointToScreen(skeleton.Joints[JointType.Head].Position); //sets the (X,Y) of skull
                return uSkullMid;

            }else if(boneInt == 2) {
                //left humerus
                return getMidPoint( (skeleton.Joints[JointType.ShoulderLeft]),
                                    (skeleton.Joints[JointType.ElbowLeft]) );

            }else if(boneInt == 3) {
                //radius+ulna
                return getMidPoint( (skeleton.Joints[JointType.ElbowLeft]),
                                    (skeleton.Joints[JointType.WristLeft]) );

            }else if(boneInt == 4) {
                //left Femur
                return getMidPoint( (skeleton.Joints[JointType.HipLeft]),
                                    (skeleton.Joints[JointType.KneeLeft]) );

            }else if(boneInt == 5) {
                //rib cage
                return getMidPoint( (skeleton.Joints[JointType.Spine]),
                                    (skeleton.Joints[JointType.ShoulderCenter]) );

            }else if(boneInt == 6) {
                //Right Femur
                return getMidPoint((skeleton.Joints[JointType.HipRight]),
                                    (skeleton.Joints[JointType.KneeRight]));

            }else if(boneInt == 7) {
                //Left Tibia+Fibula
                return getMidPoint((skeleton.Joints[JointType.KneeLeft]),
                                    (skeleton.Joints[JointType.AnkleLeft]));

            }else { //boneInt=8
                //Right Tibia+Fibula
                return getMidPoint( (skeleton.Joints[JointType.KneeRight]),
                                    (skeleton.Joints[JointType.AnkleRight]) );
            }
        }


        //#### GET TWO POINTS AND SEE IF THE FIRST IS CLOSE TO THE SECOND ####
        private bool inRange(Point value1, Point value2) {
            //value1 -> pointer
            //value2 -> requested coordinate
            error[0] = value1.X - value2.X;
            error[1] = value1.Y - value2.Y;

            if(error[0] < 0) {
                error[0] = error[0] * -1;
            }if(error[1] < 0) {
                error[1] = error[1] * -1;
            }
            
            if(error[0] <=15 && error[1] <=15) {
             //value is in range
                return true;
            }
            else {
                //value is not in range
                return false;
            }
        }


        //#### CONVERT THE KINECT COORDINATES TO WPF COORDINATES ####
        private Point SkeletonPointToScreen(SkeletonPoint skelpoint) {
            //convert the Kinect depth coordinates into WPF coordinates
            DepthImagePoint depthPoint = this.sensor.CoordinateMapper.MapSkeletonPointToDepthPoint(skelpoint, DepthImageFormat.Resolution640x480Fps30);
            return new Point(depthPoint.X, depthPoint.Y);
        }


        //#### DRAW A LINE FROM JOINT0 TO JOINT1 ####
        private void DrawBone(Skeleton skeleton, DrawingContext drawingContext, JointType jointType0, JointType jointType1) {
            Joint joint0 = skeleton.Joints[jointType0];
            Joint joint1 = skeleton.Joints[jointType1];

            // If we can't find either of these joints, exit
            if(joint0.TrackingState == JointTrackingState.NotTracked ||
                joint1.TrackingState == JointTrackingState.NotTracked) {
                return;
            }

            // Don't draw if both points are inferred
            if(joint0.TrackingState == JointTrackingState.Inferred &&
                joint1.TrackingState == JointTrackingState.Inferred) {
                return;
            }

            // We assume all drawn bones are inferred unless BOTH joints are tracked
            Pen drawPen = this.inferredBonePen;
            if(joint0.TrackingState == JointTrackingState.Tracked && joint1.TrackingState == JointTrackingState.Tracked) {
                drawPen = this.trackedBonePen;
            }

            drawingContext.DrawLine(drawPen, this.SkeletonPointToScreen(joint0.Position), 
                this.SkeletonPointToScreen(joint1.Position));
            
        }


        //standard debug mode
        private void DebugCheckChanged(object sender, RoutedEventArgs e) {
            if(debugMode.IsChecked.Value == true) {
                sDebug = true;
            }
            else {
                sDebug = false;
            }
        }

        //advanced debug mode
        private void aDebugCheckChanged(object sender, RoutedEventArgs e) {
            if(advancedDebugMode.IsChecked.Value == true) {
                aDebug = true;
            }
            else {
                aDebug = false;
            }
        }

        
        //checkbox if the lower legs should be included or not. UNCHECKED by default
        private void legModeChanged(object sender, RoutedEventArgs e) {
            if(legMode.IsChecked.Value == true) {
                range = 9; //all bones
            }
            else {
                range = 7; //upper body only + Femur bones
            }
        }

        private void timerModeChanged(object sender, RoutedEventArgs e) {
            if(timerMode.IsChecked.Value == true) {
                timer.IsEnabled = true;
            }
            else{
                timer.IsEnabled = false;
            }

        }
    }
}