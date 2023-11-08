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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            button2 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            button4 = new Button();
            label5 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            button5 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button7 = new Button();
            tabPage2 = new TabPage();
            button6 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericLabel = new Label();
            btnUp = new Button();
            btnDown = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            btnStart = new Button();
            btnStop = new Button();
            numericUpDown2 = new NumericUpDown();
            processBtn = new Button();
            linkBox = new TextBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // button2
            // 
            button2.Location = new Point(409, 97);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 6;
            button2.Text = "tıkla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(418, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 35);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Message Box";
            // 
            // button3
            // 
            button3.Location = new Point(409, 179);
            button3.Name = "button3";
            button3.Size = new Size(111, 21);
            button3.TabIndex = 9;
            button3.Text = "pick a color";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(409, 206);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "pick a font";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 210);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 11;
            label5.Text = "lorem ipsum";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // button5
            // 
            button5.Location = new Point(409, 244);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "notify";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(38, 297);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(269, 256);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(261, 228);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(58, 87);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 0;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(261, 228);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(84, 110);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            button6.Text = "New Tab";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(376, 351);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericLabel
            // 
            numericLabel.AutoSize = true;
            numericLabel.Location = new Point(480, 353);
            numericLabel.Name = "numericLabel";
            numericLabel.Size = new Size(44, 15);
            numericLabel.TabIndex = 14;
            numericLabel.Text = "count: ";
            // 
            // btnUp
            // 
            btnUp.Location = new Point(418, 322);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(22, 23);
            btnUp.TabIndex = 15;
            btnUp.Text = "+";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(418, 380);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(22, 23);
            btnDown.TabIndex = 16;
            btnDown.Text = "-";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Location = new Point(402, 455);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(43, 15);
            timerLabel.TabIndex = 17;
            timerLabel.Text = "Timer: ";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(449, 428);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 18;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(555, 428);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 19;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown2.Location = new Point(501, 408);
            numericUpDown2.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(63, 23);
            numericUpDown2.TabIndex = 20;
            numericUpDown2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // processBtn
            // 
            processBtn.Location = new Point(402, 495);
            processBtn.Name = "processBtn";
            processBtn.Size = new Size(75, 23);
            processBtn.TabIndex = 21;
            processBtn.Text = "Proccess";
            processBtn.UseVisualStyleBackColor = true;
            processBtn.Click += processBtn_Click;
            // 
            // linkBox
            // 
            linkBox.Location = new Point(490, 495);
            linkBox.Name = "linkBox";
            linkBox.Size = new Size(100, 23);
            linkBox.TabIndex = 22;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(402, 530);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(188, 23);
            progressBar1.TabIndex = 23;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(490, 470);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Process Bar";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 575);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(linkBox);
            Controls.Add(processBtn);
            Controls.Add(numericUpDown2);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(timerLabel);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(numericLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(tabControl1);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week4 Learning";
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private Button button3;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Button button4;
        private Label label5;
        private NotifyIcon notifyIcon1;
        private Button button5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button6;
        private Button button7;
        private NumericUpDown numericUpDown1;
        private Label numericLabel;
        private Button btnUp;
        private Button btnDown;
        private System.Windows.Forms.Timer timer1;
        private Label timerLabel;
        private Button btnStart;
        private Button btnStop;
        private NumericUpDown numericUpDown2;
        private Button processBtn;
        private TextBox linkBox;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
    }
}