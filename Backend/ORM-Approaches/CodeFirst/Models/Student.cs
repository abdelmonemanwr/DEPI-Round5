using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(50)]
        public string FName { get; set; } = string.Empty;
        public string? LName { get; set; }

        [Length(minimumLength:10, maximumLength: 200, ErrorMessage = "length must be within range (10, 20)")]
        public string? Address { get; set; }

        public int Age { get; set; }

        [ForeignKey("StdDepartment")]
        public int DeptId { get; set; }
        public Department StdDepartment { get; set; }

        [InverseProperty("Manager")]
        public Department StManager { get; set; }

        //[ForeignKey(nameof("DeptId"))]
        //public Department Dept { get; set; }  

        public override string ToString()
        {
            return $"Id = {Id}, FullName = {FName} {LName} Age = {Age}";
        }
    }
}
