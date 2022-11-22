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
    }
}
