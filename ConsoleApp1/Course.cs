using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment2
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set;}
        public double Cost { get; set;}


        public Course(string code, string course_name, double cost)
        {
            CourseCode = code;
            CourseName = course_name;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"Course_Code: {CourseCode}, Course_Name: {CourseName}, Course Cost: {Cost}";
        }

    }
}
