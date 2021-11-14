using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StAlbertAssessment2
{
    public partial class Remove_Prescription : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmAdmission;
        private CurrencyManager cmPrescription;
        private CurrencyManager cmPatients;
        private int AdmissionID;
        
        public Remove_Prescription(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        
        public void BindControls()
        {
          
            

            cmAdmission = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Admissions"];
            cmPatients = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Patients"];
            cmPrescription = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Prescriptions"];

           

        }


        private void cboAdmissionID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboAdmissionID.SelectedItem != null)
            {
                string admission = "";
                admission = cboAdmissionID.SelectedItem.ToString();
                string[] parts = admission.Split(',');
                AdmissionID = Convert.ToInt32(parts[0]);
                cmAdmission.Position = DC.admissionView.Find(AdmissionID);
                DataRow drAdmission = DC.dtAdmission.Rows[cmAdmission.Position];
                DataRow drPatient = drAdmission.GetParentRow(DC.dtAdmission.ParentRelations["Patients_Admissions"]);
                txtAdmissionID.Text = drAdmission["AdmissionID"].ToString();
                txtLastName.Text = drPatient["LastName"].ToString();
                txtFirstName.Text = drPatient["FirstName"].ToString();
                txtDescription.Text = drAdmission["Description"].ToString();


            }

            if (cboAdmissionID.SelectedItem != null)
            {
                string admission, PrescriptionText = "";
                listPrescriptions.Items.Clear();
                admission = cboAdmissionID.SelectedItem.ToString();
                string[] parts = admission.Split(',');
                int AdmissionID = Convert.ToInt32(parts[0]);
                cmAdmission.Position = DC.admissionView.Find(AdmissionID);
                DataRow drAdmission = DC.dtAdmission.Rows[cmAdmission.Position];
                DataRow[] drPrescriptions = drAdmission.GetChildRows(DC.dtAdmission.ChildRelations["Admissions_Prescriptions"]);
                foreach (DataRow drPrescription in drPrescriptions)
                {
                    PrescriptionText = drPrescription["PrescriptionID"] + ", " + drPrescription["MedicationName"] + "," + drPrescription["PrescriptionDate"] + "," + drPrescription["Amount"].ToString();
                    listPrescriptions.Items.Add(PrescriptionText);
                }


            }
        }

        private void btnRemovePrescription_Click(object sender, EventArgs e)
        {
            DataRow deletePrescription = DC.dtPrescription.Rows[cmPrescription.Position];
            deletePrescription.Delete();
            listPrescriptions.Items.Clear();
            DC.UpdatePrescription();            
            MessageBox.Show("Prescription removed successfully", "Acknowledgement", MessageBoxButtons.OK);
            if (MessageBox.Show("Remove another prescription?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtDescription.Text = "";
                txtAdmissionID.Text = "";
                cboAdmissionID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                listPrescriptions.Items.Clear();
            }

        }

        private void Remove_Prescription_Load_1(object sender, EventArgs e)
        {
            string AdmissionText = " ";
            foreach (DataRow drAdmission in DC.dtAdmission.Rows)
            {
                if (drAdmission["Status"].ToString() == "Complete")
                {
                    AdmissionText = drAdmission["AdmissionID"] + ", ";
                    AdmissionText += drAdmission["Description"];
                    cboAdmissionID.Items.Add(AdmissionText);
                }

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void listPrescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPrescriptions.SelectedItem != null)
            {
                string prescription = " ";
                prescription = listPrescriptions.SelectedItem.ToString();
                string[] parts = prescription.Split(',');
                int prescriptionID = Convert.ToInt32(parts[0]);
                cmPrescription.Position = DC.prescriptionView.Find(prescriptionID);
                DataRow drAdmission = DC.dtPrescription.Rows[cmPrescription.Position];               
                
            }
        }
    }
}
