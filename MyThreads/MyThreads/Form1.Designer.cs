namespace MyThreads
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
            this.butMyThread = new System.Windows.Forms.Button();
            this.bthThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMyThread
            // 
            this.butMyThread.Location = new System.Drawing.Point(130, 87);
            this.butMyThread.Name = "butMyThread";
            this.butMyThread.Size = new System.Drawing.Size(214, 52);
            this.butMyThread.TabIndex = 0;
            this.butMyThread.Text = "test my thread";
            this.butMyThread.UseVisualStyleBackColor = true;
            this.butMyThread.Click += new System.EventHandler(this.butMyThread_Click);
            // 
            // bthThrow
            // 
            this.bthThrow.Location = new System.Drawing.Point(130, 209);
            this.bthThrow.Name = "bthThrow";
            this.bthThrow.Size = new System.Drawing.Size(214, 47);
            this.bthThrow.TabIndex = 1;
            this.bthThrow.Text = "test Exception";
            this.bthThrow.UseVisualStyleBackColor = true;
            this.bthThrow.Click += new System.EventHandler(this.bthThrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 354);
            this.Controls.Add(this.bthThrow);
            this.Controls.Add(this.butMyThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMyThread;
        private System.Windows.Forms.Button bthThrow;
    }
}

