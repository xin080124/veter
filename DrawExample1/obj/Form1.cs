using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DrawExample1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private bool willShowNothing, willShowLine, willShowElipse, willShowRect;
		private System.Windows.Forms.Button button5;
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Line";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 32);
			this.button2.TabIndex = 2;
			this.button2.Text = "Elipse";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(296, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 32);
			this.button3.TabIndex = 3;
			this.button3.Text = "Rectangle";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(424, 336);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 32);
			this.button4.TabIndex = 4;
			this.button4.Text = "Draw On/Off";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.panel1.Location = new System.Drawing.Point(392, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(312, 320);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(560, 336);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(120, 32);
			this.button5.TabIndex = 9;
			this.button5.Text = "Draw Temp";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(728, 378);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button5,
																		  this.panel1,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1});
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
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

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		///this controls drawing on the form and runs every time
		///the form needs to be redrawn
		///The flags that control how the drawing is done are set by
		///the buttons at the bottom of the screen
		{
			
			if (willShowNothing)
			{
				return;
			}
			Graphics g = e.Graphics;
			if (willShowLine)
			{
				Pen pn = new Pen( Color.Blue,4 );
				Point pt1 = new Point( 30, 30);
				Point pt2 = new Point( 110, 100);
				g.DrawLine( pn, pt1, pt2 );
			}
			if (willShowElipse)
			{
				Rectangle rect = new Rectangle(50, 50, 200, 100);
				Pen pn = new Pen( Color.Azure,3 );
				g.DrawEllipse( pn, rect );
			}
			if (willShowRect)
			{
				Rectangle rect = new Rectangle(50, 50, 200, 100);
				Pen pn = new Pen( Color.Chocolate,2 );
				g.DrawRectangle(pn,rect);
			}
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		//controls how the panel is painted
		{
			Graphics g = e.Graphics; //graphics object for the panel1 control

			//draw a line
			Pen pn = new Pen( Color.Red,2 );
			Point pt1 = new Point( 30, 30);
			Point pt2 = new Point( 110, 100);
			g.DrawLine( pn, pt1, pt2 );

			//draw a filled rectangle
			Rectangle rect = new Rectangle(50, 150, 200, 150);
			LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
			g.FillRectangle(lBrush,rect);

			//draw some text
			Font fnt = new Font("Arial", 16);
			g.DrawString("Text drawn using GDI+", fnt, new SolidBrush(Color.DarkCyan), 14,10);


		}

		private void button1_Click(object sender, System.EventArgs e)
		///The form's Paint event handler will draw a line
		///The line 
		///		this.Invalidate(); 
		///will force the form to be re painted
		{
			willShowNothing = false;
			willShowLine = !willShowLine;
			this.Invalidate();
		}

		private void button2_Click(object sender, System.EventArgs e)
		///The form's Paint event handler will draw an ellipse
		///The line 
		///		this.Invalidate(); 
		///will force the form to be re painted
		{
			willShowNothing = false;
			willShowElipse = !willShowElipse;
			this.Invalidate();
		}

		private void button3_Click(object sender, System.EventArgs e)
		///The form's Paint event handler will draw a rectangle
		///The line 
		///		this.Invalidate(); 
		///will force the form to be re painted
		{
			willShowNothing = false;
			willShowRect = !willShowRect;
			this.Invalidate();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
		///The form's Paint event handler will return without drawing
		///any extra graphics
		///The line 
		///		this.Invalidate(); 
		///will force the form to be re painted
			willShowNothing = ! willShowNothing;
			this.Invalidate();
		}

		bool drawEllipse = false;


		private void button5_Click(object sender, System.EventArgs e)
		///creates a graphics object for immediate drawing independant of the
		///paint event. Problem is when the form is forced to repaint
		///this drawing will vanish
		{
			// Toggle whether to draw the ellipse or not
			drawEllipse = !drawEllipse;

			Graphics g = this.CreateGraphics(); //allows drawing on the form
			try 
			{
			     if( drawEllipse ) 
				 {
			          // Draw the ellipse
			          g.FillEllipse(Brushes.DarkBlue, this.ClientRectangle);
			     }
				 else 
				 {
			          // Erase the previously drawn ellipse
			          g.FillEllipse(SystemBrushes.Control, this.ClientRectangle);
			     }
			}
			finally 
			{
			     g.Dispose(); //Need to dispose of graphics objects if
							  //we are responsible for creating them
			}

		}
	}
}
