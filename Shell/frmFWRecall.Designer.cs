namespace Shell
{
    partial class frmFWRecall
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
            this.TabCollection = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.respondentProfileInformation1 = new Shell.RespondentProfileInformation();
            this.TabSummaryRecuit = new DevExpress.XtraTab.XtraTabPage();
            this.summarySupRecuit1 = new Shell.SummarySupRecuit();
            this.TabValSummary = new DevExpress.XtraTab.XtraTabPage();
            this.summaryVal1 = new Shell.SummaryVal();
            this.TabSummaryQC = new DevExpress.XtraTab.XtraTabPage();
            this.summaryQC1 = new Shell.SummaryQC();
            this.TabSummaryInterview = new DevExpress.XtraTab.XtraTabPage();
            this.summarySupInterview1 = new Shell.SummarySupInterview();
            this.TabWaitting = new DevExpress.XtraTab.XtraTabPage();
            this.waittingList1 = new Shell.WaittingList();
            this.TabReport = new DevExpress.XtraTab.XtraTabPage();
            this.fwProfile1 = new Shell.FWProfile();
            ((System.ComponentModel.ISupportInitialize)(this.TabCollection)).BeginInit();
            this.TabCollection.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.TabSummaryRecuit.SuspendLayout();
            this.TabValSummary.SuspendLayout();
            this.TabSummaryQC.SuspendLayout();
            this.TabSummaryInterview.SuspendLayout();
            this.TabWaitting.SuspendLayout();
            this.TabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabCollection
            // 
            this.TabCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCollection.Location = new System.Drawing.Point(1, 5);
            this.TabCollection.Name = "TabCollection";
            this.TabCollection.SelectedTabPage = this.xtraTabPage1;
            this.TabCollection.Size = new System.Drawing.Size(1283, 653);
            this.TabCollection.TabIndex = 0;
            this.TabCollection.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.TabSummaryRecuit,
            this.TabValSummary,
            this.TabSummaryQC,
            this.TabSummaryInterview,
            this.TabWaitting,
            this.TabReport});
            this.TabCollection.Click += new System.EventHandler(this.TabCollection_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.respondentProfileInformation1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1277, 625);
            this.xtraTabPage1.Text = "Respondent Detail";
            // 
            // respondentProfileInformation1
            // 
            this.respondentProfileInformation1.AnswerID = null;
            this.respondentProfileInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.respondentProfileInformation1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respondentProfileInformation1.Location = new System.Drawing.Point(0, 0);
            this.respondentProfileInformation1.Name = "respondentProfileInformation1";
            this.respondentProfileInformation1.ProjectID = null;
            this.respondentProfileInformation1.Services = null;
            this.respondentProfileInformation1.Size = new System.Drawing.Size(1277, 625);
            this.respondentProfileInformation1.TabIndex = 0;
            this.respondentProfileInformation1.tblNhanSu = null;
            // 
            // TabSummaryRecuit
            // 
            this.TabSummaryRecuit.Controls.Add(this.summarySupRecuit1);
            this.TabSummaryRecuit.Name = "TabSummaryRecuit";
            this.TabSummaryRecuit.Size = new System.Drawing.Size(1277, 602);
            this.TabSummaryRecuit.Text = "Field Summary";
            // 
            // summarySupRecuit1
            // 
            this.summarySupRecuit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summarySupRecuit1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarySupRecuit1.Location = new System.Drawing.Point(0, 0);
            this.summarySupRecuit1.Name = "summarySupRecuit1";
            this.summarySupRecuit1.ProjectID = null;
            this.summarySupRecuit1.Services = null;
            this.summarySupRecuit1.Size = new System.Drawing.Size(1277, 602);
            this.summarySupRecuit1.TabIndex = 0;
            // 
            // TabValSummary
            // 
            this.TabValSummary.Controls.Add(this.summaryVal1);
            this.TabValSummary.Name = "TabValSummary";
            this.TabValSummary.Size = new System.Drawing.Size(1277, 602);
            this.TabValSummary.Text = "Val. Summary";
            // 
            // summaryVal1
            // 
            this.summaryVal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryVal1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryVal1.Location = new System.Drawing.Point(0, 0);
            this.summaryVal1.Name = "summaryVal1";
            this.summaryVal1.ProjectID = null;
            this.summaryVal1.Services = null;
            this.summaryVal1.Size = new System.Drawing.Size(1277, 602);
            this.summaryVal1.TabIndex = 0;
            // 
            // TabSummaryQC
            // 
            this.TabSummaryQC.Controls.Add(this.summaryQC1);
            this.TabSummaryQC.Name = "TabSummaryQC";
            this.TabSummaryQC.Size = new System.Drawing.Size(1277, 602);
            this.TabSummaryQC.Text = "QC Summary";
            // 
            // summaryQC1
            // 
            this.summaryQC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryQC1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryQC1.Location = new System.Drawing.Point(0, 0);
            this.summaryQC1.Name = "summaryQC1";
            this.summaryQC1.ProjectID = null;
            this.summaryQC1.Services = null;
            this.summaryQC1.Size = new System.Drawing.Size(1277, 602);
            this.summaryQC1.TabIndex = 0;
            // 
            // TabSummaryInterview
            // 
            this.TabSummaryInterview.Controls.Add(this.summarySupInterview1);
            this.TabSummaryInterview.Name = "TabSummaryInterview";
            this.TabSummaryInterview.Size = new System.Drawing.Size(1277, 602);
            this.TabSummaryInterview.Text = "Prod.Test Summary";
            // 
            // summarySupInterview1
            // 
            this.summarySupInterview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summarySupInterview1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarySupInterview1.Location = new System.Drawing.Point(0, 0);
            this.summarySupInterview1.Name = "summarySupInterview1";
            this.summarySupInterview1.ProjectID = null;
            this.summarySupInterview1.Services = null;
            this.summarySupInterview1.Size = new System.Drawing.Size(1277, 602);
            this.summarySupInterview1.TabIndex = 0;
            // 
            // TabWaitting
            // 
            this.TabWaitting.Controls.Add(this.waittingList1);
            this.TabWaitting.Name = "TabWaitting";
            this.TabWaitting.Size = new System.Drawing.Size(1277, 602);
            this.TabWaitting.Text = "Pickup List";
            // 
            // waittingList1
            // 
            this.waittingList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waittingList1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waittingList1.Location = new System.Drawing.Point(0, 0);
            this.waittingList1.Name = "waittingList1";
            this.waittingList1.ProjectID = null;
            this.waittingList1.Services = null;
            this.waittingList1.Size = new System.Drawing.Size(1277, 602);
            this.waittingList1.TabIndex = 0;
            // 
            // TabReport
            // 
            this.TabReport.Controls.Add(this.fwProfile1);
            this.TabReport.Name = "TabReport";
            this.TabReport.Size = new System.Drawing.Size(1277, 602);
            this.TabReport.Text = "Respondent Profile";
            // 
            // fwProfile1
            // 
            this.fwProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fwProfile1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwProfile1.Location = new System.Drawing.Point(0, 0);
            this.fwProfile1.Name = "fwProfile1";
            this.fwProfile1.ProjectID = null;
            this.fwProfile1.Services = null;
            this.fwProfile1.Size = new System.Drawing.Size(1277, 602);
            this.fwProfile1.TabIndex = 0;
            // 
            // frmFWRecall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 672);
            this.Controls.Add(this.TabCollection);
            this.MaximumSize = new System.Drawing.Size(1500, 710);
            this.MinimumSize = new System.Drawing.Size(1000, 710);
            this.Name = "frmFWRecall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FW Recall";
            ((System.ComponentModel.ISupportInitialize)(this.TabCollection)).EndInit();
            this.TabCollection.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.TabSummaryRecuit.ResumeLayout(false);
            this.TabValSummary.ResumeLayout(false);
            this.TabSummaryQC.ResumeLayout(false);
            this.TabSummaryInterview.ResumeLayout(false);
            this.TabWaitting.ResumeLayout(false);
            this.TabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabCollection;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage TabSummaryQC;
        private DevExpress.XtraTab.XtraTabPage TabSummaryInterview;
        private RespondentProfileInformation respondentProfileInformation1;
        private SummaryQC summaryQC1;
        private SummarySupInterview summarySupInterview1;
        private DevExpress.XtraTab.XtraTabPage TabSummaryRecuit;
        private SummarySupRecuit summarySupRecuit1;
        private DevExpress.XtraTab.XtraTabPage TabWaitting;
        private WaittingList waittingList1;
        private DevExpress.XtraTab.XtraTabPage TabReport;
        private FWProfile fwProfile1;
        private DevExpress.XtraTab.XtraTabPage TabValSummary;
        private SummaryVal summaryVal1;
    }
}