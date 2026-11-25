using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DepiContext db;

        public EmployeeRepository(DepiContext db)
        {
            this.db = db;
        }

        public void AddNewEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = db.Employees.FirstOrDefault(e => e.Id == id);
            if (employee is null)
            {
                throw new Exception("employee not found");
            }
            db.Entry(employee).State = EntityState.Deleted;
            //db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public Employee? GetEmployeeById(int id)
        {
            return db.Employees.AsNoTracking().Include(e => e.Department).FirstOrDefault(e => e.Id == id);
        }

        public Employee? GetEmployeeByName(string name)
        {
            return db.Employees.AsNoTracking().Include(e=>e.Department).FirstOrDefault(e => e.Name == name);
        }

        public List<Employee> GetEmployees()
        {
            // 10:PageSize, 3:PageNumber
            //return db.Employees.AsNoTracking().Include(e => e.Department).Skip(10 * (3 - 1)).Take(10).ToList();
            return db.Employees.AsNoTracking().Include(e => e.Department).ToList();
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
