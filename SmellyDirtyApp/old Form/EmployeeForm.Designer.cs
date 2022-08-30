namespace SmellyDirtyApp
{
    partial class EmployeeForm
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
            this.btnOfferCourses = new System.Windows.Forms.Button();
            this.btnInsertResult = new System.Windows.Forms.Button();
            this.btnCalculateSalary = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNationalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBirthCertificate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbStudentCode = new System.Windows.Forms.TextBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWorkDay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOfferCourses
            // 
            this.btnOfferCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfferCourses.Location = new System.Drawing.Point(26, 19);
            this.btnOfferCourses.Name = "btnOfferCourses";
            this.btnOfferCourses.Size = new System.Drawing.Size(91, 23);
            this.btnOfferCourses.TabIndex = 13;
            this.btnOfferCourses.Text = "ارائه کلاس";
            this.btnOfferCourses.UseVisualStyleBackColor = true;
            this.btnOfferCourses.Click += new System.EventHandler(this.btnOfferCourses_Click);
            // 
            // btnInsertResult
            // 
            this.btnInsertResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertResult.Location = new System.Drawing.Point(26, 48);
            this.btnInsertResult.Name = "btnInsertResult";
            this.btnInsertResult.Size = new System.Drawing.Size(91, 23);
            this.btnInsertResult.TabIndex = 17;
            this.btnInsertResult.Text = "ثبت نمرات";
            this.btnInsertResult.UseVisualStyleBackColor = true;
            this.btnInsertResult.Click += new System.EventHandler(this.btnInsertResult_Click);
            // 
            // btnCalculateSalary
            // 
            this.btnCalculateSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculateSalary.Location = new System.Drawing.Point(26, 106);
            this.btnCalculateSalary.Name = "btnCalculateSalary";
            this.btnCalculateSalary.Size = new System.Drawing.Size(91, 23);
            this.btnCalculateSalary.TabIndex = 18;
            this.btnCalculateSalary.Text = "محاسبه حقوق";
            this.btnCalculateSalary.UseVisualStyleBackColor = true;
            this.btnCalculateSalary.Click += new System.EventHandler(this.btnCalculateSalary_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEditProfile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbMobile);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNationalCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbBirthCertificate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbStudentCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(322, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 221);
            this.panel1.TabIndex = 27;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(27, 16);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProfile.Location = new System.Drawing.Point(27, 182);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(100, 23);
            this.btnEditProfile.TabIndex = 23;
            this.btnEditProfile.Text = "ویرایش پروفایل";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "شماره شناسنامه";
            // 
            // tbMobile
            // 
            this.tbMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMobile.Location = new System.Drawing.Point(27, 120);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(100, 20);
            this.tbMobile.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "کد ملی";
            // 
            // tbNationalCode
            // 
            this.tbNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNationalCode.Location = new System.Drawing.Point(27, 94);
            this.tbNationalCode.Name = "tbNationalCode";
            this.tbNationalCode.Size = new System.Drawing.Size(100, 20);
            this.tbNationalCode.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "شماره همراه";
            // 
            // tbBirthCertificate
            // 
            this.tbBirthCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBirthCertificate.Location = new System.Drawing.Point(27, 68);
            this.tbBirthCertificate.Name = "tbBirthCertificate";
            this.tbBirthCertificate.Size = new System.Drawing.Size(100, 20);
            this.tbBirthCertificate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "کد کارمندی";
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(27, 42);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 19;
            // 
            // tbStudentCode
            // 
            this.tbStudentCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudentCode.Location = new System.Drawing.Point(27, 146);
            this.tbStudentCode.Name = "tbStudentCode";
            this.tbStudentCode.Size = new System.Drawing.Size(100, 20);
            this.tbStudentCode.TabIndex = 12;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.Location = new System.Drawing.Point(123, 182);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(91, 23);
            this.btnCloseForm.TabIndex = 29;
            this.btnCloseForm.Text = "خروج";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitProgram.Location = new System.Drawing.Point(26, 182);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(91, 23);
            this.btnExitProgram.TabIndex = 28;
            this.btnExitProgram.Text = "خروج از سیستم";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "تعداد روز کارکرد";
            // 
            // txtWorkDay
            // 
            this.txtWorkDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkDay.Location = new System.Drawing.Point(123, 106);
            this.txtWorkDay.Name = "txtWorkDay";
            this.txtWorkDay.Size = new System.Drawing.Size(100, 20);
            this.txtWorkDay.TabIndex = 30;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 221);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWorkDay);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculateSalary);
            this.Controls.Add(this.btnInsertResult);
            this.Controls.Add(this.btnOfferCourses);
            this.Name = "EmployeeForm";
            this.Text = "پروفایل کارکنان";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOfferCourses;
        private System.Windows.Forms.Button btnInsertResult;
        private System.Windows.Forms.Button btnCalculateSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNationalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBirthCertificate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbStudentCode;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWorkDay;
    }
}