using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Course>(this);
    }
}
