using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal class Teacher
    {
        public Teacher(string dep, string fNavn, string lNavn, DateTime birth)
        {
            Department = dep;
            FirstName = fNavn;
            LastName = lNavn;
            DateOfBirth = birth;
            TimeSpan t = DateTime.Now - DateOfBirth;
            double j = t.TotalDays / 365;
            Age = (int)j;
        }
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public int Age { get; set; }
    }
}
