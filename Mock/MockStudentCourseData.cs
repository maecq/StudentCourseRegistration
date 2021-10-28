using Microsoft.AspNetCore.Hosting;
using StudentCourseRegistration.Data;
using StudentCourseRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseRegistration.Mock
{
    public class MockStudentCourseData : IStudentCourseData
    {
        private List<StudentCourse2> studentCourse2 = new List<StudentCourse2>
        {
            new StudentCourse2()
            {
                StudentId = "ST-2021-001",
                CourseID = "COURSE-2021-001"
            },
            new StudentCourse2()
            {
                StudentId = "ST-2021-001",
                CourseID = "COURSE-2021-002"
            },
            new StudentCourse2()
            {
                StudentId = "ST-2021-001",
                CourseID = "COURSE-2021-003"
            },
            new StudentCourse2()
            {
                StudentId = "ST-2021-002",
                CourseID = "COURSE-2021-001"
            },
            new StudentCourse2()
            {
                StudentId = "ST-2021-002",
                CourseID = "COURSE-2021-002"
            },
            new StudentCourse2()
            {
                StudentId = "ST-2021-003",
                CourseID = "COURSE-2021-001"
            },
            new StudentCourse2()
            {
                StudentId = "ST-2021-003",
                CourseID = "COURSE-2021-004"
            }
        };

        public List<StudentCourse2> GetStudentsFromCourse(string _courseID)
        {
            //throw new NotImplementedException();
            //return studentCourse.SingleOrDefault(x => x.CourseID == _courseID);
            return studentCourse2.FindAll(x => x.CourseID == _courseID);
        }



    }
}
