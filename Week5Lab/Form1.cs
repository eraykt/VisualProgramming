namespace Week5Lab
{
    public partial class Form1 : Form
    {
        private int time = 60;
        private float timeLeft;
        private bool win = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // center the button
            btnStart.Left = (this.ClientSize.Width - btnStart.Width) / 2;
            btnStart.Top = (this.ClientSize.Height - btnStart.Height) / 2;

            lblTimeLeft.Left = (this.ClientSize.Width - lblTimeLeft.Width) / 2;

            progressBar1.Maximum = time * 100;
            timeLeft = time;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            lblTimeLeft.Visible = true;
            btnStart.Visible = false;

            btnGame.Visible = true;
            RandomButtonPosition();

            timerGame.Interval = 500;
            timerGame.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1f;

            var value = time * 100 - (int)(timeLeft * 100);
            progressBar1.Value = value > progressBar1.Maximum ? progressBar1.Maximum : value;

            lblTimeLeft.Text = $"Kalan saniye: {timeLeft} ";

            if (timeLeft <= 10f)
                lblTimeLeft.ForeColor = Color.Red;

            if (timeLeft <= 0f)
            {
                win = false;
                btnGame_Click(sender, e);
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            RandomButtonPosition();
        }

        private void RandomButtonPosition()
        {
            var random = new Random();
            var left = random.Next(12, 845);
            var top = random.Next(12, 428);

            btnGame.Left = left;
            btnGame.Top = top;
        }

        private void Restart()
        {
            btnStart.Visible = true;
            progressBar1.Value = progressBar1.Minimum;
            lblTimeLeft.Text = $"Kalan saniye: 60 ";
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            btnGame.Visible = false;
            lblTimeLeft.Visible = false;

            progressBar1.Value = progressBar1.Maximum;

            timer1.Stop();
            timerGame.Stop();
            DialogResult res;

            if (win)
            {
                res = MessageBox.Show("Tebrikler, " + timeLeft + " saniye kala oyunu bitirdin!",
                    "Tebrikler!!!",
                    MessageBoxButtons.RetryCancel);
            }

            else
            {
                res = MessageBox.Show("Süre doldu, kaybettin!",
                    "Oyun bitti",
                    MessageBoxButtons.RetryCancel);
            }

            if (res == DialogResult.Retry)
                Restart();

            else if (res == DialogResult.Cancel)
                Close();

            timeLeft = time;
        }
    }
}