namespace Week4
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
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 150);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 0;
            button1.Text = "Click";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem, cToolStripMenuItem1 });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(107, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(98, 22);
            cToolStripMenuItem.Text = "C++";
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(98, 22);
            cToolStripMenuItem1.Text = "C#";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 71);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 111);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Second Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 244);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 327);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Week4 Learning";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}