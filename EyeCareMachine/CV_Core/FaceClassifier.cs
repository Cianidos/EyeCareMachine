using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCareMachine.CV_Core
{
    class FaceClassifier : IClassifier
    {
        private const string path = "D:\\Projects\\source\\repos\\EyeCareMachine\\EyeCareMachine\\res\\haarcascade_frontalface_alt.xml";
        private readonly CascadeClassifier classer;
        public FaceClassifier()
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
