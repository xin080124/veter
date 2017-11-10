using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OpOverload1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(112, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "2,3";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(232, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "2,3";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(224, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 48);
			this.button2.TabIndex = 4;
			this.button2.Text = "Test ==";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(336, 72);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 48);
			this.button3.TabIndex = 5;
			this.button3.Text = "Test !=";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "loc1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(232, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "loc2";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(560, 269);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			Location loc1, loc2, loc3;
			loc1 = new Location(textBox1.Text);
			loc2 = new Location(textBox2.Text);
			loc3 = loc1 + loc2;
			label1.Text = loc3.ToString();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Location loc1, loc2;
			loc1 = new Location(textBox1.Text);
			loc2 = new Location(textBox2.Text);
			if (loc1 == loc2)
			{
				label1.Text = "equal";
			}
			else
			{
				label1.Text = "NOT equal";
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Location loc1, loc2;
			loc1 = new Location(textBox1.Text);
			loc2 = new Location(textBox2.Text);
			if (loc1 != loc2)
			{
				label1.Text = "loc1 not equal loc2";
			}
			else
			{
				label1.Text = "loc1 equal loc2";
			}
		}
	}
}
