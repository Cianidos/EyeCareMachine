using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Tracking;
using Emgu.CV.Util;
using EyeCareMachine.CV_Core;

namespace EyeCareMachine
{
    public partial class Form1 : Form
    {
        Worker worker;
        public Form1()
        {
            InitializeComponent();
            worker = new Worker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            } 
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            worker.Work();
            imageBox1.Image = worker.GetImage();
            imageBox2.Image = worker.GetFace();
        }

        private void chb_tracking_CheckedChanged(object sender, EventArgs e)
        {
            worker.Tracking = chb_tracking.Checked;
        }

        private void b_track_init_Click(object sender, EventArgs e)
        {
            worker.TrackingInit();
        }
    }
}
