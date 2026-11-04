using CompanyPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentRepository departmentRepository;

        // dependecy injection (don't create but inject or ask)
        public DepartmentController(DepartmentRepository departmentRepository) 
        {
            this.departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDepartmentById(int id)
        {
            var dept = departmentRepository.GetDepartmentById(id);

            if (dept == null)
            {
                return NotFound("Item Not Found");
            }

            return View("ShowDepartmentDetails", dept);
        }
    }
}
