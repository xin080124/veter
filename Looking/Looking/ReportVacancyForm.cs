using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looking
{
    public partial class ReportVacancyForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfPrinted, pagesAmountExpected;
        private DataRow[] reportForPrint;

        public ReportVacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void printVacancy_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 16, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 16, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 16, FontStyle.Bold);
            Font headingFont = new Font("Arial", 16, FontStyle.Bold);

            //DataRow drVisit = invoicesForPrint[amountOfInvoicesPrinted];
            DataRow drVacancy = reportForPrint[amountOfPrinted];

            /*CurrencyManager cmCat;
            CurrencyManager cmOwner;
            CurrencyManager cmTreatment;
            CurrencyManager cmVeterinarian;
            double visitTotal = 0;
            */

            CurrencyManager cmVacancy;
            CurrencyManager cmEmployer;
            CurrencyManager cmSkill;

            //cmCat = (CurrencyManager)this.BindingContext[DM.dsGlendene, "CAT"];
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLooking1, "VACANCY"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLooking1, "EMPLOYER"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLooking1, "SKILL"];

            Brush brush = new SolidBrush(Color.Black);

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //get the cat record matching the cat ID from the visit record
            /*int aCatID = Convert.ToInt32(drVisit["CatID"].ToString());
            cmCat.Position = DM.catView.Find(aCatID);
            DataRow drCat = DM.dtCat.Rows[cmCat.Position];
            */

            //get the vacancy record matching the vacancy ID from the vacancy record
            int aVacancyID = Convert.ToInt32(drVacancy["VacancyID"].ToString());
            //cmCat.Position = DM.catView.Find(aCatID);
            cmVacancy.Position = DM.vacancyView.Find(aVacancyID);
            //DataRow drCat = DM.dtVancancy.Rows[cmVacancy.Position];

            //heading
            
            g.DrawString("Vacancy ID: " + drVacancy["VacancyID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Description: " + drVacancy["Description"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            DataRow drEmployer;
            cmEmployer.Position = DM.employerView.Find(drVacancy["EmployerID"]);
            drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
            g.DrawString("Employer Name: " + drEmployer["EmployerName"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Status: " + drVacancy["Status"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Salary: NZ$" + drVacancy["Salary"] +".00", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Skills: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drVacancySkills = drVacancy.GetChildRows(DM.dtVancancy.ChildRelations["VACANCY_VACANCYSKILL"]);
            foreach (DataRow drVacancySkill in drVacancySkills)
            {
                cmSkill.Position = DM.skillView.Find(drVacancySkill["SkillID"]);
                DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];

                g.DrawString(drSkill["Description"] + "      " + drVacancySkill["Years"] + " Years ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
            }

            amountOfPrinted++;
            if (!(amountOfPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butPrintReport_Click(object sender, EventArgs e)
        {
            amountOfPrinted = 0;
            string strFilter = "";
            string strSort = "VacancyID";
            reportForPrint = DM.dsLooking1.Tables["VACANCY"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = reportForPrint.Length;
            printPreviewVacancy.Show();
        }


    }
}
