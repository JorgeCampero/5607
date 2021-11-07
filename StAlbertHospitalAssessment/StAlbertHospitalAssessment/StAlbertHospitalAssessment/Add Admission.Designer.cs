
namespace StAlbertHospitalAssessment
{
    partial class Add_Admission
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddAdmission = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.DateAdmission = new System.Windows.Forms.DateTimePicker();
            this.cboPatientsID = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stAlbertDataSet = new StAlbertHospitalAssessment.StAlbertDataSet();
            this.patientsTableAdapter = new StAlbertHospitalAssessment.StAlbertDataSetTableAdapters.PatientsTableAdapter();
            this.cboWardID = new System.Windows.Forms.ComboBox();
            this.wardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardsTableAdapter = new StAlbertHospitalAssessment.StAlbertDataSetTableAdapters.WardsTableAdapter();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblAddAdmission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stAlbertDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(198, 72);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(208, 22);
            this.txtDescription.TabIndex = 93;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(138, 188);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(53, 17);
            this.lblSuburb.TabIndex = 87;
            this.lblSuburb.Text = "Wards:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(128, 150);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(63, 17);
            this.lblStreetAddress.TabIndex = 85;
            this.lblStreetAddress.Text = "Patients:";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Location = new System.Drawing.Point(76, 112);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(115, 17);
            this.lblAdmissionDate.TabIndex = 84;
            this.lblAdmissionDate.Text = "Admission Date*:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(326, 265);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 83;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddAdmission
            // 
            this.btnAddAdmission.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddAdmission.Location = new System.Drawing.Point(14, 265);
            this.btnAddAdmission.Name = "btnAddAdmission";
            this.btnAddAdmission.Size = new System.Drawing.Size(177, 59);
            this.btnAddAdmission.TabIndex = 82;
            this.btnAddAdmission.Text = "Add Admission";
            this.btnAddAdmission.UseVisualStyleBackColor = false;
            this.btnAddAdmission.Click += new System.EventHandler(this.btnAddAdmission_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(35, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(156, 17);
            this.lblDescription.TabIndex = 81;
            this.lblDescription.Text = "Admission Description*:";
            // 
            // DateAdmission
            // 
            this.DateAdmission.Location = new System.Drawing.Point(197, 112);
            this.DateAdmission.Name = "DateAdmission";
            this.DateAdmission.Size = new System.Drawing.Size(256, 22);
            this.DateAdmission.TabIndex = 94;
            // 
            // cboPatientsID
            // 
            this.cboPatientsID.DataSource = this.patientsBindingSource;
            this.cboPatientsID.DisplayMember = "PatientID";
            this.cboPatientsID.FormattingEnabled = true;
            this.cboPatientsID.Location = new System.Drawing.Point(198, 150);
            this.cboPatientsID.Name = "cboPatientsID";
            this.cboPatientsID.Size = new System.Drawing.Size(55, 24);
            this.cboPatientsID.TabIndex = 95;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.stAlbertDataSet;
            // 
            // stAlbertDataSet
            // 
            this.stAlbertDataSet.DataSetName = "StAlbertDataSet";
            this.stAlbertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // cboWardID
            // 
            this.cboWardID.DataSource = this.wardsBindingSource;
            this.cboWardID.DisplayMember = "WardID";
            this.cboWardID.FormattingEnabled = true;
            this.cboWardID.Location = new System.Drawing.Point(198, 188);
            this.cboWardID.Name = "cboWardID";
            this.cboWardID.Size = new System.Drawing.Size(55, 24);
            this.cboWardID.TabIndex = 96;
            // 
            // wardsBindingSource
            // 
            this.wardsBindingSource.DataMember = "Wards";
            this.wardsBindingSource.DataSource = this.stAlbertDataSet;
            // 
            // wardsTableAdapter
            // 
            this.wardsTableAdapter.ClearBeforeFill = true;
            // 
            // cboLastName
            // 
            this.cboLastName.DataSource = this.patientsBindingSource;
            this.cboLastName.DisplayMember = "LastName";
            this.cboLastName.Enabled = false;
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(259, 150);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(91, 24);
            this.cboLastName.TabIndex = 97;
            // 
            // cboFirstName
            // 
            this.cboFirstName.DataSource = this.patientsBindingSource;
            this.cboFirstName.DisplayMember = "FirstName";
            this.cboFirstName.Enabled = false;
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(360, 150);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(93, 24);
            this.cboFirstName.TabIndex = 98;
            // 
            // cboName
            // 
            this.cboName.DataSource = this.wardsBindingSource;
            this.cboName.DisplayMember = "WardName";
            this.cboName.Enabled = false;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(259, 188);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(126, 24);
            this.cboName.TabIndex = 99;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(76, 245);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(112, 17);
            this.lblRequired.TabIndex = 100;
            this.lblRequired.Text = "Required Fields*";
            // 
            // lblAddAdmission
            // 
            this.lblAddAdmission.AutoSize = true;
            this.lblAddAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdmission.Location = new System.Drawing.Point(145, 9);
            this.lblAddAdmission.Name = "lblAddAdmission";
            this.lblAddAdmission.Size = new System.Drawing.Size(205, 32);
            this.lblAddAdmission.TabIndex = 101;
            this.lblAddAdmission.Text = "Add Admission";
            // 
            // Add_Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 341);
            this.Controls.Add(this.lblAddAdmission);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboWardID);
            this.Controls.Add(this.cboPatientsID);
            this.Controls.Add(this.DateAdmission);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAdmission);
            this.Controls.Add(this.lblDescription);
            this.Name = "Add_Admission";
            this.Text = "Add Admission";
            this.Load += new System.EventHandler(this.Add_Admission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stAlbertDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddAdmission;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker DateAdmission;
        private System.Windows.Forms.ComboBox cboPatientsID;
        private StAlbertDataSet stAlbertDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private StAlbertDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.ComboBox cboWardID;
        private System.Windows.Forms.BindingSource wardsBindingSource;
        private StAlbertDataSetTableAdapters.WardsTableAdapter wardsTableAdapter;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblAddAdmission;
    }
}