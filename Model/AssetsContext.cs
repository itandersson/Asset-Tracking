using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mini_Project_2.Asset;

namespace Mini_Project_2.Model
{
    public class AssetsContext : DbContext
    {
        public DbSet<Assets> Asset { get; set; }
        public DbSet<MacBook> MacBook { get; set; }
        public DbSet<Asus> Asus { get; set; }
        public DbSet<Lenovo> Lenovo { get; set; }
        public DbSet<HP> HP { get; set; }
        public DbSet<Iphone> Iphone { get; set; }
        public DbSet<Samsung> Samsung { get; set; }
        public DbSet<Nokia> Nokia { get; set; }
        public DbSet<Motorola> Motorola { get; set; }

        /// <summary>
        /// Connection string mssql server
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost,1433;Database=Blogging;Trusted_Connection=False;User Id=SA;Password=@mssql1Ipw;");
        }

        /// <summary>
        /// Table Asset set to not contain a primary key
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assets>(
                asset =>
                {
                    asset.HasNoKey();
                });
        }
    }
}