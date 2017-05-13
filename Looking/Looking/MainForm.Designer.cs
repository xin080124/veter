namespace Looking
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnAssignSkillToCandidate = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnAssignSkillToVacancy = new System.Windows.Forms.Button();
            this.btnVacancy = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVacancies = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnAssignSkillToCandidate);
            this.grpMaintenance.Controls.Add(this.btnApplication);
            this.grpMaintenance.Controls.Add(this.btnAssignSkillToVacancy);
            this.grpMaintenance.Controls.Add(this.btnVacancy);
            this.grpMaintenance.Controls.Add(this.btnCandidate);
            this.grpMaintenance.Controls.Add(this.btnEmployer);
            this.grpMaintenance.Location = new System.Drawing.Point(57, 21);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(222, 314);
            this.grpMaintenance.TabIndex = 1;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintainance";
            // 
            // btnAssignSkillToCandidate
            // 
            this.btnAssignSkillToCandidate.Location = new System.Drawing.Point(35, 205);
            this.btnAssignSkillToCandidate.Name = "btnAssignSkillToCandidate";
            this.btnAssignSkillToCandidate.Size = new System.Drawing.Size(152, 23);
            this.btnAssignSkillToCandidate.TabIndex = 5;
            this.btnAssignSkillToCandidate.Text = "Assign Skill to a Candidate";
            this.btnAssignSkillToCandidate.UseVisualStyleBackColor = true;
            this.btnAssignSkillToCandidate.Click += new System.EventHandler(this.btnAssignSkillToCandidate_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.Location = new System.Drawing.Point(35, 244);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(152, 23);
            this.btnApplication.TabIndex = 4;
            this.btnApplication.Text = "Application Maintenance";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnAssignSkillToVacancy
            // 
            this.btnAssignSkillToVacancy.Location = new System.Drawing.Point(34, 167);
            this.btnAssignSkillToVacancy.Name = "btnAssignSkillToVacancy";
            this.btnAssignSkillToVacancy.Size = new System.Drawing.Size(152, 23);
            this.btnAssignSkillToVacancy.TabIndex = 3;
            this.btnAssignSkillToVacancy.Text = "Assign Skill to a Vacancy";
            this.btnAssignSkillToVacancy.UseVisualStyleBackColor = true;
            this.btnAssignSkillToVacancy.Click += new System.EventHandler(this.btnAssignSkillToVacancy_Click);
            // 
            // btnVacancy
            // 
            this.btnVacancy.Location = new System.Drawing.Point(34, 124);
            this.btnVacancy.Name = "btnVacancy";
            this.btnVacancy.Size = new System.Drawing.Size(152, 23);
            this.btnVacancy.TabIndex = 2;
            this.btnVacancy.Text = "Vacancy Maintenance";
            this.btnVacancy.UseVisualStyleBackColor = true;
            this.btnVacancy.Click += new System.EventHandler(this.btnVacancy_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.Location = new System.Drawing.Point(34, 78);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(152, 23);
            this.btnCandidate.TabIndex = 1;
            this.btnCandidate.Text = "Candidate Maintenance";
            this.btnCandidate.UseVisualStyleBackColor = true;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.Location = new System.Drawing.Point(34, 34);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(152, 23);
            this.btnEmployer.TabIndex = 0;
            this.btnEmployer.Text = "Employer Maintenance";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnCandidates);
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnVacancies);
            this.grpReport.Location = new System.Drawing.Point(369, 22);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(200, 313);
            this.grpReport.TabIndex = 2;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnCandidates
            // 
            this.btnCandidates.Location = new System.Drawing.Point(31, 77);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(131, 23);
            this.btnCandidates.TabIndex = 2;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(31, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVacancies
            // 
            this.btnVacancies.Location = new System.Drawing.Point(31, 33);
            this.btnVacancies.Name = "btnVacancies";
            this.btnVacancies.Size = new System.Drawing.Size(131, 23);
            this.btnVacancies.TabIndex = 0;
            this.btnVacancies.Text = "Vacancies";
            this.btnVacancies.UseVisualStyleBackColor = true;
            this.btnVacancies.Click += new System.EventHandler(this.btnVacancies_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 360);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnAssignSkillToCandidate;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnAssignSkillToVacancy;
        private System.Windows.Forms.Button btnVacancy;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVacancies;
        private System.Windows.Forms.Button btnCandidates;
    }
}

