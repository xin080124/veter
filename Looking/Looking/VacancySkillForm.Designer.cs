namespace Looking
{
    partial class VacancySkillForm
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
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.dgvVacancySkill = new System.Windows.Forms.DataGridView();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkills
            // 
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkills.Location = new System.Drawing.Point(422, 221);
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.Size = new System.Drawing.Size(348, 150);
            this.dgvSkills.TabIndex = 6;
            // 
            // dgvVacancySkill
            // 
            this.dgvVacancySkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancySkill.Location = new System.Drawing.Point(12, 221);
            this.dgvVacancySkill.Name = "dgvVacancySkill";
            this.dgvVacancySkill.Size = new System.Drawing.Size(240, 150);
            this.dgvVacancySkill.TabIndex = 5;
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(157, 23);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(423, 180);
            this.dgvVacancy.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(301, 331);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 36);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove Skill";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(325, 285);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(90, 20);
            this.txtYears.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(270, 288);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Years";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(301, 229);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(93, 33);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign Skill";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(742, 377);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // VacancySkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 417);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgvSkills);
            this.Controls.Add(this.dgvVacancySkill);
            this.Controls.Add(this.dgvVacancy);
            this.Name = "VacancySkillForm";
            this.Text = "VacancySkillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.DataGridView dgvVacancySkill;
        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnReturn;
    }
}