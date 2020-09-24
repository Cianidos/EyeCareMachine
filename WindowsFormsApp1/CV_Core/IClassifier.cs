using Emgu.CV;
using System.Drawing;


namespace WindowsFormsApp1.CV_Core
{
    interface IClassifier
    {
        void Detect(IInputArray image, out Rectangle[] rec);
        Rectangle[] Detect(IInputArray image);
    }
}