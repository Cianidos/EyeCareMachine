using Emgu.CV;
using System.Drawing;


namespace EyeCareMachine.CV_Core
{
    interface IClassifier
    {
        void Detect(ref Mat image, out Rectangle[] rec);
        Rectangle[] Detect(ref Mat image);
    }
}