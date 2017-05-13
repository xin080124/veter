namespace Looking
{
    partial class ReportCandidateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCandidateForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.butPrintReport = new System.Windows.Forms.Button();
            this.printPreviewCandidate = new System.Windows.Forms.PrintPreviewDialog();
            this.printCandidate = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(295, 45);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(104, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // butPrintReport
            // 
            this.butPrintReport.Location = new System.Drawing.Point(89, 45);
            this.butPrintReport.Name = "butPrintReport";
            this.butPrintReport.Size = new System.Drawing.Size(110, 23);
            this.butPrintReport.TabIndex = 7;
            this.butPrintReport.Text = "Print Report";
            this.butPrintReport.UseVisualStyleBackColor = true;
            this.butPrintReport.Click += new System.EventHandler(this.butPrintReport_Click);
            // 
            // printPreviewCandidate
            // 
            this.printPreviewCandidate.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewCandidate.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewCandidate.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewCandidate.Document = this.printCandidate;
            this.printPreviewCandidate.Enabled = true;
            this.printPreviewCandidate.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewCandidate.Icon")));
            this.printPreviewCandidate.Name = "printPreviewVacancy";
            this.printPreviewCandidate.Visible = false;
            // 
            // printCandidate
            // 
            this.printCandidate.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCandidate_PrintPage);
            // 
            // ReportCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 96);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.butPrintReport);
            this.Name = "ReportCandidateForm";
            this.Text = "ReportCandidateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button butPrintReport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewCandidate;
        private System.Drawing.Printing.PrintDocument printCandidate;
    }
}