
namespace EnrollmentSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterLnkLbl = new System.Windows.Forms.LinkLabel();
            this.Errormsg1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginUserName
            // 
            this.LoginUserName.Location = new System.Drawing.Point(165, 118);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(177, 22);
            this.LoginUserName.TabIndex = 0;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(165, 201);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(177, 22);
            this.LoginPassword.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(217, 268);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 28);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(163, 91);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(81, 17);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password :";
            // 
            // RegisterLnkLbl
            // 
            this.RegisterLnkLbl.AutoSize = true;
            this.RegisterLnkLbl.Location = new System.Drawing.Point(170, 315);
            this.RegisterLnkLbl.Name = "RegisterLnkLbl";
            this.RegisterLnkLbl.Size = new System.Drawing.Size(167, 17);
            this.RegisterLnkLbl.TabIndex = 5;
            this.RegisterLnkLbl.TabStop = true;
            this.RegisterLnkLbl.Text = "No account yet? Sign up.";
            this.RegisterLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLnkLbl_LinkClicked);
            // 
            // Errormsg1
            // 
            this.Errormsg1.AutoSize = true;
            this.Errormsg1.ForeColor = System.Drawing.Color.Red;
            this.Errormsg1.Location = new System.Drawing.Point(154, 235);
            this.Errormsg1.Name = "Errormsg1";
            this.Errormsg1.Size = new System.Drawing.Size(204, 17);
            this.Errormsg1.TabIndex = 7;
            this.Errormsg1.Text = "*Invalid Username or Password";
            this.Errormsg1.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.Errormsg1);
            this.Controls.Add(this.RegisterLnkLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUserName;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel RegisterLnkLbl;
        private System.Windows.Forms.Label Errormsg1;
    }
}

