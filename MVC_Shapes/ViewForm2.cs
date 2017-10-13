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
	public class ViewForm2 : System.Windows.Forms.Form, IShapeView
	{
		private ShapesModel myModel;
		// variables for max values of parameters input by user
		int max_X = 425;
		int max_Y = 325;
		int max_width = 200;
		int max_height = 200;

		private System.Windows.Forms.Panel pnlDrawOn;
		private System.Windows.Forms.RadioButton rbCircle;
		private System.Windows.Forms.RadioButton rbSquare;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtXpos;
		private System.Windows.Forms.TextBox txtYpos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Button btnAddShape;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtWidth;
		private System.Windows.Forms.RadioButton rbElipse;
		private System.Windows.Forms.RadioButton rbRectangle;
		private System.Windows.Forms.RadioButton rbTriangle;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label lblSelectColor;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnClearInput;
		private System.ComponentModel.IContainer components;

		public ViewForm2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// sets drawing style to remove blinking ***not working***
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
			this.components = new System.ComponentModel.Container();
			this.pnlDrawOn = new System.Windows.Forms.Panel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.rbCircle = new System.Windows.Forms.RadioButton();
			this.rbElipse = new System.Windows.Forms.RadioButton();
			this.rbRectangle = new System.Windows.Forms.RadioButton();
			this.rbTriangle = new System.Windows.Forms.RadioButton();
			this.rbSquare = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtXpos = new System.Windows.Forms.TextBox();
			this.txtYpos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblSelectColor = new System.Windows.Forms.Label();
			this.btnAddShape = new System.Windows.Forms.Button();
			this.btnClearInput = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlDrawOn.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDrawOn
			// 
			this.pnlDrawOn.BackColor = System.Drawing.Color.White;
			this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDrawOn.Controls.Add(this.listBox1);
			this.pnlDrawOn.Location = new System.Drawing.Point(8, 8);
			this.pnlDrawOn.Name = "pnlDrawOn";
			this.pnlDrawOn.Size = new System.Drawing.Size(500, 380);
			this.pnlDrawOn.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(24, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(440, 344);
			this.listBox1.TabIndex = 0;
			// 
			// rbCircle
			// 
			this.rbCircle.Checked = true;
			this.rbCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbCircle.Location = new System.Drawing.Point(16, 398);
			this.rbCircle.Name = "rbCircle";
			this.rbCircle.TabIndex = 1;
			this.rbCircle.TabStop = true;
			this.rbCircle.Text = "Circle";
			this.rbCircle.Click += new System.EventHandler(this.rbCircle_Click);
			// 
			// rbElipse
			// 
			this.rbElipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbElipse.Location = new System.Drawing.Point(16, 534);
			this.rbElipse.Name = "rbElipse";
			this.rbElipse.TabIndex = 3;
			this.rbElipse.Text = "Elipse";
			this.rbElipse.Click += new System.EventHandler(this.rbElipse_Click);
			// 
			// rbRectangle
			// 
			this.rbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbRectangle.Location = new System.Drawing.Point(16, 466);
			this.rbRectangle.Name = "rbRectangle";
			this.rbRectangle.TabIndex = 4;
			this.rbRectangle.Text = "Rectangle";
			this.rbRectangle.Click += new System.EventHandler(this.rbRectangle_Click);
			// 
			// rbTriangle
			// 
			this.rbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbTriangle.Location = new System.Drawing.Point(16, 500);
			this.rbTriangle.Name = "rbTriangle";
			this.rbTriangle.TabIndex = 5;
			this.rbTriangle.Text = "Triangle";
			this.rbTriangle.Click += new System.EventHandler(this.rbTriangle_Click);
			// 
			// rbSquare
			// 
			this.rbSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbSquare.Location = new System.Drawing.Point(16, 432);
			this.rbSquare.Name = "rbSquare";
			this.rbSquare.TabIndex = 2;
			this.rbSquare.Text = "Square";
			this.rbSquare.Click += new System.EventHandler(this.rbSquare_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 400);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Position";
			// 
			// txtXpos
			// 
			this.txtXpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtXpos.Location = new System.Drawing.Point(168, 432);
			this.txtXpos.Name = "txtXpos";
			this.txtXpos.Size = new System.Drawing.Size(40, 26);
			this.txtXpos.TabIndex = 7;
			this.txtXpos.Text = "";
			this.toolTip1.SetToolTip(this.txtXpos, "Maximum value for X is 425");
			this.txtXpos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
			// 
			// txtYpos
			// 
			this.txtYpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtYpos.Location = new System.Drawing.Point(168, 464);
			this.txtYpos.Name = "txtYpos";
			this.txtYpos.Size = new System.Drawing.Size(40, 26);
			this.txtYpos.TabIndex = 8;
			this.txtYpos.Text = "";
			this.toolTip1.SetToolTip(this.txtYpos, "Maximum value for Y is 325");
			this.txtYpos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(136, 432);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 24);
			this.label2.TabIndex = 9;
			this.label2.Text = "X";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(136, 464);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 24);
			this.label3.TabIndex = 10;
			this.label3.Text = "Y";
			// 
			// lblHeight
			// 
			this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblHeight.Location = new System.Drawing.Point(224, 464);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(56, 24);
			this.lblHeight.TabIndex = 14;
			this.lblHeight.Text = "Heigth";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(224, 432);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Width";
			// 
			// txtHeight
			// 
			this.txtHeight.Enabled = false;
			this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtHeight.Location = new System.Drawing.Point(296, 464);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(40, 26);
			this.txtHeight.TabIndex = 12;
			this.txtHeight.Text = "";
			this.toolTip1.SetToolTip(this.txtHeight, "Maximum Height is 200");
			this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
			// 
			// txtWidth
			// 
			this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtWidth.Location = new System.Drawing.Point(296, 432);
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.Size = new System.Drawing.Size(40, 26);
			this.txtWidth.TabIndex = 11;
			this.txtWidth.Text = "";
			this.toolTip1.SetToolTip(this.txtWidth, "Maximum Width is 200");
			this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(248, 400);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "Size";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(364, 473);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 24);
			this.label7.TabIndex = 16;
			this.label7.Text = "Colour";
			// 
			// lblColor
			// 
			this.lblColor.BackColor = System.Drawing.Color.Lime;
			this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblColor.Location = new System.Drawing.Point(460, 473);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(24, 24);
			this.lblColor.TabIndex = 17;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.lblSelectColor);
			this.panel1.Location = new System.Drawing.Point(360, 400);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 64);
			this.panel1.TabIndex = 18;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Gray;
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label17.Location = new System.Drawing.Point(56, 32);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(24, 24);
			this.label17.TabIndex = 9;
			this.label17.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label16.Location = new System.Drawing.Point(104, 32);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(24, 24);
			this.label16.TabIndex = 8;
			this.label16.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Purple;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label15.Location = new System.Drawing.Point(80, 32);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(24, 24);
			this.label15.TabIndex = 7;
			this.label15.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Maroon;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Location = new System.Drawing.Point(32, 32);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(24, 24);
			this.label14.TabIndex = 6;
			this.label14.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Red;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Location = new System.Drawing.Point(8, 32);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(24, 24);
			this.label13.TabIndex = 5;
			this.label13.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Magenta;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Location = new System.Drawing.Point(104, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(24, 24);
			this.label12.TabIndex = 4;
			this.label12.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Blue;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Location = new System.Drawing.Point(80, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 24);
			this.label11.TabIndex = 3;
			this.label11.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Aqua;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Location = new System.Drawing.Point(56, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 24);
			this.label10.TabIndex = 2;
			this.label10.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Lime;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Location = new System.Drawing.Point(32, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 24);
			this.label9.TabIndex = 1;
			this.label9.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// lblSelectColor
			// 
			this.lblSelectColor.BackColor = System.Drawing.Color.Yellow;
			this.lblSelectColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSelectColor.Location = new System.Drawing.Point(8, 8);
			this.lblSelectColor.Name = "lblSelectColor";
			this.lblSelectColor.Size = new System.Drawing.Size(24, 24);
			this.lblSelectColor.TabIndex = 0;
			this.lblSelectColor.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// btnAddShape
			// 
			this.btnAddShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAddShape.Location = new System.Drawing.Point(360, 521);
			this.btnAddShape.Name = "btnAddShape";
			this.btnAddShape.Size = new System.Drawing.Size(136, 32);
			this.btnAddShape.TabIndex = 19;
			this.btnAddShape.Text = "Add Shape";
			this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
			// 
			// btnClearInput
			// 
			this.btnClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClearInput.Location = new System.Drawing.Point(171, 521);
			this.btnClearInput.Name = "btnClearInput";
			this.btnClearInput.Size = new System.Drawing.Size(136, 32);
			this.btnClearInput.TabIndex = 20;
			this.btnClearInput.Text = "Clear Input";
			this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
			// 
			// ViewForm2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(514, 568);
			this.Controls.Add(this.btnClearInput);
			this.Controls.Add(this.btnAddShape);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtYpos);
			this.Controls.Add(this.txtXpos);
			this.Controls.Add(this.rbCircle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rbSquare);
			this.Controls.Add(this.rbTriangle);
			this.Controls.Add(this.rbRectangle);
			this.Controls.Add(this.rbElipse);
			this.Controls.Add(this.pnlDrawOn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(520, 0);
			this.Name = "ViewForm2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ViewForm2";
			this.TopMost = true;
			this.pnlDrawOn.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		// set method for myModel
		public ShapesModel MyModel
		{
			set
			{
				myModel = value;
			}
		}
		
		/// <summary>method: isInputValid
		/// method to check user input is valid
		/// </summary>
		/// <param name="txtXpos"></param>
		/// <param name="txtYpos"></param>
		/// <param name="txtWidth"></param>
		/// <param name="txtHeight"></param>
		/// <returns></returns>
		private bool InputValid(string txtXpos, string txtYpos, 
			string txtWidth, string txtHeight)
		{
			
			int X,Y, Width;
			int Height = 0;
			bool validInput = false;
			// required fields populated 
			if (txtHeight.Length > 0)
				Height = Convert.ToInt32(txtHeight);
							
			// convert user inputs to variables				
			X = Convert.ToInt32(txtXpos);
			Y = Convert.ToInt32(txtYpos);
			Width = Convert.ToInt32(txtWidth);	

			// validate data entry is within limits
			if ((X > max_X) || (Y > max_Y) || (Width > max_width) || 
				(Height > max_height))
				MessageBox.Show("Maximum value for X is " + max_X 
					+ "\r\n" + 	"Maximum value for Y is " + max_Y + "\r\n"
					+ "\r\n" +	"Maximum value for Width is " + max_width 
					+ "\r\n" +	"Maximum value for Height is " + max_height,
					"Please Check the Values Entered", 
					MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
				validInput = true;
			return validInput;
		}		


		/// <summary> method: btnAddShape_Click
		/// adds shape to model based on parameters entered by user
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddShape_Click(object sender, System.EventArgs e)
		{		
			// variables required for anyShape object
			int X, Y, Width;
			int Height = 0;					
			Color aColor;
			AnyShape aShape;
			aColor = lblColor.BackColor;

			bool heightRequired = true; // variable to aid validation of txtHeight field
			bool validInput = false;

			try
			{
				// first work if height is required based on shape selected
				if (rbCircle.Checked || rbSquare.Checked)
					heightRequired = false;			
			
				// if heightRequired check all fields populated
				if (heightRequired)
				{
					if ((txtXpos.Text.ToString() == "") ||
						(txtYpos.Text.ToString() == "") ||
						(txtWidth.Text.ToString() == "") ||
						(txtHeight.Text.ToString() == ""))
                        					
						// display error message
						MessageBox.Show
							("Please enter Position and Size", "Required Data Missing", 
							MessageBoxButtons.OK,MessageBoxIcon.Error);	
					else
					{					
						// fields populated, if valid input create shape
						validInput = InputValid(txtXpos.Text.ToString(),txtYpos.Text.ToString(),
							txtWidth.Text.ToString(), txtHeight.Text.ToString());
					
					
						if (validInput)
						{
							X = Convert.ToInt32(txtXpos.Text);
							Y = Convert.ToInt32(txtYpos.Text);
							Width = Convert.ToInt32(txtWidth.Text);	
							Height = Convert.ToInt32(txtHeight.Text);

							// if circle selected create circle shape
							if (rbCircle.Checked)
							{
								aShape = new AnyCircle("circle", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

								// if square selected create square shape
							else if (rbSquare.Checked)
							{
								aShape = new AnySquare("square", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

								// if rectangle selected create rectangle shape
							else if(rbRectangle.Checked)
							{
								aShape = new AnyRectangle("rectangle", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

								// if triangle selected create triangle
							else if(rbTriangle.Checked)
							{
								aShape = new AnyTriangle("triangle", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

							else // must be an ellipse
							{
								aShape = new AnyElipse("elipse", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}
						}
					}
				}
					
				else // txtHeight not required
				{
					if ((txtXpos.Text.ToString() == "") ||
						(txtYpos.Text.ToString() == "") ||
						(txtWidth.Text.ToString() == ""))						
						// display error message
						MessageBox.Show
							("Please enter Position and Size", "Required Data Missing", 
							MessageBoxButtons.OK,MessageBoxIcon.Error);	
					else
					{
						// fields populated, if valid input create shape
						validInput = InputValid(txtXpos.Text.ToString(),txtYpos.Text.ToString(),
							txtWidth.Text.ToString(), "0");

						if (validInput)
						{
							// all input valid, create shape
							X = Convert.ToInt32(txtXpos.Text);
							Y = Convert.ToInt32(txtYpos.Text);
							Width = Convert.ToInt32(txtWidth.Text);	
							// if circle selected create circle shape
							if (rbCircle.Checked)
							{
								aShape = new AnyCircle("circle", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

								// if square selected create square shape
							else if (rbSquare.Checked)
							{
								aShape = new AnySquare("square", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

								// if rectangle selected create rectangle shape
							else if(rbRectangle.Checked)
							{
								aShape = new AnyRectangle("rectangle", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

								// if triangle selected create triangle
							else if(rbTriangle.Checked)
							{
								aShape = new AnyTriangle("triangle", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}

							else // must be an ellipse
							{
								aShape = new AnyElipse("elipse", X, Y, Width, Height, aColor);
								myModel.AddShape(aShape);
							}
						}
					}
				}			
			}			

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
					"Error", 
					MessageBoxButtons.OK,MessageBoxIcon.Error);
			}			
		}

		/// <summary> method: RefreshView
		/// clears the listBox displays all the shapes in the shapesModel
		/// </summary>
		public void RefreshView()
		{
			// clear listBox
			listBox1.Items.Clear();
			// create arrayList from shapes in model
			ArrayList theShapeList = myModel.ShapeList;
			//Convert arrayList to array of shapes
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			// graphics object to draw shapes
			Graphics g = this.pnlDrawOn.CreateGraphics(); 
			// add each shape in the array to the listBox
			foreach (AnyShape sh in theShapes)
			{
				listBox1.Items.Add(sh);
			}
		}

		/// <summary> method: lblSelectColor_Click
		/// sets back color label to selected colour
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblSelectColor_Click(object sender, System.EventArgs e)
		{
			lblColor.BackColor = (sender as Label).BackColor;
		}

		/// <summary> method: rbCircle_Click
		/// if circle selected set txtHeight to zero and disbale field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rbCircle_Click(object sender, System.EventArgs e)
		{
			txtHeight.Text = "";
			txtHeight.Enabled = false;
		}

		/// <summary> method: rbSquare_Click
		/// if square selected selected set txtHeight to zero and disbale field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rbSquare_Click(object sender, System.EventArgs e)
		{
			txtHeight.Text = "";
			txtHeight.Enabled = false;
		}

		/// <summary>method: rbRectangle_Click
		/// If rectangle selected enable txtHeight field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rbRectangle_Click(object sender, System.EventArgs e)
		{
			txtHeight.Enabled = true;
		}

		/// <summary>method: rbTriangle_Click
		/// if triangle selected enable txtHeight field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rbTriangle_Click(object sender, System.EventArgs e)
		{
			txtHeight.Enabled = true;
		}

		/// <summary>rbElipse_Click
		/// if ellipse selected enable txtHeight field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rbElipse_Click(object sender, System.EventArgs e)
		{
			txtHeight.Enabled = true;
		}

		/// <summary>method: CheckForNumeric
		/// check for only numbers and backspace key
		/// </summary>
		/// <param name="ch"></param>
		/// <returns></returns>
		static bool CheckForNumeric(char ch)
		{			
			int keyInt = (int)ch ;
			if (( keyInt < 48 || keyInt > 57) &&  keyInt != 8)
				return false;
			else
				return true ;
		}
		
		/// <summary> method: txtXpos_KeyPress
		/// allow only numbers and backspace key
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtXpos_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (CheckForNumeric(e.KeyChar) == false)
				e.Handled = true ;	
		}	
	
		/// <summary>method: btnClearInput_Click
		/// clear user input fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearInput_Click(object sender, System.EventArgs e)
		{
			txtXpos.Text = "";
			txtYpos.Text = "";
			txtWidth.Text = "";
			txtHeight.Text = "";		
		}
	}
}
