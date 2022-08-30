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
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmployeeCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.btnCalsSalary = new System.Windows.Forms.Button();
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.btnOfferCourses = new System.Windows.Forms.Button();
            this.pnlBaseInfo.SuspendLayout();
            this.pnlUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaseInfo
            // 
            this.pnlBaseInfo.Controls.Add(this.label6);
            this.pnlBaseInfo.Controls.Add(this.tbEmployeeCode);
            this.pnlBaseInfo.Location = new System.Drawing.Point(312, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.tbNationalCode, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.tbMobile, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.tbBirthCertificate, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.tbLastName, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.tbFirstName, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.label5, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.label4, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.label3, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.label2, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.label1, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.btnEditProfile, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.tbEmployeeCode, 0);
            this.pnlBaseInfo.Controls.SetChildIndex(this.label6, 0);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(184, 217);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(15, 217);
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
            this.pnlUserControl.Size = new System.Drawing.Size(312, 190);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "کد کارمندی";
            // 
            // tbEmployeeCode
            // 
            this.tbEmployeeCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmployeeCode.Location = new System.Drawing.Point(21, 151);
            this.tbEmployeeCode.Name = "tbEmployeeCode";
            this.tbEmployeeCode.Size = new System.Drawing.Size(100, 20);
            this.tbEmployeeCode.TabIndex = 24;
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
            this.ClientSize = new System.Drawing.Size(544, 252);
            this.Name = "frmTeacher";
            this.Text = "پروفایل استاتید";
            this.pnlBaseInfo.ResumeLayout(false);
            this.pnlBaseInfo.PerformLayout();
            this.pnlUserControl.ResumeLayout(false);
            this.pnlUserControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmployeeCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkHours;
        private System.Windows.Forms.Button btnCalsSalary;
        private System.Windows.Forms.Button btnRegisterScore;
        private System.Windows.Forms.Button btnOfferCourses;
    }
}
