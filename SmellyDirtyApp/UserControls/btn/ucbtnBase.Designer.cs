namespace SmellyDirtyApp.UserControls.btn
{
    partial class ucbtnBase
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
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Location = new System.Drawing.Point(2, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(91, 23);
            this.btn.TabIndex = 19;
            this.btn.Text = "Base btn";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // ucbtnBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Name = "ucbtnBase";
            this.Size = new System.Drawing.Size(96, 30);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btn;
    }
}
