﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Data
{
    public class DataContext : DbContext
    {
        private string _connectionString;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();
            modelBuilder.Entity<Student>().HasData(seeder.Students);

        }
        public DbSet<Bottle> Bottles { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
