using Emgu.CV;
using System.Drawing;


namespace WindowsFormsApp1.CV_Core
{
    interface IClassifier
    {
        void Detect(ref Mat image, out Rectangle[] rec);
        Rectangle[] Detect(ref Mat image);
    }
}