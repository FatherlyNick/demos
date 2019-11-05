using System;
using System.Text;
using System.Windows;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;

namespace BioKinect {

    public partial class Instructions : Window {

        private KinectSensorChooser sensorChooser;
        
        public Instructions() {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs) {
            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();
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
                    //no errors, add the detected Kinect
                    kinectRegion.KinectSensor = args.NewSensor;
                }


            }//end if

        }


        //#### CLOSE WINDOW BUTTON PRESS EVENT HANDLER ####
        private void CloseInstructionsClick(object sender, RoutedEventArgs e) {
            
            this.sensorChooser.Stop();
            Window1 win1 = new Window1(); //open the main menu again.
            win1.Show();
            this.Close();
            
        }

        //### EVENT HANDLERS TO OPEN URLs ####

        private void skullClick(object sender, RoutedEventArgs e) {
            iFrame.Navigate(new System.Uri("http://en.wikipedia.org/wiki/Skull", UriKind.RelativeOrAbsolute)); //open Google Earth

        }

        private void radius_ulnaClick(object sender, RoutedEventArgs e) {
            iFrame.Navigate(new System.Uri("http://en.wikipedia.org/wiki/Forearm", UriKind.RelativeOrAbsolute)); //open wikipedia link
        }

        private void ribCageClick(object sender, RoutedEventArgs e) {
            iFrame.Navigate(new System.Uri("http://en.wikipedia.org/wiki/Rib_cage", UriKind.RelativeOrAbsolute));
        }

        private void humerusClick(object sender, RoutedEventArgs e) {
            iFrame.Navigate(new System.Uri("http://en.wikipedia.org/wiki/Humerus", UriKind.RelativeOrAbsolute));
        }

        private void femurClick(object sender, RoutedEventArgs e) {
            iFrame.Navigate(new System.Uri("http://en.wikipedia.org/wiki/Femur", UriKind.RelativeOrAbsolute));
        }

        private void tibiaFibulaClick(object sender, RoutedEventArgs e) {
            iFrame.Navigate(new System.Uri("http://en.wikipedia.org/wiki/Human_leg", UriKind.RelativeOrAbsolute));
        }        
    }
}
