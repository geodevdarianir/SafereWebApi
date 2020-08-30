using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SafereWebApi.Models
{
    public class SafereMainDBContext : DbContext
    {
        public SafereMainDBContext(DbContextOptions<SafereMainDBContext> options) : base(options) { }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-I6D89M8;database=SafereMain;User ID=SafereMain;password=123safere123;");
            }
        }
    }
}
