using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClickMe;
		private System.Windows.Forms.Button btnOnMove;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtNumbers;
		private System.Windows.Forms.TextBox txtNumPlus;
		private System.Windows.Forms.Label lblResult;
		private NumberBox numBox1;
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
			this.btnClickMe = new System.Windows.Forms.Button();
			this.btnOnMove = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtNumbers = new System.Windows.Forms.TextBox();
			this.txtNumPlus = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnClickMe
			// 
			this.btnClickMe.Location = new System.Drawing.Point(8, 8);
			this.btnClickMe.Name = "btnClickMe";
			this.btnClickMe.Size = new System.Drawing.Size(88, 48);
			this.btnClickMe.TabIndex = 0;
			this.btnClickMe.Text = "Click Me";
			this.btnClickMe.MouseEnter += new System.EventHandler(this.btnClickMe_MouseEnter);
			// 
			// btnOnMove
			// 
			this.btnOnMove.Location = new System.Drawing.Point(8, 72);
			this.btnOnMove.Name = "btnOnMove";
			this.btnOnMove.Size = new System.Drawing.Size(88, 48);
			this.btnOnMove.TabIndex = 1;
			this.btnOnMove.Text = "Click Me";
			this.btnOnMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOnMove_MouseMove);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(8, 136);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 48);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtNumbers
			// 
			this.txtNumbers.AcceptsReturn = true;
			this.txtNumbers.Location = new System.Drawing.Point(200, 8);
			this.txtNumbers.Name = "txtNumbers";
			this.txtNumbers.Size = new System.Drawing.Size(120, 29);
			this.txtNumbers.TabIndex = 3;
			this.txtNumbers.Text = "0";
			this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
			// 
			// txtNumPlus
			// 
			this.txtNumPlus.AcceptsReturn = true;
			this.txtNumPlus.Location = new System.Drawing.Point(200, 80);
			this.txtNumPlus.Name = "txtNumPlus";
			this.txtNumPlus.Size = new System.Drawing.Size(120, 29);
			this.txtNumPlus.TabIndex = 4;
			this.txtNumPlus.Text = "0";
			this.txtNumPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPlus_KeyPress);
			// 
			// lblResult
			// 
			this.lblResult.BackColor = System.Drawing.Color.Yellow;
			this.lblResult.Location = new System.Drawing.Point(384, 88);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(104, 24);
			this.lblResult.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(568, 270);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtNumPlus);
			this.Controls.Add(this.txtNumbers);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnOnMove);
			this.Controls.Add(this.btnClickMe);
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "Some Events other than the Click event";
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

		/// <summary> method: btnClickMe_MouseEnter
		/// As the mouse enters the space above the control
		/// move the control 20 pixels to the right
		/// </summary>
		private void btnClickMe_MouseEnter(object sender, System.EventArgs e)
		{
			btnClickMe.Left += 20;
		}

		/// <summary> method: btnOnMove_MouseMove
		/// As the mouse makes any movement in the space 
		/// above the control move the control 20 pixels to the right
		/// </summary>
		private void btnOnMove_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btnOnMove.Left += 20;
		}

		/// <summary> method: btnReset_Click
		/// Move the top two buttons to line up their left
		/// sides with the left side of the reset button
		/// </summary>
		private void btnReset_Click(object sender, System.EventArgs e)
		{
			btnClickMe.Left = btnReset.Left;
			btnOnMove.Left = btnReset.Left;
		}

		/// <summary> method: txtNumbers_KeyPress
		/// only allow numbers in this textbox
		/// </summary>
		private void txtNumbers_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < (char)48) || (e.KeyChar > (char)57))  //if outside range '0'-'9'
			{
				e.Handled=true; //do nothing further so key does not display
			}
		}

		/// <summary> method: txtNumPlus_KeyPress
		/// only allow numbers, backspace, delete, enter and '.' 
		/// in this textbox
		/// </summary>
		private void txtNumPlus_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ( (e.KeyChar != (char)8) // backspace
				&& (e.KeyChar != (char)46) // '.' decimal point
				&& (e.KeyChar != (char)13) // Enter key
				&& ( (e.KeyChar < (char)48) || (e.KeyChar > (char)57) )  //if outside range '0'-'9'
				)
			{
				e.Handled=true; //do nothing further so key does not display
			}
			else
			{
				if (e.KeyChar == (char)13) // Enter key
				{
					lblResult.Text = txtNumPlus.Text;
					e.Handled=true; //do nothing further so no beep for Enter key
				}
			}
		
		}


	}
}
