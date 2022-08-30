namespace SmellyDirtyApp.UserControls
{
    partial class ucbtnInsertPoint
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
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterScore
            // 
            this.btnRegisterScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterScore.Location = new System.Drawing.Point(2, 3);
            this.btnRegisterScore.Name = "btnRegisterScore";
            this.btnRegisterScore.Size = new System.Drawing.Size(91, 23);
            this.btnRegisterScore.TabIndex = 18;
            this.btnRegisterScore.Text = "ثبت نمرات";
            this.btnRegisterScore.UseVisualStyleBackColor = true;
            // 
            // ucInsertPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegisterScore);
            this.Name = "ucInsertPoint";
            this.Size = new System.Drawing.Size(96, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterScore;
    }
}
