namespace Shell
{
    partial class FWProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gProfile = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewData = new DevExpress.XtraEditors.SimpleButton();
            this.btnF5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gProfile
            // 
            this.gProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gProfile.Location = new System.Drawing.Point(3, 3);
            this.gProfile.MainView = this.gridView1;
            this.gProfile.Name = "gProfile";
            this.gProfile.Size = new System.Drawing.Size(714, 406);
            this.gProfile.TabIndex = 22;
            this.gProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gProfile;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "[Data Submitted By]", null, "Tổng bài ={0:n0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(3, 415);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(103, 23);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewData.Location = new System.Drawing.Point(603, 415);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(103, 23);
            this.btnViewData.TabIndex = 24;
            this.btnViewData.Text = "Xem data";
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnF5
            // 
            this.btnF5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF5.Location = new System.Drawing.Point(112, 415);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(103, 23);
            this.btnF5.TabIndex = 25;
            this.btnF5.Text = "Làm mới";
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // FWProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gProfile);
            this.Name = "FWProfile";
            this.Size = new System.Drawing.Size(720, 447);
            ((System.ComponentModel.ISupportInitialize)(this.gProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gProfile;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnViewData;
        private DevExpress.XtraEditors.SimpleButton btnF5;
    }
}
