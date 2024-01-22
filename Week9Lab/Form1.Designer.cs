namespace Week9Lab
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
            buttonAdd = new Button();
            listBox1 = new ListBox();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(50, 278);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(64, 53);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add Student";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(39, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 229);
            listBox1.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(133, 278);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(64, 53);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 372);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private ListBox listBox1;
        private Button buttonUpdate;
    }
}
