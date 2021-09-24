using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Applications.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
