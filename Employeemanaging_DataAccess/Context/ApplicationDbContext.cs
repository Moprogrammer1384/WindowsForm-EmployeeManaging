using Employeemanaging_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Employeemanaging_DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            optionsBuilder.UseSqlServer(config["ConnectionStrings:DefaultConnection"]);
        }
        public DbSet<EmployeesTB> EmployeesTB { get; set; }
        public DbSet<Login> Login { get; set; }

  

    }
}
