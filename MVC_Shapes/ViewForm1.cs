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
	public class ViewForm1 : System.Windows.Forms.Form, IShapeView
	{
		private ShapesModel myModel;

		bool dragging;
		AnyShape topShape; //  variable for selected shape
		AnyShape editShape; // variable for shape to edit

		// variables for max values of parameters input by user
		int max_X = 425;
		int max_Y = 325;
		int max_width = 200;
		int max_height = 200;		
		
		// variables for mouse position
		Point lastPosition = new Point (0,0);
		Point currentPosition = new Point (0,0);

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
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnuEdit;
		private System.Windows.Forms.MenuItem mnuDelete;
		private System.Windows.Forms.MenuItem mnuFront;
		private System.Windows.Forms.MenuItem mnuBack;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuCancel;
		private System.Windows.Forms.Panel pnlUpdate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtUpdateHeight;
		private System.Windows.Forms.TextBox txtUpdateWidth;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lblUpdateColour;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblNewBackColour;
		private System.Windows.Forms.Panel pnlColour;
		private System.Windows.Forms.Label lblSelectColour;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblSelectedShape;
		private System.Windows.Forms.Button btnClearInput;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.ComponentModel.IContainer components;

		public ViewForm1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//

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
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnuEdit = new System.Windows.Forms.MenuItem();
			this.mnuDelete = new System.Windows.Forms.MenuItem();
			this.mnuFront = new System.Windows.Forms.MenuItem();
			this.mnuBack = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuCancel = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.pnlUpdate = new System.Windows.Forms.Panel();
			this.lblSelectedShape = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.lblNewBackColour = new System.Windows.Forms.Label();
			this.lblUpdateColour = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txtUpdateHeight = new System.Windows.Forms.TextBox();
			this.txtUpdateWidth = new System.Windows.Forms.TextBox();
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
			this.pnlColour = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblSelectColour = new System.Windows.Forms.Label();
			this.btnAddShape = new System.Windows.Forms.Button();
			this.btnClearInput = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlUpdate.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnlColour.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDrawOn
			// 
			this.pnlDrawOn.BackColor = System.Drawing.Color.White;
			this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDrawOn.ContextMenu = this.contextMenu1;
			this.pnlDrawOn.Location = new System.Drawing.Point(8, 8);
			this.pnlDrawOn.Name = "pnlDrawOn";
			this.pnlDrawOn.Size = new System.Drawing.Size(500, 380);
			this.pnlDrawOn.TabIndex = 0;
			this.pnlDrawOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn__MouseUp);
			this.pnlDrawOn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseMove);
			this.pnlDrawOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn__MouseDown);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnuEdit,
																						 this.mnuDelete,
																						 this.mnuFront,
																						 this.mnuBack,
																						 this.menuItem1,
																						 this.mnuCancel,
																						 this.menuItem2});
			// 
			// mnuEdit
			// 
			this.mnuEdit.Index = 0;
			this.mnuEdit.Text = "Edit";
			this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
			// 
			// mnuDelete
			// 
			this.mnuDelete.Index = 1;
			this.mnuDelete.Text = "Delete";
			this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
			// 
			// mnuFront
			// 
			this.mnuFront.Index = 2;
			this.mnuFront.Text = "Bring to Front";
			this.mnuFront.Click += new System.EventHandler(this.mnuFront_Click);
			// 
			// mnuBack
			// 
			this.mnuBack.Index = 3;
			this.mnuBack.Text = "Send to Back";
			this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 4;
			this.menuItem1.Text = "----------------";
			// 
			// mnuCancel
			// 
			this.mnuCancel.Index = 5;
			this.mnuCancel.Text = "Cancel";
			this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 6;
			this.menuItem2.Text = "Refresh";
			this.menuItem2.Click += new System.EventHandler(this.mnuCancel_Click);
			// 
			// pnlUpdate
			// 
			this.pnlUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlUpdate.Controls.Add(this.lblSelectedShape);
			this.pnlUpdate.Controls.Add(this.btnCancel);
			this.pnlUpdate.Controls.Add(this.btnUpdate);
			this.pnlUpdate.Controls.Add(this.panel3);
			this.pnlUpdate.Controls.Add(this.lblUpdateColour);
			this.pnlUpdate.Controls.Add(this.label31);
			this.pnlUpdate.Controls.Add(this.label4);
			this.pnlUpdate.Controls.Add(this.label18);
			this.pnlUpdate.Controls.Add(this.label19);
			this.pnlUpdate.Controls.Add(this.txtUpdateHeight);
			this.pnlUpdate.Controls.Add(this.txtUpdateWidth);
			this.pnlUpdate.Location = new System.Drawing.Point(8, 424);
			this.pnlUpdate.Name = "pnlUpdate";
			this.pnlUpdate.Size = new System.Drawing.Size(488, 176);
			this.pnlUpdate.TabIndex = 21;
			this.pnlUpdate.Visible = false;
			// 
			// lblSelectedShape
			// 
			this.lblSelectedShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSelectedShape.Location = new System.Drawing.Point(8, 9);
			this.lblSelectedShape.Name = "lblSelectedShape";
			this.lblSelectedShape.Size = new System.Drawing.Size(472, 24);
			this.lblSelectedShape.TabIndex = 26;
			this.lblSelectedShape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(320, 96);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(136, 32);
			this.btnCancel.TabIndex = 25;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(320, 48);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(136, 32);
			this.btnUpdate.TabIndex = 24;
			this.btnUpdate.Text = "Update Shape";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.label20);
			this.panel3.Controls.Add(this.label21);
			this.panel3.Controls.Add(this.label22);
			this.panel3.Controls.Add(this.label23);
			this.panel3.Controls.Add(this.label24);
			this.panel3.Controls.Add(this.label25);
			this.panel3.Controls.Add(this.label26);
			this.panel3.Controls.Add(this.label27);
			this.panel3.Controls.Add(this.label28);
			this.panel3.Controls.Add(this.lblNewBackColour);
			this.panel3.Location = new System.Drawing.Point(144, 48);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(136, 64);
			this.panel3.TabIndex = 23;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Gray;
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label20.Location = new System.Drawing.Point(56, 32);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(24, 24);
			this.label20.TabIndex = 9;
			this.label20.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label21.Location = new System.Drawing.Point(104, 32);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(24, 24);
			this.label21.TabIndex = 8;
			this.label21.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Purple;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label22.Location = new System.Drawing.Point(80, 32);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(24, 24);
			this.label22.TabIndex = 7;
			this.label22.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Maroon;
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label23.Location = new System.Drawing.Point(32, 32);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(24, 24);
			this.label23.TabIndex = 6;
			this.label23.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Red;
			this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label24.Location = new System.Drawing.Point(8, 32);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(24, 24);
			this.label24.TabIndex = 5;
			this.label24.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Magenta;
			this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label25.Location = new System.Drawing.Point(104, 8);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(24, 24);
			this.label25.TabIndex = 4;
			this.label25.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Blue;
			this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label26.Location = new System.Drawing.Point(80, 8);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(24, 24);
			this.label26.TabIndex = 3;
			this.label26.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Aqua;
			this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label27.Location = new System.Drawing.Point(56, 8);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(24, 24);
			this.label27.TabIndex = 2;
			this.label27.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Lime;
			this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label28.Location = new System.Drawing.Point(32, 8);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(24, 24);
			this.label28.TabIndex = 1;
			this.label28.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// lblNewBackColour
			// 
			this.lblNewBackColour.BackColor = System.Drawing.Color.Yellow;
			this.lblNewBackColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNewBackColour.Location = new System.Drawing.Point(8, 8);
			this.lblNewBackColour.Name = "lblNewBackColour";
			this.lblNewBackColour.Size = new System.Drawing.Size(24, 24);
			this.lblNewBackColour.TabIndex = 0;
			this.lblNewBackColour.Click += new System.EventHandler(this.lblNewBackColour_Click);
			// 
			// lblUpdateColour
			// 
			this.lblUpdateColour.BackColor = System.Drawing.Color.Lime;
			this.lblUpdateColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblUpdateColour.Location = new System.Drawing.Point(248, 120);
			this.lblUpdateColour.Name = "lblUpdateColour";
			this.lblUpdateColour.Size = new System.Drawing.Size(24, 24);
			this.lblUpdateColour.TabIndex = 22;
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label31.Location = new System.Drawing.Point(152, 120);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(88, 24);
			this.label31.TabIndex = 21;
			this.label31.Text = "Colour";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 24);
			this.label4.TabIndex = 20;
			this.label4.Text = "Size";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(16, 112);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 24);
			this.label18.TabIndex = 19;
			this.label18.Text = "Heigth";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(16, 80);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 24);
			this.label19.TabIndex = 18;
			this.label19.Text = "Width";
			// 
			// txtUpdateHeight
			// 
			this.txtUpdateHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUpdateHeight.Location = new System.Drawing.Point(88, 112);
			this.txtUpdateHeight.Name = "txtUpdateHeight";
			this.txtUpdateHeight.Size = new System.Drawing.Size(40, 26);
			this.txtUpdateHeight.TabIndex = 17;
			this.txtUpdateHeight.Text = "";
			this.txtUpdateHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip1.SetToolTip(this.txtUpdateHeight, "Maximum Height is 200");
			// 
			// txtUpdateWidth
			// 
			this.txtUpdateWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUpdateWidth.Location = new System.Drawing.Point(88, 80);
			this.txtUpdateWidth.Name = "txtUpdateWidth";
			this.txtUpdateWidth.Size = new System.Drawing.Size(40, 26);
			this.txtUpdateWidth.TabIndex = 16;
			this.txtUpdateWidth.Text = "";
			this.toolTip1.SetToolTip(this.txtUpdateWidth, "Maximum Width is 200");
			this.txtUpdateWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXpos_KeyPress);
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
			// pnlColour
			// 
			this.pnlColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlColour.Controls.Add(this.label17);
			this.pnlColour.Controls.Add(this.label16);
			this.pnlColour.Controls.Add(this.label15);
			this.pnlColour.Controls.Add(this.label14);
			this.pnlColour.Controls.Add(this.label13);
			this.pnlColour.Controls.Add(this.label12);
			this.pnlColour.Controls.Add(this.label11);
			this.pnlColour.Controls.Add(this.label10);
			this.pnlColour.Controls.Add(this.label9);
			this.pnlColour.Controls.Add(this.lblSelectColour);
			this.pnlColour.Location = new System.Drawing.Point(360, 400);
			this.pnlColour.Name = "pnlColour";
			this.pnlColour.Size = new System.Drawing.Size(136, 64);
			this.pnlColour.TabIndex = 18;
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
			// lblSelectColour
			// 
			this.lblSelectColour.BackColor = System.Drawing.Color.Yellow;
			this.lblSelectColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSelectColour.Location = new System.Drawing.Point(8, 8);
			this.lblSelectColour.Name = "lblSelectColour";
			this.lblSelectColour.Size = new System.Drawing.Size(24, 24);
			this.lblSelectColour.TabIndex = 0;
			this.lblSelectColour.Click += new System.EventHandler(this.lblSelectColor_Click);
			// 
			// btnAddShape
			// 
			this.btnAddShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAddShape.Location = new System.Drawing.Point(360, 520);
			this.btnAddShape.Name = "btnAddShape";
			this.btnAddShape.Size = new System.Drawing.Size(136, 32);
			this.btnAddShape.TabIndex = 19;
			this.btnAddShape.Text = "Add Shape";
			this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
			// 
			// btnClearInput
			// 
			this.btnClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClearInput.Location = new System.Drawing.Point(178, 520);
			this.btnClearInput.Name = "btnClearInput";
			this.btnClearInput.Size = new System.Drawing.Size(136, 32);
			this.btnClearInput.TabIndex = 20;
			this.btnClearInput.Text = "Clear Input";
			this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
			// 
			// ViewForm1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(514, 576);
			this.Controls.Add(this.pnlDrawOn);
			this.Controls.Add(this.pnlUpdate);
			this.Controls.Add(this.btnClearInput);
			this.Controls.Add(this.btnAddShape);
			this.Controls.Add(this.pnlColour);
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
			this.Controls.Add(this.rbTriangle);
			this.Controls.Add(this.rbRectangle);
			this.Controls.Add(this.rbElipse);
			this.Controls.Add(this.rbSquare);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ViewForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ViewForm1";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.ViewForm1_Load);
			this.pnlUpdate.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnlColour.ResumeLayout(false);
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

		
		/// <summary> method: RefreshView
		/// clears the listBox displays all the shapes in the shapesModel
		/// </summary>
		public void RefreshView()
		{
			// clear drawOn panel
			clearPanel();
			// create arrayList from model and convert to array of shapes
			ArrayList theShapeList = myModel.ShapeList;
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			Graphics g = this.pnlDrawOn.CreateGraphics(); 
			// draw all shapes in array
			foreach (AnyShape sh in theShapes)
			{				
				sh.Display(g);
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

		/// <summary>method: pnlDrawOn__MouseDown
		/// check if mouse is over shape and sets sets variable to 
		/// enable shape to be moved
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlDrawOn__MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(topShape != null)	
				dragging = true;			
		}

		/// <summary>method: pnlDrawOn__MouseUp
		/// method to stop dragging of shape
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlDrawOn__MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dragging = false;
			// clear drawOn panel
			clearPanel();
			// create arrayList of shapes from model and convert to array of shapes
			ArrayList theShapeList = myModel.ShapeList;			
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));			
			// graphics object to draw selected shape
			Graphics g = this.pnlDrawOn.CreateGraphics(); 

			// check if shape selected and if so display
			if (topShape !=null)
			{
				theShapes[0] = topShape;
				topShape.Display(g);
			}
			myModel.UpdateViews();
		}

		/// <summary> method: pnlDrawOn_MouseMove
		/// when mouse moves it checks if mouse is down and/or over shape 
		/// If mouse is down and over shape draws border around shape and 
		/// sets new position for shape based on how far mouse has moved.
		/// If mouse is up and over shape, draw border around shape.
		/// If mouse if down and not over shape, do nothing.		
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlDrawOn_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// set last position to current position
			lastPosition = currentPosition;
			// set current position to mouse position
			currentPosition = new Point (e.X, e.Y);	
			// calculate how far mouse has moved 
			int xMove = currentPosition.X - lastPosition.X;		
			int yMove = currentPosition.Y - lastPosition.Y;
                                                     
			if (!dragging) // mouse not down 
			{				
				// reset variables 
				topShape = null; 
				bool needsDisplay = false; 

				// create arrayList of shaapes from myModel
				ArrayList theShapeList = myModel.ShapeList;
				// create array of shapes from array list
				AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
				// graphics object to draw shapes when required
				Graphics g = this.pnlDrawOn.CreateGraphics(); 
				
				// loop through array checking if mouse is over shape
				foreach (AnyShape s in theShapes)
				{
					// check if mouse is over shape
					if (s.HitTest(new Point(e.X, e.Y)))
					{
						// if so make shape topShape
						topShape = s; 
					}

					if(s.Highlight == true) 
					{
						// shape to be redrawn
						needsDisplay = true;
						// redraw shape
						s.Display(g);						
						s.Highlight = false;
					}
					// 30 Oct moved this piece up to before highlight test
//					if (s.HitTest(new Point(e.X, e.Y)))// check if mouse is over shape
//					{
//						topShape = s; // make shape topShape
//					}
				}
				
				if(topShape != null) // if there is a topShape
				{
					needsDisplay = true; // need to redisplay
					topShape.Display(g); // redisplay topShape					
					topShape.Highlight = true;
				}

				if (needsDisplay)
				{
					// redisplay model
					myModel.UpdateViews();
				}
			}
			else // mouse is down
			{
				// reset position of selected shape by value of mouse move 
				topShape.x_pos = topShape.x_pos + xMove;
				topShape.y_pos = topShape.y_pos + yMove;

				myModel.UpdateViews();
			}	
		}

		/// <summary>method: mnuEdit_Click
		/// displays the update panel and prompts the user to 
		/// enter new values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuEdit_Click(object sender, System.EventArgs e)
		{
			if (topShape != null)
			{
				// message to user to enter new size and colour
                MessageBox.Show("You May Update Shape Size and Color Only" + "\r\n",
                    "Enter new values and click the Update button", 
					MessageBoxButtons.OK,MessageBoxIcon.Information);				

				// make editShape the current topShape 
				editShape = topShape;

				// update values in update panel to selected shape
				lblSelectedShape.Text = 
					topShape.ToString();
				lblUpdateColour.BackColor = topShape.shapeColor;
				txtUpdateWidth.Text = topShape.shape_width.ToString();
				txtUpdateHeight.Text = topShape.shape_height.ToString();

				// disable height text box is square or circle
				if ((topShape.name.ToString() == "circle") || 
					(topShape.name.ToString() == "square"))
				{
					txtUpdateHeight.Enabled = false;
				}
				else
				{
					txtUpdateHeight.Enabled = true;
					txtUpdateHeight.Text = topShape.shape_height.ToString();
				}
				// show update panel
				pnlUpdate.Show();	
				//myModel.UpdateViews();
			}
			myModel.UpdateViews();
		}

		/// <summary>method: mnuDelete_Click
		/// delete selected shape and redisplay shapes remaiing in model
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuDelete_Click(object sender, System.EventArgs e)
		{
			// check is topShape has a value, if so delete
			if (topShape != null)
			{
				// clear panel
				clearPanel();
				// delete selected shape and redisplay remaining shapes
				myModel.DeleteShape(topShape);
			}
			myModel.UpdateViews();
		}

		/// <summary>  method: mnuBack_Click
		/// get selected shape displayed behind other shapes  
		/// all shapes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuBack_Click(object sender, System.EventArgs e)
		{
			if (topShape != null) // if shape selcted
			{
				clearPanel();
				// resort arrayList to get selected shape drawn first and redisplay
				myModel.SendToBack(topShape);				
			}	
			myModel.UpdateViews();
		}

		/// <summary>method: mnuFront_Click
		/// get selected shape displayed in front of other shapes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuFront_Click(object sender, System.EventArgs e)
		{
			if (topShape != null) // if shape selcted
			{
				clearPanel();
				// resort arrayList to get selected shape drawn last and rdisplay
				myModel.BringToFront(topShape);
			}	
			myModel.UpdateViews();
		}

		/// <summary> method: mnuCancel_Click
		/// do nothing when user selects cancel menu option
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuCancel_Click(object sender, System.EventArgs e)
		{
			// refresh view
			myModel.UpdateViews();
		}

		/// <summary>method: btnCancel_Click
		/// hide the update panel without updating shape
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			pnlUpdate.Hide();
		}

		/// <summary>method: clearPanel
		/// clear all shapes from display on panel
		/// </summary>
		private void clearPanel()
		{
			pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
		}

		/// <summary>method: btnUpdate_Click
		/// update selected shape with values entered by user 
		/// and redisplay all shapes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			// clear draw on panel
			clearPanel();

			// local variables for updates to selected shape
			int Width;
			int Height = 0;
			Color aColor;

			// get updated attributes for selected shape						
			Width = Convert.ToInt32(txtUpdateWidth.Text);
			if (txtUpdateHeight.Text.Length > 0)
				Height = Convert.ToInt32(txtUpdateHeight.Text);				
			// check new values are within limits
			if ((Width > max_width)||(Height > max_height))
				MessageBox.Show("Maximum value for Width is " + max_width 
					+ "\r\n" +	"Maximum value for Height is " + max_height,
					"Please Check the Values Entered", 
					MessageBoxButtons.OK,MessageBoxIcon.Error);
			else
			{
				// update shape attributes
				editShape.shape_width = Width;	
				if (txtUpdateHeight.Text.Length > 0)
				{					
					editShape.shape_height = Height;
				}			
				// 
				aColor = lblUpdateColour.BackColor;
				// update selected shape
				editShape.shapeColor = aColor;			
				// redisplay
				myModel.UpdateViews();
				pnlUpdate.Hide();
			}
		}

		/// <summary>method: lblNewBackColour_Click
		/// set lblUpdateColor to selected color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblNewBackColour_Click(object sender, System.EventArgs e)
		{
			lblUpdateColour.BackColor = (sender as Label).BackColor;		
		}

		/// <summary>method: reDisplay
		/// redraws all the shapes in the model
		/// </summary>
		public void reDisplay()
		{
			ArrayList theShapeList = myModel.ShapeList;				
			AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
			Graphics g = this.pnlDrawOn.CreateGraphics();			
			foreach (AnyShape sh in theShapes)
			{					
				sh.Display(g);
			}
		}

		// set the runtime position of update panel
		private void ViewForm1_Load(object sender, System.EventArgs e)
		{			
			pnlUpdate.Top = rbCircle.Top;
			pnlUpdate.Left = rbCircle.Left;
			
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
