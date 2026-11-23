using CompanyERP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CompanyPro.Models
{
    public class DepiContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public DepiContext() : base()
        {
            
        }

        // DepiContext db = new (options);
        public DepiContext(DbContextOptions<DepiContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(e => e.Employees)
            .HasForeignKey(e => e.DeptId);

            modelBuilder.Entity<Department>().HasData(new Department() { Did = 1, Location = "Cairo", Name = "MVC" });
            modelBuilder.Entity<Department>().HasData(new Department() { Did = 2, Location = "Sohag", Name = "EFCore" });

            modelBuilder.Entity<Employee>().HasData(new Employee() { Id = 1, Name = "Ahmed", DeptId = 1, IsDeleted = false, Address = "12 abbs street", Salary = 12878 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id = 2, Name = "Hassan", DeptId = 2, IsDeleted = false, Address = "12 abbs street", Salary = 15878 });
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id = 3, Name = "Fatma", DeptId = 2, IsDeleted = false, Address = "12 abbs street", Salary = 20878 });

        }
    }
}


/*
 
 parent


 class child : parent{

 }

 */ 