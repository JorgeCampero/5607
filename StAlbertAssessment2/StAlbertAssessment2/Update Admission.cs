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



      
        public void BindControls()
        {
            
            cmAdmission = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Admissions"];
            cmPatients = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Patients"];
            cmWard = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Wards"];
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
                txtAdmissionID.Text = drAdmission["AdmissionID"].ToString();
                DateAdmission.Value = Convert.ToDateTime(drAdmission["AdmissionDate"]);
                txtDescription.Text = drAdmission["Description"].ToString();
                cboStatus.Text = drAdmission["Status"].ToString();
                cmPatients.Position = DC.patientView.Find(AdmissionID);
                DataRow drPatient = drAdmission.GetParentRow(DC.dtAdmission.ParentRelations["Patients_Admissions"]);
                txtLastName.Text = drPatient["LastName"].ToString();
                txtFirstName.Text = drPatient["FirstName"].ToString();
                cmWard.Position = DC.wardView.Find(AdmissionID);
                DataRow drWard = drAdmission.GetParentRow(DC.dtAdmission.ParentRelations["Wards_Admissions"]);
                txtWard.Text = drWard["WardName"].ToString();
            }
        }

        private void btnUpdateAdmission_Click_1(object sender, EventArgs e)
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
                    if (MessageBox.Show("Update another admission?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtDescription.Text = "";
                        txtAdmissionID.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtWard.Text = "";
                        DateAdmission.Text = "";
                        cboAdmissionID.Text = "";
                        cboStatus.Text = "";
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                }



            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void Update_Admission_Load_1(object sender, EventArgs e)
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
    }
}
