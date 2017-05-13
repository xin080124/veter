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
    public partial class ReportCandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfPrinted, pagesAmountExpected;
        private DataRow[] reportForPrint;

        private void butPrintReport_Click(object sender, EventArgs e)
        {
            amountOfPrinted = 0;
            string strFilter = "";
            string strSort = "CandidateID";
            reportForPrint = DM.dsLooking1.Tables["CANDIDATE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = reportForPrint.Length;
            //printPreviewVacancy.Show();
            printPreviewCandidate.Show();
        }

        private void printCandidate_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 16, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 16, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 16, FontStyle.Bold);
            Font headingFont = new Font("Arial", 16, FontStyle.Bold);
            
            DataRow drCandidate = reportForPrint[amountOfPrinted];

            CurrencyManager cmVacancy;
            CurrencyManager cmCandidate;
            CurrencyManager cmSkill;
            
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLooking1, "VACANCY"];
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLooking1, "CANDIDATE"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLooking1, "SKILL"];
            
            Brush brush = new SolidBrush(Color.Black);

            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            
            //get the vacancy record matching the vacancy ID from the vacancy record
            //int aVacancyID = Convert.ToInt32(drVacancy["VacancyID"].ToString());
            
            //heading
            g.DrawString("Candidate ID: " + drCandidate["CandidateID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString(drCandidate["FirstName"]+ " " + drCandidate["LastName"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["StreetAddress"] + " ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["Suburb"] + " ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            
            g.DrawString("Skills: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            //get skill list matching the candidate ID
            //cmCandidate.Position = DM.candidateView.Find(drCandidate["CandidateID"]);
            //DataRow drCandidate = DM.dtCandidate.Rows[cmCandidate.Position];
            DataRow[] drCandidateSkills = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_CANDIDATESKILL"]);

            foreach (DataRow drCandidateSkill in drCandidateSkills)
            {
                cmSkill.Position = DM.skillView.Find(drCandidateSkill["SkillID"]);
                DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];
                //DataRow[]  

                //print skill ID
                //g.DrawString(drCandidateSkill["SkillID"] + " ", headingFont, brush, leftMargin + headingLeftMargin,
                //topMargin + (linesSoFarHeading * textFont.Height));
                //linesSoFarHeading++;

                //print skill Description
                g.DrawString(drSkill["Description"] + "      " + drCandidateSkill["Years"] + " Years ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
            }

            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Current Vacancy Applications: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drCandidateApplications;
            string strFilter = "CandidateID = " + drCandidate["CandidateID"];
            string strSort = "VacancyID";
            int aVacancyID;
            DataRow drVacancy;
            drCandidateApplications = DM.dsLooking1.Tables["APPLICATION"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            foreach (DataRow drCandidateApplication in drCandidateApplications)
            {
                aVacancyID = Convert.ToInt32(drCandidateApplication["VacancyID"].ToString());
                cmVacancy.Position = DM.vacancyView.Find(aVacancyID);
                drVacancy = DM.dtVancancy.Rows[cmVacancy.Position];

                g.DrawString(" Vacancy ID: "+drCandidateApplication["VacancyID"] + "     "+
                            drVacancy["Description"], headingFont, brush, leftMargin + headingLeftMargin,
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

        public ReportCandidateForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }


    }
}
