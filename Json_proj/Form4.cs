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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.label1.Text = "\r\nOptions:\r\n\t1. View Profile\r\n\t2. View Available Courses\r\n\t3. View Registered Courses\r\n\t4. Register to a New Course\r\n\t5. View Intrested Subjects\r\n\t6. Exit\r\n\t\tChoice: ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentName = this.textBox1.Text;
            var student = Students.LoadFromFile(studentName);
            if (comboBox1.SelectedIndex == 0)
            {
                this.textBox2.Text = student.ToString();
            } else if (comboBox1.SelectedIndex == 1)
            {
                this.textBox2.Text = (String.Join(", \n", Utils.LoadAllCourses()));
            } else if (comboBox1.SelectedIndex == 2)
            {
                this.textBox2.Text = (String.Join(", \n", student.Courses));
            } else if (comboBox1.SelectedIndex == 3)
            {
            
            } else if (comboBox1.SelectedIndex == 4)
            {
                var availaCourses = Utils.LoadAllCourses(student.Courses);
                int count = 0;
                this.textBox2.Text = ("Available Courses: \n-----------------------------");
                foreach (Course availaCourse in availaCourses)
                {
                    this.textBox2.Text = ($"{++count}) {availaCourse}");
                }
                Console.Write("Choice: ");
                comboBox1.SelectedIndex = Convert.ToInt32(Console.ReadLine());
                //student.RegisterCourse(availaCourses[comboBox1.SelectedIndex - 1]);
                //student.SaveToFile();
                //MessageBox.Show($"{availaCourses[comboBox1.SelectedIndex - 1].CourseName} has been Registered Sucessfully!");
            } else if (comboBox1.SelectedIndex == 5)
            {
                this.textBox2.Text = (String.Join(", ", student.IntrestedSubjects));
            } else if (comboBox1.SelectedIndex == 6)
            {
                this.textBox2.Text = ($"{student.Name}, Logout Sucessfully!");
            } else
            {
                MessageBox.Show("Please Enter a Valid Input!");
            }
        }
    }
}
