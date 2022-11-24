using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal sealed class Student : Person
    {
        public Student(int id, string fNavn, string lNavn, DateTime birth) : base(fNavn, lNavn, birth)
        {
            StudentId = id;
        }
        public int StudentId { get; set; }
        internal override List<string> GetAllCourses(Enrollment enrollments)
        {
            List<string> courses = new List<string>();
            foreach (var item in enrollments.enrollment1)
            {
                if (FirstName == item.StudentInfo.FirstName && LastName == item.StudentInfo.LastName)
                {
                    courses.Add(Convert.ToString(item.CourseInfo.CourseName));
                }
            }
            //foreach (var item in courses)
            //{
            //    Console.WriteLine(item);
            //}
            return courses;
        }


        internal override List<string> GetAllCourses(List<Enrollment> enrollmentList)
        {
            List<string> courses = new List<string>();
            foreach (var item in enrollmentList)
            {
                if (FirstName == item.StudentInfo.FirstName && LastName == item.StudentInfo.LastName)
                {
                    courses.Add(Convert.ToString(item.CourseInfo.CourseName));
                }
            }
            return courses;
        }
    }
}
