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
            changeBackgroundColorToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
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
            comboBox1 = new ComboBox();
            txtNewCity = new TextBox();
            btnCity = new Button();
            btnRemove = new Button();
            btnCmbNext = new Button();
            btnCmbPrev = new Button();
            btnCmbShow = new Button();
            listBox1 = new ListBox();
            btnAddListbox = new Button();
            btnListReadFile = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtage = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnNewUser = new Button();
            btnSaveFile = new Button();
            btnLoadFile = new Button();
            chckFutball = new CheckBox();
            chckBasketball = new CheckBox();
            chckVolleyball = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            radioZoom = new RadioButton();
            radioStretch = new RadioButton();
            trackBar1 = new TrackBar();
            lblLevel = new Label();
            maskedTextBox1 = new MaskedTextBox();
            treeView1 = new TreeView();
            btnTree = new Button();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { changeBackgroundColorToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(215, 48);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            changeBackgroundColorToolStripMenuItem.Size = new Size(214, 22);
            changeBackgroundColorToolStripMenuItem.Text = "Change Background Color";
            changeBackgroundColorToolStripMenuItem.Click += changeBackgroundColorToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(214, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Kayseri", "Karabük", "Ankara", "İstanbul" });
            comboBox1.Location = new Point(702, 68);
            comboBox1.MaxDropDownItems = 2;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 25;
            // 
            // txtNewCity
            // 
            txtNewCity.Location = new Point(706, 33);
            txtNewCity.Name = "txtNewCity";
            txtNewCity.Size = new Size(100, 23);
            txtNewCity.TabIndex = 26;
            // 
            // btnCity
            // 
            btnCity.Location = new Point(815, 35);
            btnCity.Name = "btnCity";
            btnCity.Size = new Size(75, 23);
            btnCity.TabIndex = 27;
            btnCity.Text = "Add";
            btnCity.UseVisualStyleBackColor = true;
            btnCity.Click += btnCity_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(896, 32);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(67, 23);
            btnRemove.TabIndex = 28;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCmbNext
            // 
            btnCmbNext.Location = new Point(706, 108);
            btnCmbNext.Name = "btnCmbNext";
            btnCmbNext.Size = new Size(75, 23);
            btnCmbNext.TabIndex = 29;
            btnCmbNext.Text = "next";
            btnCmbNext.UseVisualStyleBackColor = true;
            btnCmbNext.Click += btnCmbNext_Click;
            // 
            // btnCmbPrev
            // 
            btnCmbPrev.Location = new Point(793, 107);
            btnCmbPrev.Name = "btnCmbPrev";
            btnCmbPrev.Size = new Size(75, 23);
            btnCmbPrev.TabIndex = 30;
            btnCmbPrev.Text = "prev";
            btnCmbPrev.UseVisualStyleBackColor = true;
            btnCmbPrev.Click += btnCmbPrev_Click;
            // 
            // btnCmbShow
            // 
            btnCmbShow.Location = new Point(877, 67);
            btnCmbShow.Name = "btnCmbShow";
            btnCmbShow.Size = new Size(75, 23);
            btnCmbShow.TabIndex = 31;
            btnCmbShow.Text = "show";
            btnCmbShow.UseVisualStyleBackColor = true;
            btnCmbShow.Click += btnCmbShow_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(702, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 32;
            // 
            // btnAddListbox
            // 
            btnAddListbox.Location = new Point(711, 168);
            btnAddListbox.Name = "btnAddListbox";
            btnAddListbox.Size = new Size(95, 23);
            btnAddListbox.TabIndex = 33;
            btnAddListbox.Text = "Add To ListBox";
            btnAddListbox.UseVisualStyleBackColor = true;
            btnAddListbox.Click += btnAddListbox_Click;
            // 
            // btnListReadFile
            // 
            btnListReadFile.Location = new Point(815, 168);
            btnListReadFile.Name = "btnListReadFile";
            btnListReadFile.Size = new Size(101, 23);
            btnListReadFile.TabIndex = 34;
            btnListReadFile.Text = "Read From File";
            btnListReadFile.UseVisualStyleBackColor = true;
            btnListReadFile.Click += btnListReadFile_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(702, 333);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(702, 362);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 36;
            // 
            // txtage
            // 
            txtage.Location = new Point(702, 391);
            txtage.Name = "txtage";
            txtage.Size = new Size(100, 23);
            txtage.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(639, 336);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 38;
            label6.Text = "Full Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(639, 365);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 39;
            label7.Text = "E-Mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(639, 394);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 40;
            label8.Text = "Age";
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(841, 333);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(75, 23);
            btnNewUser.TabIndex = 41;
            btnNewUser.Text = "New User";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(841, 365);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 42;
            btnSaveFile.Text = "Save to File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(841, 394);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(75, 23);
            btnLoadFile.TabIndex = 43;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // chckFutball
            // 
            chckFutball.AutoSize = true;
            chckFutball.Location = new Point(858, 218);
            chckFutball.Name = "chckFutball";
            chckFutball.Size = new Size(60, 19);
            chckFutball.TabIndex = 44;
            chckFutball.Text = "Futbol";
            chckFutball.UseVisualStyleBackColor = true;
            chckFutball.CheckedChanged += CheckBoxStatusControl;
            // 
            // chckBasketball
            // 
            chckBasketball.AutoSize = true;
            chckBasketball.Location = new Point(858, 240);
            chckBasketball.Name = "chckBasketball";
            chckBasketball.Size = new Size(77, 19);
            chckBasketball.TabIndex = 45;
            chckBasketball.Text = "Basketbol";
            chckBasketball.UseVisualStyleBackColor = true;
            chckBasketball.CheckedChanged += CheckBoxStatusControl;
            // 
            // chckVolleyball
            // 
            chckVolleyball.AutoSize = true;
            chckVolleyball.Location = new Point(858, 265);
            chckVolleyball.Name = "chckVolleyball";
            chckVolleyball.Size = new Size(71, 19);
            chckVolleyball.TabIndex = 46;
            chckVolleyball.Text = "Voleybol";
            chckVolleyball.UseVisualStyleBackColor = true;
            chckVolleyball.CheckedChanged += CheckBoxStatusControl;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(652, 449);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(100, 91);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 48);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 19);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Location = new Point(768, 449);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(100, 85);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 48);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(3, 19);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 1;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(997, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioZoom);
            groupBox3.Controls.Add(radioStretch);
            groupBox3.Location = new Point(993, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(104, 100);
            groupBox3.TabIndex = 50;
            groupBox3.TabStop = false;
            groupBox3.Text = "Size mode";
            // 
            // radioZoom
            // 
            radioZoom.AutoSize = true;
            radioZoom.Location = new Point(5, 41);
            radioZoom.Name = "radioZoom";
            radioZoom.Size = new Size(57, 19);
            radioZoom.TabIndex = 1;
            radioZoom.TabStop = true;
            radioZoom.Text = "Zoom";
            radioZoom.UseVisualStyleBackColor = true;
            radioZoom.CheckedChanged += radioZoom_CheckedChanged;
            // 
            // radioStretch
            // 
            radioStretch.AutoSize = true;
            radioStretch.Location = new Point(4, 22);
            radioStretch.Name = "radioStretch";
            radioStretch.Size = new Size(62, 19);
            radioStretch.TabIndex = 0;
            radioStretch.TabStop = true;
            radioStretch.Text = "Stretch";
            radioStretch.UseVisualStyleBackColor = true;
            radioStretch.CheckedChanged += radioStretch_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(970, 306);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(144, 45);
            trackBar1.TabIndex = 51;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(984, 365);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(40, 15);
            lblLevel.TabIndex = 52;
            lblLevel.Text = "Level: ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(970, 409);
            maskedTextBox1.Mask = "aa-00-aa00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 53;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(970, 449);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 54;
            // 
            // btnTree
            // 
            btnTree.Location = new Point(888, 470);
            btnTree.Name = "btnTree";
            btnTree.Size = new Size(75, 23);
            btnTree.TabIndex = 55;
            btnTree.Text = "Load tree";
            btnTree.UseVisualStyleBackColor = true;
            btnTree.Click += btnTree_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 575);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(btnTree);
            Controls.Add(treeView1);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblLevel);
            Controls.Add(trackBar1);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chckVolleyball);
            Controls.Add(chckBasketball);
            Controls.Add(chckFutball);
            Controls.Add(btnLoadFile);
            Controls.Add(btnSaveFile);
            Controls.Add(btnNewUser);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtage);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(btnListReadFile);
            Controls.Add(btnAddListbox);
            Controls.Add(listBox1);
            Controls.Add(btnCmbShow);
            Controls.Add(btnCmbPrev);
            Controls.Add(btnCmbNext);
            Controls.Add(btnRemove);
            Controls.Add(btnCity);
            Controls.Add(txtNewCity);
            Controls.Add(comboBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
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
        private ComboBox comboBox1;
        private TextBox txtNewCity;
        private Button btnCity;
        private Button btnRemove;
        private Button btnCmbNext;
        private Button btnCmbPrev;
        private Button btnCmbShow;
        private ListBox listBox1;
        private Button btnAddListbox;
        private Button btnListReadFile;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtage;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnNewUser;
        private Button btnSaveFile;
        private Button btnLoadFile;
        private CheckBox chckFutball;
        private CheckBox chckBasketball;
        private CheckBox chckVolleyball;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private RadioButton radioZoom;
        private RadioButton radioStretch;
        private TrackBar trackBar1;
        private Label lblLevel;
        private MaskedTextBox maskedTextBox1;
        private TreeView treeView1;
        private Button btnTree;
        private ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}