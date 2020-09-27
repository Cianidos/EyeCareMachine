namespace EyeCareMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.b_start = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chb_tracking = new System.Windows.Forms.CheckBox();
            this.b_track_init = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.b_track_init);
            this.splitContainer1.Panel1.Controls.Add(this.chb_tracking);
            this.splitContainer1.Panel1.Controls.Add(this.b_start);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1109, 640);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 0;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(12, 12);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(971, 640);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chb_tracking
            // 
            this.chb_tracking.AutoSize = true;
            this.chb_tracking.Location = new System.Drawing.Point(12, 78);
            this.chb_tracking.Name = "chb_tracking";
            this.chb_tracking.Size = new System.Drawing.Size(68, 17);
            this.chb_tracking.TabIndex = 1;
            this.chb_tracking.Text = "Tracking";
            this.chb_tracking.UseVisualStyleBackColor = true;
            this.chb_tracking.CheckedChanged += new System.EventHandler(this.chb_tracking_CheckedChanged);
            // 
            // b_track_init
            // 
            this.b_track_init.Location = new System.Drawing.Point(13, 42);
            this.b_track_init.Name = "b_track_init";
            this.b_track_init.Size = new System.Drawing.Size(75, 23);
            this.b_track_init.TabIndex = 2;
            this.b_track_init.Text = "Track Init";
            this.b_track_init.UseVisualStyleBackColor = true;
            this.b_track_init.Click += new System.EventHandler(this.b_track_init_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1109, 640);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timer1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.CheckBox chb_tracking;
        private System.Windows.Forms.Button b_track_init;
    }
}

