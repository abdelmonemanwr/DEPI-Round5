using System.ComponentModel.DataAnnotations;

namespace CompanyPro.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }

        [MaxLength(25)]
        [MinLength(5)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string Location { get; set; } = string.Empty;

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
