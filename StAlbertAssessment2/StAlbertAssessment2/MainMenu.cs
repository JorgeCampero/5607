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
    public partial class MainMenu : Form
    {
        private DataController DC;
        private Add_Admission frmAddAdmission;
        private Update_Admission frmUpdateAdmission;
        private Delete_Admission frmDeleteAdmission;
        private Add_Research_Project frmAddResearch;
        private Remove_Prescription frmRemovePrescription;
        private Produce_Admissions_Report frmProduceAdmissionReport;
        private Remove_Research_Project frmRemoveResearchProject;
        private Produce_Research_Projects_Report frmProduceResearchProjectReport;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAdmission_Click(object sender, EventArgs e)
        {
            if (frmAddAdmission == null)
            {
                frmAddAdmission = new Add_Admission(DC, this);
            }
            frmAddAdmission.ShowDialog();
        }

               
      
      
        private void btnUpdateAdmission_Click(object sender, EventArgs e)
        {
            if (frmUpdateAdmission == null)
            {
                frmUpdateAdmission = new Update_Admission(DC, this);
            }
            frmUpdateAdmission.ShowDialog();
        }

        private void btnDeleteAdmission_Click_1(object sender, EventArgs e)
        {
            if (frmDeleteAdmission == null)
            {
                frmDeleteAdmission = new Delete_Admission(DC, this);
            }
            frmDeleteAdmission.ShowDialog();
        }

        private void btnAddResearchProject_Click_1(object sender, EventArgs e)
        {
            if (frmAddResearch == null)
            {
                frmAddResearch = new Add_Research_Project(DC, this);
            }
            frmAddResearch.ShowDialog();
        }

        private void btnRemovePrescription_Click_1(object sender, EventArgs e)
        {

            if (frmRemovePrescription == null)
            {
                frmRemovePrescription = new Remove_Prescription(DC, this);
            }
            frmRemovePrescription.ShowDialog();
        }

        private void btnRemoveResearchProject_Click(object sender, EventArgs e)
        {
            if (frmRemoveResearchProject == null)
            {
                frmRemoveResearchProject = new Remove_Research_Project(DC, this);
            }
            frmRemoveResearchProject.ShowDialog();
        }

        private void btnAdmissionsReport_Click(object sender, EventArgs e)
        {
            if (frmProduceAdmissionReport == null)
            {
                frmProduceAdmissionReport = new Produce_Admissions_Report(DC, this);
            }
            frmProduceAdmissionReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmProduceResearchProjectReport == null)
            {
                frmProduceResearchProjectReport = new Produce_Research_Projects_Report(DC, this);
            }
            frmProduceResearchProjectReport.ShowDialog();
        }
    }
}
