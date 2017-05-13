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
    public partial class ApplicationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;

        private CurrencyManager cmApplication;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmCandidateSkill;
        private CurrencyManager cmEmployer;

        private CurrencyManager currencyManager;

        public ApplicationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;

            cmApplication = (CurrencyManager)this.BindingContext[DM.dsLooking1, "Application"];
            
            BindControls();
        }

        public void BindControls()
        {
            dgvApplication.DataSource = DM.dsLooking1;
            dgvApplication.DataMember = "Application";
            
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLooking1, "VACANCY"];
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLooking1, "CANDIDATE"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLooking1, "EMPLOYER"];

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLooking1, "APPLICATION"];

            updateVacancyInfo();
        }

        private void aplst_Click(object sender, EventArgs e)
        {
            updateVacancyInfo();
        }

        private void updateVacancyInfo()
        {
            int anVacancyID = Convert.ToInt32(dgvApplication["VacancyID", cmApplication.Position].Value);
            cmVacancy.Position = DM.vacancyView.Find(anVacancyID);
            DataRow drVacancy = DM.dtVancancy.Rows[cmVacancy.Position];
            txtDescription.Text = drVacancy["Description"].ToString();
            //dgvApplication
            txtSalary.Text = drVacancy["Salary"].ToString();

            DataRow drEmployer;
            cmEmployer.Position = DM.employerView.Find(drVacancy["EmployerID"]);
            drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();

            int anCandidateID = Convert.ToInt32(dgvApplication["CandidateID", cmApplication.Position].Value);
            cmCandidate.Position = DM.candidateView.Find(anCandidateID);
            DataRow drCandidate = DM.dtCandidate.Rows[cmCandidate.Position];
            txtCandidateFullName.Text = (drCandidate["FirstName"] + " " + drCandidate["LastName"]).ToString();
        }


        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            dgvApplication.Visible = false;
            
            btnDeleteApplication.Enabled = false;
            btnReturn.Enabled = false;
            
            pnlAddApplication.Show();

            LoadVacancies();
            LoadCandidates();
        }

        private void LoadVacancies()
        {
            cboAddVacancyID.DataSource = DM.dsLooking1;
            cboAddVacancyID.DisplayMember = "Vacancy.VacancyID";
            cboAddVacancyID.ValueMember = "Vacancy.VacancyID";
            cboAddVacancyDescription.DataSource = DM.dsLooking1;
            cboAddVacancyDescription.DisplayMember = "Vacancy.Description";
            cboAddVacancyDescription.ValueMember = "Vacancy.Description";
 
        }

        private void LoadCandidates()
        {
            cboAddCandidateID.DataSource = DM.dsLooking1;
            cboAddCandidateID.DisplayMember = "Candidate.CandidateID";
            cboAddCandidateID.ValueMember = "Candidate.CandidateID";
            cboAddCandidateName.DataSource = DM.dsLooking1;
            cboAddCandidateName.DisplayMember = "Candidate.FirstName";
            cboAddCandidateName.ValueMember = "Candidate.FirstName";


        }
        private bool checkIfVacancyIsCurrent()
        {
            bool isCurrent = false;

            //get vacancy id
            int anVacancyID = Convert.ToInt32(cboAddVacancyID.Text);

            cmVacancy.Position = DM.vacancyView.Find(anVacancyID);
            DataRow drVacancy = DM.dtVancancy.Rows[cmVacancy.Position];
            string vacancyStatus = drVacancy["Status"].ToString();
            if (vacancyStatus == "current")
                isCurrent = true;

            return isCurrent;
        }


        private bool checkCandidate()
        {
            bool skillmatch=false;
            
            //get vacancy id
            int anVacancyID = Convert.ToInt32(cboAddVacancyID.Text);

            cmVacancy.Position = DM.vacancyView.Find(anVacancyID);
            DataRow drVacancy = DM.dtVancancy.Rows[cmVacancy.Position];
            DataRow[] drVacancySkills = drVacancy.GetChildRows(DM.dtVancancy.ChildRelations["VACANCY_VACANCYSKILL"]);
            int requireSkillID;
            int requireYear;

            int anCandidateID = Convert.ToInt32(cboAddCandidateID.Text);
            cmCandidate.Position = DM.candidateView.Find(anCandidateID);
            DataRow drCandidate = DM.dtCandidate.Rows[cmCandidate.Position];
            DataRow[] drCandidateSkills = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_CANDIDATESKILL"]);
            
            foreach (DataRow drVacancySkill in drVacancySkills)
            {
                requireSkillID = Convert.ToInt32(drVacancySkill["SkillID"].ToString());

                //get experience year
                requireYear = Convert.ToInt32(drVacancySkill["Years"].ToString());

                int cSkillID;
                int cYear;
                skillmatch = false;

                bool hasSkill = false;

                //find in candidate skill table
                foreach (DataRow drCandidateSkill in drCandidateSkills)
                {
                    cSkillID = Convert.ToInt32(drCandidateSkill["SkillID"].ToString());
                    cYear = Convert.ToInt32(drCandidateSkill["Years"].ToString());
                    
                    if (cSkillID == requireSkillID)
                    {
                        hasSkill = true;
                        //if candidate has the skill, check the year
                        if (requireYear <= cYear)
                        {
                            skillmatch = true;
                        }
                        else
                        {
                            //once the year number is smaller,no need to do more check
                            return false;
                        }
                          
                    }
                }

                //if the candidate does not have the vacancy required skill,no need to do more check
                if (!hasSkill)
                {
                    return false;
                }
                
                //if can't find,return false
                if (!skillmatch)
                {
                    Console.WriteLine("this skill can't be matched!");
                }
                
            }

            //DataRow[] drSkills = drSkills;

            return skillmatch;
        }

        private void btnSaveApplication_Click(object sender, EventArgs e)
        {
            if (!checkIfVacancyIsCurrent())
            {
                MessageBox.Show("Candidates can only apply to current vacancies.", "Error");
                return;
            }
            try
            {
                bool match = checkCandidate();
                if (match)//skills reach the level
                {
                    DataRow newApplication = DM.dtApplication.NewRow();
                    
                    newApplication["VacancyID"] = cboAddVacancyID.Text;
                    newApplication["CandidateID"] = cboAddCandidateID.Text;
                    
                    DM.dsLooking1.Tables["Application"].Rows.Add(newApplication);
                    DM.UpdateApplication();

                    //Give the user a success message
                    MessageBox.Show("Application added succesfully", "Success");

                }
                else
                {
                    MessageBox.Show("The candidate does not have the experience to apply for the vacancy.", "Error");
                }
                
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Candidate can only apply to current vacancies.", "Error");
            }
   
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            DataRow deleteApplicationRow = DM.dtApplication.Rows[currencyManager.Position];
            
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteApplicationRow.Delete();
                DM.UpdateApplication();

                //Give the user a success message
                MessageBox.Show("Application deleted succesfully", "Success");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddApplication.Hide();
            
            dgvApplication.Visible = true;
            
            btnDeleteApplication.Enabled = true;
            btnReturn.Enabled = true;
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
