using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
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
			((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer6)).BeginInit();
			this.SuspendLayout();
			// 
			// pic1
			// 
			this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
			this.pic1.Location = new System.Drawing.Point(16, 56);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(88, 96);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic1.TabIndex = 0;
			this.pic1.TabStop = false;
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
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.SynchronizingObject = this;
			// 
			// timer2
			// 
			this.timer2.Interval = 500;
			this.timer2.SynchronizingObject = this;
			// 
			// timer3
			// 
			this.timer3.Interval = 5000;
			this.timer3.SynchronizingObject = this;
			// 
			// timer4
			// 
			this.timer4.Interval = 2000;
			this.timer4.SynchronizingObject = this;
			// 
			// timer5
			// 
			this.timer5.Interval = 1000;
			this.timer5.SynchronizingObject = this;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(152, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "A clock";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer6
			// 
			this.timer6.Interval = 1000;
			this.timer6.SynchronizingObject = this;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(376, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "On / Off";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(560, 381);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pic3);
			this.Controls.Add(this.pic2);
			this.Controls.Add(this.pic1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer6)).EndInit();
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


	}
}
