namespace Looking
{
    partial class ReportVacancyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportVacancyForm));
            this.printVacancy = new System.Drawing.Printing.PrintDocument();
            this.printPreviewVacancy = new System.Windows.Forms.PrintPreviewDialog();
            this.btnReturn = new System.Windows.Forms.Button();
            this.butPrintReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printVacancy
            // 
            this.printVacancy.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printVacancy_PrintPage);
            // 
            // printPreviewVacancy
            // 
            this.printPreviewVacancy.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewVacancy.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewVacancy.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewVacancy.Document = this.printVacancy;
            this.printPreviewVacancy.Enabled = true;
            this.printPreviewVacancy.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewVacancy.Icon")));
            this.printPreviewVacancy.Name = "printPreviewVacancy";
            this.printPreviewVacancy.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(464, 60);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // butPrintReport
            // 
            this.butPrintReport.Location = new System.Drawing.Point(144, 60);
            this.butPrintReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butPrintReport.Name = "butPrintReport";
            this.butPrintReport.Size = new System.Drawing.Size(165, 32);
            this.butPrintReport.TabIndex = 4;
            this.butPrintReport.Text = "Print Report";
            this.butPrintReport.UseVisualStyleBackColor = true;
            this.butPrintReport.Click += new System.EventHandler(this.butPrintReport_Click);
            // 
            // ReportVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 150);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.butPrintReport);
            this.Name = "ReportVacancyForm";
            this.Text = "ReportVacancyForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printVacancy;
        private System.Windows.Forms.PrintPreviewDialog printPreviewVacancy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button butPrintReport;
    }
}