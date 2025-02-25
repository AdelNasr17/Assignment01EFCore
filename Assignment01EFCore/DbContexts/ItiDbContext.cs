using Assignment01EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.DbContexts
{
    internal class ItiDbContext : DbContext
    {

        public ItiDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .; Database = ItiDb; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Topic>? Topic { get; set; }
        public DbSet<Instructor>? Instructors { get; set; }
       // public DbSet<Course_Inst> Course_Inst {  get; set; }

        public DbSet<Department>? Departments { get; set; }
       // public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
