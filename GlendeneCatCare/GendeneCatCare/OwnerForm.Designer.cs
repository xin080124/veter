namespace GendeneCatCare
{
    partial class OwnerForm
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
            this.lstOwner = new System.Windows.Forms.ListBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.pnlAddOwner = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textNewPhoneNumber = new System.Windows.Forms.TextBox();
            this.textNewStreetAddress = new System.Windows.Forms.TextBox();
            this.textNewSuburb = new System.Windows.Forms.TextBox();
            this.textNewFirstName = new System.Windows.Forms.TextBox();
            this.textNewLastName = new System.Windows.Forms.TextBox();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddGender = new System.Windows.Forms.Label();
            this.lblAddBreed = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.pnlAddOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOwner
            // 
            this.lstOwner.FormattingEnabled = true;
            this.lstOwner.Location = new System.Drawing.Point(30, 27);
            this.lstOwner.Name = "lstOwner";
            this.lstOwner.Size = new System.Drawing.Size(178, 251);
            this.lstOwner.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(287, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(287, 84);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(309, 122);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(320, 162);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtSuburb.TabIndex = 10;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(228, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(229, 88);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "street address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "suburb";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(325, 194);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "phone number";
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(452, 235);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteOwner.TabIndex = 21;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(323, 235);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateOwner.TabIndex = 20;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(240, 235);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(75, 23);
            this.btnAddOwner.TabIndex = 19;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // pnlAddOwner
            // 
            this.pnlAddOwner.Controls.Add(this.label4);
            this.pnlAddOwner.Controls.Add(this.textNewPhoneNumber);
            this.pnlAddOwner.Controls.Add(this.textNewStreetAddress);
            this.pnlAddOwner.Controls.Add(this.textNewSuburb);
            this.pnlAddOwner.Controls.Add(this.textNewFirstName);
            this.pnlAddOwner.Controls.Add(this.textNewLastName);
            this.pnlAddOwner.Controls.Add(this.btnSaveCat);
            this.pnlAddOwner.Controls.Add(this.btnCancel);
            this.pnlAddOwner.Controls.Add(this.lblAddDateOfBirth);
            this.pnlAddOwner.Controls.Add(this.lblAddGender);
            this.pnlAddOwner.Controls.Add(this.lblAddBreed);
            this.pnlAddOwner.Controls.Add(this.lblAddName);
            this.pnlAddOwner.Location = new System.Drawing.Point(583, 27);
            this.pnlAddOwner.Name = "pnlAddOwner";
            this.pnlAddOwner.Size = new System.Drawing.Size(350, 284);
            this.pnlAddOwner.TabIndex = 23;
            this.pnlAddOwner.Visible = false;
            this.pnlAddOwner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddOwner_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "phone number";
            // 
            // textNewPhoneNumber
            // 
            this.textNewPhoneNumber.Location = new System.Drawing.Point(94, 152);
            this.textNewPhoneNumber.Name = "textNewPhoneNumber";
            this.textNewPhoneNumber.Size = new System.Drawing.Size(91, 20);
            this.textNewPhoneNumber.TabIndex = 27;
            // 
            // textNewStreetAddress
            // 
            this.textNewStreetAddress.Location = new System.Drawing.Point(94, 84);
            this.textNewStreetAddress.Name = "textNewStreetAddress";
            this.textNewStreetAddress.Size = new System.Drawing.Size(91, 20);
            this.textNewStreetAddress.TabIndex = 26;
            // 
            // textNewSuburb
            // 
            this.textNewSuburb.Location = new System.Drawing.Point(94, 114);
            this.textNewSuburb.Name = "textNewSuburb";
            this.textNewSuburb.Size = new System.Drawing.Size(91, 20);
            this.textNewSuburb.TabIndex = 25;
            // 
            // textNewFirstName
            // 
            this.textNewFirstName.Location = new System.Drawing.Point(94, 55);
            this.textNewFirstName.Name = "textNewFirstName";
            this.textNewFirstName.Size = new System.Drawing.Size(57, 20);
            this.textNewFirstName.TabIndex = 19;
            // 
            // textNewLastName
            // 
            this.textNewLastName.Location = new System.Drawing.Point(94, 20);
            this.textNewLastName.Name = "textNewLastName";
            this.textNewLastName.Size = new System.Drawing.Size(57, 20);
            this.textNewLastName.TabIndex = 18;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(142, 224);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCat.TabIndex = 17;
            this.btnSaveCat.Text = "Save Owner";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAddDateOfBirth
            // 
            this.lblAddDateOfBirth.AutoSize = true;
            this.lblAddDateOfBirth.Location = new System.Drawing.Point(38, 118);
            this.lblAddDateOfBirth.Name = "lblAddDateOfBirth";
            this.lblAddDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddDateOfBirth.Size = new System.Drawing.Size(39, 13);
            this.lblAddDateOfBirth.TabIndex = 4;
            this.lblAddDateOfBirth.Text = "suburb";
            // 
            // lblAddGender
            // 
            this.lblAddGender.AutoSize = true;
            this.lblAddGender.Location = new System.Drawing.Point(18, 87);
            this.lblAddGender.Name = "lblAddGender";
            this.lblAddGender.Size = new System.Drawing.Size(73, 13);
            this.lblAddGender.TabIndex = 3;
            this.lblAddGender.Text = "street address";
            // 
            // lblAddBreed
            // 
            this.lblAddBreed.AutoSize = true;
            this.lblAddBreed.Location = new System.Drawing.Point(32, 57);
            this.lblAddBreed.Name = "lblAddBreed";
            this.lblAddBreed.Size = new System.Drawing.Size(57, 13);
            this.lblAddBreed.TabIndex = 2;
            this.lblAddBreed.Text = "First Name";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(33, 22);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(58, 13);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Last Name";
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 341);
            this.Controls.Add(this.pnlAddOwner);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lstOwner);
            this.Name = "OwnerForm";
            this.Text = "Owner Maintenance";
            this.pnlAddOwner.ResumeLayout(false);
            this.pnlAddOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwner;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Panel pnlAddOwner;
        private System.Windows.Forms.TextBox textNewFirstName;
        private System.Windows.Forms.TextBox textNewLastName;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddDateOfBirth;
        private System.Windows.Forms.Label lblAddGender;
        private System.Windows.Forms.Label lblAddBreed;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox textNewStreetAddress;
        private System.Windows.Forms.TextBox textNewSuburb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewPhoneNumber;
    }
}