namespace GendeneCatCare
{
    partial class TreatmentForm
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
            this.lstTreatments = new System.Windows.Forms.ListBox();
            this.labelTreatmentNo = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddTreatment = new System.Windows.Forms.Panel();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTreatment = new System.Windows.Forms.Button();
            this.pnlAddTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTreatments
            // 
            this.lstTreatments.FormattingEnabled = true;
            this.lstTreatments.ItemHeight = 18;
            this.lstTreatments.Location = new System.Drawing.Point(69, 55);
            this.lstTreatments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTreatments.Name = "lstTreatments";
            this.lstTreatments.Size = new System.Drawing.Size(290, 220);
            this.lstTreatments.TabIndex = 0;
            // 
            // labelTreatmentNo
            // 
            this.labelTreatmentNo.AutoSize = true;
            this.labelTreatmentNo.Location = new System.Drawing.Point(424, 55);
            this.labelTreatmentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTreatmentNo.Name = "labelTreatmentNo";
            this.labelTreatmentNo.Size = new System.Drawing.Size(125, 18);
            this.labelTreatmentNo.TabIndex = 1;
            this.labelTreatmentNo.Text = "Treatment ID:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(424, 126);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(53, 18);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(424, 86);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 18);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.AutoSize = true;
            this.lblTreatmentID.Location = new System.Drawing.Point(552, 55);
            this.lblTreatmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(89, 18);
            this.lblTreatmentID.TabIndex = 5;
            this.lblTreatmentID.Text = "treatment";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(556, 84);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(148, 28);
            this.txtDescription.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(556, 119);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(148, 28);
            this.txtCost.TabIndex = 7;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(69, 320);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 32);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(226, 320);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 32);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(387, 320);
            this.btnAddTreatment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(146, 32);
            this.btnAddTreatment.TabIndex = 10;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(574, 320);
            this.btnUpdateTreatment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(112, 32);
            this.btnUpdateTreatment.TabIndex = 11;
            this.btnUpdateTreatment.Text = "Update Treatment";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Location = new System.Drawing.Point(734, 320);
            this.btnDeleteTreatment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(112, 32);
            this.btnDeleteTreatment.TabIndex = 12;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(734, 381);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 32);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // pnlAddTreatment
            // 
            this.pnlAddTreatment.Controls.Add(this.btnSaveTreatment);
            this.pnlAddTreatment.Controls.Add(this.btnCancel);
            this.pnlAddTreatment.Controls.Add(this.txtAddCost);
            this.pnlAddTreatment.Controls.Add(this.txtAddDescription);
            this.pnlAddTreatment.Controls.Add(this.lblAddCost);
            this.pnlAddTreatment.Controls.Add(this.lblAddDescription);
            this.pnlAddTreatment.Location = new System.Drawing.Point(441, 158);
            this.pnlAddTreatment.Name = "pnlAddTreatment";
            this.pnlAddTreatment.Size = new System.Drawing.Size(354, 155);
            this.pnlAddTreatment.TabIndex = 14;
            this.pnlAddTreatment.Visible = false;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(32, 22);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(107, 18);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(35, 73);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(44, 18);
            this.lblAddCost.TabIndex = 1;
            this.lblAddCost.Text = "Cost";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(184, 22);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(100, 28);
            this.txtAddDescription.TabIndex = 2;
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(184, 73);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(100, 28);
            this.txtAddCost.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(35, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTreatment
            // 
            this.btnSaveTreatment.Location = new System.Drawing.Point(169, 116);
            this.btnSaveTreatment.Name = "btnSaveTreatment";
            this.btnSaveTreatment.Size = new System.Drawing.Size(115, 36);
            this.btnSaveTreatment.TabIndex = 5;
            this.btnSaveTreatment.Text = "Save";
            this.btnSaveTreatment.UseVisualStyleBackColor = true;
            this.btnSaveTreatment.Click += new System.EventHandler(this.btnSaveTreatment_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 464);
            this.Controls.Add(this.pnlAddTreatment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.btnUpdateTreatment);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.labelTreatmentNo);
            this.Controls.Add(this.lstTreatments);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TreatmentForm";
            this.Text = "Treatment Maintenance";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.pnlAddTreatment.ResumeLayout(false);
            this.pnlAddTreatment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTreatments;
        private System.Windows.Forms.Label labelTreatmentNo;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddTreatment;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Button btnSaveTreatment;
        private System.Windows.Forms.Button btnCancel;
    }
}