using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarsAdvisors.Models
{
    public class Cars : IdentityDbContext
    {
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Compare> Compares { get; set; }
        public DbSet<News_Reviews> News_Reviews { get; set; }


        //public CarsAdvisors(DbContextOptions options) : base(options)
        //{

        //}
        //public CarsAdvisors()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Cars;Integrated Security=True");
        }


    }
}
