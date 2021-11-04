
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
            this.cboAdmissionID = new System.Windows.Forms.ComboBox();
            this.admissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stAlbertDataSet = new StAlbertHospitalAssessment.StAlbertDataSet();
            this.DateAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAdmissions = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateAdmission = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.admissionsTableAdapter = new StAlbertHospitalAssessment.StAlbertDataSetTableAdapters.AdmissionsTableAdapter();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtWard = new System.Windows.Forms.TextBox();
            this.lblWard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stAlbertDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(119, 377);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(112, 17);
            this.lblRequired.TabIndex = 114;
            this.lblRequired.Text = "Required Fields*";
            // 
            // cboAdmissionID
            // 
            this.cboAdmissionID.FormattingEnabled = true;
            this.cboAdmissionID.Location = new System.Drawing.Point(244, 58);
            this.cboAdmissionID.Name = "cboAdmissionID";
            this.cboAdmissionID.Size = new System.Drawing.Size(208, 24);
            this.cboAdmissionID.TabIndex = 110;
            this.cboAdmissionID.SelectedIndexChanged += new System.EventHandler(this.cboAdmissionID_SelectedIndexChanged);
            // 
            // admissionsBindingSource
            // 
            this.admissionsBindingSource.DataMember = "Admissions";
            this.admissionsBindingSource.DataSource = this.stAlbertDataSet;
            // 
            // stAlbertDataSet
            // 
            this.stAlbertDataSet.DataSetName = "StAlbertDataSet";
            this.stAlbertDataSet.EnforceConstraints = false;
            this.stAlbertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateAdmission
            // 
            this.DateAdmission.Location = new System.Drawing.Point(243, 176);
            this.DateAdmission.Name = "DateAdmission";
            this.DateAdmission.Size = new System.Drawing.Size(256, 22);
            this.DateAdmission.TabIndex = 108;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(244, 136);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(208, 22);
            this.txtDescription.TabIndex = 107;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
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
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(110, 254);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(128, 17);
            this.lblPatientLastName.TabIndex = 105;
            this.lblPatientLastName.Text = "Patient Last Name:";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Location = new System.Drawing.Point(122, 176);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(115, 17);
            this.lblAdmissionDate.TabIndex = 104;
            this.lblAdmissionDate.Text = "Admission Date*:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(369, 397);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 103;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateAdmission
            // 
            this.btnUpdateAdmission.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdateAdmission.Location = new System.Drawing.Point(57, 397);
            this.btnUpdateAdmission.Name = "btnUpdateAdmission";
            this.btnUpdateAdmission.Size = new System.Drawing.Size(177, 59);
            this.btnUpdateAdmission.TabIndex = 102;
            this.btnUpdateAdmission.Text = "Update Admission";
            this.btnUpdateAdmission.UseVisualStyleBackColor = false;
            this.btnUpdateAdmission.Click += new System.EventHandler(this.btnUpdateAdmission_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(81, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(156, 17);
            this.lblDescription.TabIndex = 101;
            this.lblDescription.Text = "Admission Description*:";
            // 
            // admissionsTableAdapter
            // 
            this.admissionsTableAdapter.ClearBeforeFill = true;
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(244, 99);
            this.txtAdmissionID.MaxLength = 30;
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.ReadOnly = true;
            this.txtAdmissionID.Size = new System.Drawing.Size(55, 22);
            this.txtAdmissionID.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 116;
            this.label1.Text = "AdmissionID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(179, 217);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 17);
            this.lblStatus.TabIndex = 118;
            this.lblStatus.Text = "Status*:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Current",
            "Complete"});
            this.cboStatus.Location = new System.Drawing.Point(243, 217);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(102, 24);
            this.cboStatus.TabIndex = 119;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(109, 290);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(128, 17);
            this.lblFirstName.TabIndex = 120;
            this.lblFirstName.Text = "Patient First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(243, 254);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(189, 22);
            this.txtLastName.TabIndex = 121;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(243, 290);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtFirstName.TabIndex = 122;
            // 
            // txtWard
            // 
            this.txtWard.Location = new System.Drawing.Point(243, 326);
            this.txtWard.MaxLength = 30;
            this.txtWard.Name = "txtWard";
            this.txtWard.ReadOnly = true;
            this.txtWard.Size = new System.Drawing.Size(102, 22);
            this.txtWard.TabIndex = 124;
            // 
            // lblWard
            // 
            this.lblWard.AutoSize = true;
            this.lblWard.Location = new System.Drawing.Point(190, 326);
            this.lblWard.Name = "lblWard";
            this.lblWard.Size = new System.Drawing.Size(46, 17);
            this.lblWard.TabIndex = 123;
            this.lblWard.Text = "Ward:";
            // 
            // Update_Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 488);
            this.Controls.Add(this.txtWard);
            this.Controls.Add(this.lblWard);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAdmissionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.cboAdmissionID);
            this.Controls.Add(this.DateAdmission);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAdmissions);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateAdmission);
            this.Controls.Add(this.lblDescription);
            this.Name = "Update_Admission";
            this.Text = "Update_Admission";
            this.Load += new System.EventHandler(this.Update_Admission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stAlbertDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.ComboBox cboAdmissionID;
        private System.Windows.Forms.DateTimePicker DateAdmission;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAdmissions;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateAdmission;
        private System.Windows.Forms.Label lblDescription;
        private StAlbertDataSet stAlbertDataSet;
        private System.Windows.Forms.BindingSource admissionsBindingSource;
        private StAlbertDataSetTableAdapters.AdmissionsTableAdapter admissionsTableAdapter;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtWard;
        private System.Windows.Forms.Label lblWard;
    }
}