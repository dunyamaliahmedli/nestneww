using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.DAL
{
    public class AppDbContext : DbContext
    {
      
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
