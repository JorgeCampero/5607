using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StAlbertHospitalAssessment
{
    public partial class Remove_Prescription : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmAdmission;
        private CurrencyManager cmPrescription;
        private CurrencyManager cmPatients;
        private int AdmissionID;
        private int TopicID;
        public Remove_Prescription(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        private void Remove_Prescription_Load(object sender, EventArgs e)
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
        public void BindControls()
        {
            txtAdmissionID.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.AdmissionID");
            txtLastName.DataBindings.Add("Text", DC.dsStAlbert, "Patients.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsStAlbert, "Patients.FirstName");
            txtDescription.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.Description");

            cmAdmission = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Admissions"];
            cmPatients = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Patients"];

            dgvPrescriptions.DataSource = DC.dsStAlbert;
            dgvPrescriptions.DataMember = "Admissions.Admissions_Prescriptions";
            dgvPrescriptions.Columns["PrescriptionID"].Visible = false;

        }

        private void cboAdmissionID_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
