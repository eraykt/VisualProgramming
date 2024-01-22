using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9
{
    public partial class Form2 : Form
    {
        public delegate void DataSendHandler(string name, string lastName);
        public event DataSendHandler DataSend;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSend(textBox1.Text, textBox2.Text);
            Close();
        }
    }
}
