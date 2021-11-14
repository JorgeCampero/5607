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
    public partial class Add_Research_Project : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        private CurrencyManager cmDoctor;
        private CurrencyManager cmResearchTopic;
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

      

        public void BindControls()
        {

            cmResearchTopic = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Research topic"];
            cmDoctor = (CurrencyManager)this.BindingContext[DC.dsStAlbert, "Doctors"];

            
        }

              

        private void cboDoctors_SelectedIndexChanged_1(object sender, EventArgs e)
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
                dgvResearch.DataSource = DC.dsStAlbert;
                dgvResearch.DataMember = "Doctors.Doctors_Research Project";
                dgvResearch.Columns["DoctorID"].Visible = false;
                dgvResearch.Columns["ResearchProjectID"].Visible = false;
                dgvResearch.Columns["ResearchTopicID"].Visible = false;

            }
        }

        private void cboResearchTopics_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void btnAddResearch_Click_1(object sender, EventArgs e)
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
            if (MessageBox.Show("Add another research project?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtDoctorID.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtSpecialty.Text= "";
                dgvResearch.Columns.Clear();
                cboOutcome.Text = "";
                numBudget.Value = 0;
                cboResearchTopics.Text = "";
                cboDoctors.Text = "";
                
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void Add_Research_Project_Load_1(object sender, EventArgs e)
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
    }
}
