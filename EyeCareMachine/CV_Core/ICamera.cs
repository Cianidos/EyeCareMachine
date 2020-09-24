using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCareMachine.CV_Core
{
    interface ICamera
    {
        void GetFrame(ref Emgu.CV.Mat frame);
    }
}
