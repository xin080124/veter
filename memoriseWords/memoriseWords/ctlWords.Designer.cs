namespace memoriseWords
{
    partial class ctlWords
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textWord = new System.Windows.Forms.TextBox();
            this.butShowWord = new System.Windows.Forms.Button();
            this.butShowMeaning = new System.Windows.Forms.Button();
            this.textMeaning = new System.Windows.Forms.TextBox();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.butFail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textWord
            // 
            this.textWord.Location = new System.Drawing.Point(42, 82);
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(100, 20);
            this.textWord.TabIndex = 0;
            // 
            // butShowWord
            // 
            this.butShowWord.Location = new System.Drawing.Point(42, 43);
            this.butShowWord.Name = "butShowWord";
            this.butShowWord.Size = new System.Drawing.Size(75, 23);
            this.butShowWord.TabIndex = 1;
            this.butShowWord.Text = "ShowWord";
            this.butShowWord.UseVisualStyleBackColor = true;
            this.butShowWord.Click += new System.EventHandler(this.butShowWord_Click);
            // 
            // butShowMeaning
            // 
            this.butShowMeaning.Location = new System.Drawing.Point(42, 127);
            this.butShowMeaning.Name = "butShowMeaning";
            this.butShowMeaning.Size = new System.Drawing.Size(139, 23);
            this.butShowMeaning.TabIndex = 2;
            this.butShowMeaning.Text = "ShowMeaning";
            this.butShowMeaning.UseVisualStyleBackColor = true;
            this.butShowMeaning.Click += new System.EventHandler(this.butShowMeaning_Click);
            // 
            // textMeaning
            // 
            this.textMeaning.Location = new System.Drawing.Point(42, 175);
            this.textMeaning.Name = "textMeaning";
            this.textMeaning.Size = new System.Drawing.Size(100, 20);
            this.textMeaning.TabIndex = 3;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(42, 243);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(75, 23);
            this.btnSuccess.TabIndex = 4;
            this.btnSuccess.Text = "success";
            this.btnSuccess.UseVisualStyleBackColor = true;
            // 
            // butFail
            // 
            this.butFail.Location = new System.Drawing.Point(194, 243);
            this.butFail.Name = "butFail";
            this.butFail.Size = new System.Drawing.Size(75, 23);
            this.butFail.TabIndex = 5;
            this.butFail.Text = "fail";
            this.butFail.UseVisualStyleBackColor = true;
            // 
            // ctlWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butFail);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.textMeaning);
            this.Controls.Add(this.butShowMeaning);
            this.Controls.Add(this.butShowWord);
            this.Controls.Add(this.textWord);
            this.Name = "ctlWords";
            this.Size = new System.Drawing.Size(392, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.Button butShowWord;
        private System.Windows.Forms.Button butShowMeaning;
        private System.Windows.Forms.TextBox textMeaning;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button butFail;
    }
}
