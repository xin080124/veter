namespace mealsOrders1483998
{
    partial class ViewForm3
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
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.cmbFilterDisplay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.Color.White;
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(24, 12);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(500, 261);
            this.pnlDrawOn.TabIndex = 2;
            // 
            // cmbFilterDisplay
            // 
            this.cmbFilterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterDisplay.Items.AddRange(new object[] {
            "Select display.....",
            "All Orders",
            "Pizzas only",
            "Noodles only",
            "Cakes only"});
            this.cmbFilterDisplay.Location = new System.Drawing.Point(197, 316);
            this.cmbFilterDisplay.Name = "cmbFilterDisplay";
            this.cmbFilterDisplay.Size = new System.Drawing.Size(240, 28);
            this.cmbFilterDisplay.TabIndex = 31;
            this.cmbFilterDisplay.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDisplay_SelectedIndexChanged);
            // 
            // ViewForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 384);
            this.Controls.Add(this.cmbFilterDisplay);
            this.Controls.Add(this.pnlDrawOn);
            this.Name = "ViewForm3";
            this.Text = "ViewForm3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.ComboBox cmbFilterDisplay;
    }
}