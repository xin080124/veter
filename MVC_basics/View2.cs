using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVC_basics
{
	/// <summary>
	/// Summary description for View2.
	/// </summary>
	public class View2 : System.Windows.Forms.Form, IView
	{
		private ModelX myModel;
		private Random rdn = new Random();
		
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public View2(ModelX theModel)
		{
			InitializeComponent();
			myModel = theModel;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label1.Location = new System.Drawing.Point(152, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 232);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add number";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// View2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(336, 246);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Location = new System.Drawing.Point(400, 100);
			this.Name = "View2";
			this.Text = "View2";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			//get a new random number and add it to the model's data
			int n;
			n = rdn.Next(11,20);
			myModel.Add(n);
		}

		public void UpdateView()
		{
			//ask the model for a copy of the current data
			int[] data = myModel.Numbers;

			//display the current data
			label1.Text = "";
			foreach (int n in data)
			{
				label1.Text += dots(n) + "\r\n";
			}
		}

		private string dots(int n)
		{
			string temp = "";
			for (int i = 1; i <= n; i++)
			{
				temp += ".";
			}
			return temp;
		}

	}
}