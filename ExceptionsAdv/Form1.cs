using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ExceptionsAdv
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnBasicEx;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFinally;
		private System.Windows.Forms.Button btnTryFinally;
		private System.Windows.Forms.Button btnThrowUpwards;
		private System.Windows.Forms.Button btnThrow;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
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
			this.btnBasicEx = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFinally = new System.Windows.Forms.Button();
			this.btnTryFinally = new System.Windows.Forms.Button();
			this.btnThrowUpwards = new System.Windows.Forms.Button();
			this.btnThrow = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBasicEx
			// 
			this.btnBasicEx.Location = new System.Drawing.Point(16, 16);
			this.btnBasicEx.Name = "btnBasicEx";
			this.btnBasicEx.Size = new System.Drawing.Size(152, 40);
			this.btnBasicEx.TabIndex = 0;
			this.btnBasicEx.Text = "Basic exceptions";
			this.btnBasicEx.Click += new System.EventHandler(this.btnBasicEx_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(384, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// btnFinally
			// 
			this.btnFinally.Location = new System.Drawing.Point(16, 72);
			this.btnFinally.Name = "btnFinally";
			this.btnFinally.Size = new System.Drawing.Size(152, 40);
			this.btnFinally.TabIndex = 2;
			this.btnFinally.Text = "Try catch finally";
			this.btnFinally.Click += new System.EventHandler(this.btnFinally_Click);
			// 
			// btnTryFinally
			// 
			this.btnTryFinally.Location = new System.Drawing.Point(16, 128);
			this.btnTryFinally.Name = "btnTryFinally";
			this.btnTryFinally.Size = new System.Drawing.Size(152, 40);
			this.btnTryFinally.TabIndex = 3;
			this.btnTryFinally.Text = "Try finally";
			this.btnTryFinally.Click += new System.EventHandler(this.btnTryFinally_Click);
			// 
			// btnThrowUpwards
			// 
			this.btnThrowUpwards.Location = new System.Drawing.Point(16, 256);
			this.btnThrowUpwards.Name = "btnThrowUpwards";
			this.btnThrowUpwards.Size = new System.Drawing.Size(152, 40);
			this.btnThrowUpwards.TabIndex = 4;
			this.btnThrowUpwards.Text = "Catch and throw";
			this.btnThrowUpwards.Click += new System.EventHandler(this.btnThrowUpwards_Click);
			// 
			// btnThrow
			// 
			this.btnThrow.Location = new System.Drawing.Point(16, 192);
			this.btnThrow.Name = "btnThrow";
			this.btnThrow.Size = new System.Drawing.Size(152, 40);
			this.btnThrow.TabIndex = 5;
			this.btnThrow.Text = "Throw exception";
			this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(16, 320);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(152, 40);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear labels";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(192, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 26);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "24";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(288, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(48, 26);
			this.textBox2.TabIndex = 8;
			this.textBox2.Text = "0";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label2.Location = new System.Drawing.Point(192, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(336, 48);
			this.label2.TabIndex = 9;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label3.Location = new System.Drawing.Point(192, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(336, 208);
			this.label3.TabIndex = 10;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(256, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "/";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(352, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "=";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(616, 405);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnThrow);
			this.Controls.Add(this.btnThrowUpwards);
			this.Controls.Add(this.btnTryFinally);
			this.Controls.Add(this.btnFinally);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBasicEx);
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

		private void btnBasicEx_Click(object sender, System.EventArgs e)
		{
			clearLabels();
			try
			{
				int n1 = Convert.ToInt32(textBox1.Text);
				int n2 = Convert.ToInt32(textBox2.Text);
				int d1 = n1 / n2;
				label1.Text = d1.ToString();
			}
			catch (DivideByZeroException ex)
			{
				label2.Text = "Please enter a non-zero number in the second textbox";
				label3.Text = ex.Message + "\r\n" + ex.ToString();
				//MessageBox.Show(ex.Message + "\r\n" + ex.ToString());
			}
			catch (Exception ex)
			{
				label2.Text = "A problem has occured that this program cannot handle," +
					" tell your software vendor about this message"
					+ "\r\n" + ex.Message;
				label3.Text = ex.Message + "\r\n" + ex.ToString();
				//MessageBox.Show(ex.Message + "\r\n" + ex.ToString());
			}
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			clearLabels();
		}

		private void clearLabels()
		{
			label1.Text = "";
			label2.Text = "";
			label3.Text = "";
		}

		private void btnFinally_Click(object sender, System.EventArgs e)
		{
			clearLabels();
			try
			{
				this.Cursor = Cursors.WaitCursor;
				int n1 = Convert.ToInt32(textBox1.Text);
				int n2 = Convert.ToInt32(textBox2.Text);
				int d1 = n1 / n2;
				label1.Text = d1.ToString();
			}
			catch (DivideByZeroException ex)
			{
				label2.Text = "The program cannot divide by zero, please use another number";
			}
			catch (FormatException ex)
			{
				label2.Text = "Please enter whole numbers in the top two textboxes";
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btnTryFinally_Click(object sender, System.EventArgs e)
		{
			clearLabels();
			try
			{
				this.Cursor = Cursors.WaitCursor;
				int n1 = Convert.ToInt32(textBox1.Text);
				int n2 = Convert.ToInt32(textBox2.Text);
				int d1 = n1 / n2;
				label1.Text = d1.ToString();
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void btnThrow_Click(object sender, System.EventArgs e)
		{
			clearLabels();
			try
			{
				int n1 = Convert.ToInt32(textBox1.Text);
				NoSmallNumbers(n1);
			}
			catch (NumberTooSmallException)
			{
				label2.Text = "For this button the first textbox needs a number over 100";
			}
			catch
			{
				label2.Text = "A problem has occured that this program cannot handle";
			}

		}

		private void NoSmallNumbers(int n)
		{
			if (n < 100)
			{
				throw new NumberTooSmallException("number must be over 100");
			}
			else
			{
				label1.Text = n.ToString();
			}
		}

		private void ThrowProblemUpwards()
		{
			try
			{
				int n1 = Convert.ToInt32(textBox1.Text);
				label1.Text = n1.ToString();
			}
			catch (FormatException ex)
			{
				throw (new FormatException(ex.Message));
			}
		}

		private void btnThrowUpwards_Click(object sender, System.EventArgs e)
		{
			clearLabels();
			try
			{
				ThrowProblemUpwards();
				label2.Text = "No problem occurred";
			}
			catch (FormatException ex)
			{
				label2.Text = "Please only enter numbers in the textboxes";
			}
		}
	}

	public class NumberTooSmallException : Exception 
	{
		public NumberTooSmallException(string msg):base(msg)
		{
		}
	}	

}