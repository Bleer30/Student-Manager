using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_proj
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        public Course(string courseName, string instructor)
        { 
            CourseName = courseName;
            Instructor = instructor;    
        }

        public void SaveToFile()
        {
            if (!Directory.Exists("Courses"))
            {
                Directory.CreateDirectory("Courses");
                File.WriteAllText("Courses/courses.json", "[]");
            }

            var jsonString = File.ReadAllText("Courses/courses.json");
            var courseList = JsonConvert.DeserializeObject<List<Course>>(jsonString);

            courseList.Add(this);

            File.WriteAllText("Courses/courses.json", JsonConvert.SerializeObject(courseList, Formatting.Indented));
        }

        public override string ToString()
        {
            return $"Course Name: ${this.CourseName}\r\nInstructor: ${this.Instructor}";
        }
    }
}
