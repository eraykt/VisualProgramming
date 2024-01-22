using System.Data.SQLite;

namespace Week8
{
    public partial class Form1 : Form
    {
        string dbName = "vp.db";

        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
            LoadDatabase();
        }

        public void CreateDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                using (var con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();

                    SQLiteCommand cmd = con.CreateCommand();
                    cmd.CommandText = "create table first_table(number1 INTEGER NOT NULL)";
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }

        }

        public void LoadDatabase()
        {
            comboBoxNumbers.Items.Clear();

            SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName);
            con.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT * FROM first_table";
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Database is empty!");
                    reader.Close();
                    con.Close();
                    return;
                }

                while (reader.Read())
                {
                    var nmb = reader.GetInt32(0);
                    comboBoxNumbers.Items.Add(nmb);
                }
                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName);
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO first_table(number1) values(@number1)";
                int number1 = int.Parse(textBoxNumber.Text);
                cmd.Parameters.AddWithValue("@number1", number1);
                cmd.ExecuteNonQuery();
                MessageBox.Show(number1 + " added successfully!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }

            textBoxNumber.Text = "";
            con.Close();

            LoadDatabase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxNumbers.SelectedIndex < 0) return;

            var selectedNumber = int.Parse(comboBoxNumbers.SelectedItem.ToString());

            SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName);
            con.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = "DELETE FROM first_table WHERE number1=@number1";
                cmd.Parameters.AddWithValue("@number1", selectedNumber);
                cmd.ExecuteNonQuery();
                MessageBox.Show(selectedNumber + " deleted successfully");
                comboBoxNumbers.Items.RemoveAt(comboBoxNumbers.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }



            con.Close();
        }
    }
}
