using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtCat;
        public DataTable dtOwner;
        public DataTable dtVeterinarian;
        public DataTable dtTreatment;
        public DataTable dtVisit;
        public DataTable dtVisitTreatment;

        public DataView catView;
        public DataView treatmentView;
        public DataView ownerView;
        public DataView veterinarianView;
        public DataView visitView;
        public DataView visitTreatmentView;

        public DataModule()
        {
            InitializeComponent();
            dsGlendene.EnforceConstraints = false;

            daCat.Fill(dsGlendene);
            daOwner.Fill(dsGlendene);
            daTreatment.Fill(dsGlendene);
            daVisit.Fill(dsGlendene);
            daVeterinarian.Fill(dsGlendene);
            daVisitTreatment.Fill(dsGlendene);

            dtCat = dsGlendene.Tables["Cat"];
            dtTreatment = dsGlendene.Tables["Treatment"];
            dtOwner = dsGlendene.Tables["Owner"];
            dtVeterinarian = dsGlendene.Tables["Veterinarian"];
            dtVisit = dsGlendene.Tables["Visit"];
            dtVisitTreatment = dsGlendene.Tables["VisitTreatment"];

            catView = new DataView(dtCat);
            catView.Sort = "CatID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            treatmentView = new DataView(dtTreatment);
            treatmentView.Sort = "TreatmentID";
            veterinarianView = new DataView(dtVeterinarian);
            veterinarianView.Sort = "VeterinarianID";


            dsGlendene.EnforceConstraints = true;
        }
        public void UpdateTreatment()
        {
            daTreatment.Update(dtTreatment);
        }
        public void UpdateVisitTreatment()
        {
            daVisitTreatment.Update(dtVisitTreatment);
        }
        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }
        public void UpdateCat()
        {
            daCat.Update(dtCat);
        }
        public void UpdateVeterinarian()
        {
            //daVisit.Update(dtVeterinarian);
            daVeterinarian.Update(dtVeterinarian);
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void daCat_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void oleDbDataAdapter2_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daTreatment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGlendene);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TreatmentID"] = newID;
            }
        }
    }
}
