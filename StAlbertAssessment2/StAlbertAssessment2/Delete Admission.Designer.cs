
namespace StAlbertAssessment2
{
    partial class Delete_Admission
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblAddAdmission = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAdmissionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAdmissionID = new System.Windows.Forms.ComboBox();
            this.DateAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAdmissions = new System.Windows.Forms.Label();
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteAdmission = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(204, 214);
            this.txtStatus.MaxLength = 30;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(86, 22);
            this.txtStatus.TabIndex = 159;
            // 
            // lblAddAdmission
            // 
            this.lblAddAdmission.AutoSize = true;
            this.lblAddAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdmission.Location = new System.Drawing.Point(166, 9);
            this.lblAddAdmission.Name = "lblAddAdmission";
            this.lblAddAdmission.Size = new System.Drawing.Size(237, 32);
            this.lblAddAdmission.TabIndex = 158;
            this.lblAddAdmission.Text = "Delete Admission";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(145, 217);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 157;
            this.lblStatus.Text = "Status:";
            // 
            // txtAdmissionID
            // 
            this.txtAdmissionID.Location = new System.Drawing.Point(204, 99);
            this.txtAdmissionID.MaxLength = 30;
            this.txtAdmissionID.Name = "txtAdmissionID";
            this.txtAdmissionID.ReadOnly = true;
            this.txtAdmissionID.Size = new System.Drawing.Size(55, 22);
            this.txtAdmissionID.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "AdmissionID:";
            // 
            // cboAdmissionID
            // 
            this.cboAdmissionID.FormattingEnabled = true;
            this.cboAdmissionID.Location = new System.Drawing.Point(204, 58);
            this.cboAdmissionID.Name = "cboAdmissionID";
            this.cboAdmissionID.Size = new System.Drawing.Size(208, 24);
            this.cboAdmissionID.TabIndex = 154;
            this.cboAdmissionID.SelectedIndexChanged += new System.EventHandler(this.cboAdmissionID_SelectedIndexChanged_1);
            // 
            // DateAdmission
            // 
            this.DateAdmission.Enabled = false;
            this.DateAdmission.Location = new System.Drawing.Point(203, 176);
            this.DateAdmission.Name = "DateAdmission";
            this.DateAdmission.Size = new System.Drawing.Size(256, 22);
            this.DateAdmission.TabIndex = 153;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(204, 136);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(208, 22);
            this.txtDescription.TabIndex = 152;
            // 
            // lblAdmissions
            // 
            this.lblAdmissions.AutoSize = true;
            this.lblAdmissions.Location = new System.Drawing.Point(115, 58);
            this.lblAdmissions.Name = "lblAdmissions";
            this.lblAdmissions.Size = new System.Drawing.Size(83, 17);
            this.lblAdmissions.TabIndex = 151;
            this.lblAdmissions.Text = "Admissions:";
            // 
            // lblAdmissionDate
            // 
            this.lblAdmissionDate.AutoSize = true;
            this.lblAdmissionDate.Location = new System.Drawing.Point(88, 176);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Size = new System.Drawing.Size(110, 17);
            this.lblAdmissionDate.TabIndex = 150;
            this.lblAdmissionDate.Text = "Admission Date:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(338, 276);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 149;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnDeleteAdmission
            // 
            this.btnDeleteAdmission.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDeleteAdmission.Location = new System.Drawing.Point(21, 276);
            this.btnDeleteAdmission.Name = "btnDeleteAdmission";
            this.btnDeleteAdmission.Size = new System.Drawing.Size(177, 59);
            this.btnDeleteAdmission.TabIndex = 148;
            this.btnDeleteAdmission.Text = "Delete Admission";
            this.btnDeleteAdmission.UseVisualStyleBackColor = false;
            this.btnDeleteAdmission.Click += new System.EventHandler(this.btnDeleteAdmission_Click_1);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(46, 139);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(151, 17);
            this.lblDescription.TabIndex = 147;
            this.lblDescription.Text = "Admission Description:";
            // 
            // Delete_Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 378);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblAddAdmission);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAdmissionID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAdmissionID);
            this.Controls.Add(this.DateAdmission);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAdmissions);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteAdmission);
            this.Controls.Add(this.lblDescription);
            this.Name = "Delete_Admission";
            this.Text = "Delete Admission";
            this.Load += new System.EventHandler(this.Delete_Admission_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblAddAdmission;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAdmissionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAdmissionID;
        private System.Windows.Forms.DateTimePicker DateAdmission;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAdmissions;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteAdmission;
        private System.Windows.Forms.Label lblDescription;
    }
}