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
    }
}
