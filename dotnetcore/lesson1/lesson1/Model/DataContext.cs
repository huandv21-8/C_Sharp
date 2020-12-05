using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using lesson1.Model;

namespace lesson1.Model
{
    
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=T1907A;Integrated Security=True");
        }


        public DbSet<Category> Categories { get; set; }


        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }

    }
}
