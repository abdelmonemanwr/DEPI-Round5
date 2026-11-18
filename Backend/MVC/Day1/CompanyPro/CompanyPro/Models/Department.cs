using System.ComponentModel.DataAnnotations;

namespace CompanyPro.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }

        [MaxLength(length: 25, ErrorMessage = "Name can't be more than 25 character")]
        [MinLength(length: 5, ErrorMessage = "Name can't be less than 5 character")]
        public string Name { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "loc can't exceed 50")]
        public string Location { get; set; } = string.Empty;

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        // just for test
        //[Display(Name="DeptName")]
        //public string DepartmentName { get; set; } = string.Empty;
        //public string DepartmentLocation { get; set; } = string.Empty;

        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; } = string.Empty;
        
        //[DataType(DataType.Password)]
        //public string Password { get; set; } = string.Empty;
        //public string Username { get; set; } = string.Empty;
    }
}
