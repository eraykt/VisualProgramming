namespace Week10Lab
{
    partial class UserProfile
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
            groupBox1 = new GroupBox();
            btnUpdate = new Button();
            labelAge = new Label();
            labelAdress = new Label();
            labelName = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            labelId = new Label();
            menuStrip1 = new MenuStrip();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            addNewRecordToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(labelAge);
            groupBox1.Controls.Add(labelAdress);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(30, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(47, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(207, 48);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelAge.ForeColor = Color.Red;
            labelAge.Location = new Point(47, 195);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(66, 32);
            labelAge.TabIndex = 5;
            labelAge.Text = "Age:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelAdress.ForeColor = Color.Red;
            labelAdress.Location = new Point(47, 163);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(113, 32);
            labelAdress.TabIndex = 4;
            labelAdress.Text = "Address:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelName.ForeColor = Color.Red;
            labelName.Location = new Point(47, 131);
            labelName.Name = "labelName";
            labelName.Size = new Size(88, 32);
            labelName.TabIndex = 3;
            labelName.Text = "Name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelPassword.ForeColor = Color.Red;
            labelPassword.Location = new Point(47, 99);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(136, 32);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password: ";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelEmail.ForeColor = Color.Red;
            labelEmail.Location = new Point(47, 67);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(83, 32);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelId.ForeColor = Color.Red;
            labelId.Location = new Point(47, 35);
            labelId.Name = "labelId";
            labelId.Size = new Size(47, 32);
            labelId.TabIndex = 0;
            labelId.Text = "ID:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { operationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(972, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewRecordToolStripMenuItem, logOutToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(77, 20);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // addNewRecordToolStripMenuItem
            // 
            addNewRecordToolStripMenuItem.Name = "addNewRecordToolStripMenuItem";
            addNewRecordToolStripMenuItem.Size = new Size(180, 22);
            addNewRecordToolStripMenuItem.Text = "Add New Record";
            addNewRecordToolStripMenuItem.Click += addNewRecordToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(180, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(438, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(509, 297);
            dataGridView1.TabIndex = 2;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelAge;
        private Label labelAdress;
        private Label labelName;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelId;
        private Button btnUpdate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem addNewRecordToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}