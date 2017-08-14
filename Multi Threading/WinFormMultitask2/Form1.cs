using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace WinFormMultitask1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		delegate void StringParameterDelegate (string value);
		/// Lock around target and currentCount
		readonly object stateLock = new object();
		int target;
		int currentCount;
    	Random rng = new Random();

		private System.Windows.Forms.Label lblStatusIndicator;
		private System.Windows.Forms.Button btnStartThread;
		private System.Windows.Forms.Button btnStart2ndThread;
		private System.Windows.Forms.Button btnClear;
		public System.Windows.Forms.TextBox txtCount;
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
			this.lblStatusIndicator = new System.Windows.Forms.Label();
			this.btnStartThread = new System.Windows.Forms.Button();
			this.btnStart2ndThread = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblStatusIndicator
			// 
			this.lblStatusIndicator.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblStatusIndicator.Location = new System.Drawing.Point(200, 16);
			this.lblStatusIndicator.Name = "lblStatusIndicator";
			this.lblStatusIndicator.Size = new System.Drawing.Size(216, 352);
			this.lblStatusIndicator.TabIndex = 0;
			// 
			// btnStartThread
			// 
			this.btnStartThread.Location = new System.Drawing.Point(16, 16);
			this.btnStartThread.Name = "btnStartThread";
			this.btnStartThread.Size = new System.Drawing.Size(152, 48);
			this.btnStartThread.TabIndex = 1;
			this.btnStartThread.Text = "Start Thread";
			this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
			// 
			// btnStart2ndThread
			// 
			this.btnStart2ndThread.Location = new System.Drawing.Point(16, 104);
			this.btnStart2ndThread.Name = "btnStart2ndThread";
			this.btnStart2ndThread.Size = new System.Drawing.Size(152, 48);
			this.btnStart2ndThread.TabIndex = 3;
			this.btnStart2ndThread.Text = "Start Thread";
			this.btnStart2ndThread.Click += new System.EventHandler(this.btnStart2ndThread_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(16, 200);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(152, 48);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtCount
			// 
			this.txtCount.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCount.Location = new System.Drawing.Point(456, 16);
			this.txtCount.Multiline = true;
			this.txtCount.Name = "txtCount";
			this.txtCount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCount.Size = new System.Drawing.Size(136, 352);
			this.txtCount.TabIndex = 5;
			this.txtCount.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(624, 389);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnStart2ndThread);
			this.Controls.Add(this.btnStartThread);
			this.Controls.Add(this.lblStatusIndicator);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
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

		private void btnStartThread_Click(object sender, System.EventArgs e)
		{
			btnStartThread.Enabled = false;
			lock (stateLock)
			{
				target = rng.Next(20);
			}
			Thread t = new Thread(new ThreadStart(ThreadJob));
			t.IsBackground = true;
			t.Start();
		}

		void ThreadJob()
		//this is the method that will be run by the thread
		{
			int localTarget;
			lock (stateLock)
			{
				localTarget = target;
			}
			UpdateStatus("Starting");
        
			lock (stateLock)
			{
				currentCount = 0;
			}
			Counter aCount = new Counter(currentCount, localTarget-1, this);
			MethodInvoker updateCounterDelegate = new MethodInvoker(aCount.DoCount);

			// Pause before starting
			Thread.Sleep(500);
			//UpdateStatus("Counting from 0 to " + (target-1).ToString()); //shared variable error 
			UpdateStatus("Counting to " + (localTarget-1).ToString());//no error
			
			for (int i=0; i < localTarget; i++)
			{
				lock (stateLock)
				{
					currentCount = i;
				}
				// Synchronously show the counter
				aCount.updateGotTo(i);
				BeginInvoke (updateCounterDelegate);
				Thread.Sleep(100);
			}
			UpdateStatus("Finished count to " + (localTarget-1).ToString());
			BeginInvoke(new MethodInvoker(EnableButton));
		}

		void UpdateStatus(string info)
		{
			if (InvokeRequired)
			{
				// We're not in the UI thread, so we need to call BeginInvoke
				info += " . ";
				BeginInvoke(new StringParameterDelegate(UpdateStatus), new object[]{info});
				return;
			}
			// Must be on the UI thread if we've got this far
			lblStatusIndicator.Text += "\r\n" + info;
		}
    
    
		void EnableButton()
		{
			btnStartThread.Enabled = true;
		}

		private void btnStart2ndThread_Click(object sender, System.EventArgs e)
		{
			lock (stateLock)
			{
				target = rng.Next(30);
			}
			Thread t = new Thread(new ThreadStart(ThreadJob));
			t.IsBackground = true;
			t.Start();
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			lblStatusIndicator.Text = "";
			txtCount.Text = "";
		}


	}

	public class Counter
	{
		private int GotTo;
		private int Target;
		private Form1 theForm;

		public Counter(int zGotTo, int zTarget, Form1 aForm)
		{
			GotTo = zGotTo;
			Target = zTarget;
			theForm = aForm;
		}

		public void updateGotTo(int gotTo)
		{
			GotTo = gotTo;
		}

		public void DoCount()
		{
			theForm.txtCount.Text += GotTo.ToString() + " -> " + Target.ToString() + "\r\n";
		}
	}

}
