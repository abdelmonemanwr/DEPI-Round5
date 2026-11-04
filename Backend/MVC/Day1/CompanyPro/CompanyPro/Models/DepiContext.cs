using Microsoft.EntityFrameworkCore;

namespace CompanyPro.Models
{
    public class DepiContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public DepiContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=Depi_Dotnet_R5;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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