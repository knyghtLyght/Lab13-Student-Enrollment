using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrolment.Models
{
    public class CourseViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Element Elements { get; set; }
    }
}
