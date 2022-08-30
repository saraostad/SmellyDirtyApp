namespace SmellyDirtyApp.UserControls.btn
{
    partial class ucbtnShowResult
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
            this.btnSeeResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeeResult
            // 
            this.btnSeeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeResult.Location = new System.Drawing.Point(3, 3);
            this.btnSeeResult.Name = "btnSeeResult";
            this.btnSeeResult.Size = new System.Drawing.Size(91, 23);
            this.btnSeeResult.TabIndex = 18;
            this.btnSeeResult.Text = "دیدن کارنامه";
            this.btnSeeResult.UseVisualStyleBackColor = true;
            // 
            // ucShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSeeResult);
            this.Name = "ucShowResult";
            this.Size = new System.Drawing.Size(97, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeeResult;
    }
}
