using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Lab
{
    public partial class AddBookRecord : Form
    {
        public Action<BookRecord> AddBookRecordAction;

        public AddBookRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookRecord b = new BookRecord
                (name: textBox1.Text,
                author: textBox2.Text,
                pageCount: int.Parse(textBox3.Text)
                );

            AddBookRecordAction(b);
            Close();
        }
    }
}
