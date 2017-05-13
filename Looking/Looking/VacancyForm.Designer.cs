namespace Looking
{
    partial class VacancyForm
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
            this.lstVacancy = new System.Windows.Forms.ListBox();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDeleteVacancy = new System.Windows.Forms.Button();
            this.btnUpdateVacancy = new System.Windows.Forms.Button();
            this.btnAddVacancy = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddVacancy = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddSalary = new System.Windows.Forms.TextBox();
            this.cboAddEmployerName = new System.Windows.Forms.ComboBox();
            this.cboAddEmployerID = new System.Windows.Forms.ComboBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.btnSaveVacancy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOwnerID1 = new System.Windows.Forms.Label();
            this.lblAddBreed = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.pnlAddVacancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVacancy
            // 
            this.lstVacancy.FormattingEnabled = true;
            this.lstVacancy.ItemHeight = 18;
            this.lstVacancy.Location = new System.Drawing.Point(30, 26);
            this.lstVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVacancy.Name = "lstVacancy";
            this.lstVacancy.Size = new System.Drawing.Size(265, 274);
            this.lstVacancy.TabIndex = 3;
            this.lstVacancy.Click += new System.EventHandler(this.lstVacancy_Click);
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(315, 33);
            this.lblVacancyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(116, 18);
            this.lblVacancyID.TabIndex = 39;
            this.lblVacancyID.Text = "Vancancy ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Employer Name:";
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(460, 267);
            this.txtEmployerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(148, 28);
            this.txtEmployerName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Employer ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Salary:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(316, 120);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 18);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "Status:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(315, 72);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 18);
            this.lblLastName.TabIndex = 33;
            this.lblLastName.Text = "Description:";
            // 
            // txtEmployerID
            // 
            this.txtEmployerID.Location = new System.Drawing.Point(453, 223);
            this.txtEmployerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.Size = new System.Drawing.Size(148, 28);
            this.txtEmployerID.TabIndex = 32;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(436, 168);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(361, 28);
            this.txtSalary.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(430, 115);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(148, 28);
            this.txtStatus.TabIndex = 30;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(432, 65);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(242, 28);
            this.txtDescription.TabIndex = 29;
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(430, 25);
            this.txtVacancyID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.Size = new System.Drawing.Size(148, 28);
            this.txtVacancyID.TabIndex = 28;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(166, 318);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 32);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(34, 318);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 32);
            this.btnPrevious.TabIndex = 43;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDeleteVacancy
            // 
            this.btnDeleteVacancy.Location = new System.Drawing.Point(651, 317);
            this.btnDeleteVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteVacancy.Name = "btnDeleteVacancy";
            this.btnDeleteVacancy.Size = new System.Drawing.Size(176, 32);
            this.btnDeleteVacancy.TabIndex = 42;
            this.btnDeleteVacancy.Text = "Delete Vacancy";
            this.btnDeleteVacancy.UseVisualStyleBackColor = true;
            this.btnDeleteVacancy.Click += new System.EventHandler(this.btnDeleteVacancy_Click);
            // 
            // btnUpdateVacancy
            // 
            this.btnUpdateVacancy.Location = new System.Drawing.Point(480, 317);
            this.btnUpdateVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateVacancy.Name = "btnUpdateVacancy";
            this.btnUpdateVacancy.Size = new System.Drawing.Size(153, 32);
            this.btnUpdateVacancy.TabIndex = 41;
            this.btnUpdateVacancy.Text = "Update Vacancy";
            this.btnUpdateVacancy.UseVisualStyleBackColor = true;
            this.btnUpdateVacancy.Click += new System.EventHandler(this.btnUpdateVacancy_Click);
            // 
            // btnAddVacancy
            // 
            this.btnAddVacancy.Location = new System.Drawing.Point(314, 317);
            this.btnAddVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddVacancy.Name = "btnAddVacancy";
            this.btnAddVacancy.Size = new System.Drawing.Size(138, 32);
            this.btnAddVacancy.TabIndex = 40;
            this.btnAddVacancy.Text = "Add Vacancy";
            this.btnAddVacancy.UseVisualStyleBackColor = true;
            this.btnAddVacancy.Click += new System.EventHandler(this.btnAddVacancy_Click);
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(369, 371);
            this.btnMark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(264, 32);
            this.btnMark.TabIndex = 45;
            this.btnMark.Text = "Mark Vacancy as Filled";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(696, 371);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 32);
            this.btnReturn.TabIndex = 46;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddVacancy
            // 
            this.pnlAddVacancy.Controls.Add(this.label4);
            this.pnlAddVacancy.Controls.Add(this.txtAddSalary);
            this.pnlAddVacancy.Controls.Add(this.cboAddEmployerName);
            this.pnlAddVacancy.Controls.Add(this.cboAddEmployerID);
            this.pnlAddVacancy.Controls.Add(this.txtAddDescription);
            this.pnlAddVacancy.Controls.Add(this.txtAddID);
            this.pnlAddVacancy.Controls.Add(this.btnSaveVacancy);
            this.pnlAddVacancy.Controls.Add(this.btnCancel);
            this.pnlAddVacancy.Controls.Add(this.lblOwnerID1);
            this.pnlAddVacancy.Controls.Add(this.lblAddBreed);
            this.pnlAddVacancy.Controls.Add(this.lblAddName);
            this.pnlAddVacancy.Location = new System.Drawing.Point(314, 15);
            this.pnlAddVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddVacancy.Name = "pnlAddVacancy";
            this.pnlAddVacancy.Size = new System.Drawing.Size(525, 393);
            this.pnlAddVacancy.TabIndex = 47;
            this.pnlAddVacancy.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Salary:";
            // 
            // txtAddSalary
            // 
            this.txtAddSalary.Location = new System.Drawing.Point(162, 115);
            this.txtAddSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddSalary.Name = "txtAddSalary";
            this.txtAddSalary.Size = new System.Drawing.Size(84, 28);
            this.txtAddSalary.TabIndex = 25;
            // 
            // cboAddEmployerName
            // 
            this.cboAddEmployerName.FormattingEnabled = true;
            this.cboAddEmployerName.Location = new System.Drawing.Point(318, 238);
            this.cboAddEmployerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAddEmployerName.Name = "cboAddEmployerName";
            this.cboAddEmployerName.Size = new System.Drawing.Size(164, 26);
            this.cboAddEmployerName.TabIndex = 24;
            // 
            // cboAddEmployerID
            // 
            this.cboAddEmployerID.FormattingEnabled = true;
            this.cboAddEmployerID.Location = new System.Drawing.Point(144, 238);
            this.cboAddEmployerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAddEmployerID.Name = "cboAddEmployerID";
            this.cboAddEmployerID.Size = new System.Drawing.Size(132, 26);
            this.cboAddEmployerID.TabIndex = 23;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(162, 72);
            this.txtAddDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(84, 28);
            this.txtAddDescription.TabIndex = 19;
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(168, 28);
            this.txtAddID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(84, 28);
            this.txtAddID.TabIndex = 18;
            // 
            // btnSaveVacancy
            // 
            this.btnSaveVacancy.Location = new System.Drawing.Point(99, 310);
            this.btnSaveVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveVacancy.Name = "btnSaveVacancy";
            this.btnSaveVacancy.Size = new System.Drawing.Size(148, 32);
            this.btnSaveVacancy.TabIndex = 17;
            this.btnSaveVacancy.Text = "Save Vacancy";
            this.btnSaveVacancy.UseVisualStyleBackColor = true;
            this.btnSaveVacancy.Click += new System.EventHandler(this.btnSaveVacancy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(334, 310);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOwnerID1
            // 
            this.lblOwnerID1.AutoSize = true;
            this.lblOwnerID1.Location = new System.Drawing.Point(56, 242);
            this.lblOwnerID1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerID1.Name = "lblOwnerID1";
            this.lblOwnerID1.Size = new System.Drawing.Size(89, 18);
            this.lblOwnerID1.TabIndex = 6;
            this.lblOwnerID1.Text = "Employer:";
            // 
            // lblAddBreed
            // 
            this.lblAddBreed.AutoSize = true;
            this.lblAddBreed.Location = new System.Drawing.Point(56, 76);
            this.lblAddBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBreed.Name = "lblAddBreed";
            this.lblAddBreed.Size = new System.Drawing.Size(107, 18);
            this.lblAddBreed.TabIndex = 2;
            this.lblAddBreed.Text = "Description";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(56, 28);
            this.lblAddName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(107, 18);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Vacancy ID:";
            // 
            // VacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 422);
            this.Controls.Add(this.pnlAddVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDeleteVacancy);
            this.Controls.Add(this.btnUpdateVacancy);
            this.Controls.Add(this.btnAddVacancy);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.lstVacancy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VacancyForm";
            this.Text = "VacancyForm";
            this.pnlAddVacancy.ResumeLayout(false);
            this.pnlAddVacancy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVacancy;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDeleteVacancy;
        private System.Windows.Forms.Button btnUpdateVacancy;
        private System.Windows.Forms.Button btnAddVacancy;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddVacancy;
        private System.Windows.Forms.ComboBox cboAddEmployerName;
        private System.Windows.Forms.ComboBox cboAddEmployerID;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Button btnSaveVacancy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOwnerID1;
        private System.Windows.Forms.Label lblAddBreed;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddSalary;
    }
}