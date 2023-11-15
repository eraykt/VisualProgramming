using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class FormSignUp : Form
    {
        string name;
        string surname;
        int age;
        Form1 form1;

        public FormSignUp()
        {
            InitializeComponent();
        }

        public FormSignUp(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            var dateTime = dateTimePicker1.Value;

            age = DateTime.Now.Year - dateTime.Year;

            var user = new User(-1, name, surname, age);

            //form1.SetANewUser(user);
            Form1.Instance.SetANewUser(user);
            MessageBox.Show("New user created successfully!");
            Close();
        }
    }
}
