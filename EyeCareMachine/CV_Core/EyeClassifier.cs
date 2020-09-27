using System.Drawing;
using Emgu.CV;

namespace EyeCareMachine.CV_Core
{
    class EyeClassifier : AClassifier
    {
        public EyeClassifier(string path= "D:\\Projects\\source\\repos\\EyeCareMachine\\EyeCareMachine\\res\\frontalEyes35x16.xml") : base(path)
        {
        }
    }
}