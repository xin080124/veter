using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TrackingCircles
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private ArrayList allPoints;
		private Point[] CirclePoints;
		private System.Windows.Forms.Button btnShowForm3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
			this.btnShowForm3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(726, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Try clicking on the form several times then drag the form half off the page and b" +
				"ack";
			// 
			// btnShowForm3
			// 
			this.btnShowForm3.Location = new System.Drawing.Point(8, 424);
			this.btnShowForm3.Name = "btnShowForm3";
			this.btnShowForm3.Size = new System.Drawing.Size(256, 40);
			this.btnShowForm3.TabIndex = 2;
			this.btnShowForm3.Text = "Form 3 Storing the results";
			this.btnShowForm3.Click += new System.EventHandler(this.btnShowForm3_Click);
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(752, 466);
			this.Controls.Add(this.btnShowForm3);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form2";
			this.Text = "These circles stay painted - how?";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary> method: Form2_MouseUp
		/// on left mouse button up
		/// draw a circle on the form's graphics object
		/// and store the point used for the circle
		/// in the allPoints ArrayList
		/// </summary>
		private void Form2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Graphics g = this.CreateGraphics(); //allows drawing on the form
				Pen pn = new Pen( Color.Orange,3 );

				g.DrawEllipse(pn,e.X, e.Y, 20, 20);
				allPoints.Add(new Point(e.X, e.Y));
			}
		}

		/// <summary> method: Form2_Load
		/// create the allPoints ArrayList
		/// </summary>
		private void Form2_Load(object sender, System.EventArgs e)
		{
			allPoints = new ArrayList();
		
		}

		/// <summary> method: Form2_Paint
		/// When the form re-paints itself
		/// draw a circle for each Point found
		/// in the allPoints ArrayList 
		/// </summary>
		private void Form2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = this.CreateGraphics(); //allows drawing on the form
			Pen pn = new Pen( Color.Orange,2 );

			Point[] CirclePoints = (Point[])allPoints.ToArray(typeof(Point));
			foreach (Point pt in CirclePoints)
			{
				g.DrawEllipse(pn,pt.X, pt.Y, 20, 20);

			}
		}

		/// <summary> method: btnShowForm3_Click
		/// Create a Form3 object and display it
		/// </summary>
		private void btnShowForm3_Click(object sender, System.EventArgs e)
		{
			Form3 someForm3;
			someForm3 = new Form3();
			someForm3.Show();
		}

	}
}
