
namespace StAlbertAssessment2
{
    partial class Produce_Admissions_Report
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
            this.TxtAdmissions = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAdmissions
            // 
            this.TxtAdmissions.Location = new System.Drawing.Point(22, 67);
            this.TxtAdmissions.Multiline = true;
            this.TxtAdmissions.Name = "TxtAdmissions";
            this.TxtAdmissions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAdmissions.Size = new System.Drawing.Size(654, 468);
            this.TxtAdmissions.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(403, 541);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 151;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDisplayReport.Location = new System.Drawing.Point(91, 541);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(177, 59);
            this.btnDisplayReport.TabIndex = 150;
            this.btnDisplayReport.Text = "Generate Report";
            this.btnDisplayReport.UseVisualStyleBackColor = false;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 55);
            this.label1.TabIndex = 152;
            this.label1.Text = "Admissions Report";
            // 
            // Produce_Admissions_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.TxtAdmissions);
            this.Name = "Produce_Admissions_Report";
            this.Text = "Produce Admissions Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAdmissions;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Label label1;
    }
}