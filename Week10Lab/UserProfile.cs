using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Lab
{
    public delegate void LogOutDelegate();
    public partial class UserProfile : Form
    {
        public User user;
        public event LogOutDelegate LogOutEvent;

        public UserProfile()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.user = this.user;
            updateUser.UpdateUserEvent += UpdateUserInfo;
            updateUser.ShowDialog();
        }

        private void UpdateUserInfo(User user)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + Form1.DBNAME))
                {
                    this.user = user;

                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "UPDATE users SET email=@email, pw=@pw, name=@name, adress=@adress, age=@age WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", user.id);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@pw", user.password);
                    cmd.Parameters.AddWithValue("@name", user.name);
                    cmd.Parameters.AddWithValue("@adress", user.adress);
                    cmd.Parameters.AddWithValue("@age", user.age);
                    cmd.ExecuteNonQuery();

                    GetUserInfo();
                    con.Close();
                    MessageBox.Show("Your changes are saved!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            GetUserInfo();
            GetBookRecords();
        }

        private void GetBookRecords()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + Form1.DBNAME))
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM users_books WHERE user_id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id", user.id);
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Book Name");
                    dt.Columns.Add("Author");
                    dt.Columns.Add("Page Count");

                    while (dataReader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = int.Parse(dataReader["id"].ToString());
                        row["Book Name"] = dataReader["book_name"].ToString();
                        row["Author"] = dataReader["author"].ToString();
                        row["Page Count"] = int.Parse(dataReader["page_count"].ToString());
                        dt.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dt;
                    dataReader.Close();
                    con.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }
        }

        private void GetUserInfo()
        {
            labelId.Text = "Id: " + user.id;
            labelEmail.Text = "Email: " + user.email;
            labelPassword.Text = "Password: " + user.password;
            labelName.Text = "Name: " + user.name;
            labelAdress.Text = "Adress: " + user.adress;
            labelAge.Text = "Age: " + user.age;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOutEvent();
            Close();
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookRecord formAddBookRecord = new AddBookRecord();
            formAddBookRecord.AddBookRecordAction += AddNewBookRecord;
            formAddBookRecord.ShowDialog();
        }

        private void AddNewBookRecord(BookRecord record)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + Form1.DBNAME))
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO users_books(user_id, book_name, author, page_count) VALUES(@user_id, @book_name, @author, @page_count) ";
                    cmd.Parameters.AddWithValue("@user_id", user.id);
                    cmd.Parameters.AddWithValue("@book_name", record.name);
                    cmd.Parameters.AddWithValue("@author", record.author);
                    cmd.Parameters.AddWithValue("@page_count", record.pageCount);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your record added successfully!");
                    GetBookRecords();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }
        }
    }
}
