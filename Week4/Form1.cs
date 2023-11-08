using System.Diagnostics;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = $"{label3.Text} {textBox1.Text} {textBox2.Text}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = textBox3.Text;
            var res = MessageBox.Show(message, "Uyari!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button3);

            if (res == DialogResult.Yes)
                MessageBox.Show("yes butonu");

            else if (res == DialogResult.No)
                MessageBox.Show("no butonu");

            else if (res == DialogResult.Cancel)
                MessageBox.Show("cancel butonu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();
            Color selectedColor = colorDialog1.Color;
            this.BackColor = selectedColor;
            Debug.WriteLine(res.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font selectedFont = fontDialog1.Font;
            label5.Font = selectedFont;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(4000, "Warning!", "Your notification text", ToolTipIcon.Warning);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TabPage customPage = new TabPage();
            customPage.Text = "Tab #" + (tabControl1.TabPages.Count + 1);
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var num = (int)numericUpDown1.Value;
            numericLabel.Text = "count: " + num.ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var value = numericUpDown1.Value + numericUpDown1.Increment;
            numericUpDown1.Value = value > numericUpDown1.Maximum ? numericUpDown1.Maximum : value;

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var value = numericUpDown1.Value - numericUpDown1.Increment;
            numericUpDown1.Value = value < numericUpDown1.Minimum ? numericUpDown1.Minimum : value;

            //Size = new Size(25 );
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            timerLabel.Text = "Timer: " + counter.ToString();

            Size = new Size(Size.Width + 5, Size.Height + 5);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown2.Value;
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.google.com/search?q=" + linkBox.Text);
            if (radioButton1.Checked)
                progressBar1.Value += 100;

        }

        private void radioCustomEvent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}