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
    }
}