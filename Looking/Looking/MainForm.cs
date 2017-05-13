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
    public partial class MainForm : Form
    {
        private DataModule DM;         //the reference to the form that holds the data components
        private EmployerForm frmEmployer;    //the reference to the employer form 
        private CandidateForm frmCandidate;    //the reference to the candidate form 
        private VacancyForm frmVacancy;    //the reference to the vacancy form 
        private VacancySkillForm frmVacancySlill;    //the reference to the vacancySkill form 
        private CandidateSkillForm frmCandidateSkill;  //the reference to the CandidateSkill form 
        private ApplicationForm frmApplication;  //the reference to the Application form 
        private ReportVacancyForm frmReportVacancy; //the reference to the report vacancy form
        private ReportCandidateForm frmReportCandidate; //the reference to the report candidate form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();   //Create the data module and load the dataset
        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            if (frmEmployer == null)
            {
                frmEmployer = new EmployerForm(DM, this);
            }
            frmEmployer.ShowDialog();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            if (frmCandidate == null)
            {
                frmCandidate = new CandidateForm(DM, this);
            }
            frmCandidate.ShowDialog();

        }

        private void btnVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancy == null)
            {
                frmVacancy = new VacancyForm(DM, this);
            }
            frmVacancy.ShowDialog();
        }

        private void btnAssignSkillToVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancySlill == null)
            {
                frmVacancySlill = new VacancySkillForm(DM, this);
                frmVacancySlill.ShowDialog();
            }
        }

        private void btnAssignSkillToCandidate_Click(object sender, EventArgs e)
        {
            if (frmCandidateSkill == null)
            {
                frmCandidateSkill = new CandidateSkillForm(DM, this);
                frmCandidateSkill.ShowDialog();
            }

        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            if (frmApplication == null)
            {
                frmApplication = new ApplicationForm(DM, this);
                frmApplication.ShowDialog();
            }
        }

        private void btnVacancies_Click(object sender, EventArgs e)
        {
            if (frmReportVacancy == null)
            {
                frmReportVacancy = new ReportVacancyForm(DM, this);
                frmReportVacancy.ShowDialog();
            }

        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            if (frmReportCandidate  == null)
            {
                frmReportCandidate = new ReportCandidateForm(DM, this);
                frmReportCandidate.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
