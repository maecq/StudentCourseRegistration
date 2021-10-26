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
    public class CourseController : ControllerBase
    {
        public CourseController(JsonFileCoursesService courseService)
        {
            this.CourseService = courseService;
        }
        public JsonFileCoursesService CourseService { get;  }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return CourseService.GetCourses();
        }
    }
}
