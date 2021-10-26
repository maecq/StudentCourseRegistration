using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentCourseRegistration.Models;

namespace StudentCourseRegistration.Data
{
    public class StudentCourseRegistrationContext : DbContext
    {
        public StudentCourseRegistrationContext (DbContextOptions<StudentCourseRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<StudentCourseRegistration.Models.Instructor> Instructor { get; set; }
    }
}
