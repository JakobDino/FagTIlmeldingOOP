using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal class Course
    {
        public Course(FagEnum courseName, Teacher teacherInfo)
        {
            CourseName = courseName;
            
            TeacherInfo = teacherInfo;
        }

        public FagEnum CourseName { get; set; }
        public Teacher TeacherInfo { get; set; }
    }
}
