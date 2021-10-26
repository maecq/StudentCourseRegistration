using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Models
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CourseName { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Student>(this);

    }
}
