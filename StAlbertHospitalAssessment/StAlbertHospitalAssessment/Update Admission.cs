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
    public partial class Update_Admission : Form
    {
        public Update_Admission()
        {
            InitializeComponent();
        }

        private void Update_Admission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stAlbertDataSet.Admissions' table. You can move, or remove it, as needed.
            this.admissionsTableAdapter.Fill(this.stAlbertDataSet.Admissions);

        }
    }
}
