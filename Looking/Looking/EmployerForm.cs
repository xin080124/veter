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
    public partial class EmployerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        private int mode;  //0:add, 1:update

        public EmployerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            mode = 0;
        }

        public void BindControls()
        {
            txtEmployerID.DataBindings.Add("Text", DM.dsLooking1, "Employer.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.dsLooking1, "Employer.EmployerName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLooking1, "Employer.Street Address");
            txtSuburb.DataBindings.Add("Text", DM.dsLooking1, "Employer.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsLooking1, "Employer.PhoneNumber");

            txtEmployerID.Enabled = false;
            txtEmployerName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
            
            lstEmployer.DataSource = DM.dsLooking1;
            lstEmployer.DisplayMember = "Employer.EmployerName";
            lstEmployer.ValueMember = "Employer.EmployerName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLooking1, "EMPLOYER"];
        }

        //no use but can't delete
        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            lstEmployer.Visible = false;  //Note that if you use this line of code

            btnDeleteEmployer.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
        }

        private void btnAddAnEmplyer_Click(object sender, EventArgs e)
        {
            lstEmployer.Visible = false;  //Note that if you use this line of code
            
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            btnDeleteEmployer.Enabled = false;
            btnUpdateAnEmployer.Enabled = false;
            btnReturn.Enabled = false;

            
            pnlAddEmployer.Show();
        }

        private void btnAddOneEmployer_Click(object sender, EventArgs e)
        {
            mode = 0;
            EmployerUIChange();
        }

        private void EmployerUIChange()  //private int mode;  //0:add, 1:update
        {
            lstEmployer.Visible = false;  //Note that if you use this line of code

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            btnDeleteEmployer.Enabled = false;
            if(mode == 0)
                btnUpdateAnEmployer.Enabled = false;
            else if(mode == 1)
                btnAddOneEmployer.Enabled = false;

            btnReturn.Enabled = false;
            
            pnlAddEmployer.Show();
        }

        private void btnSaveEmployer_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                //Create a new row that the variables will be added into
                DataRow newEmployerRow = DM.dtEmployer.NewRow();

                if ((textNewEmployerName.Text == "") || (textNewStreetAddress.Text == "") ||
                    (textNewSuburb.Text == "") || (textNewPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    try
                    {
                        newEmployerRow["EmployerName"] = textNewEmployerName.Text;
                        newEmployerRow["Street Address"] = textNewStreetAddress.Text;
                        newEmployerRow["Suburb"] = textNewSuburb.Text;
                        newEmployerRow["PhoneNumber"] = textNewPhoneNumber.Text;

                        //Add the new row to the Table

                        DM.dtEmployer.Rows.Add(newEmployerRow);
                        DM.UpdateEmployer();

                        //Give the user a success message
                        MessageBox.Show("Employer added succesfully", "Success");

                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("Invalid input,please check each field.", "Error");
                    }

                }
            }
            else if (mode == 1)
            {
                DataRow updateEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
                
                if ((textNewEmployerName.Text == "") || (textNewStreetAddress.Text == "") ||
                    (textNewSuburb.Text == "") || (textNewPhoneNumber.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    try
                    {
                        updateEmployerRow["EmployerName"] = textNewEmployerName.Text;
                        updateEmployerRow["Street Address"] = textNewStreetAddress.Text;
                        updateEmployerRow["Suburb"] = textNewSuburb.Text;
                        updateEmployerRow["PhoneNumber"] = textNewPhoneNumber.Text;

                        //Update the database
                        currencyManager.EndCurrentEdit();
                        DM.UpdateEmployer();

                        //Give the user a success message
                        MessageBox.Show("Employer updated successfully", "Success");

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
            pnlAddEmployer.Hide();
            
           
            lstEmployer.Enabled = true;
            lstEmployer.Visible = true;
            
            btnDeleteEmployer.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateAnEmployer.Enabled = true;
            btnAddOneEmployer.Enabled = true;
            btnReturn.Enabled = true;

        }

        private void btnUpdateAnEmployer_Click(object sender, EventArgs e)
        {
            mode = 1;

            textNewEmployerName.Text = txtEmployerName.Text;
            textNewStreetAddress.Text = txtStreetAddress.Text;
            textNewSuburb.Text = txtSuburb.Text;
            textNewPhoneNumber.Text = txtPhoneNumber.Text;

            EmployerUIChange();
        }

        private bool checkEmployerReference()
        {
            bool refer = false;
            
            string employerID = DM.dtEmployer.Rows[currencyManager.Position]["EmployerID"].ToString();
            string strFilter = "EmployerID = " + employerID;
            string strSort = "EmployerID";
            DataRow[] matchRecords = DM.dsLooking1.Tables["VACANCY"].Select(strFilter,
                                     strSort, DataViewRowState.CurrentRows);
            int count = matchRecords.Length;

            if (count > 0)
                refer = true;
            
            return refer;

        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
                //check employer reference status
                if (checkEmployerReference())
                {
                    MessageBox.Show("You may only delete employers who have no vacancies", "Error");
                }
                else
                {
                    DataRow deleteEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
                    
                    deleteEmployerRow.Delete();
                    DM.UpdateEmployer();

                    //Give the user a success message
                    MessageBox.Show("Employer deleted succesfully", "Success");
                }

            }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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
