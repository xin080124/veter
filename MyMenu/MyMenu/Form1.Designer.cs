namespace MyMenu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
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
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 35);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 35);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 25);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 98);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(493, 174);
            this.textBox4.TabIndex = 7;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuEdit,
            this.menuItem3,
            this.menuItem2});
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
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 1;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCut,
            this.menuCopy,
            this.menuPaste});
            this.menuEdit.Text = "Edit";
            // 
            // menuCut
            // 
            this.menuCut.Index = 0;
            this.menuCut.Text = "Cut";
            // 
            // menuCopy
            // 
            this.menuCopy.Enabled = false;
            this.menuCopy.Index = 1;
            this.menuCopy.Text = "Copy";
            // 
            // menuPaste
            // 
            this.menuPaste.Enabled = false;
            this.menuPaste.Index = 2;
            this.menuPaste.Text = "Paste";
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
            // 
            // menuCourierNew
            // 
            this.menuCourierNew.Index = 1;
            this.menuCourierNew.RadioCheck = true;
            this.menuCourierNew.Text = "Courier New";
            // 
            // menuTimesNewRoman
            // 
            this.menuTimesNewRoman.Index = 2;
            this.menuTimesNewRoman.RadioCheck = true;
            this.menuTimesNewRoman.Text = "Times New Roman";
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
            // 
            // menuStyleBold
            // 
            this.menuStyleBold.Index = 1;
            this.menuStyleBold.Text = "Bold";
            // 
            // menuStyleItalic
            // 
            this.menuStyleItalic.Index = 2;
            this.menuStyleItalic.Text = "Italic";
            // 
            // menuColor
            // 
            this.menuColor.Index = 2;
            this.menuColor.Text = "Color...";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem2.Text = "myTab";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "mySub";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 301);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuNew;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuEdit;
        private System.Windows.Forms.MenuItem menuCut;
        private System.Windows.Forms.MenuItem menuCopy;
        private System.Windows.Forms.MenuItem menuPaste;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuFont;
        private System.Windows.Forms.MenuItem menuArial;
        private System.Windows.Forms.MenuItem menuCourierNew;
        private System.Windows.Forms.MenuItem menuTimesNewRoman;
        private System.Windows.Forms.MenuItem menuStyle;
        private System.Windows.Forms.MenuItem menuStyleNormal;
        private System.Windows.Forms.MenuItem menuStyleBold;
        private System.Windows.Forms.MenuItem menuStyleItalic;
        private System.Windows.Forms.MenuItem menuColor;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

