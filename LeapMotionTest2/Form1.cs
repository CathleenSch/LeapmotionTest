using Leap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Linq;

namespace LeapMotionTest2 {
    public partial class FrameDataForm : Form {

        private byte[] imagedata = new byte[1];
        private Controller controller = new Controller();
        Bitmap bitmap = new Bitmap(640, 480, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

        public FrameDataForm() {
            InitializeComponent();
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            controller.ImageReady += onImageReady;
            controller.ImageRequestFailed += onImageRequestFailed;

            //set greyscale palette for image Bitmap object
            ColorPalette grayscale = bitmap.Palette;
            for (int i = 0; i < 256; i++) {
                grayscale.Entries[i] = Color.FromArgb((int)255, i, i, i);
            }
            bitmap.Palette = grayscale;
        }

        void newFrameHandler(object sender, FrameEventArgs eventArgs) {
            Frame frame = eventArgs.frame;
            
            //The following are Label controls added in design view for the form
            this.displayID.Text = frame.Id.ToString();
            this.displayTimestamp.Text = frame.Timestamp.ToString();
            this.displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            this.displayHandCount.Text = frame.Hands.Count.ToString();
            this.displayArm.Text = "No arm detected";

            List<Hand> handsInFrame = frame.Hands;
            if (handsInFrame.Count > 0) {
                Hand hand1 = handsInFrame[0];

                if (hand1.Arm != null) {
                    this.displayArm.Text = "Arm detected";
                    Arm arm = hand1.Arm;

                    double angle = hand1.Direction.AngleTo(arm.Direction) * (180 / Math.PI);

                    this.displayAngle.Text = "angle hand - arm: " + angle.ToString();
                } else {
                    this.displayArm.Text = "No arm detected";
                }

                List<Finger> fingers = hand1.Fingers;
                Finger thumb = fingers[0];
                Finger index = fingers[1];

                double angleThumb = thumb.Direction.AngleTo(index.Direction) * (180 / Math.PI);

                this.displayAngleThumb.Text = "angle hand - thumb" + angleThumb.ToString();

                if (hand1.IsLeft == true) {
                    this.displayLeftOrRight.Text = "Left hand";
                } else {
                    this.displayLeftOrRight.Text = "Right hand";
                }

                this.displayPinchStrength.Text = "Pinch strength: " + hand1.PinchStrength;

                /* if (hand1.PinchStrength > 0.75) {
                    float[] tipsDistances = new float[5];
                    Vector thumbPos = thumb.TipPosition;
                    Vector pinkyPos = fingers[4].TipPosition;
                    this.displayThumbPos.Text = "thumb position: x:" + thumbPos.x + " | y:" + thumbPos.y + " | z:" + thumbPos.z;
                    this.displayPinkyPos.Text = "pinky position: x:" + pinkyPos.x + " | y:" + pinkyPos.y + " | z:" + pinkyPos.z;

                    tipsDistances[0] = 10000000000;
                    for (int i = 1; i < 5; i++) {
                        Finger finger = fingers[i];
                        Vector tipPosition = finger.TipPosition;

                        float distance = tipPosition.DistanceTo(thumbPos);
                        tipsDistances[i - 1] = distance;
                    }
                    
                    float smallestDistance = tipsDistances.Min();
                    int indexSmallestDistance = Array.IndexOf(tipsDistances, smallestDistance);
                    String pinchedFinger;
                    switch(indexSmallestDistance) {
                        case 1:
                            pinchedFinger = "index";
                            break;
                        case 2:
                            pinchedFinger = "middle";
                            break;
                        case 3:
                            pinchedFinger = "ring";
                            break;
                        case 4:
                            pinchedFinger = "pinky";
                            break;
                        default:
                            pinchedFinger = "not detected";
                            break;
                    }
                    this.displayPinchedFinger.Text = "pinched finger: " + pinchedFinger;

                    this.displayThumbIndex.Text = "distance thumb - index: " + tipsDistances[1];
                    this.displayThumbMiddle.Text = "distance thumb - middle: " + tipsDistances[2];
                    this.displayThumbRing.Text = "distance thumb - ring: " + tipsDistances[3];
                    this.displayThumbPinky.Text = "distance thumb - pinky: " + tipsDistances[4];


                } */

            }            
            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);
        }

        void onImageRequestFailed(object sender, ImageRequestFailedEventArgs e) {
            if (e.reason == Leap.Image.RequestFailureReason.Insufficient_Buffer) {
                imagedata = new byte[e.requiredBufferSize];
            }
            Console.WriteLine("Image request failed: " + e.message);
        }

        void onImageReady(object sender, ImageEventArgs e) {
            Rectangle lockArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(lockArea, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] rawImageData = imagedata;
            System.Runtime.InteropServices.Marshal.Copy(rawImageData, 0, bitmapData.Scan0, e.image.Width * e.image.Height * 2 * e.image.BytesPerPixel);
            bitmap.UnlockBits(bitmapData);
            displayImages.Image = bitmap;
        }
    }
}
