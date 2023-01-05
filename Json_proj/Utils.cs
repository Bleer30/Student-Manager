using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_proj   
{
    internal class Utils
    {
        public static List<Course> LoadAllCourses()
        {
            return JsonConvert.DeserializeObject<List<Course>>(File.ReadAllText("Courses/courses.json"));
        }
        public static List<Course> LoadAllCourses(List<Course> courses)
        {
            string strCourses = File.ReadAllText("Courses/courses.json");
            var coursesAll = JsonConvert.DeserializeObject<List<Course>>(strCourses);

            var exceptedList = coursesAll.Except(courses, new CompareCourses()).ToList();

            return exceptedList;
        }
    }
}
