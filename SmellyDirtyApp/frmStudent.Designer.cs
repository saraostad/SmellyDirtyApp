namespace SmellyDirtyApp
{
    partial class frmStudent
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
            this.pnlucDynamicFild = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRight.SuspendLayout();
            this.pnlUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaseInfo
            // 
            this.pnlRight.Controls.Add(this.pnlucDynamicFild);
            this.pnlRight.Controls.SetChildIndex(this.tbNationalCode, 0);
            this.pnlRight.Controls.SetChildIndex(this.tbMobile, 0);
            this.pnlRight.Controls.SetChildIndex(this.tbBirthCertificate, 0);
            this.pnlRight.Controls.SetChildIndex(this.tbLastName, 0);
            this.pnlRight.Controls.SetChildIndex(this.tbFirstName, 0);
            this.pnlRight.Controls.SetChildIndex(this.label5, 0);
            this.pnlRight.Controls.SetChildIndex(this.label4, 0);
            this.pnlRight.Controls.SetChildIndex(this.label3, 0);
            this.pnlRight.Controls.SetChildIndex(this.label2, 0);
            this.pnlRight.Controls.SetChildIndex(this.label1, 0);
            this.pnlRight.Controls.SetChildIndex(this.btnEditProfile, 0);
            this.pnlRight.Controls.SetChildIndex(this.pnlucDynamicFild, 0);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Controls.Add(this.panel1);
            // 
            // pnlucDynamicFild
            // 
            this.pnlucDynamicFild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlucDynamicFild.Location = new System.Drawing.Point(0, 152);
            this.pnlucDynamicFild.Name = "pnlucDynamicFild";
            this.pnlucDynamicFild.Size = new System.Drawing.Size(232, 51);
            this.pnlucDynamicFild.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 51);
            this.panel1.TabIndex = 24;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(504, 252);
            this.Name = "frmStudent";
            this.Text = "پروفایل دانشجو";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlUserControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlucDynamicFild;
        private System.Windows.Forms.Panel panel1;
    }
}
