namespace Week9Lab
{
    public partial class Form1 : Form
    {
        public event StudentHandler StudentUpdateInfo;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StudentEvent += AddNewStudent;
            form2.ShowDialog();
            form2.StudentEvent -= AddNewStudent;
        }

        public void AddNewStudent(Student student)
        {
            listBox1.Items.Add(student);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            Student st = new Student();
            string stItem = listBox1.SelectedItem.ToString();
            st.name = stItem.Split(":")[0];
            st.grade = int.Parse(stItem.Split(":")[1]);

            Form2 form = new Form2();
            form.UpdateStudent(st);
            form.StudentEvent += UpdateStudent;
            form.ShowDialog();
        }

        private void UpdateStudent(Student student)
        {
            listBox1.Items[listBox1.SelectedIndex] = student;
        }
    }
}
