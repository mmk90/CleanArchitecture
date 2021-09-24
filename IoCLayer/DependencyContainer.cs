using Applications.Interfaces;
using Applications.Services;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCLayer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ICourseService, CourseService>();

            service.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
