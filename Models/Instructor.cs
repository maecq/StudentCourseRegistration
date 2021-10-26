using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Models
{
    public class Instructor
    {
        public string InstructorId { get; set; }
        public string IFirstName { get; set; }
        public string ILastName { get; set; }
        public string IEmailAddress { get; set; }
        public string ICourseMaster { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Instructor>(this);
    }
}
