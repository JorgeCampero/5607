
namespace StAlbertAssessment2
{
    partial class Produce_Research_Projects_Report
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.txtResearchProjects = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Location = new System.Drawing.Point(402, 541);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 59);
            this.btnReturn.TabIndex = 154;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDisplayReport.Location = new System.Drawing.Point(90, 541);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(177, 59);
            this.btnDisplayReport.TabIndex = 153;
            this.btnDisplayReport.Text = "Generate Report";
            this.btnDisplayReport.UseVisualStyleBackColor = false;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // txtResearchProjects
            // 
            this.txtResearchProjects.Location = new System.Drawing.Point(21, 12);
            this.txtResearchProjects.Multiline = true;
            this.txtResearchProjects.Name = "txtResearchProjects";
            this.txtResearchProjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResearchProjects.Size = new System.Drawing.Size(654, 523);
            this.txtResearchProjects.TabIndex = 152;
            // 
            // Produce_Research_Projects_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 620);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.txtResearchProjects);
            this.Name = "Produce_Research_Projects_Report";
            this.Text = "Produce Research Projects Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.TextBox txtResearchProjects;
    }
}