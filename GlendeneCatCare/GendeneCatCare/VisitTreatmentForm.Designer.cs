namespace GendeneCatCare
{
    partial class VisitTreatmentForm
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
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.dgvVisitTreatments = new System.Windows.Forms.DataGridView();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Location = new System.Drawing.Point(62, 48);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.Size = new System.Drawing.Size(423, 180);
            this.dgvVisits.TabIndex = 1;
            // 
            // dgvVisitTreatments
            // 
            this.dgvVisitTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitTreatments.Location = new System.Drawing.Point(62, 257);
            this.dgvVisitTreatments.Name = "dgvVisitTreatments";
            this.dgvVisitTreatments.Size = new System.Drawing.Size(240, 150);
            this.dgvVisitTreatments.TabIndex = 2;
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Location = new System.Drawing.Point(465, 266);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(348, 150);
            this.dgvTreatments.TabIndex = 3;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(339, 266);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(93, 47);
            this.btnAllocate.TabIndex = 4;
            this.btnAllocate.Text = "Allocate Treatment";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(314, 337);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 18);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(369, 334);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(90, 28);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(339, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 47);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Treatment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(792, 431);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 47);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VisitTreatmentForm
            // 
            this.ClientSize = new System.Drawing.Size(918, 506);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.dgvVisitTreatments);
            this.Controls.Add(this.dgvVisits);
            this.Name = "VisitTreatmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.DataGridView dgvVisitTreatments;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReturn;
    }
}