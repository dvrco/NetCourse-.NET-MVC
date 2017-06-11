using NetCourse.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetCourse.Controllers
{
    public class HomeController : Controller
    {

        private NetCourseDbContext _context = new NetCourseDbContext();

        // GET: Home
        public ViewResult Index()
        {
            var lastAddedCourses = _context.Courses.OrderByDescending(c => c.CreatedAt).Take(3).ToList();
            return View(lastAddedCourses);
        }

        public ViewResult AboutUs()
        {
            var page = _context.Pages.FirstOrDefault(p => p.Name == "About Us");
            return View(page);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose(); 
            }
        }
    }
}