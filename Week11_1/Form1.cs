using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week11_1.Models;

namespace Week11_1
{
    public partial class Form1 : Form
    {
        studentsEntities db = new studentsEntities();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NOTMARUL-PC\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;");
            try
            {
                if (con.State != ConnectionState.Open)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentsDataSet.students);
            dataGridView1.DataSource = db.students.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            students st = new students();
            st.first_name = textBox1.Text;
            st.last_name = textBox2.Text;
            st.student_id = int.Parse(textBox3.Text);
            st.exam = textBox4.Text;
            st.grade = textBox5.Text;
            db.students.Add(st);
            db.SaveChanges();
            MessageBox.Show("OK!");

        }
    }
}
