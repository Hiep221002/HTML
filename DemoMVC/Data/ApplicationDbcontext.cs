using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
using DemoMVC.Migrations;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {}
        public DbSet<Person>Person{get;set;}
        public DbSet<Student>Student{get;set;}
        public DbSet<Daily>Daily{get;set;}
        public DbSet<HeThongPhanPhoi>HeThongPhanPhoi{get;set;}
        
    }
}