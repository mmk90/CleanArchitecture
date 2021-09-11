using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreMVC.Models
{
    public class CleanArchtectureDBContext:DbContext
    {
        public CleanArchtectureDBContext(DbContextOptions<CleanArchtectureDBContext> options) :base(options)
        {

        }
    }
}
