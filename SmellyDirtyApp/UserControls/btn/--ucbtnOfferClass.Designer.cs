namespace SmellyDirtyApp.UserControls
{
    partial class ucbtnOfferClass
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
            this.btnOfferCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOfferCourses
            // 
            this.btnOfferCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfferCourses.Location = new System.Drawing.Point(3, 3);
            this.btnOfferCourses.Name = "btnOfferCourses";
            this.btnOfferCourses.Size = new System.Drawing.Size(91, 23);
            this.btnOfferCourses.TabIndex = 14;
            this.btnOfferCourses.Text = "ارائه کلاس";
            this.btnOfferCourses.UseVisualStyleBackColor = true;
            // 
            // ucOfferClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOfferCourses);
            this.Name = "ucOfferClass";
            this.Size = new System.Drawing.Size(97, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOfferCourses;
    }
}
