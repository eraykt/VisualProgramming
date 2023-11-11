namespace Week4Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;

            var param = input.Split('x');

            if (param.Length < 2 || param.Length > 2)
            {
                MessageBox.Show("Invalid input");
                textBox1.Text = "";
                return;
            }

            if (!int.TryParse(param[0], out var w) || !int.TryParse(param[1], out var h))
            {
                MessageBox.Show("Invalid input");
                textBox1.Text = "";
                return;
            }

            if (w < 300 || h < 300 || w > 1500 || h > 1500)
            {
                MessageBox.Show("Out of range");
                textBox1.Text = "";
                return;
            }

            this.Width = w;
            this.Height = h;

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnOk_Click(sender, e);

        }
    }
}