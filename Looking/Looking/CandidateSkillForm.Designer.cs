namespace Looking
{
    partial class CandidateSkillForm
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.dgvCandidateSkill = new System.Windows.Forms.DataGridView();
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(291, 312);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 36);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove Skill";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(315, 266);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(90, 20);
            this.txtYears.TabIndex = 17;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(260, 269);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(34, 13);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Years";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(291, 210);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(93, 33);
            this.btnAssign.TabIndex = 15;
            this.btnAssign.Text = "Assign Skill";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dgvSkills
            // 
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkills.Location = new System.Drawing.Point(412, 202);
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.Size = new System.Drawing.Size(348, 150);
            this.dgvSkills.TabIndex = 14;
            // 
            // dgvCandidateSkill
            // 
            this.dgvCandidateSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateSkill.Location = new System.Drawing.Point(2, 202);
            this.dgvCandidateSkill.Name = "dgvCandidateSkill";
            this.dgvCandidateSkill.Size = new System.Drawing.Size(240, 150);
            this.dgvCandidateSkill.TabIndex = 13;
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Location = new System.Drawing.Point(57, 8);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.Size = new System.Drawing.Size(578, 180);
            this.dgvCandidate.TabIndex = 12;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(787, 373);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CandidateSkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 408);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgvSkills);
            this.Controls.Add(this.dgvCandidateSkill);
            this.Controls.Add(this.dgvCandidate);
            this.Name = "CandidateSkillForm";
            this.Text = "CandidateSkillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.DataGridView dgvCandidateSkill;
        private System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.Button btnReturn;
    }
}