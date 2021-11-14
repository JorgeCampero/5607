
namespace StAlbertAssessment2
{
    partial class Add_Research_Project
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
            this.numBudget = new System.Windows.Forms.NumericUpDown();
            this.cboOutcome = new System.Windows.Forms.ComboBox();
            this.dgvResearch = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddResearch = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cboResearchTopics = new System.Windows.Forms.ComboBox();
            this.lblResearch = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddResearch = new System.Windows.Forms.Button();
            this.lblSpecialty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResearch)).BeginInit();
            this.SuspendLayout();
            // 
            // numBudget
            // 
            this.numBudget.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBudget.Location = new System.Drawing.Point(216, 451);
            this.numBudget.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numBudget.Name = "numBudget";
            this.numBudget.Size = new System.Drawing.Size(120, 22);
            this.numBudget.TabIndex = 181;
            // 
            // cboOutcome
            // 
            this.cboOutcome.FormattingEnabled = true;
            this.cboOutcome.Items.AddRange(new object[] {
            "Journal article",
            "Conference paper",
            "Conference poster",
            "Book chapter",
            "Book"});
            this.cboOutcome.Location = new System.Drawing.Point(214, 413);
            this.cboOutcome.Name = "cboOutcome";
            this.cboOutcome.Size = new System.Drawing.Size(118, 24);
            this.cboOutcome.TabIndex = 180;
            // 
            // dgvResearch
            // 
            this.dgvResearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResearch.Location = new System.Drawing.Point(82, 251);
            this.dgvResearch.Name = "dgvResearch";
            this.dgvResearch.RowHeadersWidth = 51;
            this.dgvResearch.RowTemplate.Height = 24;
            this.dgvResearch.Size = new System.Drawing.Size(357, 105);
            this.dgvResearch.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 178;
            this.label3.Text = "Budget:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 177;
            this.label4.Text = "Outcome:";
            // 
            // lblAddResearch
            // 
            this.lblAddResearch.AutoSize = true;
            this.lblAddResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddResearch.Location = new System.Drawing.Point(149, 22);
            this.lblAddResearch.Name = "lblAddResearch";
            this.lblAddResearch.Size = new System.Drawing.Size(290, 32);
            this.lblAddResearch.TabIndex = 176;
            this.lblAddResearch.Text = "Add Research Project";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(213, 185);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(189, 22);
            this.txtFirstName.TabIndex = 175;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(213, 149);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(189, 22);
            this.txtLastName.TabIndex = 174;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(79, 185);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(126, 17);
            this.lblFirstName.TabIndex = 173;
            this.lblFirstName.Text = "Doctor First Name:";
            // 
            // cboResearchTopics
            // 
            this.cboResearchTopics.FormattingEnabled = true;
            this.cboResearchTopics.Location = new System.Drawing.Point(213, 374);
            this.cboResearchTopics.Name = "cboResearchTopics";
            this.cboResearchTopics.Size = new System.Drawing.Size(209, 24);
            this.cboResearchTopics.TabIndex = 172;
            this.cboResearchTopics.SelectedIndexChanged += new System.EventHandler(this.cboResearchTopics_SelectedIndexChanged_1);
            // 
            // lblResearch
            // 
            this.lblResearch.AutoSize = true;
            this.lblResearch.Location = new System.Drawing.Point(89, 377);
            this.lblResearch.Name = "lblResearch";
            this.lblResearch.Size = new System.Drawing.Size(119, 17);
            this.lblResearch.TabIndex = 171;
            this.lblResearch.Text = "Research Topics:";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(214, 112);
            this.txtDoctorID.MaxLength = 30;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.Size = new System.Drawing.Size(55, 22);
            this.txtDoctorID.TabIndex = 170;
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(139, 112);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(67, 17);
            this.lblDoctorID.TabIndex = 169;
            this.lblDoctorID.Text = "DoctorID:";
            // 
            // cboDoctors
            // 
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Location = new System.Drawing.Point(214, 71);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(208, 24);
            this.cboDoctors.TabIndex = 167;
            this.cboDoctors.SelectedIndexChanged += new System.EventHandler(this.cboDoctors_SelectedIndexChanged_1);
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(213, 488);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(256, 22);
            this.EndDate.TabIndex = 166;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(214, 222);
            this.txtSpecialty.MaxLength = 30;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.ReadOnly = true;
            this.txtSpecialty.Size = new System.Drawing.Size(208, 22);
            this.txtSpecialty.TabIndex = 165;
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Location = new System.Drawing.Point(145, 71);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(61, 17);
            this.lblDoctors.TabIndex = 164;
            this.lblDoctors.Text = "Doctors:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(80, 149);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(126, 17);
            this.lblDoctor.TabIndex = 163;
            this.lblDoctor.Text = "Doctor Last Name:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(138, 493);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(71, 17);
            this.lblEndDate.TabIndex = 162;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(328, 580);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 161;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnAddResearch
            // 
            this.btnAddResearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddResearch.Location = new System.Drawing.Point(16, 580);
            this.btnAddResearch.Name = "btnAddResearch";
            this.btnAddResearch.Size = new System.Drawing.Size(177, 59);
            this.btnAddResearch.TabIndex = 160;
            this.btnAddResearch.Text = "Add Research Project";
            this.btnAddResearch.UseVisualStyleBackColor = false;
            this.btnAddResearch.Click += new System.EventHandler(this.btnAddResearch_Click_1);
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(138, 225);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(69, 17);
            this.lblSpecialty.TabIndex = 159;
            this.lblSpecialty.Text = "Specialty:";
            // 
            // Add_Research_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 659);
            this.Controls.Add(this.numBudget);
            this.Controls.Add(this.cboOutcome);
            this.Controls.Add(this.dgvResearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAddResearch);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.cboResearchTopics);
            this.Controls.Add(this.lblResearch);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.cboDoctors);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddResearch);
            this.Controls.Add(this.lblSpecialty);
            this.Name = "Add_Research_Project";
            this.Text = "Add Research Project";
            this.Load += new System.EventHandler(this.Add_Research_Project_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBudget;
        private System.Windows.Forms.ComboBox cboOutcome;
        private System.Windows.Forms.DataGridView dgvResearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddResearch;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cboResearchTopics;
        private System.Windows.Forms.Label lblResearch;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddResearch;
        private System.Windows.Forms.Label lblSpecialty;
    }
}