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
    public partial class Produce_Research_Projects_Report : Form
    {
        private DataController DC;
        private MainMenu frmMenu;
        public Produce_Research_Projects_Report(DataController dc, MainMenu mnu)
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
            string ProjectText = "";
            txtResearchProjects.Text = "";

            foreach (DataRow drProject in DC.dtResearchProject.Rows)
            {
                ProjectText += "Research Project ID: " + drProject["ResearchProjectID"] + "                " + "Outcome: ";
                ProjectText += drProject["Outcome"] + "\r\n\r\n" + "Budget: ";
                ProjectText += drProject["Budget"] + "                              " + "End Date: ";
                ProjectText += drProject["EndDate"] + "\r\n\r\n" + "DoctorID: ";
                DataRow drDoctor = drProject.GetParentRow(DC.dtResearchProject.ParentRelations["Doctors_Research Project"]);
                ProjectText += drDoctor["DoctorID"] + "\r\n\r\n" + "Last Name: ";
                ProjectText += drDoctor["LastName"] + "\r\n\r\n" + "First Name: ";
                ProjectText += drDoctor["FirstName"] + "\r\n\r\n";
                DataRow drResearchTopic = drProject.GetParentRow(DC.dtResearchProject.ParentRelations["Research Topic_Research Project"]);              
                ProjectText += "Research Topic Description:" + drResearchTopic["Description"] + "\r\n\r\n\r\n\r\n";

                
                txtResearchProjects.Text += ProjectText;
                ProjectText = "";
            }
        }
    }
}
