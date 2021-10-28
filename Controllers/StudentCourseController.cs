using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Data;
using StudentCourseRegistration.Models;
using StudentCourseRegistration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Controllers
{
    [ApiController]
    public class StudentCourseController : ControllerBase
    {

        public StudentCourseController(JsonFileStudentCourseServices studentCourseService)
        {
            this.StudentCourseService = studentCourseService; 
        }
        public JsonFileStudentCourseServices StudentCourseService { get;  }

        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<StudentCourse> Get()
        {
            return StudentCourseService.GetStudentCourses();
        }


    }

}
