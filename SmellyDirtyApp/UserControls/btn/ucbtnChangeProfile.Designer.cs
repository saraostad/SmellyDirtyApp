namespace SmellyDirtyApp.UserControls
{
    partial class ucbtnChangeProfile
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProfile.Location = new System.Drawing.Point(3, 3);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(91, 23);
            this.btnEditProfile.TabIndex = 23;
            this.btnEditProfile.Text = "ویرایش پروفایل";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            // 
            // ucbtnChangeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditProfile);
            this.Name = "ucbtnChangeProfile";
            this.Size = new System.Drawing.Size(97, 29);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnEditProfile;
    }
}
