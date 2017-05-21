namespace Shell
{
    partial class frmViewData
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
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gAnswer = new DevExpress.XtraGrid.GridControl();
            this.gvAnswer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSupConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.TabControls = new DevExpress.XtraTab.XtraTabControl();
            this.TabData = new DevExpress.XtraTab.XtraTabPage();
            this.TabPic = new DevExpress.XtraTab.XtraTabPage();
            this.imageRespondent1 = new Shell.DataView.ImageRespondent();
            this.TabTime = new DevExpress.XtraTab.XtraTabPage();
            this.timeDuration1 = new Shell.DataView.TimeDuration();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnUncheck = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControls)).BeginInit();
            this.TabControls.SuspendLayout();
            this.TabData.SuspendLayout();
            this.TabPic.SuspendLayout();
            this.TabTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // gAnswer
            // 
            this.gAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gAnswer.Location = new System.Drawing.Point(0, 0);
            this.gAnswer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gAnswer.LookAndFeel.UseWindowsXPTheme = true;
            this.gAnswer.MainView = this.gvAnswer;
            this.gAnswer.Name = "gAnswer";
            this.gAnswer.Size = new System.Drawing.Size(548, 417);
            this.gAnswer.TabIndex = 16;
            this.gAnswer.TabStop = false;
            this.gAnswer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnswer});
            // 
            // gvAnswer
            // 
            this.gvAnswer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn1,
            this.gridColumn3});
            this.gvAnswer.GridControl = this.gAnswer;
            this.gvAnswer.Name = "gvAnswer";
            this.gvAnswer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAnswer.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvAnswer.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvAnswer.OptionsSelection.UseIndicatorForSelection = false;
            this.gvAnswer.OptionsView.RowAutoHeight = true;
            this.gvAnswer.OptionsView.ShowGroupPanel = false;
            this.gvAnswer.OptionsView.ShowIndicator = false;
            this.gvAnswer.DoubleClick += new System.EventHandler(this.gvAnswer_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FieldName";
            this.gridColumn2.FieldName = "FieldName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 80;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Question";
            this.gridColumn4.FieldName = "QuestionID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn6.Caption = "Câu trả lời";
            this.gridColumn6.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn6.FieldName = "AnswerText";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 560;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "QuestionID";
            this.gridColumn7.FieldName = "QuestionID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Width = 72;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã câu hỏi";
            this.gridColumn8.FieldName = "QuestionCode";
            this.gridColumn8.MaxWidth = 100;
            this.gridColumn8.MinWidth = 100;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn1.Caption = "Nội dung câu hỏi";
            this.gridColumn1.ColumnEdit = this.repositoryItemMemoEdit2;
            this.gridColumn1.FieldName = "QuestionName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 261;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "checked";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ShowCaption = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // btnSupConfirm
            // 
            this.btnSupConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSupConfirm.Location = new System.Drawing.Point(418, 5);
            this.btnSupConfirm.Name = "btnSupConfirm";
            this.btnSupConfirm.Size = new System.Drawing.Size(121, 51);
            this.btnSupConfirm.TabIndex = 17;
            this.btnSupConfirm.Text = "Xác nhận đã chấm";
            this.btnSupConfirm.Click += new System.EventHandler(this.btnSupConfirm_Click);
            // 
            // TabControls
            // 
            this.TabControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControls.Location = new System.Drawing.Point(6, 1);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedTabPage = this.TabData;
            this.TabControls.Size = new System.Drawing.Size(554, 445);
            this.TabControls.TabIndex = 21;
            this.TabControls.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabData,
            this.TabPic,
            this.TabTime});
            this.TabControls.Click += new System.EventHandler(this.TabControls_Click);
            // 
            // TabData
            // 
            this.TabData.Controls.Add(this.gAnswer);
            this.TabData.Name = "TabData";
            this.TabData.Size = new System.Drawing.Size(548, 417);
            this.TabData.Text = "Nội dung trả lời";
            // 
            // TabPic
            // 
            this.TabPic.Controls.Add(this.imageRespondent1);
            this.TabPic.Name = "TabPic";
            this.TabPic.Size = new System.Drawing.Size(548, 417);
            this.TabPic.Text = "Hình ảnh";
            // 
            // imageRespondent1
            // 
            this.imageRespondent1.AnswerID = null;
            this.imageRespondent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageRespondent1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageRespondent1.Location = new System.Drawing.Point(0, 0);
            this.imageRespondent1.Name = "imageRespondent1";
            this.imageRespondent1.ProjectID = null;
            this.imageRespondent1.Services = null;
            this.imageRespondent1.Size = new System.Drawing.Size(548, 417);
            this.imageRespondent1.TabIndex = 0;
            // 
            // TabTime
            // 
            this.TabTime.Controls.Add(this.timeDuration1);
            this.TabTime.Name = "TabTime";
            this.TabTime.Size = new System.Drawing.Size(548, 417);
            this.TabTime.Text = "Thời gian";
            // 
            // timeDuration1
            // 
            this.timeDuration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeDuration1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDuration1.Location = new System.Drawing.Point(0, 0);
            this.timeDuration1.Name = "timeDuration1";
            this.timeDuration1.Services = null;
            this.timeDuration1.Size = new System.Drawing.Size(548, 417);
            this.timeDuration1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Controls.Add(this.btnSupConfirm);
            this.panelControl1.Controls.Add(this.btnUncheck);
            this.panelControl1.Controls.Add(this.btnCheck);
            this.panelControl1.Location = new System.Drawing.Point(7, 446);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(549, 64);
            this.panelControl1.TabIndex = 22;
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = ((short)(1));
            this.radioGroup1.Location = new System.Drawing.Point(6, 5);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Mã câu hỏi bắt đầu bằng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Mã câu hỏi chứa")});
            this.radioGroup1.Size = new System.Drawing.Size(165, 51);
            this.radioGroup1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(179, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnUncheck
            // 
            this.btnUncheck.Location = new System.Drawing.Point(303, 34);
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(113, 23);
            this.btnUncheck.TabIndex = 1;
            this.btnUncheck.Text = "Uncheck";
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(303, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 514);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.TabControls);
            this.Name = "frmViewData";
            this.Text = "Xem chi tiết phiếu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControls)).EndInit();
            this.TabControls.ResumeLayout(false);
            this.TabData.ResumeLayout(false);
            this.TabPic.ResumeLayout(false);
            this.TabTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gAnswer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnswer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnSupConfirm;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraTab.XtraTabControl TabControls;
        private DevExpress.XtraTab.XtraTabPage TabData;
        private DevExpress.XtraTab.XtraTabPage TabPic;
        private DevExpress.XtraTab.XtraTabPage TabTime;
        private DataView.ImageRespondent imageRespondent1;
        private DataView.TimeDuration timeDuration1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnUncheck;
        private DevExpress.XtraEditors.SimpleButton btnCheck;
    }
}