using System.Data.SqlClient;
namespace Week11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NOTMARUL-PC\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;");
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO students(first_name, last_name, exam, grade, student_id) VALUES(@first_name, @last_name, @exam, @grade, @student_id)";
                cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@exam", textBox4.Text);
                cmd.Parameters.AddWithValue("@grade", textBox5.Text);
                cmd.Parameters.AddWithValue("@student_id", int.Parse(textBox3.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                throw;
            }

        }
    }
}
