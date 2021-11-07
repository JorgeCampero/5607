
namespace StAlbertHospitalAssessment
{
    partial class Remove_Prescription
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
            this.lblAddAdmission = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAdmissionID = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAdmissions = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemovePrescription = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddAdmission
            // 
            this.lblAddAdmission.AutoSize = true;
            this.lblAddAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdmission.Location = new System.Drawing.Point(175, 9);
            this.lblAddAdmission.Name = "lblAddAdmission";
            this.lblAddAdmission.Size = new System.Drawing.Size(246, 32);
            this.lblAddAdmission.TabIndex = 145;
            this.lblAddAdmission.Text = "Update Admission";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(213, 209);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtFirstName.TabIndex = 142;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(213, 173);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(189, 22);
            this.txtLastName.TabIndex = 141;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(79, 209);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(128, 17);
            this.lblFirstName.TabIndex = 140;
            this.lblFirstName.Text = "Patient First Name:";
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(213, 99);
            this.txtAdmissionID.MaxLength = 30;
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.ReadOnly = true;
            this.txtAdmissionID.Size = new System.Drawing.Size(55, 22);
            this.txtAdmissionID.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "AdmissionID:";
            // 
            // cboAdmissionID
            // 
            this.cboAdmissionID.FormattingEnabled = true;
            this.cboAdmissionID.Location = new System.Drawing.Point(213, 58);
            this.cboAdmissionID.Name = "cboAdmissionID";
            this.cboAdmissionID.Size = new System.Drawing.Size(208, 24);
            this.cboAdmissionID.TabIndex = 134;
            this.cboAdmissionID.SelectedIndexChanged += new System.EventHandler(this.cboAdmissionID_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(213, 136);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(208, 22);
            this.txtDescription.TabIndex = 132;
            // 
            // lblAdmissions
            // 
            this.lblAdmissions.AutoSize = true;
            this.lblAdmissions.Location = new System.Drawing.Point(124, 58);
            this.lblAdmissions.Name = "lblAdmissions";
            this.lblAdmissions.Size = new System.Drawing.Size(83, 17);
            this.lblAdmissions.TabIndex = 131;
            this.lblAdmissions.Text = "Admissions:";
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(80, 173);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(128, 17);
            this.lblPatientLastName.TabIndex = 130;
            this.lblPatientLastName.Text = "Patient Last Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(338, 397);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 128;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemovePrescription
            // 
            this.btnRemovePrescription.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRemovePrescription.Location = new System.Drawing.Point(26, 397);
            this.btnRemovePrescription.Name = "btnRemovePrescription";
            this.btnRemovePrescription.Size = new System.Drawing.Size(177, 59);
            this.btnRemovePrescription.TabIndex = 127;
            this.btnRemovePrescription.Text = "Remove Prescription";
            this.btnRemovePrescription.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(156, 17);
            this.lblDescription.TabIndex = 126;
            this.lblDescription.Text = "Admission Description*:";
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Location = new System.Drawing.Point(53, 249);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersWidth = 51;
            this.dgvPrescriptions.RowTemplate.Height = 24;
            this.dgvPrescriptions.Size = new System.Drawing.Size(368, 125);
            this.dgvPrescriptions.TabIndex = 146;
            // 
            // Remove_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 506);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.lblAddAdmission);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtAdmissionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAdmissionID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAdmissions);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemovePrescription);
            this.Controls.Add(this.lblDescription);
            this.Name = "Remove_Prescription";
            this.Text = "Remove_Prescription";
            this.Load += new System.EventHandler(this.Remove_Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddAdmission;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAdmissionID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAdmissions;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemovePrescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
    }
}