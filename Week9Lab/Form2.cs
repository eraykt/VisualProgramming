using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9Lab
{
    public delegate void StudentHandler(Student student);
    public partial class Form2 : Form
    {

        public event StudentHandler StudentEvent;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = textBox1.Text;
            student.grade = int.Parse(textBox2.Text);

            StudentEvent(student);
            Close();
        }

        public void UpdateStudent(Student student)
        {
            button1.Visible = false;
            button2.Visible = true;

            textBox1.Text = student.name;
            textBox2.Text = student.grade.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = textBox1.Text;
            student.grade = int.Parse(textBox2.Text);

            StudentEvent(student);
            Close();
        }
    }
}
