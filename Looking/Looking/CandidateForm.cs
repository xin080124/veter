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
    public partial class CandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        private int mode;  //0:add, 1:update

        public CandidateForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            txtCandidateID.DataBindings.Add("Text", DM.dsLooking1, "Candidate.CandidateID");
            txtFirstName.DataBindings.Add("Text", DM.dsLooking1, "Candidate.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsLooking1, "Candidate.LastName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLooking1, "Candidate.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsLooking1, "Candidate.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsLooking1, "Candidate.PhoneNumber");

            txtCandidateID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;

            lstCandidate.DataSource = DM.dsLooking1;
            lstCandidate.DisplayMember = "Candidate.FirstName";
            lstCandidate.ValueMember = "Candidate.FirstName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLooking1, "CANDIDATE"];
            
    }
        private void CandidateUIChange()  //private int mode;  //0:add, 1:update
        {
            lstCandidate.Visible = false;

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            btnDeleteCandidate.Enabled = false;

            if (mode == 0)
                btnUpdateCandidate.Enabled = false;
            else if (mode == 1)
                btnAddCandidate.Enabled = false;

            btnReturn.Enabled = false;
            pnlAddCandidate.Show();
            
        }
        
        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            mode = 0;
            CandidateUIChange();
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            mode = 1;

            txtNewFirstName.Text = txtFirstName.Text;
            txtNewLastName.Text = txtLastName.Text;
            txtNewSuburb.Text = txtSuburb.Text;
            txtNewAddress.Text = txtStreetAddress.Text;
            txtNewSuburb.Text = txtSuburb.Text;
            txtNewPhoneNumber.Text = txtPhoneNumber.Text;


            CandidateUIChange();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                //Create a new row that the variables will be added into
                DataRow newCandidateRow = DM.dtCandidate.NewRow();

                if ((txtNewLastName.Text == "")||(txtNewFirstName.Text == "")||
                    (txtNewAddress.Text == "")||(txtNewSuburb.Text == "")||(txtPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    try {
                        newCandidateRow["FirstName"] = txtNewFirstName.Text;
                        newCandidateRow["LastName"] = txtNewLastName.Text;
                        newCandidateRow["StreetAddress"] = txtNewAddress.Text;
                        newCandidateRow["Suburb"] = txtNewSuburb.Text;
                        newCandidateRow["PhoneNumber"] = txtNewPhoneNumber.Text;

                        //Add the new row to the Table
                        DM.dtCandidate.Rows.Add(newCandidateRow);
                        DM.UpdateCandidate();

                        //Give the user a success message
                        MessageBox.Show("Candidate added succesfully", "Success");
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("Invalid input,please check each field.", "Error");
                    }
                }
            }
            else if (mode == 1)
            {
                DataRow updateCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
                
                if ((txtNewLastName.Text == "") || (txtNewFirstName.Text == "") ||
                        (txtNewAddress.Text == "") || (txtNewSuburb.Text == "") || (txtPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    try {
                        updateCandidateRow["FirstName"] = txtNewFirstName.Text;
                        updateCandidateRow["LastName"] = txtNewLastName.Text;
                        updateCandidateRow["StreetAddress"] = txtNewAddress.Text;
                        updateCandidateRow["Suburb"] = txtNewSuburb.Text;
                        updateCandidateRow["PhoneNumber"] = txtNewPhoneNumber.Text;

                        //Update the database
                        currencyManager.EndCurrentEdit();
                        //DM.UpdateEmployer();
                        DM.UpdateCandidate();

                        //Give the user a success message
                        MessageBox.Show("Candidate updated successfully", "Success");
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("Invalid input,please check each field.", "Error");
                    }

                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddCandidate.Hide();
            
            lstCandidate.Enabled = true;
            lstCandidate.Visible = true;

            btnDeleteCandidate.Enabled = true;

            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            
            btnUpdateCandidate.Enabled = true;
            btnAddCandidate.Enabled = true;

            btnReturn.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool checkCandidateReference()
        {
            bool refer = false;
            string CandidateID = DM.dtCandidate.Rows[currencyManager.Position]["CandidateID"].ToString();
            string strFilter = "CandidateID = " + CandidateID;
            string strSort = "CandidateID";
            DataRow[] matchRecords = DM.dsLooking1.Tables["APPLICATION"].Select(strFilter,
                                     strSort, DataViewRowState.CurrentRows);
            int count = matchRecords.Length;

            if (count > 0)
                refer = true;

            return refer;

        }

        private void deleteInCandidateSkillTable()
        {
            string CandidateID = DM.dtCandidate.Rows[currencyManager.Position]["CandidateID"].ToString();
            string strFilter = "CandidateID = " + CandidateID;
            string strSort = "CandidateID";
            DataRow[] matchRecords = DM.dsLooking1.Tables["CANDIDATESKILL"].Select(strFilter,
                                     strSort, DataViewRowState.CurrentRows);
            int count = matchRecords.Length;

            if (count > 0)
            {
                foreach (DataRow matchRecord in matchRecords)
                {
                    matchRecord.Delete();
                }
                DM.UpdateCandidateSkill();
            }
            
        }

        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //check candidate reference status
                if (checkCandidateReference())
                {
                    MessageBox.Show("You may only delete candidates who have no applications", "Error");
                }
                else
                {
                    //first delete its reference in candidateSkill Table
                    deleteInCandidateSkillTable();

                    //then delete in candidate table
                    DataRow deleteCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
                    
                    deleteCandidateRow.Delete();
                    DM.UpdateCandidate();

                    //Give the user a success message
                    MessageBox.Show("Candidate deleted succesfully", "Success");

                }
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
    }
}
