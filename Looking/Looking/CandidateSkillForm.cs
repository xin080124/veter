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
    public partial class CandidateSkillForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        
        private CurrencyManager cmCandidate;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCandidateSkill;
        private CurrencyManager cmCCS;


        public CandidateSkillForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();

            DM = dm;
            frmMenu = mnu;
            
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLooking1, "Candidate"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLooking1, "Skill"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DM.dsLooking1, "CandidateSkill"];
            cmCCS = (CurrencyManager)this.BindingContext[DM.dsLooking1,"Candidate.Candidate_CandidateSkill"];

            BindControls();


        }

        public void BindControls()
        {
            
            dgvCandidate.DataSource = DM.dsLooking1;
            dgvCandidate.DataMember = "Candidate";

            dgvSkills.DataSource = DM.dsLooking1;
            dgvSkills.DataMember = "Skill";
            
            dgvCandidateSkill.DataSource = DM.dsLooking1;
            dgvCandidateSkill.DataMember = "Candidate.Candidate_CandidateSkill";
        }

        private bool checkIfSkillExists()
        {
            bool exist = false;
            string CandidateID = DM.dtCandidate.Rows[cmCandidate.Position]["CandidateID"].ToString();
            string SkillID = DM.dtSkill.Rows[cmSkill.Position]["SkillID"].ToString();

            string strFilter = "CandidateID = "+ CandidateID + " AND SkillID = " + SkillID;
            string strSort = "CandidateID";
            DataRow[] matchRecords = DM.dsLooking1.Tables["CANDIDATESKILL"].Select(strFilter, strSort,DataViewRowState.CurrentRows);
            int count = matchRecords.Length;

            if (count > 0)
                exist = true;

            return exist;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (checkIfSkillExists())
            {
                MessageBox.Show("This skill has already been assigned to this candidate.", "Error");
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
                    if (txtYears.Text != "")
                    {
                        DataRow newCandidateSkill = DM.dtCandidateSkill.NewRow();
                        
                        newCandidateSkill["CandidateID"] = dgvCandidate["CandidateID", cmCandidate.Position].Value;
                        newCandidateSkill["SkillID"] = dgvSkills["SkillID", cmSkill.Position].Value;
                        newCandidateSkill["Years"] = Convert.ToInt32(txtYears.Text);
                        
                        DM.dsLooking1.Tables["CandidateSkill"].Rows.Add(newCandidateSkill);
                        DM.UpdateCandidateSkill();

                        MessageBox.Show("Skill assigned successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Please fill the year box.", "Error");
                    }
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("This treatment has already been allocated to this visit.", "Error");
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
                
                string CandidateID = dgvCandidateSkill.Rows[cmCCS.Position].Cells[0].Value.ToString();
                string SkillID = dgvCandidateSkill.Rows[cmCCS.Position].Cells[1].Value.ToString();

                int row = 0;
                
                for(int i = 0; i < DM.dtCandidateSkill.Rows.Count; i++ )
                {
                    string sID = DM.dtCandidateSkill.Rows[i]["CandidateID"].ToString();
                    string aID = DM.dtCandidateSkill.Rows[i]["SkillID"].ToString();
                    
                    if (CandidateID == sID && SkillID == aID)
                    {
                        row = i;
                    }
                }
                
                DataRow dr = DM.dsLooking1.Tables["CandidateSkill"].Rows[row];
                dr.Delete();
                DM.UpdateCandidateSkill();
                MessageBox.Show("Skill removed successfully.", "Error");
            }
            else
            {
                MessageBox.Show("you may only remove treatments from pending visits.", "Error");
            }
            
        }
    }
}
