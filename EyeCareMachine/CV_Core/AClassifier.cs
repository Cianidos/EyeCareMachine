using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Cuda;

namespace EyeCareMachine.CV_Core
{
    internal class AClassifier : IClassifier
    {
        protected readonly CascadeClassifier classer;

        protected AClassifier(string path)
        {
            classer = new CascadeClassifier(path);
        }

        public void Detect(ref Mat image, out Rectangle[] rec)
        {
            rec = Detect(ref image);
        }

        public Rectangle[] Detect(ref Mat image)
        {
            return classer.DetectMultiScale(image);
        }
    }
}
