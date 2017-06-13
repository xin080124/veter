using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Data;

namespace StringIntro
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private bool isUpper = false;
		private Random rndm = new Random(); //a class to generate random numbers

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnhangeLine3;
		private System.Windows.Forms.Button btnGetLine3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStrbldRandom;
		private System.Windows.Forms.Button btnRandomLetters;
		private System.Windows.Forms.Button btnNoChange;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnFormatString;
		private System.Windows.Forms.Button btnUpperLower;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button btnRoundTruncate;
		private System.Windows.Forms.TextBox txtDecimal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMulti;
		private System.Windows.Forms.Button btnFormatNumber;
        private System.Windows.Forms.Label label10;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhangeLine3 = new System.Windows.Forms.Button();
            this.btnGetLine3 = new System.Windows.Forms.Button();
            this.txtMulti = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStrbldRandom = new System.Windows.Forms.Button();
            this.btnRandomLetters = new System.Windows.Forms.Button();
            this.btnNoChange = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFormatString = new System.Windows.Forms.Button();
            this.btnUpperLower = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnRoundTruncate = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFormatNumber = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(16, 64);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(208, 32);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Text and Number";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "12.34";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(96, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // btnhangeLine3
            // 
            this.btnhangeLine3.Location = new System.Drawing.Point(264, 328);
            this.btnhangeLine3.Name = "btnhangeLine3";
            this.btnhangeLine3.Size = new System.Drawing.Size(208, 32);
            this.btnhangeLine3.TabIndex = 10;
            this.btnhangeLine3.Text = "Change line 3";
            this.btnhangeLine3.Click += new System.EventHandler(this.btnhangeLine3_Click);
            // 
            // btnGetLine3
            // 
            this.btnGetLine3.Location = new System.Drawing.Point(264, 288);
            this.btnGetLine3.Name = "btnGetLine3";
            this.btnGetLine3.Size = new System.Drawing.Size(208, 32);
            this.btnGetLine3.TabIndex = 9;
            this.btnGetLine3.Text = "Get line 3";
            this.btnGetLine3.Click += new System.EventHandler(this.btnGetLine3_Click);
            // 
            // txtMulti
            // 
            this.txtMulti.Location = new System.Drawing.Point(264, 160);
            this.txtMulti.Multiline = true;
            this.txtMulti.Name = "txtMulti";
            this.txtMulti.Size = new System.Drawing.Size(208, 121);
            this.txtMulti.TabIndex = 8;
            this.txtMulti.Text = "The lines of text\r\ncan be found in\r\nthe .Lines property\r\nwhich is a \r\nString[ ] a" +
    "rray";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 26);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Conversion";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Multi-line textbox";
            // 
            // btnStrbldRandom
            // 
            this.btnStrbldRandom.Location = new System.Drawing.Point(272, 80);
            this.btnStrbldRandom.Name = "btnStrbldRandom";
            this.btnStrbldRandom.Size = new System.Drawing.Size(200, 32);
            this.btnStrbldRandom.TabIndex = 25;
            this.btnStrbldRandom.Text = "Random Letters 2";
            this.btnStrbldRandom.Click += new System.EventHandler(this.btnStrbldRandom_Click);
            // 
            // btnRandomLetters
            // 
            this.btnRandomLetters.Location = new System.Drawing.Point(272, 40);
            this.btnRandomLetters.Name = "btnRandomLetters";
            this.btnRandomLetters.Size = new System.Drawing.Size(200, 32);
            this.btnRandomLetters.TabIndex = 24;
            this.btnRandomLetters.Text = "Random Letters 1";
            this.btnRandomLetters.Click += new System.EventHandler(this.btnRandomLetters_Click);
            // 
            // btnNoChange
            // 
            this.btnNoChange.Location = new System.Drawing.Point(16, 152);
            this.btnNoChange.Name = "btnNoChange";
            this.btnNoChange.Size = new System.Drawing.Size(208, 32);
            this.btnNoChange.TabIndex = 23;
            this.btnNoChange.Text = "Strings do not change";
            this.btnNoChange.Click += new System.EventHandler(this.btnNoChange_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 26);
            this.textBox4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(128, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(256, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "StringBuilder";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Formatting";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(488, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Truncate and round";
            // 
            // btnFormatString
            // 
            this.btnFormatString.Location = new System.Drawing.Point(16, 280);
            this.btnFormatString.Name = "btnFormatString";
            this.btnFormatString.Size = new System.Drawing.Size(208, 32);
            this.btnFormatString.TabIndex = 31;
            this.btnFormatString.Text = "Format( ) method";
            this.btnFormatString.Click += new System.EventHandler(this.btnFormatString_Click);
            // 
            // btnUpperLower
            // 
            this.btnUpperLower.Location = new System.Drawing.Point(512, 360);
            this.btnUpperLower.Name = "btnUpperLower";
            this.btnUpperLower.Size = new System.Drawing.Size(200, 32);
            this.btnUpperLower.TabIndex = 32;
            this.btnUpperLower.Text = "UPPER lower";
            this.btnUpperLower.Click += new System.EventHandler(this.btnUpperLower_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(16, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 48);
            this.label8.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(512, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 26);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "Change the CASE";
            // 
            // btnRoundTruncate
            // 
            this.btnRoundTruncate.Location = new System.Drawing.Point(512, 216);
            this.btnRoundTruncate.Name = "btnRoundTruncate";
            this.btnRoundTruncate.Size = new System.Drawing.Size(200, 32);
            this.btnRoundTruncate.TabIndex = 36;
            this.btnRoundTruncate.Text = "Round and Truncate";
            this.btnRoundTruncate.Click += new System.EventHandler(this.btnRoundTruncate_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(512, 40);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(152, 26);
            this.txtDecimal.TabIndex = 35;
            this.txtDecimal.Text = "123.567";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(512, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 128);
            this.label9.TabIndex = 37;
            // 
            // btnFormatNumber
            // 
            this.btnFormatNumber.Location = new System.Drawing.Point(16, 336);
            this.btnFormatNumber.Name = "btnFormatNumber";
            this.btnFormatNumber.Size = new System.Drawing.Size(208, 32);
            this.btnFormatNumber.TabIndex = 38;
            this.btnFormatNumber.Text = "Number Formatting";
            this.btnFormatNumber.Click += new System.EventHandler(this.btnFormatNumber_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(512, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 32);
            this.label10.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 31);
            this.button2.TabIndex = 41;
            this.button2.Text = "Question 1";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 31);
            this.button3.TabIndex = 42;
            this.button3.Text = "Question 2";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 43;
            this.button1.Text = "Question 3";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(469, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 31);
            this.button4.TabIndex = 44;
            this.button4.Text = "Question 4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(623, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 31);
            this.button5.TabIndex = 45;
            this.button5.Text = "Question 5";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(310, 479);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 31);
            this.button6.TabIndex = 46;
            this.button6.Text = "Question 8";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(469, 479);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 31);
            this.button7.TabIndex = 47;
            this.button7.Text = "Five Star";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(623, 479);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 31);
            this.button8.TabIndex = 48;
            this.button8.Text = "FIVE STAR";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(788, 521);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFormatNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRoundTruncate);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpperLower);
            this.Controls.Add(this.btnFormatString);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnStrbldRandom);
            this.Controls.Add(this.btnRandomLetters);
            this.Controls.Add(this.btnNoChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhangeLine3);
            this.Controls.Add(this.btnGetLine3);
            this.Controls.Add(this.txtMulti);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Introduction to strings";
            this.ResumeLayout(false);
            this.PerformLayout();

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

		/// <summary> method: btnConvert_Click
		/// use a method from the Convert class 
		/// to get a number from a string
		/// </summary>
		private void btnConvert_Click(object sender, System.EventArgs e)
		{
			double d1, d2;
			d1 = Convert.ToDouble(textBox1.Text);
			d2 = d1 *2;
			label1.Text = d2.ToString();
		}

		/// <summary> method: btnGetLine3_Click
		/// the .Lines property of a multi-line textbox 
		/// acts like a read only array of strings
		/// </summary>
		private void btnGetLine3_Click(object sender, System.EventArgs e)
		{
			textBox3.Text = txtMulti.Lines[3];
		}

		/// <summary> method: btnhangeLine3_Click
		///we want to replace line 3 in a multiline textbox
		/// </summary>
		private void btnhangeLine3_Click(object sender, System.EventArgs e)
		{
			//the next line does not work as the lines of the textbox cannot 
			//be modified after they have been assigned to

			//txtMulti.Lines[3] = textBox1.Text; //does not work

			int newLength = txtMulti.Text.Length +
							textBox3.Text.Length + 10;
			StringBuilder sb = new StringBuilder(newLength);
			int lineCount = 0;
			foreach (string aLine in txtMulti.Lines)
			{
				if (lineCount != 3)
				{
					sb.Append(aLine + "\r\n");
				}
				else //we are replacing line3
				{
					sb.Append(textBox3.Text + "\r\n");
				}
				lineCount++;
			}
			//put the new version back in txtMulti
			txtMulti.Text = sb.ToString();
		}

		/// <summary> method: btnNoChange_Click
		/// this is to show that the character array 
		/// where a string is stored is read only
		/// </summary>
		private void btnNoChange_Click(object sender, System.EventArgs e)
		{
			string str;
			str = "Fred";
            str = "Frederick";
			//str[1] = '1'; //will not compile. string buffer is read only
			textBox4.Text = str;
			label4.Text = str[1].ToString(); //read is okay but we get a character
			//and need to convert it to a string with the .ToString method
			//note the positions in the array start from zero for the first character
		}

		/// <summary> method: RandomLetter
		/// Return a random letter between A and Z
		/// </summary>
		private string RandomLetter()
		{
			int num = rndm.Next(26) + 65;
			return ((char)num).ToString();
			// Make a random number between 65 and 91 
			// (65 and 91 are the char codesfor A and Z)
			// cast the number as a char
			// then we convert the char to a string
		}

		
		/// <summary> method: btnRoundTruncate_Click
		///An example of using the Decimal class to round and
		///truncate numbers
		/// </summary>
		private void btnRoundTruncate_Click(object sender, System.EventArgs e)
		{
			double d1;
			d1 = Convert.ToDouble(txtDecimal.Text);
			Decimal dec1;
			dec1 = (Decimal)d1;
			int nTrunc, nRound;
			nTrunc = (int)Decimal.Truncate(dec1);
			nRound = (int)Decimal.Round(dec1,0);
			label9.Text = d1.ToString() + 
				"\r\n" + "Truncated gives " +nTrunc.ToString() +
				"\r\n" + "Rounded gives   " +nRound.ToString();
		}

		/// <summary> method: btnUpperLower_Click
		///convert text to upper case or lower case
		/// </summary>
		private void btnUpperLower_Click(object sender, System.EventArgs e)
		{
			if (isUpper)
			{
				label10.Text = textBox5.Text.ToLower();
				isUpper = false;
			}
			else
			{
				label10.Text = textBox5.Text.ToUpper();
				isUpper = true;
			}
		}

		/// <summary> method: btnFormatString_Click
		///The Format method of a string lets you specify a list
		///of dates and numbers that you want to insert into the
		///string
		/// </summary>
		private void btnFormatString_Click(object sender, System.EventArgs e)
		{
			string formattedStr;
			string name = "Freda";
			double height = 1.65;
			
			//the format method takes a list of place holders starting from {0}
			//and replaces each of these from the list of variables given after 
			//the format string
			formattedStr = string.Format("{0} is {1} meters tall",name, height);
			label8.Text = formattedStr;
		}


		/// <summary> method: btnRandomLetters_Click
		///Generate a long string of random capital letters
		///This is a slow way of allocating additional characters to a string
		///the problem is that each time we change str C# will copy all the
		///existing characters of str to a new location
		///on average this means that the example involves copying
		///40 x 1000 x 500 characters
		/// </summary>
		private void btnRandomLetters_Click(object sender, System.EventArgs e)
		{
			string str = "";
			Cursor.Current = Cursors.WaitCursor;
			for (int j = 0; j < 40; j++)
			{

				for (int i = 0; i < 1000; i++)
				{
					str = str + RandomLetter();
				}
			}
			Cursor.Current = Cursors.Default;
			label9.Text = str;
		}

		/// <summary> method: btnStrbldRandom_Click
		///Generate a long string of random capital letters
		///Here we have a much faster approach where we use a 
		///StringBuilder object to allocate enough space for 
		///all the characters we want to end up with. 
		///
		///This means we add characters to the same piece of
		///memory without needing to do any copying. The speed 
		///difference is impressive
		/// </summary>
		private void btnStrbldRandom_Click(object sender, System.EventArgs e)
		{
			int num;
			Cursor.Current = Cursors.WaitCursor;
			StringBuilder sb = new StringBuilder(1100);
			for (int j = 0; j < 40; j++)
			{

				for (int i = 0; i < 1000; i++)
				{
					num = rndm.Next(26) + 65;
					sb.Append(RandomLetter());
				}
			}
			Cursor.Current = Cursors.Default;
			label9.Text = sb.ToString();
		}

		/// <summary> method: btnFormatNumber_Click
		//this example looks at custom numeric format strings
		//# is a placeholder for either a blank or a number
		//0 is a placeholder for either a zero or a number
		//the ToString method for numeric types can have a 
		//formating string passed to it as a parameter
		/// </summary>
		private void btnFormatNumber_Click(object sender, System.EventArgs e)
		{
			string formattedStr1;
			string name = "Freda";
			double height1 = 1.654321;
			string strHeight = height1.ToString("#0.000");
			formattedStr1 = string.Format("{0} is {1} meters tall",name, strHeight);

			label8.Text = formattedStr1;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
				label8.Text = "AA"+@"\r\r"+"BB";
		}

        private void button2_Click(object sender, EventArgs e)
        {
            string aString = "hello";
      //      aString[3] = 'A'; // This fails because the string is read only
            label8.Text = aString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "AA" + @"\r\r" + "BB";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(34);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble("12.34");
            label8.Text = "answer to question 4 works!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label8.Text = "The Decimal Class";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string aString = "aaDDbbccDDee";
            int num;
            num = aString.IndexOf("DD");
            label8.Text = Convert.ToString(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String s1 = "Five Star";
            String s2 = "FIVE Star";
            int c;
            c = s1.CompareTo(s2);
            label8.Text = c.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String s1 = "Five Star";
            String s2 = "FIVE STAR";
            String s3;
            int c;
            s3 = "FIVE STAR";
            c = s2.CompareTo(s3);
            label8.Text = c.ToString();
        }

	
	}
}
