using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Models
{
    public class StudentCourse
    {
        public string StudentId { get; set; }

        public string CourseID { get; set; }

        //public override string ToString() => JsonSerializer.Serialize<StudentCourse>(this);


    }
}
