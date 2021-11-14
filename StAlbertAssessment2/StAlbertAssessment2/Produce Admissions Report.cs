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
    public partial class Produce_Admissions_Report : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        public Produce_Admissions_Report(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            string admissionsText = "";
            TxtAdmissions.Text = "";
            

            foreach (DataRow drAdmission in DC.dtAdmission.Rows)
            {
                admissionsText += drAdmission["AdmissionID"] + "     " + "Description: ";
                admissionsText += drAdmission["Description"] + "                " + " Admission Date: ";
                admissionsText += drAdmission["AdmissionDate"] + "\r\n\r\n" + "       " + "Status: ";
                admissionsText += drAdmission["Status"] + "                 ";
                DataRow[] drMedications = drAdmission.GetChildRows(DC.dtAdmission.ChildRelations["Admissions_Prescriptions"]);

                foreach (DataRow drMedication in drMedications)
                {
                    admissionsText += "MedicationID:" + drMedication["MedicationName"] + "\r\n\r\n" + "       ";

                }
                DataRow drPatient = drAdmission.GetParentRow(DC.dtAdmission.ParentRelations["Patients_Admissions"]);
                admissionsText += "Last Name: " + drPatient["LastName"] + "                " + " First Name: ";
                admissionsText += drPatient["FirstName"] + "\r\n\r\n\r\n\r\n";
               
                TxtAdmissions.Text += admissionsText;
                admissionsText = "";
            }
        }
    }
}
