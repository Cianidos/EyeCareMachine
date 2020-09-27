using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCareMachine.CV_Core
{

    class FaceClassifier : AClassifier
    {
        public FaceClassifier(string path = "D:\\Projects\\source\\repos\\EyeCareMachine\\EyeCareMachine\\res\\haarcascade_frontalface_alt.xml") : base(path)
        {
        }
    }
}
