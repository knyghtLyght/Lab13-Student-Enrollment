using Microsoft.EntityFrameworkCore;
using StudentEnrolment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrolment.Models
{
    public class CourseDetailViewModel
    {
        public IEnumerable<Student> EStudents { get; set; }
        public Course Course { get; set; }

        public static async Task<CourseDetailViewModel> FromIDAsync(int id, StudentEnrolmentDbContext context)
        {
            CourseDetailViewModel courseDetailVM = new CourseDetailViewModel();

            courseDetailVM.Course =
                await context.Courses.Where(c => c.ID == id).SingleAsync();

            courseDetailVM.EStudents =
                await context.Students.Where(s => s.Course == courseDetailVM.Course)
                                     .Select(s => s)
                                     .ToListAsync();

            return courseDetailVM;
        }
    }
}
