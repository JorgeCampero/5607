
namespace StAlbertHospitalAssessment
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
            this.btnAddAdmission = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateAdmission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAdmission
            // 
            this.btnAddAdmission.Location = new System.Drawing.Point(34, 12);
            this.btnAddAdmission.Name = "btnAddAdmission";
            this.btnAddAdmission.Size = new System.Drawing.Size(159, 71);
            this.btnAddAdmission.TabIndex = 0;
            this.btnAddAdmission.Text = "Add Admission";
            this.btnAddAdmission.UseVisualStyleBackColor = true;
            this.btnAddAdmission.Click += new System.EventHandler(this.btnAddAdmission_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(606, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 71);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateAdmission
            // 
            this.btnUpdateAdmission.Location = new System.Drawing.Point(34, 112);
            this.btnUpdateAdmission.Name = "btnUpdateAdmission";
            this.btnUpdateAdmission.Size = new System.Drawing.Size(159, 71);
            this.btnUpdateAdmission.TabIndex = 2;
            this.btnUpdateAdmission.Text = "Update Admission";
            this.btnUpdateAdmission.UseVisualStyleBackColor = true;
            this.btnUpdateAdmission.Click += new System.EventHandler(this.btnUpdateAdmission_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 565);
            this.Controls.Add(this.btnUpdateAdmission);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAdmission);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAdmission;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdateAdmission;
    }
}

