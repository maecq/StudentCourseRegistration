using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using StudentCourseRegistration.Models;
using StudentCourseRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileStudentsService StudentsService;

        public IEnumerable<Student> Students { get; private set; }


        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileStudentsService studentsService)
        { 
            _logger = logger;
            StudentsService = studentsService;
        }

        public void OnGet()
        {
            Students = StudentsService.GetStudents();
        }
    }
}
