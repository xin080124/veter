namespace Looking
{
    partial class EmployerForm
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
            this.btnDeleteEmployer = new System.Windows.Forms.Button();
            this.btnUpdateAnEmployer = new System.Windows.Forms.Button();
            this.btnAddOneEmployer = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.lstEmployer = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pnlAddEmployer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.textNewStreetAddress = new System.Windows.Forms.TextBox();
            this.textNewSuburb = new System.Windows.Forms.TextBox();
            this.textNewEmployerName = new System.Windows.Forms.TextBox();
            this.btnSaveEmployer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.pnlAddEmployer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteEmployer
            // 
            this.btnDeleteEmployer.Location = new System.Drawing.Point(702, 295);
            this.btnDeleteEmployer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployer.Name = "btnDeleteEmployer";
            this.btnDeleteEmployer.Size = new System.Drawing.Size(144, 32);
            this.btnDeleteEmployer.TabIndex = 30;
            this.btnDeleteEmployer.Text = "Delete Emplyer";
            this.btnDeleteEmployer.UseVisualStyleBackColor = true;
            this.btnDeleteEmployer.Click += new System.EventHandler(this.btnDeleteEmployer_Click);
            // 
            // btnUpdateAnEmployer
            // 
            this.btnUpdateAnEmployer.Location = new System.Drawing.Point(486, 295);
            this.btnUpdateAnEmployer.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAnEmployer.Name = "btnUpdateAnEmployer";
            this.btnUpdateAnEmployer.Size = new System.Drawing.Size(153, 32);
            this.btnUpdateAnEmployer.TabIndex = 29;
            this.btnUpdateAnEmployer.Text = "Update Employer";
            this.btnUpdateAnEmployer.UseVisualStyleBackColor = true;
            this.btnUpdateAnEmployer.Click += new System.EventHandler(this.btnUpdateAnEmployer_Click);
            // 
            // btnAddOneEmployer
            // 
            this.btnAddOneEmployer.Location = new System.Drawing.Point(320, 295);
            this.btnAddOneEmployer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOneEmployer.Name = "btnAddOneEmployer";
            this.btnAddOneEmployer.Size = new System.Drawing.Size(138, 32);
            this.btnAddOneEmployer.TabIndex = 28;
            this.btnAddOneEmployer.Text = "Add Employer";
            this.btnAddOneEmployer.UseVisualStyleBackColor = true;
            this.btnAddOneEmployer.Click += new System.EventHandler(this.btnAddOneEmployer_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(544, 238);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 28);
            this.txtPhoneNumber.TabIndex = 27;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(536, 177);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(148, 28);
            this.txtSuburb.TabIndex = 26;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(536, 122);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(348, 28);
            this.txtStreetAddress.TabIndex = 25;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(554, 76);
            this.txtEmployerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(295, 28);
            this.txtEmployerName.TabIndex = 24;
            // 
            // txtEmployerID
            // 
            this.txtEmployerID.Location = new System.Drawing.Point(536, 37);
            this.txtEmployerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.Size = new System.Drawing.Size(148, 28);
            this.txtEmployerID.TabIndex = 23;
            // 
            // lstEmployer
            // 
            this.lstEmployer.FormattingEnabled = true;
            this.lstEmployer.ItemHeight = 18;
            this.lstEmployer.Location = new System.Drawing.Point(18, 36);
            this.lstEmployer.Margin = new System.Windows.Forms.Padding(4);
            this.lstEmployer.Name = "lstEmployer";
            this.lstEmployer.Size = new System.Drawing.Size(376, 220);
            this.lstEmployer.TabIndex = 22;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 296);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 32);
            this.btnNext.TabIndex = 32;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(40, 296);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 32);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(702, 348);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 32);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Suburb:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Street Address:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(420, 79);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(134, 18);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "Employer Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(420, 42);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(107, 18);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.Text = "EmployerID:";
            // 
            // pnlAddEmployer
            // 
            this.pnlAddEmployer.Controls.Add(this.label4);
            this.pnlAddEmployer.Controls.Add(this.textNewPhoneNumber);
            this.pnlAddEmployer.Controls.Add(this.textNewStreetAddress);
            this.pnlAddEmployer.Controls.Add(this.textNewSuburb);
            this.pnlAddEmployer.Controls.Add(this.textNewEmployerName);
            this.pnlAddEmployer.Controls.Add(this.btnSaveEmployer);
            this.pnlAddEmployer.Controls.Add(this.btnCancel);
            this.pnlAddEmployer.Controls.Add(this.lblAddDateOfBirth);
            this.pnlAddEmployer.Controls.Add(this.lblAddGender);
            this.pnlAddEmployer.Controls.Add(this.lblAddName);
            this.pnlAddEmployer.Location = new System.Drawing.Point(411, 10);
            this.pnlAddEmployer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddEmployer.Name = "pnlAddEmployer";
            this.pnlAddEmployer.Size = new System.Drawing.Size(512, 256);
            this.pnlAddEmployer.TabIndex = 39;
            this.pnlAddEmployer.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "phone number";
            // 
            // textNewPhoneNumber
            // 
            this.textNewPhoneNumber.Location = new System.Drawing.Point(189, 168);
            this.textNewPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textNewPhoneNumber.Name = "textNewPhoneNumber";
            this.textNewPhoneNumber.Size = new System.Drawing.Size(134, 28);
            this.textNewPhoneNumber.TabIndex = 27;
            // 
            // textNewStreetAddress
            // 
            this.textNewStreetAddress.Location = new System.Drawing.Point(189, 75);
            this.textNewStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textNewStreetAddress.Name = "textNewStreetAddress";
            this.textNewStreetAddress.Size = new System.Drawing.Size(288, 28);
            this.textNewStreetAddress.TabIndex = 26;
            // 
            // textNewSuburb
            // 
            this.textNewSuburb.Location = new System.Drawing.Point(189, 120);
            this.textNewSuburb.Margin = new System.Windows.Forms.Padding(4);
            this.textNewSuburb.Name = "textNewSuburb";
            this.textNewSuburb.Size = new System.Drawing.Size(134, 28);
            this.textNewSuburb.TabIndex = 25;
            // 
            // textNewEmployerName
            // 
            this.textNewEmployerName.Location = new System.Drawing.Point(189, 18);
            this.textNewEmployerName.Margin = new System.Windows.Forms.Padding(4);
            this.textNewEmployerName.Name = "textNewEmployerName";
            this.textNewEmployerName.Size = new System.Drawing.Size(84, 28);
            this.textNewEmployerName.TabIndex = 18;
            // 
            // btnSaveEmployer
            // 
            this.btnSaveEmployer.Location = new System.Drawing.Point(62, 212);
            this.btnSaveEmployer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEmployer.Name = "btnSaveEmployer";
            this.btnSaveEmployer.Size = new System.Drawing.Size(153, 32);
            this.btnSaveEmployer.TabIndex = 17;
            this.btnSaveEmployer.Text = "Save Employer";
            this.btnSaveEmployer.UseVisualStyleBackColor = true;
            this.btnSaveEmployer.Click += new System.EventHandler(this.btnSaveEmployer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 212);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddDateOfBirth
            // 
            this.lblAddDateOfBirth.AutoSize = true;
            this.lblAddDateOfBirth.Location = new System.Drawing.Point(75, 130);
            this.lblAddDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddDateOfBirth.Name = "lblAddDateOfBirth";
            this.lblAddDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddDateOfBirth.Size = new System.Drawing.Size(62, 18);
            this.lblAddDateOfBirth.TabIndex = 4;
            this.lblAddDateOfBirth.Text = "suburb";
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Location = new System.Drawing.Point(56, 75);
            this.lblAddGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(134, 18);
            this.lblAddGender.TabIndex = 3;
            this.lblAddGender.Text = "street address";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(51, 25);
            this.lblAddName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(125, 18);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Employer Name";
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 420);
            this.Controls.Add(this.pnlAddEmployer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDeleteEmployer);
            this.Controls.Add(this.btnUpdateAnEmployer);
            this.Controls.Add(this.btnAddOneEmployer);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.lstEmployer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployerForm";
            this.Text = "EmployerForm";
            this.pnlAddEmployer.ResumeLayout(false);
            this.pnlAddEmployer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteEmployer;
        private System.Windows.Forms.Button btnUpdateAnEmployer;
        private System.Windows.Forms.Button btnAddOneEmployer;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.ListBox lstEmployer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel pnlAddEmployer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewPhoneNumber;
        private System.Windows.Forms.TextBox textNewStreetAddress;
        private System.Windows.Forms.TextBox textNewSuburb;
        private System.Windows.Forms.TextBox textNewEmployerName;
        private System.Windows.Forms.Button btnSaveEmployer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddDateOfBirth;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.Label lblAddName;
    }
}