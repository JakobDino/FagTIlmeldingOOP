using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal class Course
    {
        public Course(string courseName, Teacher teacherInfo)
        {
            CourseName = courseName;
            
            TeacherInfo = teacherInfo;
        }

        public string CourseName { get; set; }
        public Teacher TeacherInfo { get; set; }
    }
}
