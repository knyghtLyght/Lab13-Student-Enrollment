using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentEnrolment.Models;
using Microsoft.AspNetCore.Mvc;
using StudentEnrolment.Data;
using Microsoft.EntityFrameworkCore;

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
            //Generate the list of Courses
            var students = _context.Students.ToList();
            // send that list to the View
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .SingleOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}