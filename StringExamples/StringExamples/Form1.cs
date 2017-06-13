using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Data;

namespace StringExamples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string HoldText3, HoldText4, HoldText6;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btnSplitString;
		private System.Windows.Forms.Button btnSubString;
		private System.Windows.Forms.Button btnlastSubString;
		private System.Windows.Forms.Button btnAllSubStrings;
		private System.Windows.Forms.Button btnExtractSubString;
		private System.Windows.Forms.Button btnJoinStringArray;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnReset1;
		private System.Windows.Forms.TextBox textBox6;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnAllSubs;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label4;
		public const string newline = "\r\n";

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
			this.components = new System.ComponentModel.Container();
			this.btnReset1 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btnSplitString = new System.Windows.Forms.Button();
			this.btnSubString = new System.Windows.Forms.Button();
			this.btnlastSubString = new System.Windows.Forms.Button();
			this.btnAllSubStrings = new System.Windows.Forms.Button();
			this.btnExtractSubString = new System.Windows.Forms.Button();
			this.btnJoinStringArray = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.btnAllSubs = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReset1
			// 
			this.btnReset1.Location = new System.Drawing.Point(520, 360);
			this.btnReset1.Name = "btnReset1";
			this.btnReset1.Size = new System.Drawing.Size(208, 32);
			this.btnReset1.TabIndex = 4;
			this.btnReset1.Text = "Reset All";
			this.btnReset1.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(264, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(376, 29);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "111zz222zz333zz444";
			// 
			// btnSplitString
			// 
			this.btnSplitString.Location = new System.Drawing.Point(16, 56);
			this.btnSplitString.Name = "btnSplitString";
			this.btnSplitString.Size = new System.Drawing.Size(208, 32);
			this.btnSplitString.TabIndex = 6;
			this.btnSplitString.Text = "Split string";
			this.btnSplitString.Click += new System.EventHandler(this.btnSplitString_Click);
			// 
			// btnSubString
			// 
			this.btnSubString.Location = new System.Drawing.Point(264, 56);
			this.btnSubString.Name = "btnSubString";
			this.btnSubString.Size = new System.Drawing.Size(176, 32);
			this.btnSubString.TabIndex = 7;
			this.btnSubString.Text = "Find sub string";
			this.btnSubString.Click += new System.EventHandler(this.btnSubString_Click);
			// 
			// btnlastSubString
			// 
			this.btnlastSubString.Location = new System.Drawing.Point(264, 104);
			this.btnlastSubString.Name = "btnlastSubString";
			this.btnlastSubString.Size = new System.Drawing.Size(240, 32);
			this.btnlastSubString.TabIndex = 8;
			this.btnlastSubString.Text = "Find last sub string";
			this.btnlastSubString.Click += new System.EventHandler(this.btnlastSubString_Click);
			// 
			// btnAllSubStrings
			// 
			this.btnAllSubStrings.Location = new System.Drawing.Point(520, 280);
			this.btnAllSubStrings.Name = "btnAllSubStrings";
			this.btnAllSubStrings.Size = new System.Drawing.Size(208, 32);
			this.btnAllSubStrings.TabIndex = 9;
			this.btnAllSubStrings.Text = "Find each sub string 1";
			this.btnAllSubStrings.Click += new System.EventHandler(this.btnAllSubStrings_Click);
			// 
			// btnExtractSubString
			// 
			this.btnExtractSubString.Location = new System.Drawing.Point(264, 152);
			this.btnExtractSubString.Name = "btnExtractSubString";
			this.btnExtractSubString.Size = new System.Drawing.Size(240, 32);
			this.btnExtractSubString.TabIndex = 10;
			this.btnExtractSubString.Text = "Extract sub string";
			this.btnExtractSubString.Click += new System.EventHandler(this.btnExtractSubString_Click);
			// 
			// btnJoinStringArray
			// 
			this.btnJoinStringArray.Location = new System.Drawing.Point(16, 232);
			this.btnJoinStringArray.Name = "btnJoinStringArray";
			this.btnJoinStringArray.Size = new System.Drawing.Size(200, 32);
			this.btnJoinStringArray.TabIndex = 11;
			this.btnJoinStringArray.Text = "Join string array";
			this.btnJoinStringArray.Click += new System.EventHandler(this.btnJoinStringArray_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label1.Location = new System.Drawing.Point(16, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 120);
			this.label1.TabIndex = 12;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(16, 272);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(112, 120);
			this.textBox4.TabIndex = 13;
			this.textBox4.Text = "Fred\r\nSally\r\nTana\r\nJoe\r\nAnn";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(16, 16);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(224, 29);
			this.textBox6.TabIndex = 17;
			this.textBox6.Text = "WWW#XXX#YYY#ZZZ";
			// 
			// btnAllSubs
			// 
			this.btnAllSubs.Location = new System.Drawing.Point(520, 320);
			this.btnAllSubs.Name = "btnAllSubs";
			this.btnAllSubs.Size = new System.Drawing.Size(208, 32);
			this.btnAllSubs.TabIndex = 19;
			this.btnAllSubs.Text = "Find each sub string 2";
			this.btnAllSubs.Click += new System.EventHandler(this.btnAllSubs_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label2.Location = new System.Drawing.Point(520, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 96);
			this.label2.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.label3.Location = new System.Drawing.Point(520, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 96);
			this.label3.TabIndex = 21;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(264, 200);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(168, 32);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "Delete sub string";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(264, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(232, 32);
			this.button1.TabIndex = 23;
			this.button1.Text = "Insert sub string";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(448, 56);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(56, 29);
			this.textBox7.TabIndex = 18;
			this.textBox7.Text = "333";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(440, 200);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(56, 29);
			this.textBox1.TabIndex = 24;
			this.textBox1.Text = "3zz4";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(264, 288);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 29);
			this.textBox2.TabIndex = 25;
			this.textBox2.Text = "abc";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(440, 288);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(56, 29);
			this.textBox5.TabIndex = 26;
			this.textBox5.Text = "6";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(360, 288);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 24);
			this.label4.TabIndex = 27;
			this.label4.Text = "at posn.";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(744, 397);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAllSubs);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnJoinStringArray);
			this.Controls.Add(this.btnExtractSubString);
			this.Controls.Add(this.btnAllSubStrings);
			this.Controls.Add(this.btnlastSubString);
			this.Controls.Add(this.btnSubString);
			this.Controls.Add(this.btnSplitString);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.btnReset1);
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "Working with strings";
			this.Load += new System.EventHandler(this.Form1_Load);
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


		/// <summary> method: Form1_Load
		///	store the initial textbox contents
		/// </summary>
		private void Form1_Load(object sender, System.EventArgs e)
		{
			HoldText3 = textBox3.Text;
			HoldText4 = textBox4.Text;
			HoldText6 = textBox6.Text;
		}

		/// <summary> method: button3_Click
		/// Reset button replaces textbox contents with 
		/// the initial contents
		/// </summary>
		private void button3_Click(object sender, System.EventArgs e)
		{
			label1.Text = "";
			label2.Text = "";
			label3.Text = "";
			textBox3.Text = HoldText3;
			textBox4.Text = HoldText4;
			textBox6.Text = HoldText6;
		}

		/// <summary> method: btnSplitString_Click
		/// split some text into a string array
		/// then show the string array in label1
		/// </summary>
		private void btnSplitString_Click(object sender, System.EventArgs e)
		{
			//split some text into a string array splitting on each '#' character found
			string[] parts = textBox6.Text.Split('#');

			//then show the string array in label1
			string joinStr = "";
			foreach (string str in parts)
			{
				joinStr = joinStr + str + "\r\n";
			}
			label1.Text = joinStr;
		}

		/// <summary> method: btnSubString_Click
		/// get a string from textbox7 
		/// and try and find that string in the
		/// text of textbox3
		/// </summary>
		private void btnSubString_Click(object sender, System.EventArgs e)
		{
			string result;
			int index = textBox3.Text.IndexOf(textBox7.Text); 
			if (index > -1)
			{
				result = textBox7.Text + " starts at position " + Convert.ToInt32(index);
			}
			else  //index == -1 means search item was not found
			{
				result = textBox7.Text + " was not found";
			}
			
			label1.Text = result;

		}

		/// <summary> method: btnlastSubString_Click
		/// find the last instance of a substring "zz" 
		/// in the text of textbox3
		/// </summary>
		private void btnlastSubString_Click(object sender, System.EventArgs e)
		{
			string result, searchString;
			searchString =  "zz";
			int lastIndex = textBox3.Text.LastIndexOf(searchString); 
			if (lastIndex > -1)
			{
				result = "last " + searchString + " starts at position " + Convert.ToInt32(lastIndex);
			}
			else  //index == -1 means search item was not found
			{
				result = searchString + " was not found";
			}
			
			label1.Text = result;
		}

		/// <summary> method: btnAllSubStrings_Click
		/// the Split method only works for single character sepperators
		/// here we search for a set of substrings sepperated by a 
		/// group of characters = "zz"
		/// this version keeps shortening the source string to the characters
		/// after the first "zz" and then looking for the first "zz"
		/// in the shortened string
		/// </summary>
		private void btnAllSubStrings_Click(object sender, System.EventArgs e)
		{
			string searchString, sourceStr;
			searchString =  "zz";
			int len = searchString.Length;
			StringBuilder sbParts = new StringBuilder(100);
			sourceStr = textBox3.Text;
			int index = sourceStr.IndexOf(searchString); //find first "zz"
			while (index > -1)
			{
				sbParts.Append(sourceStr.Substring(0,index) + newline);
				sourceStr = sourceStr.Substring(index + len); //shorten source string
				index = sourceStr.IndexOf(searchString);//find first "zz" in shortened string
			}

			sbParts.Append(sourceStr);
			label2.Text = sbParts.ToString();
		}

		/// <summary> method: btnAllSubs_Click
		/// the Split method only works for single character sepperators
		/// here we search for a set of substrings sepperated by a 
		/// group of characters = "zz"
		/// this version finds the positions of all the "zz" 
		/// sub strings and stores them in an int array
		/// it then uses these positions to get the sub strings 
		/// between the "zz"s
		/// </summary>
		private void btnAllSubs_Click(object sender, System.EventArgs e)
		{
			int len, slen, startPos, stopPos, separatorCount = 0;
			int[] Breaks = new int[100];
			string allText, searchString;
			searchString =  "zz";
			slen = searchString.Length;
			allText = textBox3.Text;
			len = allText.Length;
			Breaks[0] = -2;
			stopPos = allText.IndexOf(searchString,0,allText.Length);
			while (stopPos > -1)
			{
				separatorCount++;
				Breaks[separatorCount] = stopPos;
				stopPos = allText.IndexOf(searchString,stopPos + slen);
			}
			Breaks[separatorCount + 1] = allText.Length;
			StringBuilder sb = new StringBuilder(100);
			for (int i = 0; i <= separatorCount; i++)
			{
				startPos = Breaks[i]+ slen;
				stopPos = Breaks[i+1]-1;
				sb.Append(allText.Substring(startPos, stopPos - startPos + 1) + ",");
			}
			label3.Text = sb.ToString();
		}

		/// <summary> method: btnExtractSubString_Click
		/// find the sub string in textbox3's text that 
		/// starts at position 5 and is 8 characters long
		/// </summary>
		private void btnExtractSubString_Click(object sender, System.EventArgs e)
		{
			string allText = textBox3.Text.ToString();
			string subText;
			subText = allText.Substring(5,8);
			//pick characters from position 5 for 8 characters, numbering begins at zero
			label1.Text = subText + " is the 8 character string starting from position 5"
				+ " where numbering starts at zero";
		}

		/// <summary> method: btnJoinStringArray_Click
		/// join up the lines in a string array into a single string 
		/// where there is a substring marking the beginning and end 
		/// of each line from the array
		/// 
		/// In this example the string array contains these lines
		/// Fred
		/// Sally
		/// Tana
		/// Joe
		/// Ann
		/// 
		/// and when the lines are joined we will get
		/// Fred @ Sally @ Tana @ Joe @ Ann
		/// </summary>
		private void btnJoinStringArray_Click(object sender, System.EventArgs e)
		{
			string[] friends;
			friends = textBox4.Lines;
			string people;
			people = string.Join(" @ ",friends);
			//the join method will join up the strings in a string array
			//putting a separator string between each. In this example the
			//separator string is " @ "
			label1.Text = people;
		}

		/// <summary> method: btnDelete_Click
		/// find if the sub string in textbox7's text 
		/// exists in textbox3's text
		/// if so then delete it
		/// otherwise give a message
		/// </summary>
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			string allText = textBox3.Text.ToString();
			string subText;
			int substringAt;
			subText = textBox1.Text.ToString();
			substringAt = allText.IndexOf(subText);
			if (substringAt >= 0)
			{
				string part1 = allText.Substring(0,substringAt);
				string part2 = allText.Substring(substringAt + subText.Length);
				textBox3.Text = part1 + part2;
			}
			else
			{
				MessageBox.Show("Substring not found");
			}
		}

		/// <summary> method:
		/// To insert a string from textBox2 into the string in 
		/// textBox3 at a position given by a number in textbox5
		/// </summary>
		private void button1_Click(object sender, System.EventArgs e)
		{
			int insertAt = Convert.ToInt32(textBox5.Text);
			string part1 = textBox3.Text.Substring(0,insertAt);
			string part2 = textBox3.Text.Substring(insertAt);
			textBox3.Text = part1 + textBox2.Text + part2;
		}
	}
}