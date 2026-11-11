namespace CompanyPro.ViewModels
{
    public class GetEmployeesViewModel
    {
        public List<EmployeeDataViewModel> EmpData { get; set; } = new();
        public string Color { get; set; } = string.Empty;
        public List<string> Branches { get; set; } = new();
        public string Msg { get; set; } = string.Empty;
        public int Temperature { get; set; }
    }

    public class EmployeeDataViewModel
    {
        public int Eid { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public string DeptName { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
    }
}
