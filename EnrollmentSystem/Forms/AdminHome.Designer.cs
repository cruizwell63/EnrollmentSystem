
namespace EnrollmentSystem
{
    partial class AdminHome
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
            this.btnGenPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(681, 29);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(79, 43);
            this.btnGenPass.TabIndex = 0;
            this.btnGenPass.Text = "Generate Password";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.btnGenPass_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenPass);
            this.Name = "AdminHome";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenPass;
    }
}