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

namespace Looking
{
    public partial class DataModule : Form
    {
        public DataTable dtEmployer;
        public DataTable dtCandidate;
        public DataTable dtVancancy;
        public DataTable dtSkill;
        public DataTable dtVacancySkill;
        public DataTable dtCandidateSkill;
        public DataTable dtApplication;

        public DataView employerView;
        public DataView vacancyView;
        public DataView candidateView;
        public DataView skillView;

        /*
        public DataView catView;
        public DataView treatmentView;
        public DataView ownerView;
        public DataView veterinarianView;
        public DataView visitView;
        public DataView visitTreatmentView;

             */

        public DataModule()
        {
            InitializeComponent();

            dsLooking1.EnforceConstraints = false;

            /*daCat.Fill(dsGlendene);
            daOwner.Fill(dsGlendene);
            daTreatment.Fill(dsGlendene);
            daVisit.Fill(dsGlendene);
            daVeterinarian.Fill(dsGlendene);
            daVisitTreatment.Fill(dsGlendene);
            */
            daEmployer.Fill(dsLooking1);
            daCandidate.Fill(dsLooking1);
            daVacancy.Fill(dsLooking1);
            daSkill.Fill(dsLooking1);
            daVacancySkill.Fill(dsLooking1);
            daCandidateSkill.Fill(dsLooking1);
            daApplication.Fill(dsLooking1);

            /*
            dtCat = dsGlendene.Tables["Cat"];
            dtTreatment = dsGlendene.Tables["Treatment"];
            dtOwner = dsGlendene.Tables["Owner"];
            dtVeterinarian = dsGlendene.Tables["Veterinarian"];
            dtVisit = dsGlendene.Tables["Visit"];
            dtVisitTreatment = dsGlendene.Tables["VisitTreatment"];
            */
            dtEmployer = dsLooking1.Tables["Employer"];
            dtCandidate = dsLooking1.Tables["Candidate"];
            dtVancancy = dsLooking1.Tables["Vacancy"];
            dtSkill = dsLooking1.Tables["Skill"];
            dtVacancySkill = dsLooking1.Tables["VacancySkill"];
            dtCandidateSkill = dsLooking1.Tables["CandidateSkill"];
            dtApplication = dsLooking1.Tables["Application"];
            

            
            /*catView = new DataView(dtCat);
            catView.Sort = "CatID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            treatmentView = new DataView(dtTreatment);
            treatmentView.Sort = "TreatmentID";
            veterinarianView = new DataView(dtVeterinarian);
            veterinarianView.Sort = "VeterinarianID";
            */

            employerView = new DataView(dtEmployer);
            employerView.Sort = "EmployerID";
            
            vacancyView = new DataView(dtVancancy);
            vacancyView.Sort = "VacancyID";

            candidateView = new DataView(dtCandidate);
            candidateView.Sort = "CandidateID";

            skillView = new DataView(dtSkill);
            skillView.Sort = "SkillID";
            
            dsLooking1.EnforceConstraints = true;
        }

        public void UpdateEmployer()
        {
            daEmployer.Update(dtEmployer);
        }

        public void UpdateCandidate()
        {
            //daEmployer.Update(dtEmployer);
            daCandidate.Update(dtCandidate);
        }

        public void UpdateVacancy()
        {
            //daCandidate.Update(dtCandidate);
            daVacancy.Update(dtVancancy);
        }

        public void UpdateVacancySkill()
        {
            daVacancySkill.Update(dtVacancySkill);
        }

        public void UpdateCandidateSkill()
        {
            daCandidateSkill.Update(dtCandidateSkill);
        }

        public void UpdateApplication()
        {
            //daCandidateSkill.Update(dtCandidateSkill);
            daApplication.Update(dtApplication);
        }
    }
}
