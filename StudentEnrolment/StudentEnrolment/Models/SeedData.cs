using Microsoft.EntityFrameworkCore;
using StudentEnrolment.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrolment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentEnrolmentDbContext(serviceProvider.
                GetRequiredService<DbContextOptions<StudentEnrolmentDbContext>>()))
            {
                // Look for any Courses.
                if (context.Courses.Any())
                {
                    return;   // No seed data needed
                }

                Course course1 = new Course() { Name = "Basic air surfing", Elements = Element.Air };
                context.Courses.Add(course1);
                Course course2 = new Course { Name = "Ice throwing", Elements = Element.Water };
                context.Courses.Add(course2);
                Course course3 = new Course { Name = "Shape your own armor", Elements = Element.Earth };
                context.Courses.Add(course3);
                Course course4 = new Course { Name = "Control: How to heat your tea pot", Elements = Element.Fire };
                context.Courses.Add(course4);

                //Update database
                context.SaveChanges();

                //Look for an students
                if (context.Students.Any())
                {
                    return; // No seed data needed.
                }

                context.Students.AddRange(
                    new Student { Name = "Ang", Course = course1 },
                    new Student { Name = "Katara", Course = course2 },
                    new Student { Name = "Toph", Course = course3 },
                    new Student { Name = "Zuko", Course = course4 }
                    );

                //Update database
                context.SaveChanges();
            }
        }
    }
}
