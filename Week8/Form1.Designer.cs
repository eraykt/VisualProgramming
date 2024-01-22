namespace Week8
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
            textBoxNumber = new TextBox();
            btnAdd = new Button();
            comboBoxNumbers = new ComboBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(88, 57);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(169, 23);
            textBoxNumber.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(307, 57);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxNumbers
            // 
            comboBoxNumbers.FormattingEnabled = true;
            comboBoxNumbers.Location = new Point(88, 120);
            comboBoxNumbers.Name = "comboBoxNumbers";
            comboBoxNumbers.Size = new Size(121, 23);
            comboBoxNumbers.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(307, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 203);
            Controls.Add(btnDelete);
            Controls.Add(comboBoxNumbers);
            Controls.Add(btnAdd);
            Controls.Add(textBoxNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumber;
        private Button btnAdd;
        private ComboBox comboBoxNumbers;
        private Button btnDelete;
    }
}
