namespace Week6Lab
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupboxSignIn = new GroupBox();
            btnSignIn = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupboxUserList = new GroupBox();
            listBoxUsers = new ListBox();
            comboBoxUsers = new ComboBox();
            labelWelcome = new Label();
            notifyIcon1 = new NotifyIcon(components);
            groupboxSignIn.SuspendLayout();
            groupboxUserList.SuspendLayout();
            SuspendLayout();
            // 
            // groupboxSignIn
            // 
            groupboxSignIn.Controls.Add(btnSignIn);
            groupboxSignIn.Controls.Add(textBoxEmail);
            groupboxSignIn.Controls.Add(textBoxPassword);
            groupboxSignIn.Controls.Add(label2);
            groupboxSignIn.Controls.Add(label1);
            groupboxSignIn.Location = new Point(48, 35);
            groupboxSignIn.Name = "groupboxSignIn";
            groupboxSignIn.Size = new Size(268, 215);
            groupboxSignIn.TabIndex = 0;
            groupboxSignIn.TabStop = false;
            groupboxSignIn.Text = "Sign In";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(36, 136);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(166, 32);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(102, 55);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(102, 94);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = 'x';
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 97);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // groupboxUserList
            // 
            groupboxUserList.Controls.Add(listBoxUsers);
            groupboxUserList.Controls.Add(comboBoxUsers);
            groupboxUserList.Location = new Point(481, 35);
            groupboxUserList.Name = "groupboxUserList";
            groupboxUserList.Size = new Size(383, 215);
            groupboxUserList.TabIndex = 1;
            groupboxUserList.TabStop = false;
            groupboxUserList.Text = "User List";
            groupboxUserList.Visible = false;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(188, 50);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(189, 139);
            listBoxUsers.TabIndex = 1;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(17, 50);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(129, 23);
            comboBoxUsers.TabIndex = 0;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(48, 329);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 32);
            labelWelcome.TabIndex = 2;
            labelWelcome.Visible = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 450);
            Controls.Add(labelWelcome);
            Controls.Add(groupboxUserList);
            Controls.Add(groupboxSignIn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupboxSignIn.ResumeLayout(false);
            groupboxSignIn.PerformLayout();
            groupboxUserList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupboxSignIn;
        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Button btnSignIn;
        private GroupBox groupboxUserList;
        private Label labelWelcome;
        private ListBox listBoxUsers;
        private ComboBox comboBoxUsers;
        private NotifyIcon notifyIcon1;
    }
}