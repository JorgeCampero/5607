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
    public partial class Add_Admission : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        public Add_Admission(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        

        

       

        private void Add_Admission_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsStAlbert.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dsStAlbert.Patients);
            // TODO: This line of code loads data into the 'dsStAlbert.Wards' table. You can move, or remove it, as needed.
            this.wardsTableAdapter.Fill(this.dsStAlbert.Wards);
            

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnAddAdmission_Click_1(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || (DateAdmission.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newAdmissionRow = DC.dtAdmission.NewRow();
                newAdmissionRow["Description"] = txtDescription.Text;
                newAdmissionRow["AdmissionDate"] = DateAdmission.Text;
                newAdmissionRow["Status"] = "Current";
                newAdmissionRow["PatientID"] = cboPatientsID.Text;
                newAdmissionRow["WardID"] = cboWardID.Text;
                DC.dsStAlbert.Tables["Admissions"].Rows.Add(newAdmissionRow);
                DC.UpdateAdmission();
                MessageBox.Show("Admission added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Add another admission?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtDescription.Text = "";
                }
                    

            }
        }

        private void txtDescription_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
