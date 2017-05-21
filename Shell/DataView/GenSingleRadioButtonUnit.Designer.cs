namespace Shell.DataView
{
    partial class GenSingleRadioButtonUnit
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
            this.customFlowLayoutPanel1 = new CustomFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // customFlowLayoutPanel1
            // 
            this.customFlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.customFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.customFlowLayoutPanel1.Name = "customFlowLayoutPanel1";
            this.customFlowLayoutPanel1.Size = new System.Drawing.Size(526, 31);
            this.customFlowLayoutPanel1.TabIndex = 0;
            this.customFlowLayoutPanel1.Resize += new System.EventHandler(this.customFlowLayoutPanel1_Resize);
            // 
            // GenSingleRadioButtonUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customFlowLayoutPanel1);
            this.Name = "GenSingleRadioButtonUnit";
            this.Size = new System.Drawing.Size(526, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFlowLayoutPanel customFlowLayoutPanel1;

    }
}
