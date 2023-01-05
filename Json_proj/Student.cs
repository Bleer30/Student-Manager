using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_proj
{
    internal class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> IntrestedSubjects { get; set; }
        public List<Course> Courses { get; set; }

        public void RegisterCourse(Course course)
        {
            if (Courses == null)
            {
                Courses = new List<Course>();
            }
            Courses.Add(course);
        }

        public void SaveToFile()
        {
            if (!Directory.Exists("Students"))
            {
                Directory.CreateDirectory("Students");
            }
            var jsonData = JsonConvert.SerializeObject(this);
            File.WriteAllText($"Students/{this.Name}.json", jsonData);
            //Students/Sai.json
        }

        public static Students LoadFromFile(string strName)
        {
            if (!File.Exists($"Students/{strName}.json"))
            {
                return null;
            }
           var jsonData = File.ReadAllText($"Students/{strName}.json");
           return JsonConvert.DeserializeObject<Students>(jsonData);
        }

        public override string ToString()
        {
            return $"******************************************************\r\n\t$Details of {this.Name}\r\n******************************************************" +
                $"\r\nName: {this.Name}\r\nEmail: {this.Email}\r\n" +
            $"Intrested Subjects: {String.Join(", ", this.IntrestedSubjects)}\r\n" +
            $"{String.Join(", ", this.Courses)}";
        }

    }
}
