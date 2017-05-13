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
    public partial class CatForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        private CurrencyManager cmOwner;

        public CatForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddCat.Left = 220;
            pnlAddCat.Top = 40;  
           
             
        }

        public void BindControls()
        {
            //lblCatID.DataBindings.Add("Text", DM.dsGlendene, "Cat.CatID");
            txtCatID.DataBindings.Add("Text", DM.dsGlendene, "Cat.CatID");
            txtName.DataBindings.Add("Text", DM.dsGlendene, "Cat.Name");
            txtBreed.DataBindings.Add("Text", DM.dsGlendene, "Cat.Breed");
            txtGender.DataBindings.Add("Text", DM.dsGlendene, "Cat.Gender");
            txtDateofBirth.DataBindings.Add("Text", DM.dsGlendene, "Cat.DateOfBirth");
            txtNeutered.DataBindings.Add("Text", DM.dsGlendene, "Cat.Neutered");
            txtOwnerID.DataBindings.Add("Text", DM.dsGlendene, "Cat.OwnerID");

            txtCatID.Enabled = false;
            txtName.Enabled = false;
            txtBreed.Enabled = false;
            txtGender.Enabled = false;
            txtDateofBirth.Enabled = false;
            txtNeutered.Enabled = false;
            txtOwnerID.Enabled = false;

            lstCats.DataSource = DM.dsGlendene;
            lstCats.DisplayMember = "Cat.Name";
            lstCats.ValueMember = "Cat.Name";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "CAT"];
            cmOwner = (CurrencyManager)this.BindingContext[DM.dsGlendene, "OWNER"];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddCat.Hide();
            lstCats.Enabled = true;
            lstCats.Visible = true;
            btnDeleteCat.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateCat.Enabled = true;
            btnAddCat.Enabled = true;
        }

        private void LoadOwners()
        {
            cboAddOwnerName.DataSource = DM.dsGlendene;
            cboAddOwnerName.DisplayMember = "Owner.LastName";
            cboAddOwnerName.ValueMember = "Owner.LastName";
            cboAddOwnerID.DataSource = DM.dsGlendene;
            cboAddOwnerID.DisplayMember = "Owner.OwnerID";
            cboAddOwnerID.ValueMember = "Owner.OwnerID";
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            lstCats.Visible = false;  //Note that if you use this line of code
            lstCats.Enabled = false;  //...you do not need this line
            lstCats.SelectedItem = null;  //...or this line
            btnDeleteCat.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnUpdateCat.Enabled = false;
            btnAddCat.Enabled = false;
            pnlAddCat.Show();
            LoadOwners();
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            lblCatID.Text = null;
            DataRow newCatRow = DM.dtCat.NewRow();

            if ((txtAddName.Text == ""))
            {
                MessageBox.Show("You must type in a Cat name", "Error");
            }
            else
            {
                try
                {
                    newCatRow["Name"] = txtAddName.Text;
                    newCatRow["Breed"] = txtAddBreed.Text;
                    newCatRow["Gender"] = cboAddGender.Text;
                    newCatRow["DateOfBirth"] = dtpAddDateOfBirth.Text;
                    newCatRow["Neutered"] = cbxAddNeutered.Checked;
                    newCatRow["OwnerID"] = cboAddOwnerID.Text;
                    DM.dtCat.Rows.Add(newCatRow);
                    MessageBox.Show("Cat added successfully", "Success");
                    DM.UpdateCat();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for cost", "Error");
                }
            }
        }

        private void lstCats_Click(object sender, EventArgs e)
        {
            int anOwnerID = Convert.ToInt32(txtOwnerID.Text);
            cmOwner.Position = DM.ownerView.Find(anOwnerID);
            DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];
            lblOwnerName.Text = drOwner["LastName"].ToString();
        }
    }
}
