namespace Week6Lab
{
    public partial class Form1 : Form
    {
        string email, firstName, lastName;

        class User
        {
            public int id;
            public string name, surname;
            public int age;

            public User(int id, string name, string surname, int age)
            {
                this.id = id;
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            public string GetName() => $"{name} {surname}";
            public override string ToString() => $"{id} {name} {surname} {age}";
        }

        Dictionary<int, User> users;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week6Lab\admins.txt");
            var line = "";

            while ((line = file.ReadLine()) != null)
            {
                var email = line.Split(',')[0];
                var password = line.Split(',')[1];

                if (email == textBoxEmail.Text && password == textBoxPassword.Text)
                {
                    this.email = email;
                    this.firstName = line.Split(',')[2];
                    this.lastName = line.Split(',')[3];
                    notifyIcon1.ShowBalloonTip(1000, "Login Notification", $"Welcome {firstName} {lastName}, you have sucessfully logged in !", ToolTipIcon.Info);
                    MessageBox.Show("Welcome " + firstName + " " + lastName + "!");
                    labelWelcome.Text = $"Welcome {firstName} {lastName} !";

                    groupboxUserList.Visible = true;
                    groupboxSignIn.Visible = false;
                    labelWelcome.Visible = true;

                    LoadValues();

                    return;
                }
            }

            MessageBox.Show("Invalid email or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxEmail.Text = textBoxPassword.Text = "";

            file.Close();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSignIn_Click(sender, e);
        }

        private void LoadValues()
        {
            comboBoxUsers.Items.Clear();

            var file = new StreamReader(@"C:\Users\notmarul\source\repos\Week2\Week6Lab\users.txt");
            var line = "";
            users = new();

            while ((line = file.ReadLine()) != null)
            {
                var p = new User(
                   int.Parse(line.Split(',')[0]) - 1, // id
                   line.Split(',')[1], // name
                   line.Split(',')[2], // surname
                   int.Parse(line.Split(',')[3]) // age
                    );

                users.Add(p.id, p);
                comboBoxUsers.Items.Add(p.GetName());
            }

            file.Close();

            comboBoxUsers.SelectedIndex = 0;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            var user = users[comboBoxUsers.SelectedIndex];

            listBoxUsers.Items.Add(user.id + 1);
            listBoxUsers.Items.Add(user.name);
            listBoxUsers.Items.Add(user.surname);
            listBoxUsers.Items.Add(user.age);
        }
    }
}