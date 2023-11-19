namespace Week7Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();

            foreach (var item in Controls)
            {
                if (item.GetType() != typeof(Button)) continue;
                var button = (Button)item;

                button.Text = random.Next(1, 6).ToString();
            }
        }

        private void CheckboxEvent(object sender, EventArgs e)
        {
            Random random = new Random();
            CheckBox checkBox = (CheckBox)sender;

            var color = checkBox.Checked ? Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)) : default(Color);

            foreach (var item in Controls)
            {
                if (item.GetType() != typeof(Button)) continue;
                var button = (Button)item;

                if (!button.Text.Equals(checkBox.Text)) continue;
                button.BackColor = color;
            }
        }
    }
}
