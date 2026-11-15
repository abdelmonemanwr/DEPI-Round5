using CompanyPro.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyPro.Repositories
{
    public class DepartmentRepository
    {
        private readonly DepiContext depiContext;

        public DepartmentRepository()
        {
            depiContext = new DepiContext();
        }

        public Department? GetDepartmentById(int id)
        {
            var dept = depiContext.Departments.FirstOrDefault(d => d.Did == id);

            if (dept == null)
            {
                return null;
            }

            dept.Name = "erere";


            depiContext.Entry(dept).Collection(d => d.Employees).Load();
            return dept;
        }

        public List<Department> GetDepartments()
        {
            return depiContext.Departments.AsNoTracking().ToList();
        }

        public void CreateNewDepartment(Department department)
        {
            depiContext.Departments.Add(department);
            //depiContext.Add(department);
            depiContext.SaveChanges();
        }
    }
}
