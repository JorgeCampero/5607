
namespace StAlbertHospitalAssessment
{
    partial class Update_Admission
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
            this.components = new System.ComponentModel.Container();
            this.lblRequired = new System.Windows.Forms.Label();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.cboAdmissionID = new System.Windows.Forms.ComboBox();
            this.cboPatientsID = new System.Windows.Forms.ComboBox();
            this.DateAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAdmissions = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddAdmission = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.stAlbertDataSet = new StAlbertHospitalAssessment.StAlbertDataSet();
            this.admissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admissionsTableAdapter = new StAlbertHospitalAssessment.StAlbertDataSetTableAdapters.AdmissionsTableAdapter();
            this.cboDescription = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stAlbertDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(123, 315);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(112, 17);
            this.lblRequired.TabIndex = 114;
            this.lblRequired.Text = "Required Fields*";
            // 
            // cboFirstName
            // 
            this.cboFirstName.DisplayMember = "FirstName";
            this.cboFirstName.Enabled = false;
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(407, 220);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(93, 24);
            this.cboFirstName.TabIndex = 112;
            // 
            // cboLastName
            // 
            this.cboLastName.DisplayMember = "LastName";
            this.cboLastName.Enabled = false;
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(306, 220);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(91, 24);
            this.cboLastName.TabIndex = 111;
            // 
            // cboAdmissionID
            // 
            this.cboAdmissionID.DataSource = this.admissionsBindingSource;
            this.cboAdmissionID.DisplayMember = "AdmissionID";
            this.cboAdmissionID.FormattingEnabled = true;
            this.cboAdmissionID.Location = new System.Drawing.Point(244, 58);
            this.cboAdmissionID.Name = "cboAdmissionID";
            this.cboAdmissionID.Size = new System.Drawing.Size(55, 24);
            this.cboAdmissionID.TabIndex = 110;
            // 
            // cboPatientsID
            // 
            this.cboPatientsID.DisplayMember = "PatientID";
            this.cboPatientsID.FormattingEnabled = true;
            this.cboPatientsID.Location = new System.Drawing.Point(245, 220);
            this.cboPatientsID.Name = "cboPatientsID";
            this.cboPatientsID.Size = new System.Drawing.Size(55, 24);
            this.cboPatientsID.TabIndex = 109;
            // 
            // DateAdmission
            // 
            this.DateAdmission.Location = new System.Drawing.Point(244, 182);
            this.DateAdmission.Name = "DateAdmission";
            this.DateAdmission.Size = new System.Drawing.Size(256, 22);
            this.DateAdmission.TabIndex = 108;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(245, 142);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(208, 22);
            this.txtDescription.TabIndex = 107;
            // 
            // lblAdmissions
            // 
            this.lblAdmissions.AutoSize = true;
            this.lblAdmissions.Location = new System.Drawing.Point(155, 58);
            this.lblAdmissions.Name = "lblAdmissions";
            this.lblAdmissions.Size = new System.Drawing.Size(83, 17);
            this.lblAdmissions.TabIndex = 106;
            this.lblAdmissions.Text = "Admissions:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(175, 220);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(63, 17);
            this.lblStreetAddress.TabIndex = 105;
            this.lblStreetAddress.Text = "Patients:";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Location = new System.Drawing.Point(123, 182);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(115, 17);
            this.lblAdmissionDate.TabIndex = 104;
            this.lblAdmissionDate.Text = "Admission Date*:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(373, 335);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 103;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnAddAdmission
            // 
            this.btnAddAdmission.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddAdmission.Location = new System.Drawing.Point(61, 335);
            this.btnAddAdmission.Name = "btnAddAdmission";
            this.btnAddAdmission.Size = new System.Drawing.Size(177, 59);
            this.btnAddAdmission.TabIndex = 102;
            this.btnAddAdmission.Text = "Add Admission";
            this.btnAddAdmission.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(82, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(156, 17);
            this.lblDescription.TabIndex = 101;
            this.lblDescription.Text = "Admission Description*:";
            // 
            // stAlbertDataSet
            // 
            this.stAlbertDataSet.DataSetName = "StAlbertDataSet";
            this.stAlbertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admissionsBindingSource
            // 
            this.admissionsBindingSource.DataMember = "Admissions";
            this.admissionsBindingSource.DataSource = this.stAlbertDataSet;
            // 
            // admissionsTableAdapter
            // 
            this.admissionsTableAdapter.ClearBeforeFill = true;
            // 
            // cboDescription
            // 
            this.cboDescription.DataSource = this.admissionsBindingSource;
            this.cboDescription.DisplayMember = "Description";
            this.cboDescription.FormattingEnabled = true;
            this.cboDescription.Location = new System.Drawing.Point(306, 58);
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(126, 24);
            this.cboDescription.TabIndex = 115;
            // 
            // Update_Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboAdmissionID);
            this.Controls.Add(this.cboPatientsID);
            this.Controls.Add(this.DateAdmission);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAdmissions);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAdmission);
            this.Controls.Add(this.lblDescription);
            this.Name = "Update_Admission";
            this.Text = "Update_Admission";
            this.Load += new System.EventHandler(this.Update_Admission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stAlbertDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.ComboBox cboAdmissionID;
        private System.Windows.Forms.ComboBox cboPatientsID;
        private System.Windows.Forms.DateTimePicker DateAdmission;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAdmissions;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddAdmission;
        private System.Windows.Forms.Label lblDescription;
        private StAlbertDataSet stAlbertDataSet;
        private System.Windows.Forms.BindingSource admissionsBindingSource;
        private StAlbertDataSetTableAdapters.AdmissionsTableAdapter admissionsTableAdapter;
        private System.Windows.Forms.ComboBox cboDescription;
    }
}