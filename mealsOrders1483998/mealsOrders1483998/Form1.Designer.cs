namespace mealsOrders1483998
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
            this.btnShowViews = new System.Windows.Forms.Button();
            this.btnMakeViews = new System.Windows.Forms.Button();
            this.btnMakeModel = new System.Windows.Forms.Button();
            this.btnMakeController = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowViews
            // 
            this.btnShowViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowViews.Location = new System.Drawing.Point(74, 174);
            this.btnShowViews.Name = "btnShowViews";
            this.btnShowViews.Size = new System.Drawing.Size(136, 32);
            this.btnShowViews.TabIndex = 7;
            this.btnShowViews.Text = "Show Views";
            this.btnShowViews.Click += new System.EventHandler(this.btnShowViews_Click);
            // 
            // btnMakeViews
            // 
            this.btnMakeViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeViews.Location = new System.Drawing.Point(74, 134);
            this.btnMakeViews.Name = "btnMakeViews";
            this.btnMakeViews.Size = new System.Drawing.Size(136, 32);
            this.btnMakeViews.TabIndex = 6;
            this.btnMakeViews.Text = "Make Views";
            this.btnMakeViews.Click += new System.EventHandler(this.btnMakeViews_Click);
            // 
            // btnMakeModel
            // 
            this.btnMakeModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeModel.Location = new System.Drawing.Point(74, 94);
            this.btnMakeModel.Name = "btnMakeModel";
            this.btnMakeModel.Size = new System.Drawing.Size(136, 32);
            this.btnMakeModel.TabIndex = 5;
            this.btnMakeModel.Text = "Make Model";
            this.btnMakeModel.Click += new System.EventHandler(this.btnMakeModel_Click);
            // 
            // btnMakeController
            // 
            this.btnMakeController.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeController.Location = new System.Drawing.Point(74, 54);
            this.btnMakeController.Name = "btnMakeController";
            this.btnMakeController.Size = new System.Drawing.Size(136, 32);
            this.btnMakeController.TabIndex = 4;
            this.btnMakeController.Text = "Make Controller";
            this.btnMakeController.Click += new System.EventHandler(this.btnMakeController_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowViews);
            this.Controls.Add(this.btnMakeViews);
            this.Controls.Add(this.btnMakeModel);
            this.Controls.Add(this.btnMakeController);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowViews;
        private System.Windows.Forms.Button btnMakeViews;
        private System.Windows.Forms.Button btnMakeModel;
        private System.Windows.Forms.Button btnMakeController;
    }
}

