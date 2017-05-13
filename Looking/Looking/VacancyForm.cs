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
    public partial class VacancyForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;

        private CurrencyManager cmEmployer;

        private CurrencyManager currencyManager;

        private int mode;  //0:add, 1:update

        public VacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            txtVacancyID.DataBindings.Add("Text",DM.dsLooking1, "Vacancy.VacancyID");
            txtDescription.DataBindings.Add("Text", DM.dsLooking1, "Vacancy.Description");
            txtStatus.DataBindings.Add("Text", DM.dsLooking1, "Vacancy.Status");
            txtSalary.DataBindings.Add("Text", DM.dsLooking1, "Vacancy.Salary");
            txtEmployerID.DataBindings.Add("Text", DM.dsLooking1, "Vacancy.EmployerID");
            
            txtVacancyID.Enabled = false;
            txtDescription.Enabled = false;
            txtStatus.Enabled = false;
            txtSalary.Enabled = false;
            txtEmployerID.Enabled = false;
            txtEmployerName.Enabled = false;
            
            lstVacancy.DataSource = DM.dsLooking1;
            lstVacancy.DisplayMember = "Vacancy.Description";
            lstVacancy.ValueMember = "Vacancy.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLooking1, "VACANCY"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLooking1, "EMPLOYER"];

            updateEmployerInfo();
        }

        private void LoadEmployers()
        {
            cboAddEmployerID.DataSource = DM.dsLooking1;
            cboAddEmployerID.DisplayMember = "Employer.EmployerID";
            cboAddEmployerID.ValueMember = "Employer.EmployerID";
            cboAddEmployerName.DataSource = DM.dsLooking1;
            cboAddEmployerName.DisplayMember = "Employer.EmployerName";
            cboAddEmployerName.ValueMember = "Employer.EmployerName";
        }

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            mode = 0;
            VacancyUIChange();

            txtAddID.Enabled = false;

            LoadEmployers();
        }

        private void VacancyUIChange()  //private int mode;  //0:add, 1:update
        {
            lstVacancy.Visible = false;

            btnNext.Enabled = false;
            btnPrevious.Enabled = false;

            btnDeleteVacancy.Enabled = false;

            if (mode == 0)
                btnUpdateVacancy.Enabled = false;
            else if (mode == 1)
                btnAddVacancy.Enabled = false;

            btnReturn.Enabled = false;

            pnlAddVacancy.Show();
            
        }

        private void btnSaveVacancy_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                //Create a new row that the variables will be added into
                DataRow newVacancyRow = DM.dtVancancy.NewRow();
                
                if((txtAddDescription.Text == "")||(txtAddSalary.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    //check salary input
                    try
                    {
                        int salaryValue = int.Parse(txtAddSalary.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please fill the salary box with valid number.", "Error");
                        return;
                    }
                    try
                    {
                        newVacancyRow["Description"] = txtAddDescription.Text;
                        newVacancyRow["Salary"] = txtAddSalary.Text;
                        newVacancyRow["Status"] = "current";

                        newVacancyRow["EmployerID"] = cboAddEmployerID.Text;

                        //Add the new row to the Table
                        DM.dtVancancy.Rows.Add(newVacancyRow);
                        DM.UpdateVacancy();

                        //Give the user a success message
                        MessageBox.Show("Vacancy added succesfully", "Success");
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("Invalid input,please check each field.", "Error");
                    }
                }
            }
            else if (mode == 1)
            {
                DataRow updateVacancyRow = DM.dtVancancy.Rows[currencyManager.Position];

                if ((txtAddDescription.Text == "") || (txtAddSalary.Text == ""))
                {
                    MessageBox.Show("You must enter a value for each of the text fields", "Error");
                }
                else
                {
                    //check salary input
                    try
                    {
                        int salaryValue = int.Parse(txtAddSalary.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please fill the salary box with valid number.", "Error");
                        return;
                    }
                    try
                    {
                        updateVacancyRow["Description"] = txtAddDescription.Text;
                        updateVacancyRow["Salary"] = txtAddSalary.Text;
                        updateVacancyRow["EmployerID"] = cboAddEmployerID.Text;

                        //Update the database
                        currencyManager.EndCurrentEdit();
                        DM.UpdateVacancy();

                        //Give the user a success message
                        MessageBox.Show("Vacancy updated successfully", "Success");
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
            pnlAddVacancy.Hide();

            lstVacancy.Enabled = true;
            lstVacancy.Visible = true;

            btnDeleteVacancy.Enabled = true;

            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            
            btnUpdateVacancy.Enabled = true;
            btnAddVacancy.Enabled = true;

            btnReturn.Enabled = true;
        }

        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            mode = 1;
            VacancyUIChange();

            DataRow drVacancy = DM.dtVancancy.Rows[currencyManager.Position];
            
            txtAddID.Text = drVacancy["VacancyID"].ToString();
            txtAddID.Enabled = false;
            txtAddDescription.Text = drVacancy["Description"].ToString();
            txtAddSalary.Text = drVacancy["Salary"].ToString();
            
            LoadEmployers();
        }

        private void lstVacancy_Click(object sender, EventArgs e)
        {
            updateEmployerInfo();
        }

        private void updateEmployerInfo()
        {
            DataRow drVacancy = DM.dtVancancy.Rows[currencyManager.Position];
            DataRow drEmployer;
            
            int employerID = Convert.ToInt32(drVacancy["EmployerID"]);
            cmEmployer.Position = DM.employerView.Find(employerID);
            drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool checkVacancyReference()
        {
            bool refer = false;
           
            string VacancyID = DM.dtVancancy.Rows[currencyManager.Position]["VacancyID"].ToString();
            string strFilter = "VacancyID = " + VacancyID;
            string strSort = "VacancyID";

            DataRow[] matchRecords = DM.dsLooking1.Tables["APPLICATION"].Select(strFilter,
                                     strSort, DataViewRowState.CurrentRows);
            int count = matchRecords.Length;

            if (count > 0)
                refer = true;

            return refer;

        }

        private void deleteInVacancySkillTable()
        {
            string VacancyID = DM.dtVancancy.Rows[currencyManager.Position]["VacancyID"].ToString();
            string strFilter = "VacancyID = " + VacancyID;
            string strSort = "VacancyID";

            DataRow[] matchRecords = DM.dsLooking1.Tables["VACANCYSKILL"].Select(strFilter,
                                     strSort, DataViewRowState.CurrentRows);
            int count = matchRecords.Length;

            if (count > 0)
            {
                foreach (DataRow matchRecord in matchRecords)
                {
                    matchRecord.Delete();
                }
                DM.UpdateVacancySkill();
            }

        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //check vacancy reference status
                if (checkVacancyReference())
                {
                    MessageBox.Show("You may only delete vacancies who have no applications", "Error");
                }
                
                else
                {
                    //first delete its reference in vacancySkill Table
                    deleteInVacancySkillTable();

                    //then delete in vacancy table
                    DataRow deleteVacancyRow = DM.dtVancancy.Rows[currencyManager.Position];
                    
                    deleteVacancyRow.Delete();
                    DM.UpdateVacancy();

                    //Give the user a success message
                    MessageBox.Show("Vacancy deleted succesfully", "Success");

                }
                
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            DataRow updateVacancyRow = DM.dtVancancy.Rows[currencyManager.Position];

            if (txtStatus.Text == "Filled")
            {
                MessageBox.Show("The vacancy is already filled", "Error");
            }
            else
            {
                updateVacancyRow["Status"] = "Filled";
                
                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateVacancy();
                
                //delete associated records in application table
                string VacancyID = DM.dtVancancy.Rows[currencyManager.Position]["VacancyID"].ToString();
                string strFilter = "VacancyID = " + VacancyID;
                string strSort = "VacancyID";

                DataRow[] matchRecords = DM.dsLooking1.Tables["APPLICATION"].Select(strFilter,
                                         strSort, DataViewRowState.CurrentRows);
                int count = matchRecords.Length;
                if (count > 0)
                {
                    foreach (DataRow matchRecord in matchRecords)
                    {
                        matchRecord.Delete();
                    }
                    DM.UpdateApplication();
                }

                //Give the user a success message
                MessageBox.Show("Vacancy marked as filled", "Success");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
                updateEmployerInfo();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
                updateEmployerInfo();
            }

        }
    }
}
