namespace Shell.DataView
{
    partial class frmEditOE
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblQuestionCode = new DevExpress.XtraEditors.LabelControl();
            this.txtOE = new System.Windows.Forms.TextBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Câu hỏi";
            // 
            // lblQuestionCode
            // 
            this.lblQuestionCode.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCode.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblQuestionCode.Location = new System.Drawing.Point(90, 8);
            this.lblQuestionCode.Name = "lblQuestionCode";
            this.lblQuestionCode.Size = new System.Drawing.Size(61, 19);
            this.lblQuestionCode.TabIndex = 1;
            this.lblQuestionCode.Text = "Câu hỏi";
            // 
            // txtOE
            // 
            this.txtOE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOE.Location = new System.Drawing.Point(12, 33);
            this.txtOE.Multiline = true;
            this.txtOE.Name = "txtOE";
            this.txtOE.Size = new System.Drawing.Size(512, 302);
            this.txtOE.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(13, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmEditDataOE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 382);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtOE);
            this.Controls.Add(this.lblQuestionCode);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmEditDataOE";
            this.Text = "Chỉnh sửa dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblQuestionCode;
        private System.Windows.Forms.TextBox txtOE;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}