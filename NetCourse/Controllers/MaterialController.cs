using NetCourse.Models;
using NetCourse.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NetCourse.Controllers
{
    public class MaterialController : Controller
    {
        private NetCourseDbContext _context = new NetCourseDbContext();

        // GET: Material
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Material newMaterial)
        {
            newMaterial.CreatedAt = DateTime.UtcNow;
            newMaterial.ModifiedAt = DateTime.UtcNow;

            ModelState.Remove("MaterialId");

            if (!ModelState.IsValid)
            {
                return View(newMaterial);
            }

            _context.Materials.Add(newMaterial);
            _context.SaveChanges();
            return RedirectToAction("Create");

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