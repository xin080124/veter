using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GendeneCatCare
{
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butPrintReport_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "VisitID";
            invoicesForPrint = DM.dsGlendene.Tables["VISIT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drVisit = invoicesForPrint[amountOfInvoicesPrinted];
            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            double visitTotal = 0;

            cmCat = (CurrencyManager)this.BindingContext[DM.dsGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.dsGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.dsGlendene, "VETERINARIAN"];

            Brush brush = new SolidBrush(Color.Black);
            //margins

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //get the cat record matching the cat ID from the visit record
            int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
            cmCat.Position = DM.catView.Find(aCatID);
            DataRow drCat = DM.dtCat.Rows[cmCat.Position];

            //get the owner record matching the owner ID from the cat record
            int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
            cmOwner.Position = DM.ownerView.Find(anOwnerID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

            //heading
            g.DrawString("Owner ID: " + drOwner["OwnerID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drOwner["LastName"] + ", " + drOwner["FirstName"], headingFont, brush,
                leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drOwner["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                        topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drOwner["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Cat Name: " + drCat["Name"] + "Visit ID: " + drVisit["VisitID"] +
                         "Visit Date: " + drVisit["VisitDate"], headingFont, brush, leftMargin +
                         headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            //get the veterinarian record matching the veterinarian ID from the visit record
            int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
            cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
            DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];

            g.DrawString(drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"], headingFont, brush,
                leftMargin + headingLeftMargin, topMargin +
                (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);

            DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);

            if (drTreatments.Length == 0)
            {
                g.DrawString("This visit has no treatments", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow drVisitTreatment in drTreatments)
                {
                    string treatmentText = "";
                    int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                    cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                    DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];

                    double treatmentCost;

                    treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                                    Convert.ToDouble(drTreatment["Cost"]);

                    visitTotal += treatmentCost;
                    txtInvoices.Text += treatmentText;
                    g.DrawString("tTreatment Description: " + drTreatment["Description"]
                        + "tQuantity: " + drVisitTreatment["Quantity"]
                        + "tTreatment Cost: " + Convert.ToString(treatmentCost), headingFont, brush,
                        leftMargin + headingLeftMargin, topMargin+
                        (linesSoFarHeading * textFont.Height));
                    
                    linesSoFarHeading++;
                    linesSoFarHeading++;

                    g.DrawString("Gross Due: " + Convert.ToString(visitTotal), headingFont, brush,
                        leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                }

                visitTotal = 0;
                amountOfInvoicesPrinted++;

                if (!(amountOfInvoicesPrinted == pagesAmountExpected))
                {
                    e.HasMorePages = true;
                }
            }

             

        }

        private void butDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            string visitText = "";
            double visitTotal = 0;

            cmCat = (CurrencyManager)this.BindingContext[DM.dsGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];
            cmTreatment = (CurrencyManager)this.BindingContext[DM.dsGlendene, "TREATMENT"];
            cmVeterinarian = (CurrencyManager)this.BindingContext[DM.dsGlendene, "VETERINARIAN"];

            txtInvoices.Text = "";

            foreach (DataRow drVisit in DM.dtVisit.Rows)
            {
                string visitStatus = drVisit["Status"].ToString();
                if (visitStatus.Equals("Pending") == true)
                {
                    //get the cat record matching the cat ID from the visit record
                    int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
                    cmCat.Position = DM.catView.Find(aCatID);
                    DataRow drCat = DM.dtCat.Rows[cmCat.Position];

                    //get the owner record matching the owner ID from the cat record
                    int anOwnerID = Convert.ToInt32(drCat["OwnerID"].ToString());
                    //cmOwner.Position = DM.ownerView.Find(aCatID);
                    cmOwner.Position = DM.ownerView.Find(anOwnerID);
                    //if (cmOwner.Position < 0)
                    //    cmOwner.Position += 2;
                    DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
                    //DataRow drOwner = DM.dtOwner.Rows[1];//?????????

                    visitText += "owner ID: " + drOwner["OwnerID"] + "\r\n";
                    visitText += drOwner["LastName"] + "," + drOwner["FirstName"] + "\r\n";
                    visitText += drOwner["StreetAddress"] + "\r\n";
                    visitText += drOwner["Suburb"] + "\r\n\r\n\r\n";
                    visitText += "Cat Namer: " + drCat["Name"] + "Visit ID: " + drVisit["VisitID"] +
                                  "Visit Date: " + drVisit["VisitDate"] + "\r\n\r\n\r\n";

                    // get the veterinarian record matching the veterinarian ID from the visit record
                    int aVeterinarianID = Convert.ToInt32(drVisit["VeterinarianID"].ToString());
                    cmVeterinarian.Position = DM.veterinarianView.Find(aVeterinarianID);
                    DataRow drVeterinarian = DM.dtVeterinarian.Rows[cmVeterinarian.Position];

                    visitText += drVeterinarian["LastName"] + ", " + drVeterinarian["FirstName"] + "\r\n";
                    visitTotal += Convert.ToDouble(drVeterinarian["Rate"]);

                    DataRow[] drTreatments = drVisit.GetChildRows(DM.dtVisit.ChildRelations["VISIT_VISITTREATMENT"]);

                    if (drTreatments.Length > 0)
                    {
                        txtInvoices.Text += visitText;
                        foreach (DataRow drVisitTreatment in drTreatments)
                        {
                            string treatmentText = "";
                            int aTreatmentID = Convert.ToInt32(drVisitTreatment["TreatmentID"].ToString());
                            cmTreatment.Position = DM.treatmentView.Find(aTreatmentID);
                            DataRow drTreatment = DM.dtTreatment.Rows[cmTreatment.Position];

                            double treatmentCost;

                            treatmentCost = Convert.ToInt32(drVisitTreatment["Quantity"]) *
                                            Convert.ToDouble(drTreatment["Cost"]);
                            visitTotal += treatmentCost;
                            treatmentText = "\tTreatment Description: " + drTreatment["Description"]
                                             + "\tQuantity: " + drVisitTreatment["Quantity"]
                                             + "\tTreatment Cost: " + Convert.ToString(treatmentCost)
                                             + "\r\n";

                            txtInvoices.Text += treatmentText;
                        }

                        txtInvoices.Text += "\r\n";
                        txtInvoices.Text += "\t\t\t\t\t\t\t\t\t\t\tGross Due: " + Convert.ToString(visitTotal);
                        txtInvoices.Text += "\r\n\r\n\r\n\r\n";
                    }
                    visitText = "";
                    visitTotal = 0;
                }
            }
        }
    }    
}
