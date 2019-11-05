using System;
using System.Text;
using System.Windows;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using BioKinect;

    
namespace BioKinect {    
    
    public partial class Window1 : Window {
        
        public bool focused = true;
        public int difficultyValue = 90; //how many seconds are given to play the game [Easy by default]
        public KinectSensorChooser win1SensorChooser;

        public Window1() {

            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs) {
            gameInstructions.Text = instructionsText();
            win1SensorChooser = new KinectSensorChooser();
            win1SensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = win1SensorChooser;
           
            win1SensorChooser.Start();
        }

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

            if (args.NewSensor != null) {
                try {
                    args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    args.NewSensor.SkeletonStream.Enable();

                }
                catch (InvalidOperationException) {

                    //something went wrong
                    error = true;
                }

                if (!error) {
                    //MessageBox.Show("Added Kinect");
                    //no errors, add the detected Kinect
                    kinectRegion.KinectSensor = args.NewSensor;
                }
                else {
                    MessageBox.Show("Something went wrong.");
                }
            }//end if
        }

        private string instructionsText() {

            return @">> BIOKINECT <<


The objective of the game is to learn about the bones in a human body.

[Controls]:
At startup, put your hands down by your waist. Once the IR light lights up, put up your right hand and wait for the hand cursor to appear on screen. Move your hand over a button you would like to press and push your hand forward until the hand cursor begins to fill in.

[How to play]:
Simply put your right hand on the bone that you think the game is asking for before the timer runs out. If done correctly, you will get a point. Score as many points as you can in the given time!

[Difficulty modes]: 
Easy = 90 seconds
Medium = 60 seconds;
Hard = 30 seconds";

        }

        private void PlayButtonClick(object sender, RoutedEventArgs e) {
            MainWindow appScr = new MainWindow(); //create new instance of the game window
            appScr.difficultyLevel = difficultyValue; //send the set difficulty level in the game window
            appScr.Show(); //open the appScreen window
            win1SensorChooser.Stop(); //let go of the sensor in this window.
            this.Close();//close the windows
        }

        private void InstructionButtonClick(object sender, RoutedEventArgs e) {
            win1SensorChooser.Stop(); //stop the sensor chooser

            Instructions insScr = new Instructions();
            insScr.Show(); //open the instructions window
            this.Close(); // close current window
        }

        private void easyClick(object sender, RoutedEventArgs e) {
            difficultyValue = 90;
            difficultyTick.Text = "<<<";
            difficultyTick.VerticalAlignment = VerticalAlignment.Top;
        }

        private void mediumClick(object sender, RoutedEventArgs e) {
            difficultyValue = 60;
            difficultyTick.Text = "<<<";
            difficultyTick.VerticalAlignment = VerticalAlignment.Center;
        }

        private void hardClick(object sender, RoutedEventArgs e) {
            difficultyValue = 30;
            difficultyTick.Text = "<<<";
            difficultyTick.VerticalAlignment = VerticalAlignment.Bottom;
        }
    }
}
