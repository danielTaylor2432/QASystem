namespace QAWebsite
{
    partial class DashboardPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.QAReportPage = new System.Windows.Forms.Button();
            this.QADesPage = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.QAReportPage);
            this.panel1.Controls.Add(this.QADesPage);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 50);
            this.panel1.TabIndex = 6;
            // 
            // QAReportPage
            // 
            this.QAReportPage.Location = new System.Drawing.Point(15, 15);
            this.QAReportPage.Name = "QAReportPage";
            this.QAReportPage.Size = new System.Drawing.Size(127, 23);
            this.QAReportPage.TabIndex = 3;
            this.QAReportPage.Text = "Detailed Qa Report";
            this.QAReportPage.UseVisualStyleBackColor = true;
            this.QAReportPage.Click += new System.EventHandler(this.QAReportPage_Click);
            // 
            // QADesPage
            // 
            this.QADesPage.Location = new System.Drawing.Point(344, 15);
            this.QADesPage.Name = "QADesPage";
            this.QADesPage.Size = new System.Drawing.Size(103, 23);
            this.QADesPage.TabIndex = 2;
            this.QADesPage.Text = "QA Descriptions";
            this.QADesPage.UseVisualStyleBackColor = true;
            this.QADesPage.Click += new System.EventHandler(this.QADesPage_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(682, 15);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QAReportPage;
        private System.Windows.Forms.Button QADesPage;
        private System.Windows.Forms.Button homeButton;
    }
}