using Day1.Models;

namespace Day1.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();
        public Employee? GetEmployeeById(int id);
        public Employee? GetEmployeeByName(string name);
        public void AddNewEmployee(Employee employee);
        public void UpdateEmployee(int id, Employee employee);
        public void DeleteEmployee(int id);
    }
}
