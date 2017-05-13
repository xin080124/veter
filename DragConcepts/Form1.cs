using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DragConcepts
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Color ChangeColor = Color.Orange;
		private bool isComplete = false;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnComplete;
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnComplete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(144, 24);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(112, 32);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.panel1.Location = new System.Drawing.Point(144, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 56);
			this.panel1.TabIndex = 2;
			// 
			// btnComplete
			// 
			this.btnComplete.Location = new System.Drawing.Point(464, 24);
			this.btnComplete.Name = "btnComplete";
			this.btnComplete.Size = new System.Drawing.Size(96, 32);
			this.btnComplete.TabIndex = 3;
			this.btnComplete.Text = "Complete";
			this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(24, 104);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(576, 174);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnComplete);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label1);
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

		private void label1_Click(object sender, System.EventArgs e)
		{
			ChangeColor = (sender as Label).BackColor;
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			btnComplete.Focus();
			UntilComplete();  //loop until the [Complete] button clicked
			panel1.BackColor = ChangeColor;
			isComplete = false;
		}

		private void UntilComplete()
		{
			int temp = 0;
			while (!isComplete)
			{
				temp++;
				if (temp % 200000 == 0) Text += "~";
				Application.DoEvents(); //process any events that happen
			}
		}

		private void btnComplete_Click(object sender, System.EventArgs e)
		{
			isComplete = true;
		}
	}
}
