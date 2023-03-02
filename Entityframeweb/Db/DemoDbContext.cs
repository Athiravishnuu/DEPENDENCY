using Entityframeweb.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;

namespace Entityframeweb.Db
{
    public class DemoDbContext :DbContext
    {

        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addreses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   var path = "Server=localhost\\SQLEXPRESS;Database=web;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";         
        //   optionsBuilder.UseSqlServer(path);
        //   base.OnConfiguring(optionsBuilder);
        //}
    }  
}

