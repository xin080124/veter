using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


using System.Diagnostics;
using System.Threading;

namespace TimerPLay
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pic1;
		private System.Windows.Forms.PictureBox pic2;
		private System.Windows.Forms.PictureBox pic3;
		private System.Timers.Timer timer1;
		private System.Timers.Timer timer2;
		private System.Timers.Timer timer3;
		private System.Timers.Timer timer4;
		private System.Timers.Timer timer5;
		private System.Windows.Forms.Label label1;
		private System.Timers.Timer timer6;
		private System.Windows.Forms.Button button1;
        private PictureBox pictureBox1;

        private int leftOrigin;
        private int timeTick1;
        private int timeTick2;
        private int timeTick3;
        private DateTime raceStart, raceStart3;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            leftOrigin = pic1.Left;

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Timers.Timer();
            this.timer2 = new System.Timers.Timer();
            this.timer3 = new System.Timers.Timer();
            this.timer4 = new System.Timers.Timer();
            this.timer5 = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.timer6 = new System.Timers.Timer();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(12, 56);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(88, 96);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseClick);
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(16, 168);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(84, 96);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic2_MouseClick);
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(16, 280);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(88, 96);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic3_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 500D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // timer2
            // 
            this.timer2.Interval = 500D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // timer3
            // 
            this.timer3.Interval = 5000D;
            this.timer3.SynchronizingObject = this;
            this.timer3.Elapsed += new System.Timers.ElapsedEventHandler(this.timer3_Elapsed);
            // 
            // timer4
            // 
            this.timer4.Interval = 2000D;
            this.timer4.SynchronizingObject = this;
            this.timer4.Elapsed += new System.Timers.ElapsedEventHandler(this.timer4_Elapsed);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000D;
            this.timer5.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(152, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "A clock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer6
            // 
            this.timer6.Interval = 1000D;
            this.timer6.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "On / Off";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 156);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(560, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void pic1_MouseClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(" user pic1_MouseClick ");
            //leftOrigin = pic1.Left;
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            else
            {
                timer1.Enabled = true;
                timer1.Interval = 500;
                timer1.Start();
            }
        }

        private void timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeTick2++;
            string timeStr = " timer2 tick " + timeTick2.ToString();
            Debug.WriteLine(timeStr);

            DateTime rightNow;
            TimeSpan howLong;
            rightNow = DateTime.Now;
            howLong = rightNow - raceStart;
            if(howLong.TotalMilliseconds >=5000)
            {
                timer2.Stop();
                timer2.Enabled = false;
            }
            //lblLapTimer.Text = DisplayTimeSpan(howLong);
            
            int offset = 30;
            pic2.Left += offset;
            
        }

        private void pic2_MouseClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(" user pic2_MouseClick ");
            raceStart = DateTime.Now;

            //leftOrigin = pic2.Left;
            if (pic2.Left > leftOrigin+100)
            {
                //do nothing;
            }
            else
            {
                timer2.Enabled = true;
                timer2.Interval = 500;
                timer2.Start();
            }
            
        }

        private void timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeTick3++;
            string timeStr = " timer3 tick " + timeTick3.ToString();
            Debug.WriteLine(timeStr);

            if (pic3.Left == leftOrigin)
            {
                DateTime rightNow;
                TimeSpan howLong;
                rightNow = DateTime.Now;
                howLong = rightNow - raceStart3;
                if (howLong.TotalMilliseconds > 2000)
                {
                    int offset = 50;
                    pic3.Left += offset;
                    timeTick3 = 0;
                }
            }
            else
            {
                int offset = 50 + timeTick3 * 10;
                pic3.Left += offset;
                if (pic3.Left > 500)
                {
                    raceStart3 = DateTime.Now;
                    pic3.Left = leftOrigin;
                }
                    
            }
            
        }

        private void pic3_MouseClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(" user pic1_MouseClick ");
            if(!timer3.Enabled)
            {
                raceStart3 = DateTime.Now;
                //leftOrigin = pic1.Left;
                timer3.Enabled = true;
                timer3.Interval = 300;
                timer3.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer4.Enabled == false)
            {
                timer4.Enabled = true;
                timer4.Interval = 1000;
                timer4.Start();
            }
            else
            {
                timer4.Enabled = false;
                timer4.Stop();
            }
        }

        private void timer4_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            label1.Text = DateTime.Now.ToString("h : mm : ss tt");
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeTick1++;
            string timeStr = " timer1 tick " + timeTick1.ToString();
            Debug.WriteLine(timeStr);
            //pic1.Location.X += 50;  //the ide banned the operation of changing X value;
            //pictureBox1.Left

            int offset = 50;
            if (pic1.Right < 450)
                pic1.Left += offset;
            else
                pic1.Left = leftOrigin;
        }
    }
}
