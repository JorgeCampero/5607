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
    public partial class Delete_Admission : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmAdmission;
        private int AdmissionID;
        
        public Delete_Admission(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        private void Delete_Admission_Load(object sender, EventArgs e)
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
            txtDescription.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.Description");
            DateAdmission.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.AdmissionDate");
            txtStatus.DataBindings.Add("Text", DC.dsStAlbert, "Admissions.Status");            
            cmAdmission = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Admissions"];
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteAdmission_Click(object sender, EventArgs e)
        {
            DataRow deleteAdmissionRow = DC.dtAdmission.Rows[cmAdmission.Position];        
            deleteAdmissionRow.Delete();
            cmAdmission.EndCurrentEdit();
            DC.UpdateAdmission();
            MessageBox.Show("Admission deleted successfully", "Acknowledgment", MessageBoxButtons.OK);  
               
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
                txtStatus.Text = drAdmission["Status"].ToString();
               
            }
        }
    }    
}
