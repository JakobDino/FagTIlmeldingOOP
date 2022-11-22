using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal class Student
    {
        public Student(int id, string fNavn, string lNavn, DateTime birth)
        {
            StudentId = id;
            FirstName = fNavn;
            LastName = lNavn;
            DateOfBirth = birth;
            TimeSpan t = DateTime.Now - DateOfBirth;
            double j = t.TotalDays / 365;
            Age = (int)j;
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
    }
}
