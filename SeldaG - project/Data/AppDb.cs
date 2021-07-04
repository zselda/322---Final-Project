using Microsoft.EntityFrameworkCore;
using SeldaG___project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeldaG___project.Data
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options): base(options)
        {

        }
      
        public DbSet<School> School { get; set; }
        public DbSet<DonationType> DonationType { get; set; }
    }
}
