using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyPro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string Address { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
        
        //public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name = {Name}, DeptId = {DeptId}, ImageUrl = {ImageUrl}";
        }
    } 
}
