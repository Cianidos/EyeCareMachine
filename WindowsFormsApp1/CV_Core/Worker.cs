﻿using EyeCareMachine.CV_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace WindowsFormsApp1.CV_Core
{
    using StdImg = Image<Bgr, Byte>;
    class Worker
    {
        private ICamera camera;
        private IClassifier face;
        private Mat frame;

        public Worker()
        {
            camera = new Camera();
            face = new FaceClassifier();
            frame = new Mat();
        }

        public StdImg GetImage()
        {
            camera.GetFrame(frame);
            Processing();
            DrawRects(face.Detect(frame));
            return frame.ToImage<Bgr, Byte>();
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
