using EyeCareMachine.CV_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Tracking;

namespace EyeCareMachine.CV_Core
{
    using StdImg = Image<Bgr, Byte>;
    class Worker
    {
        private ICamera camera;
        private IClassifier faceFinder;
        private Emgu.CV.Tracking.Tracker tracker;
        private Mat frame;
        private Rectangle face;

        public bool Tracking { get; set; }

        public Worker()
        {
            camera = new Camera();
            faceFinder = new FaceClassifier();
            frame = new Mat();
        }

        public void TrackingInit()
        {
            tracker = new TrackerBoosting();
            tracker.Init(frame, face);
        }

        public StdImg GetImage()
        {
            camera.GetFrame(ref frame);
            //Processing();

            if (Tracking)
            { tracker.Update(frame, out face); }
            else
            { ChooseFace(faceFinder.Detect(ref frame)); }

            DrawRects(new[] { face });
            return frame.ToImage<Bgr, Byte>();
        }
        private void ChooseFace(in Rectangle[] rectangles)
        {
            if (rectangles != null)
                face = rectangles.Max<Rectangle>();
        }
        private void Processing()
        {
            CvInvoke.CvtColor(frame, frame,  ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(frame, frame);
        }
        private void DrawRects(Rectangle[] rectangles)
        {
            foreach(var rec in rectangles)
            {
                CvInvoke.Rectangle(frame, rec, new MCvScalar(125, 20, 255));
            }
        }

    }
}
