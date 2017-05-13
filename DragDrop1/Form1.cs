using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using System.Diagnostics;

namespace DragDrop1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Color dropColor;
		private int PictureIndex = 0;
		private object DragSource;
		private System.Windows.Forms.ListBox SourceList;
		private int HowManyDrags = 0;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private ArrayList FileNames;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.RadioButton rbMove;
		private System.Windows.Forms.RadioButton rbCopy;
		private System.Windows.Forms.Label lblDragCount;
		private System.Windows.Forms.Label lblDone;
		private System.Windows.Forms.TabPage tpSimpleDrag;
		private System.Windows.Forms.TabPage tpDragData;
		private System.Windows.Forms.TabPage tpDragText;
		private System.Windows.Forms.TabPage tpDragFile;
		private System.Windows.Forms.Label lblTab1Orange;
		private System.Windows.Forms.Label lblTab1Blue;
		private System.Windows.Forms.Label lblTab1Green;
		private System.Windows.Forms.Label lblTab1Red;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblTab2Aqua;
		private System.Windows.Forms.Label lblTab2Blue;
		private System.Windows.Forms.Label lblTab2Green;
		private System.Windows.Forms.Label lblTab2Red;
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSimpleDrag = new System.Windows.Forms.TabPage();
            this.lblDone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTab1Orange = new System.Windows.Forms.Label();
            this.lblTab1Blue = new System.Windows.Forms.Label();
            this.lblTab1Green = new System.Windows.Forms.Label();
            this.lblTab1Red = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpDragData = new System.Windows.Forms.TabPage();
            this.lblDragCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTab2Aqua = new System.Windows.Forms.Label();
            this.lblTab2Blue = new System.Windows.Forms.Label();
            this.lblTab2Green = new System.Windows.Forms.Label();
            this.lblTab2Red = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tpDragText = new System.Windows.Forms.TabPage();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tpDragFile = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpSimpleDrag.SuspendLayout();
            this.tpDragData.SuspendLayout();
            this.tpDragText.SuspendLayout();
            this.tpDragFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSimpleDrag);
            this.tabControl1.Controls.Add(this.tpDragData);
            this.tabControl1.Controls.Add(this.tpDragText);
            this.tabControl1.Controls.Add(this.tpDragFile);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 588);
            this.tabControl1.TabIndex = 6;
            // 
            // tpSimpleDrag
            // 
            this.tpSimpleDrag.Controls.Add(this.lblTab1Red);
            this.tpSimpleDrag.Controls.Add(this.lblDone);
            this.tpSimpleDrag.Controls.Add(this.label10);
            this.tpSimpleDrag.Controls.Add(this.lblTab1Orange);
            this.tpSimpleDrag.Controls.Add(this.lblTab1Blue);
            this.tpSimpleDrag.Controls.Add(this.lblTab1Green);
            this.tpSimpleDrag.Controls.Add(this.panel1);
            this.tpSimpleDrag.Location = new System.Drawing.Point(4, 42);
            this.tpSimpleDrag.Name = "tpSimpleDrag";
            this.tpSimpleDrag.Size = new System.Drawing.Size(1062, 542);
            this.tpSimpleDrag.TabIndex = 0;
            this.tpSimpleDrag.Text = "Simple Dragging     ";
            // 
            // lblDone
            // 
            this.lblDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDone.Location = new System.Drawing.Point(772, 216);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(273, 60);
            this.lblDone.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(37, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(834, 48);
            this.label10.TabIndex = 15;
            this.label10.Text = "Drag the colors to the pale blue box";
            // 
            // lblTab1Orange
            // 
            this.lblTab1Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTab1Orange.Location = new System.Drawing.Point(124, 363);
            this.lblTab1Orange.Name = "lblTab1Orange";
            this.lblTab1Orange.Size = new System.Drawing.Size(156, 35);
            this.lblTab1Orange.TabIndex = 14;
            this.lblTab1Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab1Labels_MouseDown);
            // 
            // lblTab1Blue
            // 
            this.lblTab1Blue.BackColor = System.Drawing.Color.Blue;
            this.lblTab1Blue.Location = new System.Drawing.Point(124, 279);
            this.lblTab1Blue.Name = "lblTab1Blue";
            this.lblTab1Blue.Size = new System.Drawing.Size(156, 35);
            this.lblTab1Blue.TabIndex = 13;
            this.lblTab1Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab1Labels_MouseDown);
            // 
            // lblTab1Green
            // 
            this.lblTab1Green.BackColor = System.Drawing.Color.Lime;
            this.lblTab1Green.Location = new System.Drawing.Point(124, 195);
            this.lblTab1Green.Name = "lblTab1Green";
            this.lblTab1Green.Size = new System.Drawing.Size(156, 35);
            this.lblTab1Green.TabIndex = 12;
            this.lblTab1Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab1Labels_MouseDown);
            // 
            // lblTab1Red
            // 
            this.lblTab1Red.BackColor = System.Drawing.Color.Red;
            this.lblTab1Red.Location = new System.Drawing.Point(124, 108);
            this.lblTab1Red.Name = "lblTab1Red";
            this.lblTab1Red.Size = new System.Drawing.Size(156, 35);
            this.lblTab1Red.TabIndex = 11;
            this.lblTab1Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab1Labels_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(324, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 276);
            this.panel1.TabIndex = 10;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // tpDragData
            // 
            this.tpDragData.Controls.Add(this.lblDragCount);
            this.tpDragData.Controls.Add(this.button1);
            this.tpDragData.Controls.Add(this.label5);
            this.tpDragData.Controls.Add(this.lblTab2Aqua);
            this.tpDragData.Controls.Add(this.lblTab2Blue);
            this.tpDragData.Controls.Add(this.lblTab2Green);
            this.tpDragData.Controls.Add(this.lblTab2Red);
            this.tpDragData.Controls.Add(this.panel2);
            this.tpDragData.Location = new System.Drawing.Point(4, 42);
            this.tpDragData.Name = "tpDragData";
            this.tpDragData.Size = new System.Drawing.Size(1062, 542);
            this.tpDragData.TabIndex = 1;
            this.tpDragData.Text = "Dragging     ";
            // 
            // lblDragCount
            // 
            this.lblDragCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDragCount.Location = new System.Drawing.Point(548, 4);
            this.lblDragCount.Name = "lblDragCount";
            this.lblDragCount.Size = new System.Drawing.Size(323, 48);
            this.lblDragCount.TabIndex = 12;
            this.lblDragCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(834, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Drag the colors to the pale yellow box";
            // 
            // lblTab2Aqua
            // 
            this.lblTab2Aqua.BackColor = System.Drawing.Color.Aqua;
            this.lblTab2Aqua.Location = new System.Drawing.Point(112, 252);
            this.lblTab2Aqua.Name = "lblTab2Aqua";
            this.lblTab2Aqua.Size = new System.Drawing.Size(156, 34);
            this.lblTab2Aqua.TabIndex = 9;
            this.lblTab2Aqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab2Labels_MouseDown);
            // 
            // lblTab2Blue
            // 
            this.lblTab2Blue.BackColor = System.Drawing.Color.Blue;
            this.lblTab2Blue.Location = new System.Drawing.Point(112, 192);
            this.lblTab2Blue.Name = "lblTab2Blue";
            this.lblTab2Blue.Size = new System.Drawing.Size(156, 34);
            this.lblTab2Blue.TabIndex = 8;
            this.lblTab2Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab2Labels_MouseDown);
            // 
            // lblTab2Green
            // 
            this.lblTab2Green.BackColor = System.Drawing.Color.Lime;
            this.lblTab2Green.Location = new System.Drawing.Point(112, 132);
            this.lblTab2Green.Name = "lblTab2Green";
            this.lblTab2Green.Size = new System.Drawing.Size(156, 34);
            this.lblTab2Green.TabIndex = 7;
            this.lblTab2Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab2Labels_MouseDown);
            // 
            // lblTab2Red
            // 
            this.lblTab2Red.BackColor = System.Drawing.Color.Red;
            this.lblTab2Red.Location = new System.Drawing.Point(112, 72);
            this.lblTab2Red.Name = "lblTab2Red";
            this.lblTab2Red.Size = new System.Drawing.Size(156, 34);
            this.lblTab2Red.TabIndex = 6;
            this.lblTab2Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTab2Labels_MouseDown);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(373, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 456);
            this.panel2.TabIndex = 5;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            // 
            // tpDragText
            // 
            this.tpDragText.Controls.Add(this.rbCopy);
            this.tpDragText.Controls.Add(this.rbMove);
            this.tpDragText.Controls.Add(this.label15);
            this.tpDragText.Controls.Add(this.listBox2);
            this.tpDragText.Controls.Add(this.listBox1);
            this.tpDragText.Location = new System.Drawing.Point(4, 42);
            this.tpDragText.Name = "tpDragText";
            this.tpDragText.Size = new System.Drawing.Size(1062, 542);
            this.tpDragText.TabIndex = 3;
            this.tpDragText.Text = "Drag text     ";
            // 
            // rbCopy
            // 
            this.rbCopy.Location = new System.Drawing.Point(37, 144);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(162, 36);
            this.rbCopy.TabIndex = 9;
            this.rbCopy.Text = "Copy";
            // 
            // rbMove
            // 
            this.rbMove.Checked = true;
            this.rbMove.Location = new System.Drawing.Point(37, 204);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(162, 36);
            this.rbMove.TabIndex = 8;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "Move";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(274, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(734, 84);
            this.label15.TabIndex = 6;
            this.label15.Text = "Drag items back and forth between these list boxes under both Move and Copy condi" +
    "tions";
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.ItemHeight = 33;
            this.listBox2.Location = new System.Drawing.Point(572, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(237, 235);
            this.listBox2.TabIndex = 5;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Items.AddRange(new object[] {
            "1111",
            "2222",
            "3333",
            "4444",
            "5555"});
            this.listBox1.Location = new System.Drawing.Point(274, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 235);
            this.listBox1.TabIndex = 4;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // tpDragFile
            // 
            this.tpDragFile.Controls.Add(this.button2);
            this.tpDragFile.Controls.Add(this.label14);
            this.tpDragFile.Controls.Add(this.label13);
            this.tpDragFile.Controls.Add(this.label12);
            this.tpDragFile.Controls.Add(this.label11);
            this.tpDragFile.Controls.Add(this.textBox1);
            this.tpDragFile.Location = new System.Drawing.Point(4, 42);
            this.tpDragFile.Name = "tpDragFile";
            this.tpDragFile.Size = new System.Drawing.Size(1062, 542);
            this.tpDragFile.TabIndex = 2;
            this.tpDragFile.Text = "Drag a file     ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Next >>";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(548, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 33);
            this.label14.TabIndex = 5;
            this.label14.Text = "Pictures";
            // 
            // label13
            // 
            this.label13.AllowDrop = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(548, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(472, 392);
            this.label13.TabIndex = 4;
            this.label13.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.label13.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(25, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 33);
            this.label12.TabIndex = 3;
            this.label12.Text = "Text";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(199, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(996, 48);
            this.label11.TabIndex = 1;
            this.label11.Text = "Drop a file from Windows Explorer onto one of the boxes below";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(25, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(498, 396);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "textBox1";
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(14, 33);
            this.ClientSize = new System.Drawing.Size(720, 413);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Simple Drag and Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpSimpleDrag.ResumeLayout(false);
            this.tpDragData.ResumeLayout(false);
            this.tpDragText.ResumeLayout(false);
            this.tpDragFile.ResumeLayout(false);
            this.tpDragFile.PerformLayout();
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

//=============== Tab 1 simple dragging, global data ====================

		private void AllTab1Labels_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		/// simple dragging, global data
		/// On mouse down in the label, set a global color and start the drag
		{
            Debug.WriteLine(" enter AllTab1Labels_MouseDown ");
            lblDone.Text = "";
			Label aLabel = sender as Label;
			dropColor = aLabel.BackColor;
			DragDropEffects result = 
				aLabel.DoDragDrop(0, DragDropEffects.Scroll);
			//the next lines do not run until the drop is completed
			if (result != DragDropEffects.None) 
			{
				lblDone.Text = "Drag completed";
			}
			else
			{
				lblDone.Text = "Drag abandoned";
			}
		}

		private void panel1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		/// simple dragging global data
		/// when the drag enters the panel
		/// allow all dragdrop effects 
		{
            Debug.WriteLine(" user panel1_DragEnter ");
            e.Effect = DragDropEffects.All;
		}

		private void panel1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		/// simple dragging, global data
		/// when the drop happens
		/// use the global color to set the panel back color
		{
            Debug.WriteLine(" user panel1_DragDrop ");
            //panel1.BackColor = dropColor;
        }

//=============== Tab 2 simple dragging, drag drop data ====================
// this is more typical dragging using data stored in the drag drop data object

		private void AllTab2Labels_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// We store the color we want to use
			// when a drop happens as a Color object
			// in the first parameter of the DoDragDrop() method
			// and say what sort of drag effects are allowed
			// in the second parameter
			Label aLabel = sender as Label;
			Color aColor = aLabel.BackColor;
			lblDone.Text = "";
			
			DragDropEffects result = 
				aLabel.DoDragDrop(aColor, DragDropEffects.All);
				
			//the next lines do not run until the drop is completed
			if (result != DragDropEffects.None) 
			{
				HowManyDrags++;
				lblDragCount.Text = "drag count = " + HowManyDrags.ToString();
			}
		}


		private void panel2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		// more typical dragging using data stored in the drag drop data object
		// Say which effects are allowed if a drop occurs on this control
		{
			e.Effect = DragDropEffects.All;
		}

		private void panel2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			//get the color from the stored data
			Color drawColor = (Color)e.Data.GetData(typeof(Color));

			//use the color to draw an ellipse
			Graphics g = panel2.CreateGraphics(); //allows drawing on the form
			try 
			{
				// Draw the ellipse
				Brush br = new SolidBrush(drawColor);
				Rectangle rect = new Rectangle(e.X - panel1.Left - tpDragData.Left - tabControl1.Left - this.Left, e.Y - panel1.Top - tpDragData.Top - tabControl1.Top - this.Top -30, 40, 30);
				g.FillEllipse(br, rect);
			}
			finally 
			{
				g.Dispose(); //Need to dispose of graphics objects if
				//we are responsible for creating them
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		//repaint the panel as a way of clearing it
		{
			panel2.Invalidate();
			HowManyDrags = 0;
			lblDragCount.Text = "";
		}

//=============== Tab 3 dragging between the two list boxes ====================

		private void listBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            Debug.WriteLine(" enter listBox1_MouseDown ");
            ListBox box = (sender as ListBox);
			SourceList = box; //store the box the drag began in with a global reference
			
			//find the line we are dragging in the textbox
			int index = box.IndexFromPoint(e.X,e.Y);

            Debug.WriteLine(" before box.DoDragDrop ");
            DragDropEffects result = box.DoDragDrop(box.Items[index],DragDropEffects.All);
            Debug.WriteLine(" after box.DoDragDrop ");

            //the next lines do not run until the drop is completed
            if ((rbMove.Checked) && (result != DragDropEffects.None) )
			{
				box.Items.RemoveAt(index);
			}
		}

		private void listBox2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
            Debug.WriteLine(" enter listBox2_DragEnter ");
            ListBox box = ((ListBox)sender);
			if (SourceList == box) return; //do not drop onto list the drag came from

			if (e.Data.GetDataPresent(typeof(string)))
			{
				if (rbMove.Checked)
				{
					e.Effect = DragDropEffects.Move;
				}
				else
				{
					e.Effect = DragDropEffects.Copy;
				}
			}
		}

		private void listBox2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
            Debug.WriteLine(" enter listBox2_DragDrop ");
            if (e.Data.GetDataPresent(typeof(string)))
			{
				ListBox box = ((ListBox)sender);
				string dragText =
					(string)e.Data.GetData(typeof(string));
				box.Items.Add(dragText);
			}
		}

//=============== Tab 4 dragging file names from Explorer ====================
//code for dragging file names from Explorer to the text box and picture box on tab 4

		private void Form1_Load(object sender, System.EventArgs e)
		{
			FileNames = new ArrayList();
		}

		private void textBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
			{
				e.Effect = DragDropEffects.All;
			}

		}

		private void textBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			FileNames.Clear();
			foreach (string fileName in
				(string[])e.Data.GetData(DataFormats.FileDrop) )
			{
				FileNames.Add( fileName );
			}
			string[] TheseFiles = (string[])FileNames.ToArray(typeof(string));
			string FileName = TheseFiles[0];
			StreamReader sr = new StreamReader(FileName);
			textBox1.Text = sr.ReadToEnd();
			sr.Close();
		}

		private void pictureBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
		}

		private void pictureBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			FileNames.Clear();
			foreach (string fileName in
				(string[])e.Data.GetData(DataFormats.FileDrop) )
			{
				string extn;
				extn = Path.GetExtension(fileName).ToUpper();
				if ((extn == ".BMP") || (extn == ".JPG"))
				{
					FileNames.Add( fileName );
				}
				else
				{
					MessageBox.Show("Only picture files are allowed");
					return;
				}
			}
			if (FileNames.Count == 0)
			{
				return;
			}
			else
			{
				string[] TheseFiles = (string[])FileNames.ToArray(typeof(string));
				string FileName = TheseFiles[0];
				label13.Image = new Bitmap(FileName);
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (FileNames.Count == 0)
			{
				return;
			}
			else
			{
				if (PictureIndex >= FileNames.Count - 1)
				{
					PictureIndex = 0;
				}
				else
				{
					PictureIndex++;
				}
				string[] TheseFiles = (string[])FileNames.ToArray(typeof(string));
				string FileName = TheseFiles[PictureIndex];
				label13.Image = new Bitmap(FileName);
			}

		}

		private void label1_DragLeave(object sender, System.EventArgs e)
		{
		
		}
	}
}
