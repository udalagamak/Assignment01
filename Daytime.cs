using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Daytime : Course
    {
        public int SectionNumber { get; set; }
        public string BlockNumber { get; set; }
        public string CertificateID { get; set; }

        public override string CourseType()
        {
            return "Daytime";
        }
    }
}
