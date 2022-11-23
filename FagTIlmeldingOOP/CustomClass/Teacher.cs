using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal sealed class Teacher : Person
    {
        public Teacher(string dep, string fNavn, string lNavn, DateTime birth) : base(fNavn, lNavn, birth)
        {
            Department = dep;
        }
        public string Department { get; set; }
        public string DepCall()
        {
            return Department;
        }
        internal override List<string> GetAllCourses(Enrollment enrollments)
        {
            List<string> courses = new List<string>();
            foreach (var item in enrollments.enrollment1)
            {
                if (FirstName == item.CourseInfo.TeacherInfo.FirstName && LastName == item.CourseInfo.TeacherInfo.LastName)
                {
                    if (!courses.Contains(item.CourseInfo.CourseName))
                    {
                        courses.Add(item.CourseInfo.CourseName);
                    }
                }
            }
            return courses;
        }
        public override DateTime Day()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
