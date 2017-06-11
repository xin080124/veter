using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TrackingCircles
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private ArrayList allColorPoints;
		private Color penColor = Color.Blue;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuExit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
			this.label1.Size = new System.Drawing.Size(738, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Try clicking on the form several times then try left clicking, saving from the me" +
				"nu etc.";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuNew,
																					  this.menuOpen,
																					  this.menuSave,
																					  this.menuItem5,
																					  this.menuExit});
			this.menuItem1.Text = "File";
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.Text = "New";
			this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 1;
			this.menuOpen.Text = "Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuSave
			// 
			this.menuSave.Index = 2;
			this.menuSave.Text = "Save";
			this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 4;
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "dtz";
			this.openFileDialog1.Filter = "\"Dot files (*.dtz)|*.dtz|All files (*.*)|*.*\"";
			this.openFileDialog1.FilterIndex = 0;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "dtz";
			this.saveFileDialog1.FileName = "doc1";
			this.saveFileDialog1.Filter = "\"Dot files (*.dtz)|*.dtz|All files (*.*)|*.*\"";
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(816, 546);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
			this.Name = "Form3";
			this.Text = "Form3";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
			this.Load += new System.EventHandler(this.Form3_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary> method: Form3_Load
		/// Create a new ArrayList
		/// </summary>
		private void Form3_Load(object sender, System.EventArgs e)
		{
			allColorPoints = new ArrayList();
		}

		/// <summary> method: Form3_MouseUp
		/// on left mouse button up
		/// get the form's graphics surface
		/// create a ColorPoint object
		/// store the object in the allColorPoints ArrayList
		/// and finally draw the ColorPoint object on the form
		/// </summary>
		private void Form3_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Graphics g = this.CreateGraphics(); //allows drawing on the form
				ColorPoint cp = new ColorPoint(e.X, e.Y, penColor);
				allColorPoints.Add(cp);
				cp.Draw(g);
			}
		}

		/// <summary> method: Form3_Paint
		/// When the form re-paints
		/// draw circles for each ColorPoint 
		/// stored in the allColorPoints ArrayList
		/// </summary>
		private void Form3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = this.CreateGraphics(); //allows drawing on the form

			ColorPoint[] CirclePoints = (ColorPoint[])allColorPoints.ToArray(typeof(ColorPoint));
			foreach (ColorPoint cp in CirclePoints)
			{
				cp.Draw(g);
			}
		}

		/// <summary> method: Form3_MouseDown
		/// On right mouse down show a ColorDialog box
		/// and let the user choose a new color for drawing
		/// ColorPoint objects
		/// </summary>
		private void Form3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (colorDialog1.ShowDialog() == DialogResult.OK)
				{
					penColor = colorDialog1.Color;
				}
			}
		}

		/// <summary> method: menuExit_Click
		/// Close the form
		/// </summary>
		private void menuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary> method: menuNew_Click
		/// Clear the allColorPoints ArrayList of all previous data
		/// and by asking the form to re-paint itself
		/// get a display of a form with no ColorPoints
		/// </summary>
		private void menuNew_Click(object sender, System.EventArgs e)
		{
			allColorPoints.Clear();
			this.Invalidate();
		}

		/// <summary> method: menuSave_Click
		/// Get a file name
		/// For each ColorPoint in allColorPoints
		/// get its data as a comma seperated string
		/// add that string to a StringBuilder object
		/// finally save the text of the StringBuilder object
		/// to a file on the hard disk
		/// </summary>
		private void menuSave_Click(object sender, System.EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StringBuilder sb = new StringBuilder();
				ColorPoint[] CirclePoints = (ColorPoint[])allColorPoints.ToArray(typeof(ColorPoint));
				foreach (ColorPoint cp in CirclePoints)
				{
					sb.Append(cp.ToString());
				}
				string temp = sb.ToString();
				
				StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
				sw.Write(sb);
				sw.Close();
			}
		}

		/// <summary> method: menuOpen_Click
		/// Get a filename
		/// get the text in the file
		/// split the text into parts using the '#' character
		/// which marks the end of each ColorPoint record
		/// 
		/// For each ColorPoint record in string form
		/// make a ColorPoint object from it
		/// and add the ColorPoint object to the allColorPoints ArrayList
		/// finally ask the form to re-paint itself
		/// </summary>
		private void menuOpen_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				allColorPoints.Clear(); //should really ask if they want to save first
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string theDots = sr.ReadToEnd();
				sr.Close();
				string[] theLines = theDots.Split('#');
				foreach (string stringDot in theLines)
				{
					if (stringDot != "") allColorPoints.Add(new ColorPoint(stringDot));
				}
				this.Invalidate();
			}
		}
	}
}
