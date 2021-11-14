
namespace StAlbertAssessment2
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemovePrescription = new System.Windows.Forms.Button();
            this.btnAddResearchProject = new System.Windows.Forms.Button();
            this.btnDeleteAdmission = new System.Windows.Forms.Button();
            this.btnUpdateAdmission = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddAdmission = new System.Windows.Forms.Button();
            this.btnRemoveResearchProject = new System.Windows.Forms.Button();
            this.btnAdmissionsReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemovePrescription
            // 
            this.btnRemovePrescription.Location = new System.Drawing.Point(40, 462);
            this.btnRemovePrescription.Name = "btnRemovePrescription";
            this.btnRemovePrescription.Size = new System.Drawing.Size(159, 71);
            this.btnRemovePrescription.TabIndex = 11;
            this.btnRemovePrescription.Text = "Remove Prescription";
            this.btnRemovePrescription.UseVisualStyleBackColor = true;
            this.btnRemovePrescription.Click += new System.EventHandler(this.btnRemovePrescription_Click_1);
            // 
            // btnAddResearchProject
            // 
            this.btnAddResearchProject.Location = new System.Drawing.Point(40, 350);
            this.btnAddResearchProject.Name = "btnAddResearchProject";
            this.btnAddResearchProject.Size = new System.Drawing.Size(159, 71);
            this.btnAddResearchProject.TabIndex = 10;
            this.btnAddResearchProject.Text = "Add Research Project";
            this.btnAddResearchProject.UseVisualStyleBackColor = true;
            this.btnAddResearchProject.Click += new System.EventHandler(this.btnAddResearchProject_Click_1);
            // 
            // btnDeleteAdmission
            // 
            this.btnDeleteAdmission.Location = new System.Drawing.Point(40, 243);
            this.btnDeleteAdmission.Name = "btnDeleteAdmission";
            this.btnDeleteAdmission.Size = new System.Drawing.Size(159, 71);
            this.btnDeleteAdmission.TabIndex = 9;
            this.btnDeleteAdmission.Text = "Delete Admission";
            this.btnDeleteAdmission.UseVisualStyleBackColor = true;
            this.btnDeleteAdmission.Click += new System.EventHandler(this.btnDeleteAdmission_Click_1);
            // 
            // btnUpdateAdmission
            // 
            this.btnUpdateAdmission.Location = new System.Drawing.Point(40, 122);
            this.btnUpdateAdmission.Name = "btnUpdateAdmission";
            this.btnUpdateAdmission.Size = new System.Drawing.Size(159, 71);
            this.btnUpdateAdmission.TabIndex = 8;
            this.btnUpdateAdmission.Text = "Update Admission";
            this.btnUpdateAdmission.UseVisualStyleBackColor = true;
            this.btnUpdateAdmission.Click += new System.EventHandler(this.btnUpdateAdmission_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(612, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 71);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddAdmission
            // 
            this.btnAddAdmission.Location = new System.Drawing.Point(40, 22);
            this.btnAddAdmission.Name = "btnAddAdmission";
            this.btnAddAdmission.Size = new System.Drawing.Size(159, 71);
            this.btnAddAdmission.TabIndex = 6;
            this.btnAddAdmission.Text = "Add Admission";
            this.btnAddAdmission.UseVisualStyleBackColor = true;
            this.btnAddAdmission.Click += new System.EventHandler(this.btnAddAdmission_Click);
            // 
            // btnRemoveResearchProject
            // 
            this.btnRemoveResearchProject.Location = new System.Drawing.Point(236, 22);
            this.btnRemoveResearchProject.Name = "btnRemoveResearchProject";
            this.btnRemoveResearchProject.Size = new System.Drawing.Size(159, 71);
            this.btnRemoveResearchProject.TabIndex = 12;
            this.btnRemoveResearchProject.Text = "Remove Research Project";
            this.btnRemoveResearchProject.UseVisualStyleBackColor = true;
            this.btnRemoveResearchProject.Click += new System.EventHandler(this.btnRemoveResearchProject_Click);
            // 
            // btnAdmissionsReport
            // 
            this.btnAdmissionsReport.Location = new System.Drawing.Point(236, 122);
            this.btnAdmissionsReport.Name = "btnAdmissionsReport";
            this.btnAdmissionsReport.Size = new System.Drawing.Size(159, 71);
            this.btnAdmissionsReport.TabIndex = 13;
            this.btnAdmissionsReport.Text = "Admissions Report";
            this.btnAdmissionsReport.UseVisualStyleBackColor = true;
            this.btnAdmissionsReport.Click += new System.EventHandler(this.btnAdmissionsReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Research Projects Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmissionsReport);
            this.Controls.Add(this.btnRemoveResearchProject);
            this.Controls.Add(this.btnRemovePrescription);
            this.Controls.Add(this.btnAddResearchProject);
            this.Controls.Add(this.btnDeleteAdmission);
            this.Controls.Add(this.btnUpdateAdmission);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAdmission);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemovePrescription;
        private System.Windows.Forms.Button btnAddResearchProject;
        private System.Windows.Forms.Button btnDeleteAdmission;
        private System.Windows.Forms.Button btnUpdateAdmission;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddAdmission;
        private System.Windows.Forms.Button btnRemoveResearchProject;
        private System.Windows.Forms.Button btnAdmissionsReport;
        private System.Windows.Forms.Button button1;
    }
}

