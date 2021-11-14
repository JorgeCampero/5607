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
    public partial class Remove_Research_Project : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmResearchProject;
        private CurrencyManager cmDoctor;
        private CurrencyManager cmResearchTopic;
        private int DoctorID;
        private int TopicID;
        public Remove_Research_Project(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        public void BindControls()
        {
            
            cmResearchProject = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Research Project"];
            cmDoctor = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Doctors"];
            cmResearchTopic = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Research Topic"];

            
        }

        private void cboDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoctors.SelectedItem != null)
            {
                string doctor = "";
                doctor = cboDoctors.SelectedItem.ToString();
                string[] parts = doctor.Split(',');
                DoctorID = Convert.ToInt32(parts[0]);
                cmDoctor.Position = DC.doctorView.Find(DoctorID);
                DataRow drDoctor = DC.dtDoctor.Rows[cmDoctor.Position];
                txtDoctorID.Text = drDoctor["DoctorID"].ToString();
                txtLastName.Text = drDoctor["LastName"].ToString();
                txtFirstName.Text = drDoctor["FirstName"].ToString();
                TxtSpecialty.Text = drDoctor["Specialty"].ToString();


            }
            if (cboDoctors.SelectedItem != null)
            {
                string doctor, researchProjectText = "";
                listResearchProject.Items.Clear();
                doctor = cboDoctors.SelectedItem.ToString();
                string[] parts = doctor.Split(',');
                int DoctorID = Convert.ToInt32(parts[0]);
                cmDoctor.Position = DC.admissionView.Find(DoctorID);
                DataRow drDoctor = DC.dtDoctor.Rows[cmDoctor.Position];
                DataRow[] drResearchProjects = drDoctor.GetChildRows(DC.dtDoctor.ChildRelations["Doctors_Research Project"]);
                foreach (DataRow drResearchProject in drResearchProjects)
                {
                    researchProjectText = drResearchProject["ResearchProjectID"] + ", " + drResearchProject["Outcome"] + "," + drResearchProject["Budget"] + "," + drResearchProject["ResearchTopicID"].ToString();
                    listResearchProject.Items.Add(researchProjectText);
                }
            }
        }

        private void Remove_Research_Project_Load(object sender, EventArgs e)
        {
            string DoctorText = " ";
            foreach (DataRow drDoctor in DC.dtDoctor.Rows)
            {
                DoctorText = drDoctor["DoctorID"] + ", ";
                DoctorText += drDoctor["LastName"] + ", ";
                DoctorText += drDoctor["FirstName"];
                cboDoctors.Items.Add(DoctorText);

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnRemoveResearchProject_Click(object sender, EventArgs e)
        {
            DataRow deleteResearch = DC.dtResearchProject.Rows[cmResearchProject.Position];
            deleteResearch.Delete();
            DC.UpdateResearchProject();
            listResearchProject.Items.Clear();
            MessageBox.Show("Research project removed successfully", "Acknowledgement", MessageBoxButtons.OK);
            if (MessageBox.Show("Remove another research project?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtDoctorID.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                TxtSpecialty.Text = "";
                cboDoctors.Text = "";

            }
        }

        private void listResearchProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listResearchProject.SelectedItem != null)
            {
                string research = " ";
                research = listResearchProject.SelectedItem.ToString();
                string[] parts = research.Split(',');
                int researchprojectID = Convert.ToInt32(parts[0]);
                cmResearchProject.Position = DC.researchprojectView.Find(researchprojectID);
                DataRow drResearchProject = DC.dtResearchProject.Rows[cmResearchProject.Position];

            }
        }
    }
}
