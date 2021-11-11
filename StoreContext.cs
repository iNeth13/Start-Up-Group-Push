
using Microsoft.EntityFrameworkCore;
using Start_Up_Group.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Start_Up_Group
{
    public class StoreContext : DbContext
    {

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server=localhost;database=test_parking;uid=root;password=nethdb;",
                new MySqlServerVersion(new Version(10, 4, 17))
                );
        }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; } 
    }
}
