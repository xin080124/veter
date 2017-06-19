namespace GendeneCatCare
{
    public partial class VeterinarianForm
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
            this.lstVeterinarians = new System.Windows.Forms.ListBox();
            this.lblveterinarianNo = new System.Windows.Forms.Label();
            this.lblveterinarianID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVeterinarian = new System.Windows.Forms.Button();
            this.btnUPdateVeterinarian = new System.Windows.Forms.Button();
            this.btnDeleteVeterinarian = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVeterinarians
            // 
            this.lstVeterinarians.FormattingEnabled = true;
            this.lstVeterinarians.Location = new System.Drawing.Point(42, 37);
            this.lstVeterinarians.Name = "lstVeterinarians";
            this.lstVeterinarians.Size = new System.Drawing.Size(178, 251);
            this.lstVeterinarians.TabIndex = 0;
            this.lstVeterinarians.SelectedIndexChanged += new System.EventHandler(this.lstVeterinarians_SelectedIndexChanged);
            // 
            // lblveterinarianNo
            // 
            this.lblveterinarianNo.AutoSize = true;
            this.lblveterinarianNo.Location = new System.Drawing.Point(286, 37);
            this.lblveterinarianNo.Name = "lblveterinarianNo";
            this.lblveterinarianNo.Size = new System.Drawing.Size(77, 13);
            this.lblveterinarianNo.TabIndex = 1;
            this.lblveterinarianNo.Text = "Veterinarian ID";
            // 
            // lblveterinarianID
            // 
            this.lblveterinarianID.AutoSize = true;
            this.lblveterinarianID.Location = new System.Drawing.Point(400, 37);
            this.lblveterinarianID.Name = "lblveterinarianID";
            this.lblveterinarianID.Size = new System.Drawing.Size(23, 13);
            this.lblveterinarianID.TabIndex = 2;
            this.lblveterinarianID.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(286, 92);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(286, 149);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(286, 201);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "Rate";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(403, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(403, 142);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(403, 194);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(42, 315);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(145, 315);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVeterinarian
            // 
            this.btnAddVeterinarian.Location = new System.Drawing.Point(259, 315);
            this.btnAddVeterinarian.Name = "btnAddVeterinarian";
            this.btnAddVeterinarian.Size = new System.Drawing.Size(104, 23);
            this.btnAddVeterinarian.TabIndex = 11;
            this.btnAddVeterinarian.Text = "Add Veterinarian";
            this.btnAddVeterinarian.UseVisualStyleBackColor = true;
            this.btnAddVeterinarian.Click += new System.EventHandler(this.btnAddVeterinarian_Click);
            // 
            // btnUPdateVeterinarian
            // 
            this.btnUPdateVeterinarian.Location = new System.Drawing.Point(403, 315);
            this.btnUPdateVeterinarian.Name = "btnUPdateVeterinarian";
            this.btnUPdateVeterinarian.Size = new System.Drawing.Size(136, 23);
            this.btnUPdateVeterinarian.TabIndex = 12;
            this.btnUPdateVeterinarian.Text = "UPdate Veterinarian";
            this.btnUPdateVeterinarian.UseVisualStyleBackColor = true;
            this.btnUPdateVeterinarian.Click += new System.EventHandler(this.btnUPdateVeterinarian_Click);
            // 
            // btnDeleteVeterinarian
            // 
            this.btnDeleteVeterinarian.Location = new System.Drawing.Point(575, 315);
            this.btnDeleteVeterinarian.Name = "btnDeleteVeterinarian";
            this.btnDeleteVeterinarian.Size = new System.Drawing.Size(128, 23);
            this.btnDeleteVeterinarian.TabIndex = 13;
            this.btnDeleteVeterinarian.Text = "Delete Veterinarian";
            this.btnDeleteVeterinarian.UseVisualStyleBackColor = true;
            this.btnDeleteVeterinarian.Click += new System.EventHandler(this.btnDeleteVeterinarian_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(601, 354);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "due";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VeterinarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVeterinarian);
            this.Controls.Add(this.btnUPdateVeterinarian);
            this.Controls.Add(this.btnAddVeterinarian);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblveterinarianID);
            this.Controls.Add(this.lblveterinarianNo);
            this.Controls.Add(this.lstVeterinarians);
            this.Name = "VeterinarianForm";
            this.Text = "Veterinarian Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeterinarians;
        private System.Windows.Forms.Label lblveterinarianNo;
        private System.Windows.Forms.Label lblveterinarianID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVeterinarian;
        private System.Windows.Forms.Button btnUPdateVeterinarian;
        private System.Windows.Forms.Button btnDeleteVeterinarian;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
    }
}