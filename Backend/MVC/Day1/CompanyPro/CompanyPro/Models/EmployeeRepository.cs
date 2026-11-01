namespace CompanyPro.Models
{
    public class EmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>
            {
                new Employee(){Id = 2, Name = "ahmed atef", ImageUrl = "male.jpeg", DeptId=20, IsDeleted=false },
                new Employee(){Id = 2, Name = "fatma", ImageUrl = "female.jpeg", DeptId=30, IsDeleted=false},
                new Employee(){Id = 2, Name = "youssef", ImageUrl = "male.jpeg", DeptId=20, IsDeleted=false },
                new Employee(){Id = 2, Name = "ola", ImageUrl = "female.jpeg", DeptId=30, IsDeleted = true },
            };
        }

        public List<Employee> GetEmployees()
        {
            return employees.Where(emp => emp.IsDeleted == false).ToList();
        }

    }
}
