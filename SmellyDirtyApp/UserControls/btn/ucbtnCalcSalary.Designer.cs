namespace SmellyDirtyApp.UserControls
{
    partial class ucbtnCalcSalary
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
            this.btnCalsSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalsSalary
            // 
            this.btnCalsSalary.Location = new System.Drawing.Point(3, 3);
            this.btnCalsSalary.Name = "btnCalsSalary";
            this.btnCalsSalary.Size = new System.Drawing.Size(91, 23);
            this.btnCalsSalary.TabIndex = 19;
            this.btnCalsSalary.Text = "محاسبه حقوق";
            this.btnCalsSalary.UseVisualStyleBackColor = true;
            // 
            // ucbtnCalcSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalsSalary);
            this.Name = "ucbtnCalcSalary";
            this.Size = new System.Drawing.Size(98, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalsSalary;
    }
}
