using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class CoursesController : Controller
    {
        private readonly SchoolContext _context;

        public CoursesController(SchoolContext context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index(string courseCategory, string searchString)
        {
            IQueryable<string> categoryQuery = from m in _context.Courses
                                            orderby m.Category
                                            select m.Category;

            var courses = from m in _context.Courses
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(s => s.Category.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(courseCategory))
            {
                courses = courses.Where(x => x.Category == courseCategory);
            }

            var courseCategoryVM = new CourseCategoryViewModel();
            courseCategoryVM.categories = new SelectList(await categoryQuery.Distinct().ToListAsync());
            courseCategoryVM.course = await courses.ToListAsync();

            return View(courseCategoryVM);
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .SingleOrDefaultAsync(m => m.CourseCode == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseCode,CourseName,Description,Year,Semester,Prerequisite,Compulsory,Category")] Courses courses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courses);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses.SingleOrDefaultAsync(m => m.CourseCode == id);
            if (courses == null)
            {
                return NotFound();
            }
            return View(courses);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CourseCode,CourseName,Description,Year,Semester,Prerequisite,Compulsory,Category")] Courses courses)
        {
            if (id != courses.CourseCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursesExists(courses.CourseCode))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(courses);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .SingleOrDefaultAsync(m => m.CourseCode == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var courses = await _context.Courses.SingleOrDefaultAsync(m => m.CourseCode == id);
            _context.Courses.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursesExists(string id)
        {
            return _context.Courses.Any(e => e.CourseCode == id);
        }
    }
}
