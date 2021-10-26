using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StudentCourseRegistration.Models;
using StudentCourseRegistration.Services;

namespace StudentCourseRegistration.Pages
{
    public class CoursesModel : PageModel
    {
        private readonly ILogger<CoursesModel> _logger;
        public JsonFileCoursesService CoursesService;
        public IEnumerable<Course> Courses { get; private set; }

        public CoursesModel(
            ILogger<CoursesModel> logger,
            JsonFileCoursesService coursesService)
        {
            _logger = logger;
            CoursesService = coursesService;
        }

        public void OnGet()
        {
            Courses = CoursesService.GetCourses();
        }
    }
}
