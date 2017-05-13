using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DateTimeExamples1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnNow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMonth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCreateDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnLeapYear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCountDays;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnDaysSoFar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnDayOfWeek;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnValid;
		private System.Windows.Forms.Button btnFromString;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnInvalidDate;
		private System.Windows.Forms.TextBox txtDateString;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button btnDifferences;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnDaysInYear;
        private Button button1;
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
            this.btnNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateDate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLeapYear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCountDays = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDaysSoFar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDayOfWeek = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnValid = new System.Windows.Forms.Button();
            this.txtDateString = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFromString = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnInvalidDate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDifferences = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDaysInYear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(8, 8);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(144, 32);
            this.btnNow.TabIndex = 0;
            this.btnNow.Text = "Now";
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(160, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(184, 64);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(48, 29);
            this.txtDay.TabIndex = 2;
            this.txtDay.Text = "1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(136, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(240, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(304, 64);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(48, 29);
            this.txtMonth.TabIndex = 4;
            this.txtMonth.Text = "1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(360, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(408, 64);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(56, 29);
            this.txtYear.TabIndex = 6;
            this.txtYear.Text = "2005";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(160, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // btnCreateDate
            // 
            this.btnCreateDate.Location = new System.Drawing.Point(8, 104);
            this.btnCreateDate.Name = "btnCreateDate";
            this.btnCreateDate.Size = new System.Drawing.Size(144, 32);
            this.btnCreateDate.TabIndex = 8;
            this.btnCreateDate.Text = "Create Date";
            this.btnCreateDate.Click += new System.EventHandler(this.btnCreateDate_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(160, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // btnLeapYear
            // 
            this.btnLeapYear.Location = new System.Drawing.Point(8, 152);
            this.btnLeapYear.Name = "btnLeapYear";
            this.btnLeapYear.Size = new System.Drawing.Size(144, 32);
            this.btnLeapYear.TabIndex = 10;
            this.btnLeapYear.Text = "Leap Year?";
            this.btnLeapYear.Click += new System.EventHandler(this.btnLeapYear_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(160, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // btnCountDays
            // 
            this.btnCountDays.Location = new System.Drawing.Point(8, 208);
            this.btnCountDays.Name = "btnCountDays";
            this.btnCountDays.Size = new System.Drawing.Size(144, 32);
            this.btnCountDays.TabIndex = 12;
            this.btnCountDays.Text = "Days in year";
            this.btnCountDays.Click += new System.EventHandler(this.btnCountDays_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(152, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // btnDaysSoFar
            // 
            this.btnDaysSoFar.Location = new System.Drawing.Point(0, 320);
            this.btnDaysSoFar.Name = "btnDaysSoFar";
            this.btnDaysSoFar.Size = new System.Drawing.Size(144, 32);
            this.btnDaysSoFar.TabIndex = 14;
            this.btnDaysSoFar.Text = "Days so far";
            this.btnDaysSoFar.Click += new System.EventHandler(this.btnDaysSoFar_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(152, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            // 
            // btnDayOfWeek
            // 
            this.btnDayOfWeek.Location = new System.Drawing.Point(0, 376);
            this.btnDayOfWeek.Name = "btnDayOfWeek";
            this.btnDayOfWeek.Size = new System.Drawing.Size(144, 32);
            this.btnDayOfWeek.TabIndex = 16;
            this.btnDayOfWeek.Text = "Day of week";
            this.btnDayOfWeek.Click += new System.EventHandler(this.btnDayOfWeek_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 29);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(488, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "DateTimePickers";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(648, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(648, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 32);
            this.label12.TabIndex = 22;
            this.label12.Text = "label12";
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(496, 56);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(144, 32);
            this.btnValid.TabIndex = 21;
            this.btnValid.Text = "Check if valid";
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // txtDateString
            // 
            this.txtDateString.Location = new System.Drawing.Point(648, 120);
            this.txtDateString.Name = "txtDateString";
            this.txtDateString.Size = new System.Drawing.Size(184, 29);
            this.txtDateString.TabIndex = 23;
            this.txtDateString.Text = "September 14 2005";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(648, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 48);
            this.label13.TabIndex = 25;
            this.label13.Text = "label13";
            // 
            // btnFromString
            // 
            this.btnFromString.Location = new System.Drawing.Point(496, 120);
            this.btnFromString.Name = "btnFromString";
            this.btnFromString.Size = new System.Drawing.Size(144, 32);
            this.btnFromString.TabIndex = 24;
            this.btnFromString.Text = "From string";
            this.btnFromString.Click += new System.EventHandler(this.btnFromString_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(648, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(272, 32);
            this.label14.TabIndex = 27;
            this.label14.Text = "label14";
            // 
            // btnInvalidDate
            // 
            this.btnInvalidDate.Location = new System.Drawing.Point(496, 8);
            this.btnInvalidDate.Name = "btnInvalidDate";
            this.btnInvalidDate.Size = new System.Drawing.Size(144, 32);
            this.btnInvalidDate.TabIndex = 26;
            this.btnInvalidDate.Text = "Invalid Date";
            this.btnInvalidDate.Click += new System.EventHandler(this.btnInvalidDate_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(800, 200);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 29);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // btnDifferences
            // 
            this.btnDifferences.Location = new System.Drawing.Point(496, 288);
            this.btnDifferences.Name = "btnDifferences";
            this.btnDifferences.Size = new System.Drawing.Size(144, 32);
            this.btnDifferences.TabIndex = 29;
            this.btnDifferences.Text = "Differences";
            this.btnDifferences.Click += new System.EventHandler(this.btnDifferences_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(648, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(272, 104);
            this.label15.TabIndex = 30;
            this.label15.Text = "label15";
            // 
            // btnDaysInYear
            // 
            this.btnDaysInYear.Location = new System.Drawing.Point(8, 256);
            this.btnDaysInYear.Name = "btnDaysInYear";
            this.btnDaysInYear.Size = new System.Drawing.Size(144, 32);
            this.btnDaysInYear.TabIndex = 31;
            this.btnDaysInYear.Text = "Days in year";
            this.btnDaysInYear.Click += new System.EventHandler(this.btnDaysInYear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 77);
            this.button1.TabIndex = 32;
            this.button1.Text = "Day of week - alternate version";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
            this.ClientSize = new System.Drawing.Size(936, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDaysInYear);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDifferences);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnInvalidDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFromString);
            this.Controls.Add(this.txtDateString);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDayOfWeek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDaysSoFar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCountDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLeapYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreateDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

		/// <summary> method: btnNow_Click
		/// gets the current date and time and displays them
		/// </summary>
		private void btnNow_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = DateTime.Now;
			label1.Text = aDate.ToShortDateString() + "  " + aDate.ToShortTimeString();
		}

		/// <summary> method: getDate
		/// make and initialize a date object then return it
		/// </summary>
		private DateTime getDate()
		{
			int dd,mm,yy;
			dd = Convert.ToInt32(txtDay.Text);
			mm = Convert.ToInt32(txtMonth.Text);
			yy = Convert.ToInt32(txtYear.Text);
			return(new DateTime(yy,mm,dd));
		}

		/// <summary> method: btnCreateDate_Click
		/// display a date with a format like "Thursday 14 Jan 2006"
		/// </summary>
		private void btnCreateDate_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = getDate();
			label5.Text = aDate.ToString("dddd d MMM yyyy");
		}

		/// <summary> method: btnLeapYear_Click
		/// Check if a date falls in a leap year
		/// </summary>
		private void btnLeapYear_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = getDate();
			if ( DateTime.IsLeapYear(aDate.Year) )
			{
				label6.Text = aDate.Year.ToString() + " IS a leap year";
			}
			else
			{
				label6.Text = aDate.Year.ToString() + " is NOT a leap year";
			}
		}

		/// <summary> method: btnCountDays_Click
		/// find the number of days in a given year
		/// not the best way of doing this but
		/// it demonstrates the DaysInMonth() method
		/// </summary>
		private void btnCountDays_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = getDate();
			int TotalDays = 0;
			for (int i = 1; i <= 12; i++)
			{
				TotalDays += DateTime.DaysInMonth(aDate.Year,i);
			}
			label7.Text = "Days in " + aDate.Year.ToString() 
				          + " equal " + TotalDays.ToString();
		}

		/// <summary> method: btnDaysInYear_Click
		/// find the number of days in a given year
		/// this is a more typical example of date manipulation
		/// creating a date with values to suit the problem
		/// then applying a DateTime method to it.
		/// </summary>
		private void btnDaysInYear_Click(object sender, System.EventArgs e)
		{
			int dd,mm,yy;
			dd = 31;
			mm = 12;
			yy = Convert.ToInt32(txtYear.Text);
			DateTime aDate = new DateTime(yy,mm,dd);
			label7.Text = "Days in " + aDate.Year.ToString() 
				+ " equal " + aDate.DayOfYear.ToString();
		}

		/// <summary> method: btnDaysSoFar_Click
		/// find the number of days in the year so far
		/// </summary>
		private void btnDaysSoFar_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = getDate();
			label8.Text = "Days in year so far " + aDate.DayOfYear.ToString();
		}

		/// <summary> method: btnDayOfWeek_Click
		/// DayOfWeek gives a number from 1 to 7, 
		/// the ToString() method 
		/// converts this to the name of the day
		/// </summary>
		private void btnDayOfWeek_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = getDate();
			label9.Text = "Day of the week " + aDate.DayOfWeek.ToString();
		}

		/// <summary> method: btnValid_Click
		///an example of using exception handling to catch invalid date 
		///entries
		/// </summary>
		private void btnValid_Click(object sender, System.EventArgs e)
		{
			int dd,mm,yy;
			txtMonth.Text = "99";  //force an invalid date
			try
			{
				dd = Convert.ToInt32(txtDay.Text);
				mm = Convert.ToInt32(txtMonth.Text);
				yy = Convert.ToInt32(txtYear.Text);
				DateTime aDate = new DateTime(yy,mm,dd);
				label13.Text = aDate.ToShortDateString();
			}
			catch(ArgumentOutOfRangeException)
			{
				label13.Text = "Please enter a valid date in the textboxes";
			}
			catch(FormatException)
			{
				label13.Text = "Please check that the textboxes contain numbers";
			}

			catch(Exception ee)
			{
				
				label13.Text = "an unknown problem occured with the message \n"
					            + ee.Message;
			}
		}

		/// <summary> method: btnInvalidDate_Click
		/// This shows what happens if the application tries
		/// to use an invalid date without exception handling
		/// </summary>
		private void btnInvalidDate_Click(object sender, System.EventArgs e)
		{
			int dd,mm,yy;
			txtMonth.Text = "99";  //force an invalid date
			dd = Convert.ToInt32(txtDay.Text);
			mm = Convert.ToInt32(txtMonth.Text);
			yy = Convert.ToInt32(txtYear.Text);
			DateTime aDate = new DateTime(yy,mm,dd);
			label12.Text = aDate.ToShortDateString();
		}

		/// <summary> method: btnFromString_Click
		///The parse method will extract a date from a valid date string
		/// </summary>
		private void btnFromString_Click(object sender, System.EventArgs e)
		{
			DateTime aDate = DateTime.Parse(txtDateString.Text);
			label14.Text = aDate.ToString();
		}

		/// <summary> method: btnDifferences_Click
		/// This demonstrates the use of a TimeSpan object to 
		/// calculate and store the difference between two dates
		/// </summary>
		private void btnDifferences_Click(object sender, System.EventArgs e)
		{
			DateTime aDate, bDate;
			aDate = dateTimePicker2.Value;
			bDate = DateTime.Now;
			TimeSpan howLong = new TimeSpan();
			howLong = aDate - bDate;
			label15.Text = howLong.Days.ToString() + " Days"
				+ "\r\n" 
				+ howLong.Hours.ToString() + " Hours";
}

		/// <summary> method: dateTimePicker2_CloseUp
		/// refresh the value of the label using the new value of 
		/// the DateTimePicker
		/// </summary>
		private void dateTimePicker2_CloseUp(object sender, System.EventArgs e)
		{
			label11.Text = dateTimePicker1.Text + "  " + dateTimePicker2.Text;
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		/// <summary> method: dateTimePicker1_CloseUp
		/// get a date from a DateTimePicker and use that date
		/// to update the date but not the time
		/// in another DateTimePicker
		/// A problem with DateTimePickers is that the user can
		/// type in text  or click on the drop down calendar
		/// If you use the CloseUp event handler the code
		/// is not fired when the user types in a new value
		/// so it is better to use the ValueChanged event
		/// which fires for both text changes and for closeUp
		/// </summary>
		{
			//use the new date in the DateTimePicker
			label11.Text = dateTimePicker1.Text + "  " + dateTimePicker2.Text;
			
			DateTime aDate = dateTimePicker1.Value;
			txtDay.Text = aDate.Day.ToString();
			txtMonth.Text = aDate.Month.ToString();
			txtYear.Text = aDate.Year.ToString();

			// set the second dateTimePicker to the same date 
			// but leave the time unchanged
			DateTime bDate, cDate;
			bDate = dateTimePicker2.Value;

			cDate = new DateTime();
			cDate = aDate.Date + bDate.TimeOfDay;
			dateTimePicker2.Value = cDate;
		}

        public string dayOfWeek(DateTime argDate)
        {
            return argDate.DayOfWeek.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime aDate = getDate();
            label9.Text = "Day of the week " + dayOfWeek(aDate);
        }

	}
}
