using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Json_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.label1.Text = ("Login:\r\n-------------------------------------------------\r\n\t1. Instructor\r\n\t2. Add student\r\n\t3. Consult student");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();

            if (textBox1.Text == "1")
            {
                f2.ShowDialog();
            } else if (textBox1.Text == "2")
            {
                f3.ShowDialog();
            } else if (textBox1.Text == "3")
            {
                f4.ShowDialog();
            } else
            {
                MessageBox.Show("Please Enter a Valid Input!");
            }
           
        }
    }
}
