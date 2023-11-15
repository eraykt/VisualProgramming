using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private Dictionary<int, User> users;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var email = textBoxEmail.Text;
            var password = textBoxPassword.Text;

            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week6Lab\admins.txt");
            var line = "";

            while ((line = file.ReadLine()) != null)
            {
                var lines = line.Split(',');
                if (email == lines[0] && password == lines[1])
                {
                    notifyIcon1.ShowBalloonTip(2000, "Giris Basarili",
                        $"Sayin {lines[2]} {lines[3]}, basari ile giris yaptiniz!", ToolTipIcon.Info);

                    MessageBox.Show($"Hosgeldin, {lines[2]} {lines[3]}!", "Giris Basarili!",
                        MessageBoxButtons.OK);

                    LoadUsers();
                    groupBoxUsers.Visible = true;
                    groupBoxSignIn.Visible = false;

                    file.Close();
                    return;
                }
            }

            MessageBox.Show("Hatali giris!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            file.Close();
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSignIn_Click(sender, e);
        }

        private void LoadUsers()
        {
            comboBoxUsers.Items.Clear();

            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week6Lab\users.txt");
            var line = "";

            users = new Dictionary<int, User>();

            while ((line = file.ReadLine()) != null)
            {
                var lines = line.Split(',');
                User u = new User(int.Parse(lines[0]),
                    lines[1],
                    lines[2],
                   int.Parse(lines[3]));

                users.Add(u.GetId() - 1, u);

                comboBoxUsers.Items.Add(u.GetName());
            }
            
            file.Close();

            comboBoxUsers.SelectedIndex = 0;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            var user = users[comboBoxUsers.SelectedIndex];

            listBoxUsers.Items.Add(user.GetId());
            listBoxUsers.Items.Add(user.GetFirstName());
            listBoxUsers.Items.Add(user.GetSurname());
            listBoxUsers.Items.Add(user.GetAge());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormSignUp signUpForm = new FormSignUp(this);
            signUpForm.Show();
        }

        public void SetANewUser(User u)
        {
            u.SetId(users.Count + 1);
            users.Add(u.GetId() - 1, u);

            var file = new StreamWriter(@"C:\Users\notmarul\source\repos\Week2\Week6Lab\users.txt", true);
            file.WriteLine($"{ u.GetId()},{u.GetFirstName()},{u.GetSurname()},{u.GetAge()}");
            file.Close();

            LoadUsers();

        }
    }
}