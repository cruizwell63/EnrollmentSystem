
namespace EnrollmentSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.MName = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.CredsCorner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.BDate = new System.Windows.Forms.DateTimePicker();
            this.FillFields = new System.Windows.Forms.Label();
            this.PassMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(133, 67);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(148, 22);
            this.Username.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(133, 117);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(148, 22);
            this.Password.TabIndex = 1;
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Location = new System.Drawing.Point(133, 170);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.PasswordChar = '*';
            this.ConfirmPass.Size = new System.Drawing.Size(148, 22);
            this.ConfirmPass.TabIndex = 2;
            // 
            // MName
            // 
            this.MName.Location = new System.Drawing.Point(133, 349);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(148, 22);
            this.MName.TabIndex = 4;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(133, 295);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(148, 22);
            this.Fname.TabIndex = 3;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(133, 402);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(148, 22);
            this.Lname.TabIndex = 5;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(133, 457);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(148, 24);
            this.Gender.TabIndex = 6;
            this.Gender.Text = "Male";
            // 
            // CredsCorner
            // 
            this.CredsCorner.AutoSize = true;
            this.CredsCorner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CredsCorner.Location = new System.Drawing.Point(12, 18);
            this.CredsCorner.Name = "CredsCorner";
            this.CredsCorner.Size = new System.Drawing.Size(111, 25);
            this.CredsCorner.TabIndex = 8;
            this.CredsCorner.Text = "Credentials";
            this.CredsCorner.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Personal Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "MiddleName:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Last Name:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Birthdate:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(146, 565);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(103, 33);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BDate
            // 
            this.BDate.Location = new System.Drawing.Point(133, 511);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(148, 22);
            this.BDate.TabIndex = 7;
            // 
            // FillFields
            // 
            this.FillFields.AutoSize = true;
            this.FillFields.ForeColor = System.Drawing.Color.Red;
            this.FillFields.Location = new System.Drawing.Point(134, 37);
            this.FillFields.Name = "FillFields";
            this.FillFields.Size = new System.Drawing.Size(152, 17);
            this.FillFields.TabIndex = 20;
            this.FillFields.Text = "*Please fill up all fields.";
            this.FillFields.Visible = false;
            // 
            // PassMatch
            // 
            this.PassMatch.AutoSize = true;
            this.PassMatch.ForeColor = System.Drawing.Color.Red;
            this.PassMatch.Location = new System.Drawing.Point(130, 204);
            this.PassMatch.Name = "PassMatch";
            this.PassMatch.Size = new System.Drawing.Size(174, 17);
            this.PassMatch.TabIndex = 21;
            this.PassMatch.Text = "*Passwords did not match.";
            this.PassMatch.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 717);
            this.Controls.Add(this.PassMatch);
            this.Controls.Add(this.FillFields);
            this.Controls.Add(this.BDate);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CredsCorner);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.TextBox MName;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label CredsCorner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.DateTimePicker BDate;
        private System.Windows.Forms.Label FillFields;
        private System.Windows.Forms.Label PassMatch;
    }
}