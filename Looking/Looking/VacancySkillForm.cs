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
    public partial class VacancySkillForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        
        private CurrencyManager cmVacancy;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmVVS; 

        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public VacancySkillForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLooking1, "Vacancy"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLooking1, "Skill"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DM.dsLooking1, "VacancySkill"];
            cmVVS = (CurrencyManager)this.BindingContext[DM.dsLooking1, "Vacancy.Vacancy_VacancySkill"];

            BindControls();
        }

        public void BindControls()
        {
            dgvVacancy.DataSource = DM.dsLooking1;
            dgvVacancy.DataMember = "Vacancy";
            
            dgvSkills.DataSource = DM.dsLooking1;
            dgvSkills.DataMember = "Skill";

            dgvVacancySkill.DataSource = DM.dsLooking1;
            dgvVacancySkill.DataMember = "Vacancy.Vacancy_VacancySkill";

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (txtYears.Text == "")
            {
                MessageBox.Show("Please fill the year box.", "Error");
            }
            else
            {
                try
                {
                    int yearNum = int.Parse(txtYears.Text);
                }
                catch
                {
                    MessageBox.Show("Please fill the year box with valid number.", "Error");
                    return;
                }
                try
                {
                    DataRow newVacancySkill = DM.dtVacancySkill.NewRow();
                    
                    newVacancySkill["VacancyID"] = dgvVacancy["VacancyID", cmVacancy.Position].Value;
                    newVacancySkill["SkillID"] = dgvSkills["SkillID", cmSkill.Position].Value;
                    newVacancySkill["Years"] = Convert.ToInt32(txtYears.Text);

                    //update database
                    DM.dsLooking1.Tables["VacancySkill"].Rows.Add(newVacancySkill);
                    DM.UpdateVacancySkill();

                    MessageBox.Show("Skill assigned successfully.", "Success");
                   
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("This skill has already been assigned to this vacancy.", "Error");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string VacancyID = dgvVacancySkill.Rows[cmVVS.Position].Cells[0].Value.ToString();
                string SkillID = dgvVacancySkill.Rows[cmVVS.Position].Cells[1].Value.ToString();

                int row = 0;
                
                for (int i = 0; i < DM.dtVacancySkill.Rows.Count; i++)
                {
                    string sID = DM.dtVacancySkill.Rows[i]["VacancyID"].ToString();
                    string aID = DM.dtVacancySkill.Rows[i]["SkillID"].ToString();

                    if (VacancyID == sID && SkillID == aID)
                    {
                        row = i;
                    }
                }
                
                DataRow dr = DM.dsLooking1.Tables["VacancySkill"].Rows[row];
                dr.Delete();
                DM.UpdateVacancySkill();
                MessageBox.Show("Skill removed successfully.", "Error");

            }
        }
    }
}
