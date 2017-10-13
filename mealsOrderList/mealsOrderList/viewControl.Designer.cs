namespace mealsOrderList
{
    partial class viewControl
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
            this.butOpenView1 = new System.Windows.Forms.Button();
            this.openView2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOpenView1
            // 
            this.butOpenView1.Location = new System.Drawing.Point(100, 143);
            this.butOpenView1.Name = "butOpenView1";
            this.butOpenView1.Size = new System.Drawing.Size(75, 23);
            this.butOpenView1.TabIndex = 0;
            this.butOpenView1.Text = "openView1";
            this.butOpenView1.UseVisualStyleBackColor = true;
            this.butOpenView1.Click += new System.EventHandler(this.butOpenView1_Click);
            // 
            // openView2
            // 
            this.openView2.Location = new System.Drawing.Point(100, 211);
            this.openView2.Name = "openView2";
            this.openView2.Size = new System.Drawing.Size(75, 23);
            this.openView2.TabIndex = 1;
            this.openView2.Text = "openView2";
            this.openView2.UseVisualStyleBackColor = true;
            this.openView2.Click += new System.EventHandler(this.openView2_Click);
            // 
            // viewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openView2);
            this.Controls.Add(this.butOpenView1);
            this.Name = "viewControl";
            this.Size = new System.Drawing.Size(263, 316);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button view1;
        private System.Windows.Forms.Button butOpenView1;
        private System.Windows.Forms.Button openView2;
    }
}
