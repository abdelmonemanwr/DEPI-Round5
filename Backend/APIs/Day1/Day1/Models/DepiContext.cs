using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class DepiContext : DbContext
    {
        public DepiContext() : base()
        {
            
        }
        public DepiContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Engineering", Location = "Building A - Floor 3" },
                new Department { Id = 2, Name = "Human Resources", Location = "Building B - Floor 1" },
                new Department { Id = 3, Name = "Sales", Location = "Building A - Floor 2" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Omar Hassan",
                    Email = "omar.hassan@example.com",
                    PhoneNumber = "+201001112233",
                    DepartmentId = 1
                },
                new Employee
                {
                    Id = 2,
                    Name = "Mona Adel",
                    Email = "mona.adel@example.com",
                    PhoneNumber = "+201004445566",
                    DepartmentId = 1
                },
                new Employee
                {
                    Id = 3,
                    Name = "Karim Tarek",
                    Email = "karim.tarek@example.com",
                    PhoneNumber = "+201007778899",
                    DepartmentId = 2
                },
                new Employee
                {
                    Id = 4,
                    Name = "Nourhan Samir",
                    Email = "nourhan.samir@example.com",
                    PhoneNumber = "+201009998877",
                    DepartmentId = null
                }
            );
        }
    }
}
