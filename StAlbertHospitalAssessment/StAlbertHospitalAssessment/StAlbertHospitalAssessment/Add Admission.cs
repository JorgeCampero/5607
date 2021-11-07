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

        private void Add_Admission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stAlbertDataSet.Wards' table. You can move, or remove it, as needed.
            this.wardsTableAdapter.Fill(this.stAlbertDataSet.Wards);
            // TODO: This line of code loads data into the 'stAlbertDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.stAlbertDataSet.Patients);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnAddAdmission_Click(object sender, EventArgs e)
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
                MessageBox.Show("Add another admission?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                txtDescription.Text = "";
                
            }
        }
    }
}
