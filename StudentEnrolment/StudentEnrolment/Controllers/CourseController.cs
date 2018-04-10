using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentEnrolment.Data;
using StudentEnrolment.Models;

namespace StudentEnrolment.Controllers
{
    public class CourseController : Controller
    {
        private readonly StudentEnrolmentDbContext _context;

        public CourseController(StudentEnrolmentDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Generate the list of Courses
            var courses = _context.Courses.ToList();
            // send that list to the View
            return View(courses);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}