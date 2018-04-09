using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentEnrolment.Models;

namespace StudentEnrolment.Data
{
    public class StudentEnrolmentDbContext : DbContext
    {
        public StudentEnrolmentDbContext(DbContextOptions<StudentEnrolmentDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
