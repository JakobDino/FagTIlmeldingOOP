using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal class Enrollment
    {
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentInfo = studentInfo;
            CourseInfo = courseInfo;
        }
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }
    }
}
