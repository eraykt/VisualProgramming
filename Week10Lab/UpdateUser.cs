using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Lab
{
    public partial class UpdateUser : Form
    {
        public delegate void UpdateUserHandler(User user);
        public UpdateUserHandler UpdateUserEvent;
        public User user;

        public UpdateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.email = textBox1.Text;
            user.password = textBox2.Text;
            user.name = textBox3.Text;
            user.adress = textBox4.Text;
            user.age = int.Parse(textBox5.Text);
            UpdateUserEvent(user);
            Close();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            textBox1.Text = user.email;
            textBox2.Text = user.password;
            textBox3.Text = user.name;
            textBox4.Text = user.adress;
            textBox5.Text = user.age.ToString();
        }
    }
}
