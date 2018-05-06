using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpPost]
        public async Task<IActionResult> Create(CourseViewModel cvm)
        {
            if (ModelState.IsValid)
            {
                Course newCourse = new Course()
                {
                    Name = cvm.Name,
                    Elements = cvm.Elements
                };
                _context.Add(newCourse);
                 await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Courses.SingleOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        public async Task<IActionResult> Details(int? id)
        {
            CourseDetailViewModel courseDetailVM = new CourseDetailViewModel();

            // If an ID was provided then display the Details view, otherwise return to Index
            if (id.HasValue)
            {
                return View(await CourseDetailViewModel.FromIDAsync(id.Value, _context));
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}