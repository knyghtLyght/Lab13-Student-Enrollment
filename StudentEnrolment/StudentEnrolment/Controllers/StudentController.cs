using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentEnrolment.Models;
using Microsoft.AspNetCore.Mvc;
using StudentEnrolment.Data;

namespace StudentEnrolment.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentEnrolmentDbContext _context;

        public StudentController(StudentEnrolmentDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}