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
    public class InstructorsModel : PageModel
    {
        private readonly ILogger<InstructorsModel> _logger;
        public JsonFileInstructorsService InstructorsService;

        public IEnumerable<Instructor> Instructors { get; private set; }

        public InstructorsModel(
            ILogger<InstructorsModel> logger,
            JsonFileInstructorsService instructorsService)
        {
            _logger = logger;
            InstructorsService = instructorsService;
        }

        public void OnGet()
        {
            Instructors = InstructorsService.GetInstructors();
        }
    }
}
