using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week11Lab.Models;

namespace Week11Lab
{
    public partial class Form1 : Form
    {
        carsEntities db = new carsEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.cars.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cars car = new cars();
            car.model = textBoxModel.Text;
            car.second_hand = isSecondHand.Checked;
            car.color = comboBox1.SelectedItem.ToString();

            db.cars.Add(car);
            db.SaveChanges();
            MessageBox.Show("Added successfully!");
            dataGridView1.DataSource = db.cars.ToList();
        }
    }
}
