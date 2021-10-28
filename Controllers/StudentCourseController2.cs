using Microsoft.AspNetCore.Mvc;
using StudentCourseRegistration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentCourseRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController2 : ControllerBase
    {
        private IStudentCourseData _studentCourseData2;

        public StudentCourseController2(IStudentCourseData studentCourseData2)
        {
            _studentCourseData2 = studentCourseData2;
        }


        // GET: api/<StudentCourseController2>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentCourseController2>/5
        [HttpGet("{courseID}")]
        public IActionResult Get(string courseID)
        {
            var student = _studentCourseData2.GetStudentsFromCourse(courseID);
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound($"Student with Course ID: {courseID} was not found");
            //return "value";
        }

        // POST api/<StudentCourseController2>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentCourseController2>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentCourseController2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
