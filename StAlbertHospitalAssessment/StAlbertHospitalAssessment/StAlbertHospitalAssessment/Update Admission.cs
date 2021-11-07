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
    public partial class Update_Admission : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmAdmission;
        private CurrencyManager cmPatients;
        private CurrencyManager cmWard;
        private int AdmissionID;
        public Update_Admission(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

      

        private void Update_Admission_Load(object sender, EventArgs e)
        {
            string AdmissionText = " ";
            foreach (DataRow drAdmission in DC.dtAdmission.Rows)
            {
                if (drAdmission["Status"].ToString() == "Current")
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
            txtDescription.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.Description");
            DateAdmission.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.AdmissionDate");
            cboStatus.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.Status");
            txtLastName.DataBindings.Add("Text", DC.dsStAlbert, "Patients.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsStAlbert, "Patients.FirstName");
            txtWard.DataBindings.Add("Text", DC.dsStAlbert, "Wards.WardName");
            cmAdmission = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Admissions"];
            cmPatients = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Patients"];
            cmWard = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Wards"];
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnUpdateAdmission_Click(object sender, EventArgs e)
        {
            
           
            if (txtDescription.Text == "" || DateAdmission.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("“Are you sure that you want to update this admission?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataRow updateAdmissionRow = DC.dtAdmission.Rows[cmAdmission.Position];
                    updateAdmissionRow["Description"] = txtDescription.Text;
                    updateAdmissionRow["AdmissionDate"] = DateAdmission.Text;
                    updateAdmissionRow["Status"] = cboStatus.Text;
                    cmAdmission.EndCurrentEdit();
                    DC.UpdateAdmission();
                    MessageBox.Show("Admission updated successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Update another admission?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                }



            }
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
                txtAdmissionID.Text = drAdmission["AdmissionID"].ToString();
                DateAdmission.Value = Convert.ToDateTime(drAdmission["AdmissionDate"]);
                txtDescription.Text = drAdmission["Description"].ToString();
                cboStatus.Text = drAdmission["Status"].ToString();
                cmPatients.Position = DC.patientView.Find(AdmissionID);
                DataRow drPatient = DC.dtPatient.Rows[cmPatients.Position];
                txtLastName.Text = drPatient["LastName"].ToString();
                txtFirstName.Text = drPatient["FirstName"].ToString();
                cmWard.Position = DC.wardView.Find(AdmissionID);
                DataRow drWard = DC.dtWard.Rows[cmWard.Position];
                txtWard.Text = drWard["WardName"].ToString();
            }


        }

        private void txtWard_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWard_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void txtAdmissionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRequired_Click(object sender, EventArgs e)
        {

        }

        private void DateAdmission_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAdmissions_Click(object sender, EventArgs e)
        {

        }

        private void lblPatientLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblAdmissionDate_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblAddAdmission_Click(object sender, EventArgs e)
        {

        }
    }
}
