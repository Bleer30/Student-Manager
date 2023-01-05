using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_proj
{
    internal class CompareCourses : IEqualityComparer<Course>
    {
        public bool Equals(Course x, Course y)
        {
            return (x.CourseName.Equals(y.CourseName) && x.Instructor.Equals(y.Instructor));
        }
        public int GetHashCode(Course obj)
        {
            return (obj.CourseName!= null ? obj.CourseName.GetHashCode() : 0) ^ (obj.Instructor != null ? obj.Instructor.GetHashCode() : 0);
        }
    }
}
