using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;

namespace MenusExample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuCut;
		private System.Windows.Forms.MenuItem menuCopy;
		private System.Windows.Forms.MenuItem menuPaste;
		private System.Windows.Forms.MenuItem menuFont;
		private System.Windows.Forms.MenuItem menuArial;
		private System.Windows.Forms.MenuItem menuTimesNewRoman;
		private System.Windows.Forms.MenuItem menuStyle;
		private System.Windows.Forms.MenuItem menuStyleNormal;
		private System.Windows.Forms.MenuItem menuStyleBold;
		private System.Windows.Forms.MenuItem menuStyleItalic;
		private System.Windows.Forms.MenuItem menuCourierNew;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuItem menuEdit;
		private System.Windows.Forms.MenuItem menuColor;
		private System.Windows.Forms.MenuItem popCut;
		private System.Windows.Forms.MenuItem popPaste;
		private System.Windows.Forms.MenuItem popSelectAll;
		private System.Windows.Forms.MenuItem popCopy;
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
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.popCut = new System.Windows.Forms.MenuItem();
			this.popCopy = new System.Windows.Forms.MenuItem();
			this.popPaste = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.popSelectAll = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.menuCut = new System.Windows.Forms.MenuItem();
			this.menuCopy = new System.Windows.Forms.MenuItem();
			this.menuPaste = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuFont = new System.Windows.Forms.MenuItem();
			this.menuArial = new System.Windows.Forms.MenuItem();
			this.menuCourierNew = new System.Windows.Forms.MenuItem();
			this.menuTimesNewRoman = new System.Windows.Forms.MenuItem();
			this.menuStyle = new System.Windows.Forms.MenuItem();
			this.menuStyleNormal = new System.Windows.Forms.MenuItem();
			this.menuStyleBold = new System.Windows.Forms.MenuItem();
			this.menuStyleItalic = new System.Windows.Forms.MenuItem();
			this.menuColor = new System.Windows.Forms.MenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.popCut,
																						 this.popCopy,
																						 this.popPaste,
																						 this.menuItem17,
																						 this.popSelectAll});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// popCut
			// 
			this.popCut.Index = 0;
			this.popCut.Text = "Cut";
			this.popCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// popCopy
			// 
			this.popCopy.Index = 1;
			this.popCopy.Text = "Copy";
			this.popCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// popPaste
			// 
			this.popPaste.Index = 2;
			this.popPaste.Text = "Paste";
			this.popPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 3;
			this.menuItem17.Text = "-";
			// 
			// popSelectAll
			// 
			this.popSelectAll.Index = 4;
			this.popSelectAll.Text = "Select All";
			this.popSelectAll.Click += new System.EventHandler(this.popSelectAll_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuEdit,
																					  this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuNew,
																					  this.menuOpen,
																					  this.menuSave,
																					  this.menuItem7,
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
			this.menuOpen.Text = "Open...";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuSave
			// 
			this.menuSave.Index = 2;
			this.menuSave.Text = "Save...";
			this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 4;
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuCut,
																					 this.menuCopy,
																					 this.menuPaste});
			this.menuEdit.Text = "Edit";
			this.menuEdit.Popup += new System.EventHandler(this.menuEdit_Popup);
			// 
			// menuCut
			// 
			this.menuCut.Index = 0;
			this.menuCut.Text = "Cut";
			this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// menuCopy
			// 
			this.menuCopy.Enabled = false;
			this.menuCopy.Index = 1;
			this.menuCopy.Text = "Copy";
			this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// menuPaste
			// 
			this.menuPaste.Enabled = false;
			this.menuPaste.Index = 2;
			this.menuPaste.Text = "Paste";
			this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFont,
																					  this.menuStyle,
																					  this.menuColor});
			this.menuItem3.Text = "Format";
			// 
			// menuFont
			// 
			this.menuFont.Index = 0;
			this.menuFont.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuArial,
																					 this.menuCourierNew,
																					 this.menuTimesNewRoman});
			this.menuFont.Text = "Font";
			// 
			// menuArial
			// 
			this.menuArial.Checked = true;
			this.menuArial.Index = 0;
			this.menuArial.RadioCheck = true;
			this.menuArial.Text = "Arial";
			this.menuArial.Click += new System.EventHandler(this.menuArial_Click);
			// 
			// menuCourierNew
			// 
			this.menuCourierNew.Index = 1;
			this.menuCourierNew.RadioCheck = true;
			this.menuCourierNew.Text = "Courier New";
			this.menuCourierNew.Click += new System.EventHandler(this.menuArial_Click);
			// 
			// menuTimesNewRoman
			// 
			this.menuTimesNewRoman.Index = 2;
			this.menuTimesNewRoman.RadioCheck = true;
			this.menuTimesNewRoman.Text = "Times New Roman";
			this.menuTimesNewRoman.Click += new System.EventHandler(this.menuArial_Click);
			// 
			// menuStyle
			// 
			this.menuStyle.Index = 1;
			this.menuStyle.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuStyleNormal,
																					  this.menuStyleBold,
																					  this.menuStyleItalic});
			this.menuStyle.Text = "Style";
			// 
			// menuStyleNormal
			// 
			this.menuStyleNormal.Checked = true;
			this.menuStyleNormal.Index = 0;
			this.menuStyleNormal.Text = "Normal";
			this.menuStyleNormal.Click += new System.EventHandler(this.menuStyleNormal_Click);
			// 
			// menuStyleBold
			// 
			this.menuStyleBold.Index = 1;
			this.menuStyleBold.Text = "Bold";
			this.menuStyleBold.Click += new System.EventHandler(this.menuStyleNormal_Click);
			// 
			// menuStyleItalic
			// 
			this.menuStyleItalic.Index = 2;
			this.menuStyleItalic.Text = "Italic";
			this.menuStyleItalic.Click += new System.EventHandler(this.menuStyleNormal_Click);
			// 
			// menuColor
			// 
			this.menuColor.Index = 2;
			this.menuColor.Text = "Color...";
			this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.textBox1.ContextMenu = this.contextMenu1;
			this.textBox1.Location = new System.Drawing.Point(16, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(480, 296);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "textBox1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "doc1";
			this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 22);
			this.ClientSize = new System.Drawing.Size(512, 338);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
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

		/// <summary> method: menuNew_Click
		///start a new text document by clearing the textbox
		///note that we do not check that current work is saved
		/// </summary>
		private void menuNew_Click(object sender, System.EventArgs e)
		{
			textBox1.Text = "";
			//this is a new filename so we set the default filenames of the
			//file dialog boxes to null 
			openFileDialog1.FileName = "";
			saveFileDialog1.FileName = "";
		}

		/// <summary> method: menuOpen_Click
		///Show the standard Open dialog box and if the user chooses a file name 
		///and clicks OK then use that name to display the text of the file in
		///the textbox
		/// </summary>
		private void menuOpen_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				textBox1.Text = sr.ReadToEnd();
				sr.Close();
			}
		}

		/// <summary> method: menuSave_Click
		///Show the standard Save dialog box and if the user chooses a file name 
		///and clicks OK then use that name to save the text of the textbox
		///to a file
		/// </summary>
		private void menuSave_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.FileName = openFileDialog1.FileName;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//The save dialog box will automatically
				//generate a warning if the file already exists
				//provided the property .OverWritePrompt is set to true.
				StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
				sw.Write(textBox1.Text);
				sw.Close();
				openFileDialog1.FileName = saveFileDialog1.FileName;
			}
		}

		/// <summary> method: menuExit_Click
		/// Exit the program
		/// </summary>
		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		/// <summary> method: menuEdit_Popup
		///Should we enable the Cut and Copy menu options of the
		///Edit menu?
		///this is decided when the top level Edit menu item is
		///clicked but the event we need to use is the Popup event
		///NOT the Click event for this menu item
		///We decide on enabling or disabling the options
		///based on whether there is selected text in the textbox
		///(for Cut and Copy)
		///and whether there is text stored in the Clipboard (Paste)
		/// </summary>
		private void menuEdit_Popup(object sender, System.EventArgs e)
		{
			if (textBox1.SelectedText != "")
			{
				menuCopy.Enabled = true;
				menuCut.Enabled = true;
			}
			else
			{
				menuCopy.Enabled = false;
				menuCut.Enabled = false;
			}
			//Should we enable the paste menu option?
			// Declares an IDataObject to hold the data returned from the clipboard.
			// This is used to retrieve the type of data held in clipboard.
			IDataObject iData = Clipboard.GetDataObject();
			if (iData.GetDataPresent(DataFormats.Text))
			{
				menuPaste.Enabled = true;
			}
			else
			{
				menuPaste.Enabled = false;
			}
		}

		/// <summary> method: menuCut_Click
		///copy any selected text in the textbox to the Clipboard
		///then remove the selected text from the textbox
		/// </summary>
		private void menuCut_Click(object sender, System.EventArgs e)
		{
			Clipboard.SetDataObject(textBox1.SelectedText);
			textBox1.SelectedText = "";
		}

		/// <summary> method: menuCopy_Click
		///copy any selected text in the textbox to the Clipboard
		/// </summary>
		private void menuCopy_Click(object sender, System.EventArgs e)
		{
			Clipboard.SetDataObject(textBox1.SelectedText);
		}

		/// <summary> method: menuPaste_Click
		///this menu item is only enabled when there is text in the Clipboard
		///The .Paste method will past the Clipoard text at the current cursor
		///position
		/// </summary>
		private void menuPaste_Click(object sender, System.EventArgs e)
		{
			textBox1.Paste();
		}

		/// <summary> method: menuColor_Click
		/// Show the colorDialog1 box and if the user clicks OK
		/// then use the chosen color to set a new color for the
		/// textbox
		/// </summary>
		private void menuColor_Click(object sender, System.EventArgs e)
		{
			//first set the current color selected in the color dialog
			colorDialog1.Color = textBox1.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox1.BackColor = colorDialog1.Color;
			}
		}

		///==========================================================
		///Note on the context menu. In real programming the textbox control
		///comes with its own built in context menu offering Undo and 
		///Delete options in addition to those we have given
		///To use the example context menu change the .Contextmenu property 
		///of the textbox from (none) to contextMenu1
		
		///The options of the context menu share the event handling code for 
		///the main menu Cut, Copy and paste options
		///==========================================================


		/// <summary> method: contextMenu1_Popup
		///Should we enable the Cut, Copy and Paste menu options of 
		///the context menu?
		///this is decided when the context menu item is
		///shown when the user right clicks on it?
		///The event we need to use is the Popup event
		///for the Context menu item
		///We decide on enabling or disabling the options
		///based on whether there is selected text in the textbox
		///(for Cut and Copy)
		///and whether there is text stored in the Clipboard (Paste)
		/// </summary>
		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			if (textBox1.SelectedText != "")
			{
				popCopy.Enabled = true;
				popCut.Enabled = true;
			}
			else
			{
				popCopy.Enabled = false;
				popCut.Enabled = false;
			}
			//Should we enable the paste menu option?
			// Declares an IDataObject to hold the data returned from the clipboard.
			// This is used to retrieve the type of data held in clipboard.
			IDataObject iData = Clipboard.GetDataObject();
			if (iData.GetDataPresent(DataFormats.Text))
			{
				popPaste.Enabled = true;
			}
			else
			{
				popPaste.Enabled = false;
			}
		
		}

		/// <summary> method: popSelectAll_Click
		///select all text in the textbox
		/// </summary>
		private void popSelectAll_Click(object sender, System.EventArgs e)
		{
			textBox1.SelectAll();
		}
			
		/// <summary> method: menuArial_Click
		///Note this method is shared by all the font name menu items
		///update the font in the textbox and set the othe font name
		///options to unchecked
		/// </summary>
		private void menuArial_Click(object sender, System.EventArgs e)
		{
			float fontSize;
			string fontName;
			FontStyle fontStyle;
			MenuItem mitem;

			mitem = (MenuItem) sender; //the clicked menu item

			menuArial.Checked = false;
			menuCourierNew.Checked = false;
			menuTimesNewRoman.Checked = false;
			mitem.Checked = true; //check the clicked item

			//update the font in the textbox
			fontName = mitem.Text;
			fontSize = textBox1.Font.Size;
			fontStyle = textBox1.Font.Style;
			textBox1.Font = new Font(fontName, fontSize, fontStyle);
		}

		/// <summary> method: menuStyleNormal_Click
		///Note this method will be shared by the NormalStyle, BoldStyle and ItalicStyle menu items
		///Check the relevant menu items and alter the font style used by the textbox
		///to add or drop the style for the selected menu item
		///the issue here is that if Italic is selected and the style is already Bold we need
		///to add Italic without dropping Bold.
		///To do this we use some bitwise maniplation of the integer used to hold the 
		///code for the font style information.
		/// </summary>
		private void menuStyleNormal_Click(object sender, System.EventArgs e)
		{
			float fontSize;
			string fontName;
			string fontStyleText;
			int intStyle;
			FontStyle style;
			MenuItem mitem;

			//	style = new FontStyle(); 
			style = textBox1.Font.Style;
						
			mitem = (MenuItem) sender;
			fontStyleText = mitem.Text;
			//I now know whether they clicked Normal, Bold or Italic

			if (fontStyleText == "Normal")
			{
				style = (FontStyle)DropFromBitField((int)style, (int)FontStyle.Bold);
				style = (FontStyle)DropFromBitField((int)style, (int)FontStyle.Italic);
				mitem.Checked = true;
				menuStyleBold.Checked = false;
				menuStyleItalic.Checked = false;
			}
			else if (fontStyleText == "Bold") 
			{
				if (isInBitField((int)style, (int)FontStyle.Bold))
					//I want to know if FontStyle.Bold is contained in the curent text style
				{
					mitem.Checked = false;
					style = (FontStyle)DropFromBitField((int)style, (int)FontStyle.Bold);
				}
				else
				{
					mitem.Checked = true;
					menuStyleNormal.Checked = false;
					intStyle = (int)style;
					AddToBitField(ref intStyle, (int)FontStyle.Bold);
					style = (FontStyle)intStyle;
				}
			}
			else if (fontStyleText == "Italic") 
			{
				if (isInBitField((int)style, (int)FontStyle.Italic))
				{
					mitem.Checked = false;
					style = (FontStyle)DropFromBitField((int)style, (int)FontStyle.Italic);
				}
				else
				{
					mitem.Checked = true;
					menuStyleNormal.Checked = false;
					intStyle = (int)style;
					AddToBitField(ref intStyle, (int)FontStyle.Italic);
					style = (FontStyle)intStyle;
				}
			}
			if (style == FontStyle.Regular)
			{
				menuStyleNormal.Checked = true;
			}

			fontName = textBox1.Font.Name;
			fontSize = textBox1.Font.Size;

			textBox1.Font = new Font(fontName, fontSize, style);
		}

		/// <summary> method: isInBitField
		///check to see if lookfor is in TheBitField
		/// </summary>
		private bool isInBitField(int TheBitField , int lookfor)
		{
			return ((lookfor & TheBitField) == lookfor);
		}

		/// <summary> method: AddToBitField
		///if AddValue is NOT in TheBitField then add it to the bitfield
		///example of a void function that alters a reference parameter
		/// </summary>
		private void AddToBitField(ref int TheBitField, int AddValue)
		{
			if (!isInBitField(TheBitField,AddValue))
			{
				TheBitField |= AddValue; 
			}
		}

		/// <summary> method: DropFromBitField
		///if DropValue is in TheBitField then remove it from the bitfield
		///Here the int return value is used to return the new value
		///I prefer this aproach to altering a reference parameter as 
		///used in the AddToBitField method above. 
		///In real code both methods should use the same return method
		/// </summary>
		private int DropFromBitField(int TheBitField, int DropValue)
		{
			if (isInBitField(TheBitField,DropValue))
			{
				return(TheBitField -= DropValue);
			}
			else
			{
				return(TheBitField);
			}
		}

	}
}


	













