using CompanyPro.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyPro.Repositories
{
    public class EmployeeRepository
    {
        //private List<Employee> employees;

        private readonly DepiContext db = new DepiContext();
        public EmployeeRepository()
        {
            //employees = new List<Employee>
            //{
            //    new Employee(){Id = 2, Name = "ahmed atef", ImageUrl = "male.jpeg", DeptId=20, IsDeleted=false },
            //    new Employee(){Id = 2, Name = "fatma", ImageUrl = "female.jpeg", DeptId=30, IsDeleted=false},
            //    new Employee(){Id = 2, Name = "youssef", ImageUrl = "male.jpeg", DeptId=20, IsDeleted=false },
            //    new Employee(){Id = 2, Name = "ola", ImageUrl = "female.jpeg", DeptId=30, IsDeleted = true },
            //};
        }

        //[Obsolete("in memory db")]
        //public List<Employee> GetEmployees()
        //{
        //    return employees.Where(emp => emp.IsDeleted == false).ToList();
        //}

        public List<Employee> GetEmployees()
        {
            // Eager Loading
            //var emps =  db.Employees.Include(e=>e.Department).Where(e => e.IsDeleted == false).ToList();

            //// Explicit Loading
            //var emps =  db.Employees.Where(e => e.IsDeleted == false).ToList();
            //// N+1 Problem
            //foreach(var emp in emps)
            //{
            //    db.Entry(emp).Reference(emp => emp.Department).Load();
            //}

            var emps =  db.Employees.Where(e => e.IsDeleted == false).ToList();
            return emps;
        }



    }
}
