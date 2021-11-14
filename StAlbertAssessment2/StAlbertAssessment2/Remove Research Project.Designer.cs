
namespace StAlbertAssessment2
{
    partial class Remove_Research_Project
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
            this.lblRemove = new System.Windows.Forms.Label();
            this.TxtSpecialty = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveResearchProject = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.listResearchProject = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(93, 9);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(344, 32);
            this.lblRemove.TabIndex = 173;
            this.lblRemove.Text = "Remove Research Project";
            // 
            // TxtSpecialty
            // 
            this.TxtSpecialty.Location = new System.Drawing.Point(209, 196);
            this.TxtSpecialty.MaxLength = 30;
            this.TxtSpecialty.Name = "TxtSpecialty";
            this.TxtSpecialty.ReadOnly = true;
            this.TxtSpecialty.Size = new System.Drawing.Size(236, 22);
            this.TxtSpecialty.TabIndex = 172;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(209, 160);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtFirstName.TabIndex = 171;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(134, 196);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(69, 17);
            this.lblSpecialty.TabIndex = 170;
            this.lblSpecialty.Text = "Specialty:";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(209, 86);
            this.txtDoctorID.MaxLength = 30;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.Size = new System.Drawing.Size(55, 22);
            this.txtDoctorID.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 168;
            this.label1.Text = "DoctorID:";
            // 
            // cboDoctors
            // 
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Location = new System.Drawing.Point(209, 45);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(208, 24);
            this.cboDoctors.TabIndex = 167;
            this.cboDoctors.SelectedIndexChanged += new System.EventHandler(this.cboDoctors_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(209, 123);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(189, 22);
            this.txtLastName.TabIndex = 166;
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Location = new System.Drawing.Point(142, 48);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(61, 17);
            this.lblDoctors.TabIndex = 165;
            this.lblDoctors.Text = "Doctors:";
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(78, 160);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(126, 17);
            this.lblPatientLastName.TabIndex = 164;
            this.lblPatientLastName.Text = "Doctor First Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(334, 384);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 163;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveResearchProject
            // 
            this.btnRemoveResearchProject.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRemoveResearchProject.Location = new System.Drawing.Point(22, 384);
            this.btnRemoveResearchProject.Name = "btnRemoveResearchProject";
            this.btnRemoveResearchProject.Size = new System.Drawing.Size(177, 59);
            this.btnRemoveResearchProject.TabIndex = 162;
            this.btnRemoveResearchProject.Text = "Remove Research Project";
            this.btnRemoveResearchProject.UseVisualStyleBackColor = false;
            this.btnRemoveResearchProject.Click += new System.EventHandler(this.btnRemoveResearchProject_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(78, 126);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(126, 17);
            this.lblLastName.TabIndex = 161;
            this.lblLastName.Text = "Doctor Last Name:";
            // 
            // listResearchProject
            // 
            this.listResearchProject.FormattingEnabled = true;
            this.listResearchProject.ItemHeight = 16;
            this.listResearchProject.Location = new System.Drawing.Point(81, 235);
            this.listResearchProject.Name = "listResearchProject";
            this.listResearchProject.Size = new System.Drawing.Size(331, 116);
            this.listResearchProject.TabIndex = 174;
            this.listResearchProject.SelectedIndexChanged += new System.EventHandler(this.listResearchProject_SelectedIndexChanged);
            // 
            // Remove_Research_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.listResearchProject);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.TxtSpecialty);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDoctors);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveResearchProject);
            this.Controls.Add(this.lblLastName);
            this.Name = "Remove_Research_Project";
            this.Text = "Remove Research Project";
            this.Load += new System.EventHandler(this.Remove_Research_Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.TextBox TxtSpecialty;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveResearchProject;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ListBox listResearchProject;
    }
}