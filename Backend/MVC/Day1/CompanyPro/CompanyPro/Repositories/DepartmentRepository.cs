using CompanyPro.Models;

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

            depiContext.Entry(dept).Collection(d => d.Employees).Load();
            return dept;
        }

    }
}
