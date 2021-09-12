using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}
