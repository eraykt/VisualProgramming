namespace Week10Lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSignIn = new Button();
            loginBoxPassword = new TextBox();
            loginBoxEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnRegister = new Button();
            signUpAge = new TextBox();
            signUpAdress = new TextBox();
            signUpName = new TextBox();
            signUpPassword = new TextBox();
            signUpEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(279, 262);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSignIn);
            tabPage1.Controls.Add(loginBoxPassword);
            tabPage1.Controls.Add(loginBoxEmail);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(271, 234);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sign In";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(18, 108);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(185, 46);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // loginBoxPassword
            // 
            loginBoxPassword.Location = new Point(103, 62);
            loginBoxPassword.Name = "loginBoxPassword";
            loginBoxPassword.Size = new Size(100, 23);
            loginBoxPassword.TabIndex = 0;
            // 
            // loginBoxEmail
            // 
            loginBoxEmail.Location = new Point(103, 25);
            loginBoxEmail.Name = "loginBoxEmail";
            loginBoxEmail.Size = new Size(100, 23);
            loginBoxEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(signUpAge);
            tabPage2.Controls.Add(signUpAdress);
            tabPage2.Controls.Add(signUpName);
            tabPage2.Controls.Add(signUpPassword);
            tabPage2.Controls.Add(signUpEmail);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(271, 234);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Register";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(22, 180);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(179, 48);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // signUpAge
            // 
            signUpAge.Location = new Point(101, 141);
            signUpAge.Name = "signUpAge";
            signUpAge.Size = new Size(100, 23);
            signUpAge.TabIndex = 9;
            // 
            // signUpAdress
            // 
            signUpAdress.Location = new Point(101, 113);
            signUpAdress.Name = "signUpAdress";
            signUpAdress.Size = new Size(100, 23);
            signUpAdress.TabIndex = 8;
            // 
            // signUpName
            // 
            signUpName.Location = new Point(101, 84);
            signUpName.Name = "signUpName";
            signUpName.Size = new Size(100, 23);
            signUpName.TabIndex = 7;
            // 
            // signUpPassword
            // 
            signUpPassword.Location = new Point(101, 55);
            signUpPassword.Name = "signUpPassword";
            signUpPassword.Size = new Size(100, 23);
            signUpPassword.TabIndex = 6;
            // 
            // signUpEmail
            // 
            signUpEmail.Location = new Point(101, 24);
            signUpEmail.Name = "signUpEmail";
            signUpEmail.Size = new Size(100, 23);
            signUpEmail.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 144);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 4;
            label7.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 116);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 3;
            label6.Text = "Adress:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 87);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 2;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 58);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 1;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 27);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 268);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSignIn;
        private TextBox loginBoxPassword;
        private TextBox loginBoxEmail;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox signUpAge;
        private TextBox signUpAdress;
        private TextBox signUpName;
        private TextBox signUpPassword;
        private TextBox signUpEmail;
        private Button btnRegister;
    }
}
