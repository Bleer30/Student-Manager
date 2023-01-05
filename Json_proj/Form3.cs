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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Enter your Login Name: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studentName = this.textBox1.Text;
            var studentEmail = this.textBox2.Text;
            var subjCollection = this.textBox3.Text;
            var student = Students.LoadFromFile(studentName);

            if (subjCollection != null)
            {
                    student = new Students()
                    {
                        Name = studentName,
                        Email = studentEmail,
                        IntrestedSubjects = subjCollection.Split(',').ToList(),
                        Courses = new List<Course>()
                    };
                    student.SaveToFile();
            }
            else
            {
                    return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
