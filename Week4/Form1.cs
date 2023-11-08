using System.Diagnostics;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            listBox1.Items.Clear();
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

        private void btnCity_Click(object sender, EventArgs e)
        {
            var newCity = txtNewCity.Text;
            //comboBox1.Items.Add(newCity);
            comboBox1.Items.Insert(0, newCity);
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var city = txtNewCity.Text;

            if (comboBox1.Items.Contains(city))
                comboBox1.Items.Remove(city);
        }

        private void btnCmbNext_Click(object sender, EventArgs e)
        {
            var id = comboBox1.SelectedIndex + 1;
            comboBox1.SelectedIndex = id == comboBox1.Items.Count ? 0 : id;
        }

        private void btnCmbPrev_Click(object sender, EventArgs e)
        {
            var id = comboBox1.SelectedIndex - 1;
            comboBox1.SelectedIndex = id < 0 ? comboBox1.Items.Count - 1 : id;
        }

        private void btnCmbShow_Click(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;
            var item = comboBox1.SelectedItem.ToString();

            MessageBox.Show($"Index: {index}, Item: {item}");
        }

        private void btnAddListbox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in comboBox1.Items)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btnListReadFile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week4\agalar.txt");
            var line = "";

            while ((line = file.ReadLine()) != null)
                listBox1.Items.Add(line);

            file.Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == " " || txtEmail.Text == " " || txtage.Text == " ")
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newUser = txtFullName.Text + "," + txtEmail.Text + "," + txtage.Text;

            listBox1.Items.Add(newUser);
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            var file = new StreamWriter(@"C:\Users\notmarul\source\repos\Week2\Week4\users.txt");

            foreach (var item in listBox1.Items)
                file.WriteLine(item);

            file.Close();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week4\users.txt");
            var line = "";

            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }

            file.Close();

        }

        private void CheckBoxStatusControl(object sender, EventArgs e)
        {

            CheckBox senderCheckbox = (CheckBox)sender;

            if (senderCheckbox.Checked)
            {
                listBox1.Items.Add(senderCheckbox.Text);
            }

            else
            {
                listBox1.Items.Remove(senderCheckbox.Text);
            }
        }

        private void radioStretch_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioZoom_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblLevel.Text = "Level: " + trackBar1.Value.ToString();

            pictureBox1.Size = new Size(trackBar1.Value * 100, trackBar1.Value * 100);
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week4\agalar.txt");
            var line = "";

            treeView1.Nodes.Add("Agalar");

            while ((line = file.ReadLine()) != null)
            {
                treeView1.Nodes[0].Nodes.Add(line);
            }

            file.Close();

            file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week4\users.txt");
            treeView1.Nodes.Add("Users");

            while ((line = file.ReadLine()) != null)
            {
                treeView1.Nodes[1].Nodes.Add(line);
            }

            file.Close();
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}