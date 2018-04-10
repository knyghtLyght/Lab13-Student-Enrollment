using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrolment.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Element Element { get; set; }
    }

    public enum Element
    {
        Air,
        Water,
        Earth,
        Fire
    }


}
