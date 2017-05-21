namespace Shell.DataView
{
    partial class frmEditSA
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
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuestionCode = new System.Windows.Forms.TextBox();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.customFlowLayoutPanel1 = new Shell.DataView.CustomFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 593);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblQuestionCode
            // 
            this.lblQuestionCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionCode.Location = new System.Drawing.Point(13, 12);
            this.lblQuestionCode.Multiline = true;
            this.lblQuestionCode.Name = "lblQuestionCode";
            this.lblQuestionCode.Size = new System.Drawing.Size(665, 50);
            this.lblQuestionCode.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(603, 593);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // customFlowLayoutPanel1
            // 
            this.customFlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customFlowLayoutPanel1.AutoSize = true;
            this.customFlowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.customFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.customFlowLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.customFlowLayoutPanel1.Name = "customFlowLayoutPanel1";
            this.customFlowLayoutPanel1.Size = new System.Drawing.Size(666, 519);
            this.customFlowLayoutPanel1.TabIndex = 6;
            // 
            // frmEditSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 628);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblQuestionCode);
            this.Controls.Add(this.customFlowLayoutPanel1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmEditSA";
            this.Text = "Edit SA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private CustomFlowLayoutPanel customFlowLayoutPanel1;
        private System.Windows.Forms.TextBox lblQuestionCode;
        private DevExpress.XtraEditors.SimpleButton btnClear;

    }
}