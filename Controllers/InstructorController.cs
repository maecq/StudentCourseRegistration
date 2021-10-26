using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Models;
using StudentCourseRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        public InstructorController(JsonFileInstructorsService instructorService)
        {
            this.InstructorService = instructorService;
        }
        public JsonFileInstructorsService InstructorService { get; }

        [HttpGet]
        public IEnumerable<Instructor> Get()
        {
            return InstructorService.GetInstructors();
        }

    }

}

