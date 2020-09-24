using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCareMachine.CV_Core
{
    class Camera : ICamera
    {
        private VideoCapture capture;

        public Camera()
        {
            capture = new VideoCapture(0);
            capture.Start();
        }
        public void GetFrame(ref Mat frame)
        {
            capture.Read(frame);
        }
        ~Camera()
        {
            capture.Stop();
        }
    }
}
