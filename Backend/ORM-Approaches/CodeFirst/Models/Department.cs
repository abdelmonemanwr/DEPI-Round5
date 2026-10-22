using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeFirst.Models
{
    public class Department
    {
        //[Key]
        public int Did { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        [ForeignKey("Manager")]
        public int MgrId { get; set; }  // fake: studentId
        public Student Manager { get; set; }

        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Id = {Did}, Department Name = {Name} Location = {Location}";
        }
    }
}
