using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurTravelBlog.Models
{
    public class TravelBlogContext : DbContext
    {
        public virtual DbSet<Location> Locations { get; set;  }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=travelblog;integrated security=True");
        }
    }
}
