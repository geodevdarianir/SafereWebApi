using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SafereWebApi.Models
{
    public partial class SafereDBContext : DbContext
    {
        //private readonly string _connection;
        //public SafereDBContext(string connection)
        //{
        //    _connection = connection;
        //}

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ArticleCategory> ArticleAndCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-I6D89M8;database=SafereTestDB;User ID=SafereTest;password=123safere123;");//"server=DESKTOP-I6D89M8;database=SafereDB;User ID=SafereDB;password=123safere123;"
            }
        }
    }
}
