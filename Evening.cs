using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Evening : Course
    {
        public string ContractorID { get; set; }
        public DateAndTime ContarctEndDate { get; set; }

        public override string CourseType()
        {
            return "Evening";
        }
    }
}
