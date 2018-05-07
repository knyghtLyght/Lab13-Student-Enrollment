using StudentEnrolment.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrolment.Models
{
    public class StudentViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Course ChoseCourse { get; set; }
        private readonly StudentEnrolmentDbContext _context;

        public StudentViewModel(StudentEnrolmentDbContext context)
        {
            _context = context;
        }
    }
}
