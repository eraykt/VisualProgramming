namespace Week5Lab
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
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            btnStart = new Button();
            lblTimeLeft = new Label();
            btnGame = new Button();
            timerGame = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 526);
            progressBar1.Maximum = 60;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(960, 23);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(415, 228);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 100);
            btnStart.TabIndex = 1;
            btnStart.Text = "Süreyi Başlat";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimeLeft.Location = new Point(310, 470);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(204, 30);
            lblTimeLeft.TabIndex = 2;
            lblTimeLeft.Text = "Kalan saniye: 60";
            lblTimeLeft.Visible = false;
            // 
            // btnGame
            // 
            btnGame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGame.Location = new Point(845, 428);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(123, 34);
            btnGame.TabIndex = 3;
            btnGame.Text = "Bana Tıkla";
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Visible = false;
            btnGame.Click += btnGame_Click;
            // 
            // timerGame
            // 
            timerGame.Tick += timerGame_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 557);
            Controls.Add(btnGame);
            Controls.Add(lblTimeLeft);
            Controls.Add(btnStart);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Button btnStart;
        private Label lblTimeLeft;
        private Button btnGame;
        private System.Windows.Forms.Timer timerGame;
    }
}