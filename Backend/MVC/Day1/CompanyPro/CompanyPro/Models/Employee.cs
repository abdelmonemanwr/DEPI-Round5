namespace CompanyPro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public override string ToString()
        {
            return $"Id={Id}, Name = {Name}, DeptId = {DeptId}, ImageUrl = {ImageUrl}";
        }
    } 
}
