namespace SmellyDirtyApp
{
    partial class TeacherForm
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
            this.btnOfferCourses = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.btnCalsSalary = new System.Windows.Forms.Button();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlBaseInfo = new System.Windows.Forms.Panel();
            this.pnlBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "کد کارمندی";
            // 
            // tbEmployeeCode
            // 
            this.tbEmployeeCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmployeeCode.Location = new System.Drawing.Point(28, 26);
            this.tbEmployeeCode.Name = "tbEmployeeCode";
            this.tbEmployeeCode.Size = new System.Drawing.Size(100, 20);
            this.tbEmployeeCode.TabIndex = 12;
            // 
            // btnOfferCourses
            // 
            this.btnOfferCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfferCourses.Location = new System.Drawing.Point(21, 19);
            this.btnOfferCourses.Name = "btnOfferCourses";
            this.btnOfferCourses.Size = new System.Drawing.Size(91, 23);
            this.btnOfferCourses.TabIndex = 13;
            this.btnOfferCourses.Text = "ارائه کلاس";
            this.btnOfferCourses.UseVisualStyleBackColor = true;
            this.btnOfferCourses.Click += new System.EventHandler(this.btnOfferCourses_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitProgram.Location = new System.Drawing.Point(13, 191);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(91, 23);
            this.btnExitProgram.TabIndex = 15;
            this.btnExitProgram.Text = "خروج از سیستم";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.Location = new System.Drawing.Point(120, 191);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(91, 23);
            this.btnCloseForm.TabIndex = 16;
            this.btnCloseForm.Text = "خروج";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnRegisterScore
            // 
            this.btnRegisterScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterScore.Location = new System.Drawing.Point(21, 45);
            this.btnRegisterScore.Name = "btnRegisterScore";
            this.btnRegisterScore.Size = new System.Drawing.Size(91, 23);
            this.btnRegisterScore.TabIndex = 17;
            this.btnRegisterScore.Text = "ثبت نمرات";
            this.btnRegisterScore.UseVisualStyleBackColor = true;
            this.btnRegisterScore.Click += new System.EventHandler(this.btnRegisterScore_Click);
            // 
            // btnCalsSalary
            // 
            this.btnCalsSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalsSalary.Location = new System.Drawing.Point(21, 90);
            this.btnCalsSalary.Name = "btnCalsSalary";
            this.btnCalsSalary.Size = new System.Drawing.Size(91, 23);
            this.btnCalsSalary.TabIndex = 18;
            this.btnCalsSalary.Text = "محاسبه حقوق";
            this.btnCalsSalary.UseVisualStyleBackColor = true;
            this.btnCalsSalary.Click += new System.EventHandler(this.btnCalsSalary_Click);
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkHours.Location = new System.Drawing.Point(130, 90);
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(100, 20);
            this.txtWorkHours.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ساعات آموزش";
            // 
            // pnlBaseInfo
            // 
            this.pnlBaseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBaseInfo.Controls.Add(this.label6);
            this.pnlBaseInfo.Controls.Add(this.tbEmployeeCode);
            this.pnlBaseInfo.Location = new System.Drawing.Point(323, 0);
            this.pnlBaseInfo.Name = "pnlBaseInfo";
            this.pnlBaseInfo.Size = new System.Drawing.Size(246, 226);
            this.pnlBaseInfo.TabIndex = 21;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 227);
            this.Controls.Add(this.pnlBaseInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWorkHours);
            this.Controls.Add(this.btnCalsSalary);
            this.Controls.Add(this.btnRegisterScore);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnOfferCourses);
            this.Name = "TeacherForm";
            this.Text = "پروفایل اساتید";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.pnlBaseInfo.ResumeLayout(false);
            this.pnlBaseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmployeeCode;
        private System.Windows.Forms.Button btnOfferCourses;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnRegisterScore;
        private System.Windows.Forms.Button btnCalsSalary;
        private System.Windows.Forms.TextBox txtWorkHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlBaseInfo;
    }
}