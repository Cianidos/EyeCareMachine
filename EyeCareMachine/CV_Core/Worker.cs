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
        private ICamera _camera;
        private IClassifier _faceFinder, _eyeLFinder, _eyeRFinder;
        private Emgu.CV.Tracking.Tracker _faceTracker, _eyeLTracker, _eyeRTracker;
        private Mat _frame;
        private Mat _faceMat;
        private Rectangle _faceRect, _eyeLRect, _eyeRRect;

        public bool Tracking { get; set; }

        public Worker()
        {
            _camera = new Camera();
            _faceFinder = new FaceClassifier();
            _eyeLFinder = new EyeClassifier("D:\\Projects\\source\\repos\\EyeCareMachine\\EyeCareMachine\\res\\haarcascade_eye_tree_eyeglasses.xml");
            _eyeRFinder = new EyeClassifier("D:\\Projects\\source\\repos\\EyeCareMachine\\EyeCareMachine\\res\\haarcascade_eye_tree_eyeglasses.xml");
            _frame = new Mat();
        }

        public void TrackingInit()
        {
            _faceTracker = new TrackerBoosting();
            _faceTracker.Init(_frame, _faceRect);
            _eyeLTracker = new TrackerBoosting();
            _eyeLTracker.Init(_frame, _eyeLRect);
            _eyeRTracker = new TrackerBoosting();
            _eyeRTracker.Init(_frame, _eyeRRect);
        }

        public void Work ()
        {
            _camera.GetFrame(ref _frame);
            //Processing();

            if (Tracking)
            {
                Track();
            }
            else
            {
                Detection();
            }
        }

        public StdImg GetImage()
        {

            DrawRects(new[] { _faceRect, _eyeLRect, _eyeRRect });
            return _frame.ToImage<Bgr, Byte>();
        }

        public StdImg GetFace()
        {
            return _faceMat.ToImage<Bgr, Byte>();
        }

        private void Track()
        {
            _faceTracker.Update(_frame, out _faceRect);
            _faceMat = new Mat(_frame , _faceRect);
            _eyeLTracker.Update(_faceMat, out _eyeLRect);
            _eyeRTracker.Update(_faceMat, out _eyeRRect);
        }

        private void Detection()
        { 
            _faceRect = ChooseFace(_faceFinder.Detect(ref _frame));
            _faceMat = new Mat(_frame , _faceRect);
            _eyeLRect = ChooseFace(_eyeLFinder.Detect(ref _faceMat));            
            _eyeRRect = ChooseFace(_eyeRFinder.Detect(ref _faceMat));            
        }

        private Rectangle ChooseFace(in Rectangle[] rectangles)
        {
            return rectangles.Length == 1 ? rectangles.Max() : new Rectangle();
        }
        

        private void Processing()
        {
            CvInvoke.CvtColor(_frame, _frame,  ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(_frame, _frame);
        }
        private void DrawRects(Rectangle[] rectangles)
        {
            foreach(var rec in rectangles)
            {
                CvInvoke.Rectangle(_frame, rec, new MCvScalar(125, 20, 255));
            }
        }

    }
}
