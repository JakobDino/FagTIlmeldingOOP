using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTIlmeldingOOP.CustomClass
{
    internal abstract class Person 
    {
        public Person(string fNavn, string lNavn, DateTime birth)
        {
            FirstName = fNavn;
            LastName = lNavn;
            DateOfBirth = birth;
            TimeSpan t = DateTime.Now - DateOfBirth;
            double j = t.TotalDays / 365;
            Age = (int)j;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        public int AgeCall()
        {
            TimeSpan t = DateTime.Now - DateOfBirth;
            double j = t.TotalDays / 365;
            Age = (int)j;
            return Age;
        }
        internal abstract List<string> GetAllCourses (Enrollment enrollments);
        internal abstract List<string> GetAllCourses(List<Enrollment> enrollmentList);

        public virtual DateTime Day()
        {
            return DateTime.Now;
        }

    }
}
