namespace SmellyDirtyApp
{
    partial class frmTeacher
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.btnCalsSalary = new System.Windows.Forms.Button();
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.btnOfferCourses = new System.Windows.Forms.Button();
            this.pnlRight.SuspendLayout();
            this.pnlUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaseInfo
            // 
            this.pnlRight.Location = new System.Drawing.Point(312, 0);
            this.pnlRight.Size = new System.Drawing.Size(232, 262);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(181, 227);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(12, 227);
            // 
            // tbMobile
            // 
            this.tbMobile.TextChanged += new System.EventHandler(this.tbMobile_TextChanged);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Controls.Add(this.label7);
            this.pnlUserControl.Controls.Add(this.txtWorkHours);
            this.pnlUserControl.Controls.Add(this.btnCalsSalary);
            this.pnlUserControl.Controls.Add(this.btnRegisterScore);
            this.pnlUserControl.Controls.Add(this.btnOfferCourses);
            this.pnlUserControl.Size = new System.Drawing.Size(312, 169);
            // 
            // pnlCalculateSalary
            // 
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "ساعات آموزش";
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkHours.Location = new System.Drawing.Point(124, 111);
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(100, 20);
            this.txtWorkHours.TabIndex = 24;
            // 
            // btnCalsSalary
            // 
            this.btnCalsSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalsSalary.Location = new System.Drawing.Point(15, 111);
            this.btnCalsSalary.Name = "btnCalsSalary";
            this.btnCalsSalary.Size = new System.Drawing.Size(91, 23);
            this.btnCalsSalary.TabIndex = 23;
            this.btnCalsSalary.Text = "محاسبه حقوق";
            this.btnCalsSalary.UseVisualStyleBackColor = true;
            this.btnCalsSalary.Click += new System.EventHandler(this.btnCalsSalary_Click);
            // 
            // btnRegisterScore
            // 
            this.btnRegisterScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterScore.Location = new System.Drawing.Point(15, 66);
            this.btnRegisterScore.Name = "btnRegisterScore";
            this.btnRegisterScore.Size = new System.Drawing.Size(91, 23);
            this.btnRegisterScore.TabIndex = 22;
            this.btnRegisterScore.Text = "ثبت نمرات";
            this.btnRegisterScore.UseVisualStyleBackColor = true;
            this.btnRegisterScore.Click += new System.EventHandler(this.btnRegisterScore_Click);
            // 
            // btnOfferCourses
            // 
            this.btnOfferCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfferCourses.Location = new System.Drawing.Point(15, 40);
            this.btnOfferCourses.Name = "btnOfferCourses";
            this.btnOfferCourses.Size = new System.Drawing.Size(91, 23);
            this.btnOfferCourses.TabIndex = 21;
            this.btnOfferCourses.Text = "ارائه کلاس";
            this.btnOfferCourses.UseVisualStyleBackColor = true;
            this.btnOfferCourses.Click += new System.EventHandler(this.btnOfferCourses_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 262);
            this.Name = "frmTeacher";
            this.Text = "پروفایل استاتید";
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlUserControl.ResumeLayout(false);
            this.pnlUserControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkHours;
        private System.Windows.Forms.Button btnCalsSalary;
        private System.Windows.Forms.Button btnRegisterScore;
        private System.Windows.Forms.Button btnOfferCourses;
    }
}
