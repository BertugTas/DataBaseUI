using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseUI
{
    public partial class Form1 : Form
    {
        private string username = "admin";
        private string password = "admin123";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password && checkBox1.Checked == true)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

                // Proceed to the next form or functionality
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emel Hocayı ve bu dersi sevdiğimi tüm benliğimle kabul ediyorum.");
        }
    }
}
