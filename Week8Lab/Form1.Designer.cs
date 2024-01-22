namespace Week8Lab
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
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            txtBoxFindFirstName = new TextBox();
            btnFind = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(124, 47);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(120, 23);
            textBoxFName.TabIndex = 1;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(124, 76);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(120, 23);
            textBoxLName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 50);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(169, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBoxFindFirstName
            // 
            txtBoxFindFirstName.Location = new Point(425, 50);
            txtBoxFindFirstName.Name = "txtBoxFindFirstName";
            txtBoxFindFirstName.Size = new Size(130, 23);
            txtBoxFindFirstName.TabIndex = 6;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(480, 79);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 7;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 55);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 8;
            label3.Text = "First Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 174);
            Controls.Add(label3);
            Controls.Add(btnFind);
            Controls.Add(txtBoxFindFirstName);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private TextBox txtBoxFindFirstName;
        private Button btnFind;
        private Label label3;
    }
}
