using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CountDown
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Timer tmrClock;
		private System.Windows.Forms.Label lblSecs;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TextBox txtLaps;
		private System.Windows.Forms.Label lblLapTimer;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Timer tmrLaps;
		private System.Windows.Forms.Button btnlapStart;
		private System.Windows.Forms.Button btnLap;
		private System.Windows.Forms.Button btnStop;
		private bool noSeconds = false;
		private DateTime raceStart, lastlapStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown spinSec;
		private System.Windows.Forms.NumericUpDown spinMin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStartTimer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRemaining;
		private System.Windows.Forms.Timer tmrTimer;
		private int lapCount;
		private DateTime timeIntervalBegan, timeIntervalEnd;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.Timer tmrQuit;
		private System.Windows.Forms.Timer tmrCountdown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCheck;

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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblSecs = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblLapTimer = new System.Windows.Forms.Label();
			this.txtLaps = new System.Windows.Forms.TextBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnLap = new System.Windows.Forms.Button();
			this.btnlapStart = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lblRemaining = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStartTimer = new System.Windows.Forms.Button();
			this.spinMin = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.spinSec = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.btnCheck = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.tmrClock = new System.Windows.Forms.Timer(this.components);
			this.tmrLaps = new System.Windows.Forms.Timer(this.components);
			this.tmrTimer = new System.Windows.Forms.Timer(this.components);
			this.tmrQuit = new System.Windows.Forms.Timer(this.components);
			this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spinSec)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2,
																					  this.tabPage3,
																					  this.tabPage4});
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(360, 248);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.lblSecs,
																				   this.lblDate,
																				   this.lblTime});
			this.tabPage1.Location = new System.Drawing.Point(4, 31);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(352, 213);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Clock";
			// 
			// lblSecs
			// 
			this.lblSecs.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblSecs.Location = new System.Drawing.Point(184, 16);
			this.lblSecs.Name = "lblSecs";
			this.lblSecs.Size = new System.Drawing.Size(136, 40);
			this.lblSecs.TabIndex = 2;
			this.lblSecs.Click += new System.EventHandler(this.lblSecs_Click);
			// 
			// lblDate
			// 
			this.lblDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblDate.Location = new System.Drawing.Point(40, 72);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(280, 40);
			this.lblDate.TabIndex = 1;
			// 
			// lblTime
			// 
			this.lblTime.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblTime.Location = new System.Drawing.Point(40, 16);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(120, 40);
			this.lblTime.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.lblLapTimer,
																				   this.txtLaps,
																				   this.btnStop,
																				   this.btnLap,
																				   this.btnlapStart});
			this.tabPage2.Location = new System.Drawing.Point(4, 31);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(352, 213);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Laps";
			// 
			// lblLapTimer
			// 
			this.lblLapTimer.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblLapTimer.Location = new System.Drawing.Point(104, 8);
			this.lblLapTimer.Name = "lblLapTimer";
			this.lblLapTimer.Size = new System.Drawing.Size(232, 40);
			this.lblLapTimer.TabIndex = 5;
			// 
			// txtLaps
			// 
			this.txtLaps.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.txtLaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLaps.Location = new System.Drawing.Point(104, 56);
			this.txtLaps.Multiline = true;
			this.txtLaps.Name = "txtLaps";
			this.txtLaps.ReadOnly = true;
			this.txtLaps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLaps.Size = new System.Drawing.Size(232, 128);
			this.txtLaps.TabIndex = 4;
			this.txtLaps.Text = "";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(16, 88);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 32);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnLap
			// 
			this.btnLap.Location = new System.Drawing.Point(16, 48);
			this.btnLap.Name = "btnLap";
			this.btnLap.Size = new System.Drawing.Size(75, 32);
			this.btnLap.TabIndex = 2;
			this.btnLap.Text = "Lap";
			this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
			// 
			// btnlapStart
			// 
			this.btnlapStart.Location = new System.Drawing.Point(16, 8);
			this.btnlapStart.Name = "btnlapStart";
			this.btnlapStart.Size = new System.Drawing.Size(75, 32);
			this.btnlapStart.TabIndex = 1;
			this.btnlapStart.Text = "Start";
			this.btnlapStart.Click += new System.EventHandler(this.btnlapStart_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.lblRemaining,
																				   this.label3,
																				   this.btnStartTimer,
																				   this.spinMin,
																				   this.label2,
																				   this.spinSec,
																				   this.label1});
			this.tabPage3.Location = new System.Drawing.Point(4, 31);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(352, 213);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Timer";
			// 
			// lblRemaining
			// 
			this.lblRemaining.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblRemaining.Location = new System.Drawing.Point(168, 136);
			this.lblRemaining.Name = "lblRemaining";
			this.lblRemaining.Size = new System.Drawing.Size(136, 32);
			this.lblRemaining.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "remaining";
			// 
			// btnStartTimer
			// 
			this.btnStartTimer.Location = new System.Drawing.Point(128, 72);
			this.btnStartTimer.Name = "btnStartTimer";
			this.btnStartTimer.Size = new System.Drawing.Size(96, 40);
			this.btnStartTimer.TabIndex = 5;
			this.btnStartTimer.Text = "Start";
			this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
			// 
			// spinMin
			// 
			this.spinMin.Location = new System.Drawing.Point(104, 16);
			this.spinMin.Maximum = new System.Decimal(new int[] {
																	60,
																	0,
																	0,
																	0});
			this.spinMin.Name = "spinMin";
			this.spinMin.Size = new System.Drawing.Size(72, 29);
			this.spinMin.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Minutes";
			// 
			// spinSec
			// 
			this.spinSec.Location = new System.Drawing.Point(272, 16);
			this.spinSec.Maximum = new System.Decimal(new int[] {
																	60,
																	0,
																	0,
																	0});
			this.spinSec.Name = "spinSec";
			this.spinSec.Size = new System.Drawing.Size(72, 29);
			this.spinSec.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(184, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seconds";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.btnCheck,
																				   this.label4,
																				   this.dtpTime,
																				   this.dtpDate});
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(352, 222);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Countdown";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(24, 50);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 24);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Check";
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label4.Location = new System.Drawing.Point(48, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(264, 104);
			this.label4.TabIndex = 2;
			this.label4.Text = "label4";
			// 
			// dtpTime
			// 
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTime.Location = new System.Drawing.Point(144, 48);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.TabIndex = 1;
			this.dtpTime.Value = new System.DateTime(2005, 1, 28, 7, 30, 0, 0);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(24, 8);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(320, 29);
			this.dtpDate.TabIndex = 0;
			this.dtpDate.Value = new System.DateTime(2005, 1, 31, 0, 0, 0, 0);
			// 
			// tmrClock
			// 
			this.tmrClock.Enabled = true;
			this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
			// 
			// tmrLaps
			// 
			this.tmrLaps.Tick += new System.EventHandler(this.tmrLaps_Tick);
			// 
			// tmrTimer
			// 
			this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(376, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1});
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "A Clock and Countdown timer";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spinMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spinSec)).EndInit();
			this.tabPage4.ResumeLayout(false);
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

		private void tmrClock_Tick(object sender, System.EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("h : mm  tt");
			if (!noSeconds)
			{
				lblSecs.Text = DateTime.Now.ToString("ss : ff");
			}
			
			lblDate.Text = DateTime.Now.ToString("dddd d MMMM yyyy");
		}

		private void lblSecs_Click(object sender, System.EventArgs e)
		{
			noSeconds = !noSeconds;
		}


		private void btnlapStart_Click(object sender, System.EventArgs e)
		{
			lapCount = 0;
			txtLaps.Text = "";
			raceStart = DateTime.Now;
			lastlapStop = raceStart;
			tmrLaps.Enabled = true;
		}

		private void tmrLaps_Tick(object sender, System.EventArgs e)
		{
			DateTime rightNow;
			TimeSpan howLong;
			rightNow = DateTime.Now;
			howLong = rightNow - raceStart;
			lblLapTimer.Text = DisplayTimeSpan(howLong);
		}

		private void btnLap_Click(object sender, System.EventArgs e)
		{
			DateTime rightNow;
			TimeSpan howLong;
			lapCount++;
			rightNow = DateTime.Now;
			howLong = rightNow - lastlapStop;
			lastlapStop = rightNow;
			if (txtLaps.Text == "")
			{
				txtLaps.Text = lapCount.ToString() + "  " + DisplayTimeSpan(howLong);  
			}
			else
			{
				txtLaps.Text = txtLaps.Text + "\r\n" 
					+ lapCount.ToString() + "  " + DisplayTimeSpan(howLong);
			}

		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			tmrLaps.Enabled = false;
			btnLap_Click(sender, e);
		}

		private string DisplayTimeSpan(TimeSpan howLong)
		{
			return(
				
				howLong.Hours.ToString("00") + ":"
				+ howLong.Minutes.ToString("00") + ":"
				+ howLong.Seconds.ToString("00") + ":"
				+ howLong.Milliseconds.ToString("0000"));
		}

		private string DisplayLongTimeSpan(TimeSpan howLong)
		{
			return(
				howLong.Days.ToString("0") + " days" + "\r\n"
				+ howLong.Hours.ToString("0") + " hours" + "\r\n"
				+ howLong.Minutes.ToString("0") + " minutes" + "\r\n"
				+ howLong.Seconds.ToString("0") + " seconds" + "\r\n"
				);
		}

		private void btnStartTimer_Click(object sender, System.EventArgs e)
		{
			tmrTimer.Enabled = true;
			TimeSpan ts = new TimeSpan(0,0,(int)spinMin.Value,(int)spinSec.Value,0);
			timeIntervalEnd = DateTime.Now + ts;
			timeIntervalBegan = DateTime.Now;
		}

		private void tmrTimer_Tick(object sender, System.EventArgs e)
		{
			if (timeIntervalEnd >= DateTime.Now)
			{
				lblRemaining.Text = DisplayTimeSpan(timeIntervalEnd - DateTime.Now);
			}
			else
			{
				tmrTimer.Enabled = false;
				lblRemaining.Text = "Finished";
			}
		}

		private void btnCheck_Click(object sender, System.EventArgs e)
		{
			DateTime When;
			When = new DateTime(dtpDate.Value.Year,dtpDate.Value.Month,dtpDate.Value.Day
								,dtpTime.Value.Hour,dtpTime.Value.Minute,dtpTime.Value.Second);
			label4.Text = DisplayLongTimeSpan(When - DateTime.Now);
		}

	}
}
