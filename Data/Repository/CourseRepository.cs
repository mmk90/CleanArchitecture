using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private MyDBContext _context;
        public CourseRepository(MyDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
