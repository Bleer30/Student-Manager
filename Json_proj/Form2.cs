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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label2.Text = "Course Name: ";
            this.label3.Text = "Enter your Name: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strCourseName = this.textBox2.Text;
            var strInstructorName = this.textBox3.Text;

            var course = new Course(strCourseName, strInstructorName);
            course.SaveToFile();
            MessageBox.Show($"{strCourseName}, {strCourseName} has been created successfully!");
        }
    }
}
