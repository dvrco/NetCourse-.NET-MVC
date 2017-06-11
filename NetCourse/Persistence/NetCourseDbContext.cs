using NetCourse.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetCourse.NewFolder1
{
    public class NetCourseDbContext :DbContext
    {
        public DbSet<Page> Pages { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}