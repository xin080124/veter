using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVC_Shapes
{
	/// <summary>
	/// Summary description for ViewForm1.
	/// </summary>
	public class ViewForm3 : System.Windows.Forms.Form, IShapeView
	{
		private ShapesModel myModel;
		private System.Windows.Forms.Panel pnlDrawOn;
		private System.Windows.Forms.ComboBox cmbFilterDisplay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewForm3()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			SetStyle(ControlStyles.AllPaintingInWmPaint|
				ControlStyles.UserPaint|ControlStyles.DoubleBuffer,true);			
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
			this.pnlDrawOn = new System.Windows.Forms.Panel();
			this.cmbFilterDisplay = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// pnlDrawOn
			// 
			this.pnlDrawOn.BackColor = System.Drawing.Color.White;
			this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDrawOn.Location = new System.Drawing.Point(8, 8);
			this.pnlDrawOn.Name = "pnlDrawOn";
			this.pnlDrawOn.Size = new System.Drawing.Size(500, 380);
			this.pnlDrawOn.TabIndex = 0;
			// 
			// cmbFilterDisplay
			// 
			this.cmbFilterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbFilterDisplay.Items.AddRange(new object[] {
																  "Select display.....",
																  "All Shapes",
																  "Circles only",
																  "Squares only",
																  "Circles and Squares"});
			this.cmbFilterDisplay.Location = new System.Drawing.Point(136, 400);
			this.cmbFilterDisplay.Name = "cmbFilterDisplay";
			this.cmbFilterDisplay.Size = new System.Drawing.Size(240, 28);
			this.cmbFilterDisplay.TabIndex = 22;
			this.cmbFilterDisplay.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDisplay_SelectedIndexChanged);
			// 
			// ViewForm3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(514, 440);
			this.Controls.Add(this.cmbFilterDisplay);
			this.Controls.Add(this.pnlDrawOn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(520, 0);
			this.Name = "ViewForm3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ViewForm3";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ViewForm3_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public void RefreshView()
		{
			// clear panel
			clearPanel();
			// create arraylist of shapes from model and convery
			// to array of shapes
			ArrayList theShapeList = myModel.ShapeList;
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			// graphics object to draw shapes
			Graphics g = this.pnlDrawOn.CreateGraphics(); 
			// draw all shapes in array
			foreach (AnyShape sh in theShapes)
			{
				sh.Display(g);
			}
		}

		/// <summary>method: clearPanel
		/// clear all shapes from display on panel
		/// </summary>
		private void clearPanel()
		{
			pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
		}

		/// <summary>method: DisplayCircles
		/// display circles only
		/// </summary>
		public void DisplayCircles()
		{
			// clear panel
			clearPanel(); 
			// create arraylist of shapes from model and convery
			// to array of shapes
			ArrayList theShapeList = myModel.ShapeList;
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			// graphics object to draw shapes
			Graphics g = this.pnlDrawOn.CreateGraphics(); 
			
			foreach (AnyShape sh in theShapes)
			{
				// redraw circles only
				if (sh.name.Equals("circle"))
					sh.Display(g);					
			}
		}

		/// <summary>method: DisplaySquares
		/// display squares only
		/// </summary>
		public void DisplaySquares()
		{
			// clear panel
			clearPanel(); 
			// create arraylist of shapes from model and convery
			// to array of shapes
			ArrayList theShapeList = myModel.ShapeList;
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			// graphics object to draw shapes
			Graphics g = this.pnlDrawOn.CreateGraphics(); 
			
			foreach (AnyShape sh in theShapes)
			{
				// only draw squares
				if (sh.name.Equals("square"))
					sh.Display(g);					
			}
		}

		/// <summary>method: DisplayCirclesSquares
		///  display circles and squares only
		/// </summary>
		public void DisplayCirclesSquares()
		{
			// clear panel
			clearPanel(); 
			// create arraylist of shapes from model and convery
			// to array of shapes
			ArrayList theShapeList = myModel.ShapeList;
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			// graphics object to draw shapes
			Graphics g = this.pnlDrawOn.CreateGraphics(); 
			
			foreach (AnyShape sh in theShapes)
			{
				// only draw circles & squares
				if ((sh.name.Equals("circle"))||(sh.name.Equals("square")))
					sh.Display(g);					
			}
		}

		/// <summary>method: cmbFilterDisplay_SelectedIndexChanged
		/// work out which display method to execute based on 
		/// value selected from combo box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmbFilterDisplay_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cmbFilterDisplay.Text == "All Shapes")
				RefreshView();
			else if (cmbFilterDisplay.Text == "Circles only")
				DisplayCircles();
			else if (cmbFilterDisplay.Text == "Squares only")
				DisplaySquares();
			else if (cmbFilterDisplay.Text == "Circles and Squares")
				DisplayCirclesSquares();
		}


		/// <summary>method: ViewForm3_Load
		/// default comboFilter value to null
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ViewForm3_Load(object sender, System.EventArgs e)
		{
			cmbFilterDisplay.SelectedIndex = 0;
		}

		// set value for myModel
		public ShapesModel MyModel
		{
			set
			{
				myModel = value;
			}
		}
	}
}
