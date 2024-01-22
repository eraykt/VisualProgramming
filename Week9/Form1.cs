namespace Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.DataSend += AddNewStudent;
            form2.ShowDialog();
        }

        public void AddNewStudent(string name, string lastName)
        {
            listBox1.Items.Add(name + " " + lastName);
        }
    }
}
