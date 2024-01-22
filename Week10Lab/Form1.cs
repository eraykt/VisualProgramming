using System.Data.SQLite;

namespace Week10Lab
{
    public partial class Form1 : Form
    {
        public static string DBNAME = "users.db";

        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            if (!File.Exists(DBNAME))
            {
                SQLiteConnection.CreateFile(DBNAME);

                SQLiteConnection con = new SQLiteConnection(@"Data Source = " + DBNAME);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "CREATE TABLE users(id INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE,pw TEXT NOT NULL, name TEXT NOT NULL, adress TEXT NOT NULL, age INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE users_books(id INTEGER NOT NULL UNIQUE, user_id INTEGER NOT NULL, book_name TEXT NOT NULL, author TEXT NOT NULL, page_count INTEGER NOT NULL, PRIMARY KEY(id AUTOINCREMENT), FOREIGN KEY(user_id) REFERENCES users(id))";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User
                    (email: signUpEmail.Text,
                password: signUpPassword.Text,
                name: signUpName.Text,
                adress: signUpAdress.Text,
                age: int.Parse(signUpAge.Text));

                SQLiteConnection con = new SQLiteConnection(@"Data Source = " + DBNAME);
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO users(email, pw, name, adress, age) VALUES(@email, @pw, @name, @adress, @age)";
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@pw", u.password);
                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@adress", u.adress);
                cmd.Parameters.AddWithValue("@age", u.age);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("registered sucessfully");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data source = " + DBNAME))
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM users WHERE email=@email AND pw=@pw";
                    cmd.Parameters.AddWithValue("@email", loginBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@pw", loginBoxPassword.Text);

                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    if (!dataReader.HasRows)
                    {
                        MessageBox.Show("Incorrect email or password");
                        dataReader.Close();
                        con.Close();
                        return;
                    }

                    dataReader.Read();

                    User u = new User
                        (email: dataReader["email"].ToString(),
                        password: dataReader["pw"].ToString(),
                        name: dataReader["name"].ToString(),
                        adress: dataReader["adress"].ToString(),
                        age: int.Parse(dataReader["age"].ToString())
                        ); u.id = int.Parse(dataReader["id"].ToString());

                    MessageBox.Show(u.name + " logged in successfully!");

                    dataReader.Close();
                    con.Close();

                    UserProfile frm = new UserProfile();
                    frm.user = u;
                    this.Visible = false;
                    frm.LogOutEvent += LogOut;
                    frm.ShowDialog();

                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }
        }

        private void LogOut()
        {
            this.Visible = true;
        }
    }
}
