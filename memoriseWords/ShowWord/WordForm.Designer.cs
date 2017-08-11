namespace ShowWord
{
    partial class WordForm
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
            this.ctlWords1 = new memoriseWords.ctlWords();
            this.SuspendLayout();
            // 
            // ctlWords1
            // 
            this.ctlWords1.Location = new System.Drawing.Point(54, 29);
            this.ctlWords1.Name = "ctlWords1";
            this.ctlWords1.Size = new System.Drawing.Size(400, 315);
            this.ctlWords1.TabIndex = 0;
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 374);
            this.Controls.Add(this.ctlWords1);
            this.Name = "WordForm";
            this.Text = "WordForm";
            this.ResumeLayout(false);

        }

        #endregion

        private memoriseWords.ctlWords ctlWords1;
    }
}

