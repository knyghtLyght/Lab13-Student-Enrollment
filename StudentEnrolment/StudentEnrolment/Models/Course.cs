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

    //public List<Course> BuildCourses()
    //{
    //    return new List<Course>
    //    {
    //        new Course{ Name = "Basic air surfing", Element = Element.Air},
    //        new Course{ Name = "Ice throwing", Element = Element.Water},
    //        new Course{ Name = "Shape your own armor", Element = Element.Earth},
    //        new Course{ Name = "Control: How to heat your tea pot", Element = Element.Fire},
    //    };
    //}
}
