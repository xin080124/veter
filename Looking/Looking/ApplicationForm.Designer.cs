namespace Looking
{
    partial class ApplicationForm
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
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtCandidateFullName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddApplication = new System.Windows.Forms.Panel();
            this.cboAddCandidateName = new System.Windows.Forms.ComboBox();
            this.cboAddCandidateID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAddVacancyDescription = new System.Windows.Forms.ComboBox();
            this.cboAddVacancyID = new System.Windows.Forms.ComboBox();
            this.btnSaveApplication = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOwnerID1 = new System.Windows.Forms.Label();
            this.btnAddApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.pnlAddApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApplication
            // 
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.Location = new System.Drawing.Point(45, 30);
            this.dgvApplication.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.Size = new System.Drawing.Size(298, 291);
            this.dgvApplication.TabIndex = 13;
            this.dgvApplication.Click += new System.EventHandler(this.aplst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Candidate Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Salary:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(411, 78);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(134, 18);
            this.lblFirstName.TabIndex = 42;
            this.lblFirstName.Text = "Employer Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(428, 29);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 18);
            this.lblLastName.TabIndex = 41;
            this.lblLastName.Text = "Description:";
            // 
            // txtCandidateFullName
            // 
            this.txtCandidateFullName.Location = new System.Drawing.Point(566, 180);
            this.txtCandidateFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCandidateFullName.Name = "txtCandidateFullName";
            this.txtCandidateFullName.Size = new System.Drawing.Size(148, 28);
            this.txtCandidateFullName.TabIndex = 40;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(549, 125);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(361, 28);
            this.txtSalary.TabIndex = 39;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(543, 72);
            this.txtEmployerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(148, 28);
            this.txtEmployerName.TabIndex = 38;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(544, 22);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(242, 28);
            this.txtDescription.TabIndex = 37;
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(586, 325);
            this.btnDeleteApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(200, 32);
            this.btnDeleteApplication.TabIndex = 47;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(666, 378);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 32);
            this.btnReturn.TabIndex = 48;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddApplication
            // 
            this.pnlAddApplication.Controls.Add(this.cboAddCandidateName);
            this.pnlAddApplication.Controls.Add(this.cboAddCandidateID);
            this.pnlAddApplication.Controls.Add(this.label3);
            this.pnlAddApplication.Controls.Add(this.cboAddVacancyDescription);
            this.pnlAddApplication.Controls.Add(this.cboAddVacancyID);
            this.pnlAddApplication.Controls.Add(this.btnSaveApplication);
            this.pnlAddApplication.Controls.Add(this.btnCancel);
            this.pnlAddApplication.Controls.Add(this.lblOwnerID1);
            this.pnlAddApplication.Location = new System.Drawing.Point(386, 19);
            this.pnlAddApplication.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddApplication.Name = "pnlAddApplication";
            this.pnlAddApplication.Size = new System.Drawing.Size(525, 298);
            this.pnlAddApplication.TabIndex = 49;
            this.pnlAddApplication.Visible = false;
            // 
            // cboAddCandidateName
            // 
            this.cboAddCandidateName.FormattingEnabled = true;
            this.cboAddCandidateName.Location = new System.Drawing.Point(321, 132);
            this.cboAddCandidateName.Margin = new System.Windows.Forms.Padding(4);
            this.cboAddCandidateName.Name = "cboAddCandidateName";
            this.cboAddCandidateName.Size = new System.Drawing.Size(164, 26);
            this.cboAddCandidateName.TabIndex = 27;
            // 
            // cboAddCandidateID
            // 
            this.cboAddCandidateID.FormattingEnabled = true;
            this.cboAddCandidateID.Location = new System.Drawing.Point(147, 132);
            this.cboAddCandidateID.Margin = new System.Windows.Forms.Padding(4);
            this.cboAddCandidateID.Name = "cboAddCandidateID";
            this.cboAddCandidateID.Size = new System.Drawing.Size(132, 26);
            this.cboAddCandidateID.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Candidate:";
            // 
            // cboAddVacancyDescription
            // 
            this.cboAddVacancyDescription.FormattingEnabled = true;
            this.cboAddVacancyDescription.Location = new System.Drawing.Point(318, 76);
            this.cboAddVacancyDescription.Margin = new System.Windows.Forms.Padding(4);
            this.cboAddVacancyDescription.Name = "cboAddVacancyDescription";
            this.cboAddVacancyDescription.Size = new System.Drawing.Size(164, 26);
            this.cboAddVacancyDescription.TabIndex = 24;
            // 
            // cboAddVacancyID
            // 
            this.cboAddVacancyID.FormattingEnabled = true;
            this.cboAddVacancyID.Location = new System.Drawing.Point(144, 76);
            this.cboAddVacancyID.Margin = new System.Windows.Forms.Padding(4);
            this.cboAddVacancyID.Name = "cboAddVacancyID";
            this.cboAddVacancyID.Size = new System.Drawing.Size(132, 26);
            this.cboAddVacancyID.TabIndex = 23;
            // 
            // btnSaveApplication
            // 
            this.btnSaveApplication.Location = new System.Drawing.Point(62, 228);
            this.btnSaveApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveApplication.Name = "btnSaveApplication";
            this.btnSaveApplication.Size = new System.Drawing.Size(184, 32);
            this.btnSaveApplication.TabIndex = 17;
            this.btnSaveApplication.Text = "Save Application";
            this.btnSaveApplication.UseVisualStyleBackColor = true;
            this.btnSaveApplication.Click += new System.EventHandler(this.btnSaveApplication_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 228);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOwnerID1
            // 
            this.lblOwnerID1.AutoSize = true;
            this.lblOwnerID1.Location = new System.Drawing.Point(56, 80);
            this.lblOwnerID1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerID1.Name = "lblOwnerID1";
            this.lblOwnerID1.Size = new System.Drawing.Size(80, 18);
            this.lblOwnerID1.TabIndex = 6;
            this.lblOwnerID1.Text = "Vacancy:";
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(392, 325);
            this.btnAddApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(159, 32);
            this.btnAddApplication.TabIndex = 50;
            this.btnAddApplication.Text = "Add Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 443);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.pnlAddApplication);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteApplication);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtCandidateFullName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvApplication);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.pnlAddApplication.ResumeLayout(false);
            this.pnlAddApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtCandidateFullName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddApplication;
        private System.Windows.Forms.ComboBox cboAddVacancyDescription;
        private System.Windows.Forms.ComboBox cboAddVacancyID;
        private System.Windows.Forms.Button btnSaveApplication;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOwnerID1;
        private System.Windows.Forms.ComboBox cboAddCandidateName;
        private System.Windows.Forms.ComboBox cboAddCandidateID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddApplication;
    }
}