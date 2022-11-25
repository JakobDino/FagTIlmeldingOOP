using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal class Enrollment : IComparable<Enrollment>
    {
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentInfo = studentInfo;
            CourseInfo = courseInfo;
        }
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }
        
        public List<Enrollment> enrollment1 { get; set; }
        public Enrollment()
        {
            enrollment1 = new();
        }

        //public int StudentCount(Enrollment enrollments)
        //{
        //    List<string> studentCount = new List<string>();
        //    foreach (var item in enrollments.enrollment1)
        //    {
        //        if (FirstName == item.StudentInfo.FirstName && student.LastName == item.StudentInfo.LastName)
        //        {
        //            studentCount.Add(Convert.ToString(item.CourseInfo.CourseName));
        //        }
        //    }
        //    int count = studentCount.Count();
        //    return count;
        //}

        public int CompareTo(Enrollment? other)
        {
            if (other != null)
            {
                return string.Compare(StudentInfo.FirstName, other.StudentInfo.FirstName);

            }
            else
            {
                return 0;
            }
        }
    }
}
