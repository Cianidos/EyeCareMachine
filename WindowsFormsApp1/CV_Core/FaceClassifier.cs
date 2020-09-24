using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CV_Core
{
    class FaceClassifier : IClassifier
    {
        private const string path = "D:\\Projects\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\res\\haarcascade_frontalface_alt.xml";
        private readonly CascadeClassifier classer;

        public FaceClassifier()
        {
            classer = new CascadeClassifier(path);
        }

        public void Detect(IInputArray image, out Rectangle[] rec)
        {
            rec = Detect(image);
        }
        public Rectangle[] Detect(IInputArray image)
        {
            return classer.DetectMultiScale(image);
        }
    }
}
