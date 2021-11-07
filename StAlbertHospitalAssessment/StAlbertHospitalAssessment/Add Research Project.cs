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
    public partial class Add_Research_Project : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmDoctor;
        private CurrencyManager cmResearchTopic;
        private CurrencyManager cmWard;
        private int DoctorID;
        private int TopicID;
        public Add_Research_Project(DataController dc, MainMenu mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        private void Add_Research_Project_Load(object sender, EventArgs e)
        {
            string DoctorText = " ";
            foreach (DataRow drDoctor in DC.dtDoctor.Rows)
            {
                DoctorText = drDoctor["DoctorID"] + ", ";
                DoctorText += drDoctor["LastName"] + ", ";
                DoctorText += drDoctor["FirstName"];
                cboDoctors.Items.Add(DoctorText);            

            }

            string ResearchText = " ";
            foreach (DataRow drResearch in DC.dtResearchTopic.Rows)
            {
                ResearchText = drResearch["ResearchTopicID"] + ", ";
                ResearchText += drResearch["Description"] + ", ";
                ResearchText += drResearch["Level"];
                cboResearchTopics.Items.Add(ResearchText);
            }

        }

        public void BindControls()
        {
            txtDoctorID.DataBindings.Add("Text", DC.dsStAlbert, "Doctors.DoctorID");
            txtLastName.DataBindings.Add("Text", DC.dsStAlbert, "Doctors.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsStAlbert, "Doctors.FirstName");
            txtSpecialty.DataBindings.Add("Text", DC.dsStAlbert, "Doctors.Specialty");
            
            cmResearchTopic = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Research topic"];
            cmDoctor = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Doctors"];

            dgvResearch.DataSource = DC.dsStAlbert;
            dgvResearch.DataMember = "Doctors.Doctors_Research Project";
            dgvResearch.Columns["DoctorID"].Visible = false;
            dgvResearch.Columns["ResearchProjectID"].Visible = false;
            dgvResearch.Columns["ResearchTopicID"].Visible = false;
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
                txtSpecialty.Text = drDoctor["Specialty"].ToString();
               
                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnAddResearch_Click(object sender, EventArgs e)
        {
            DataRow newProjectRow = DC.dtResearchProject.NewRow();              
            newProjectRow["EndDate"] = EndDate.Text;
            newProjectRow["Outcome"] = cboOutcome.Text;
            newProjectRow["Budget"] = numBudget.Value;
            newProjectRow["DoctorID"] = txtDoctorID.Text;
            newProjectRow["ResearchTopicID"] = TopicID;
            DC.dsStAlbert.Tables["Research project"].Rows.Add(newProjectRow);
            DC.UpdateResearchProject();
            MessageBox.Show("Research project added successfully", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Add another Research Project?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               

            
        }

        private void cboResearchTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboResearchTopics.SelectedItem != null)
            {
                string Topic = "";
                Topic = cboResearchTopics.SelectedItem.ToString();
                string[] part = Topic.Split(',');
                TopicID = Convert.ToInt32(part[0]);
                cmResearchTopic.Position = DC.researchtopicView.Find(TopicID);
                
            }
             
        }
    }
}
