using Applications.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Applications.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
