using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StAlbertHospitalAssessment
{
    public partial class DataController : Form
    {
        public DataTable dtAdmission;
        public DataTable dtPatient;
        public DataTable dtAllocation;
        public DataTable dtDoctor;
        public DataTable dtMedication;
        public DataTable dtPayment;
        public DataTable dtPrescription;
        public DataTable dtResearchProject;
        public DataTable dtResearchTopic;
        public DataTable dtWard;
        public DataView admissionView;
        public DataView patientView;
        public DataView allocationView;
        public DataView doctorView;
        public DataView medicationView;
        public DataView paymentView;
        public DataView prescriptionView;
        public DataView researchprojectView;
        public DataView researchtopicView;
        public DataView wardView;
        public DataController()
        {
            InitializeComponent();
            dsStAlbert.EnforceConstraints = false;
            DaAdmission.Fill(dsStAlbert);
            DaAllocation.Fill(dsStAlbert);
            DaDoctor.Fill(dsStAlbert);
            DaMedication.Fill(dsStAlbert);
            DaPatient.Fill(dsStAlbert);
            DaPayment.Fill(dsStAlbert);
            DaPrescription.Fill(dsStAlbert);
            DaResearchProject.Fill(dsStAlbert);
            DaResearchTopic.Fill(dsStAlbert);
            DaWard.Fill(dsStAlbert);
            dtAdmission = dsStAlbert.Tables["Admissions"];
            dtAllocation = dsStAlbert.Tables["Allocation"];
            dtDoctor = dsStAlbert.Tables["Doctors"];
            dtMedication = dsStAlbert.Tables["Medication"];
            dtPatient = dsStAlbert.Tables["Patients"];
            dtPayment = dsStAlbert.Tables["Payments"];
            dtPrescription = dsStAlbert.Tables["Prescriptions"];
            dtResearchProject = dsStAlbert.Tables["Research project"];
            dtResearchTopic = dsStAlbert.Tables["Research topic"];
            dtWard = dsStAlbert.Tables["Wards"];
            admissionView = new DataView(dtAdmission);
            admissionView.Sort = "AdmissionID";
            allocationView = new DataView(dtAllocation);
            allocationView.Sort = "AllocationID";
            doctorView = new DataView(dtDoctor);
            doctorView.Sort = "DoctorID";
            medicationView = new DataView(dtMedication);
            medicationView.Sort = "MedicationID";
            patientView = new DataView(dtPatient);
            patientView.Sort = "PatientID";
            paymentView = new DataView(dtPayment);
            paymentView.Sort = "PaymentCode";
            prescriptionView = new DataView(dtPrescription);
            prescriptionView.Sort = "PrescriptionID";
            researchprojectView = new DataView(dtResearchProject);
            researchprojectView.Sort = "ResearchProjectID";
            researchtopicView = new DataView(dtResearchTopic);
            researchtopicView.Sort = "ResearchTopicID";
            wardView = new DataView(dtWard);
            wardView.Sort = "WardID";
            dsStAlbert.EnforceConstraints = true;
        }

        public void UpdateAdmission()
        {
            DaAdmission.Update(dsStAlbert, "Admissions");
        }

        private void daAdmission_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnStAlbert);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["AdmissionID"] = newID;
            }
        }

        public void UpdateResearchProject()
        {
            DaResearchProject.Update(dsStAlbert, "Research project");
        }

        private void daResearchProject_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnStAlbert);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ResearchProjectID"] = newID;
            }
        }
    }
}
