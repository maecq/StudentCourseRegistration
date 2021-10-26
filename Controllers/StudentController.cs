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
    public class StudentController : ControllerBase
    {

        public StudentController(JsonFileStudentsService studentService)
        {
            this.StudentService = studentService;
        }

        public JsonFileStudentsService StudentService { get; }

        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<Student> Get()
        {
            return StudentService.GetStudents();
        }

    }
}
