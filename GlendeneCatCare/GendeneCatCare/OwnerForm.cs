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
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        //private mode = 0;  //0:add, 1:update

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

        }

        public void BindControls()
        {
            //lblveterinarianID.DataBindings.Add("Text", DM.dsGlendene, "Veterinarian.VeterinarianID");
            txtLastName.DataBindings.Add("Text", DM.dsGlendene, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsGlendene, "Owner.FirstName");
            //txtRate.DataBindings.Add("Text", DM.dsGlendene, "Veterinarian.Rate");
            txtStreetAddress.DataBindings.Add("Text", DM.dsGlendene, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsGlendene, "Owner.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsGlendene, "Owner.PhoneNumber");
            
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;

            lstOwner.DataSource = DM.dsGlendene;
            lstOwner.DisplayMember = "Owner.LastName";
            lstOwner.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            lstOwner.Visible = false;  //Note that if you use this line of code
            //lstCats.Enabled = false;  //...you do not need this line
            //lstCats.SelectedItem = null;  //...or this line
            btnDeleteOwner.Enabled = false;
            //btnNext.Enabled = false;
            //btnPrevious.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnAddOwner.Enabled = false;
            pnlAddOwner.Show();
            //LoadOwners();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow newOwnerRow = DM.dtOwner.NewRow();

            newOwnerRow["LastName"] = textNewLastName.Text;
            newOwnerRow["FirstName"] = textNewFirstName.Text;
            newOwnerRow["StreetAddress"] = textNewStreetAddress.Text;
            newOwnerRow["Suburb"] = textNewSuburb.Text;
            newOwnerRow["PhoneNumber"] = textNewPhoneNumber.Text;

            //Add the new row to the Table
            DM.dtOwner.Rows.Add(newOwnerRow);
            
            DM.UpdateOwner();
            //Give the user a success message
            MessageBox.Show("Veterinarian added succesfully", "Success");

            pnlAddOwner.Hide();
            lstOwner.Enabled = true;
            lstOwner.Visible = true;

            btnDeleteOwner.Enabled = true;
            //btnNext.Enabled = true;
            //btnPrevious.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnAddOwner.Enabled = true;

        }

        private void pnlAddOwner_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
