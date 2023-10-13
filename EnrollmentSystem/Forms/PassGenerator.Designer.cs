
namespace EnrollmentSystem
{
    partial class PassGenerator
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
            this.GenPass = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenPass
            // 
            this.GenPass.Location = new System.Drawing.Point(58, 94);
            this.GenPass.Name = "GenPass";
            this.GenPass.ReadOnly = true;
            this.GenPass.Size = new System.Drawing.Size(248, 22);
            this.GenPass.TabIndex = 0;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(112, 139);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(123, 45);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.GenPass);
            this.Name = "PassGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PassGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenPass;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label1;
    }
}