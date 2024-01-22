using System.Data.SQLite;

namespace Week8Lab
{
    public partial class Form1 : Form
    {
        string dbName = "users.db";
        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
        }

        public void CreateDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);

                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "CREATE TABLE users(first_name VARCHAR(255) NOT NULL, last_name VARCHAR(255) NOT NULL)";
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
            {
                con.Open();

                try
                {
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO users(first_name,last_name) VALUES(@first_name,@last_name)";
                    cmd.Parameters.AddWithValue("@first_name", textBoxFName.Text);
                    cmd.Parameters.AddWithValue("@last_name", textBoxLName.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{textBoxFName.Text} {textBoxLName.Text} added");
                    textBoxFName.Text = "";
                    textBoxLName.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }

                con.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName);
            con.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * FROM users WHERE first_name=@first_name";
                cmd.Parameters.AddWithValue("@first_name", txtBoxFindFirstName.Text);

                SQLiteDataReader dataReader = cmd.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    MessageBox.Show("didn't find");
                    dataReader.Close();
                    con.Close();
                    return;
                }

                string findedName = "";
                while (dataReader.Read())
                {
                    var first_name = dataReader.GetString(0);
                    var last_name = dataReader.GetString(1);
                    findedName = findedName + "\n" + first_name + " " + last_name;
                }
                MessageBox.Show(findedName);
                dataReader.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }

            con.Close();
        }
    }
}
