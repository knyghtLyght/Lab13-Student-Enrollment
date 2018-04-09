using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentEnrolment.Data;

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
            return View();
        }
    }
}