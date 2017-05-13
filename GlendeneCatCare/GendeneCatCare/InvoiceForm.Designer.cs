namespace GendeneCatCare
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.txtInvoices = new System.Windows.Forms.TextBox();
            this.butPrintReport = new System.Windows.Forms.Button();
            this.butDisplayReport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtInvoices
            // 
            this.txtInvoices.Location = new System.Drawing.Point(27, 38);
            this.txtInvoices.Multiline = true;
            this.txtInvoices.Name = "txtInvoices";
            this.txtInvoices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoices.Size = new System.Drawing.Size(862, 283);
            this.txtInvoices.TabIndex = 0;
            // 
            // butPrintReport
            // 
            this.butPrintReport.Location = new System.Drawing.Point(626, 361);
            this.butPrintReport.Name = "butPrintReport";
            this.butPrintReport.Size = new System.Drawing.Size(110, 23);
            this.butPrintReport.TabIndex = 1;
            this.butPrintReport.Text = "Print Report";
            this.butPrintReport.UseVisualStyleBackColor = true;
            this.butPrintReport.Click += new System.EventHandler(this.butPrintReport_Click);
            // 
            // butDisplayReport
            // 
            this.butDisplayReport.Location = new System.Drawing.Point(785, 361);
            this.butDisplayReport.Name = "butDisplayReport";
            this.butDisplayReport.Size = new System.Drawing.Size(104, 23);
            this.butDisplayReport.TabIndex = 2;
            this.butDisplayReport.Text = "Display Report";
            this.butDisplayReport.UseVisualStyleBackColor = true;
            this.butDisplayReport.Click += new System.EventHandler(this.butDisplayReport_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // prvInvoices
            // 
            this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvInvoices.Document = this.printInvoices;
            this.prvInvoices.Enabled = true;
            this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
            this.prvInvoices.Name = "prvInvoices";
            this.prvInvoices.Visible = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 490);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butDisplayReport);
            this.Controls.Add(this.butPrintReport);
            this.Controls.Add(this.txtInvoices);
            this.Name = "InvoiceForm";
            this.Text = "Invoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoices;
        private System.Windows.Forms.Button butPrintReport;
        private System.Windows.Forms.Button butDisplayReport;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvInvoices;
    }
}