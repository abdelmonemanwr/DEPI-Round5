using CompanyPro.Models;
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

        public IActionResult GetDepartments()
        {
            var depts = departmentRepository.GetDepartments();

            //if (dept == null)
            //{
            //    return NotFound("Item Not Found");
            //}

            return View("ShowDepartments", depts);
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

        [HttpGet]
        public IActionResult Create()
        {
            return View("addNewDepartment");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid == false)
            {
                return View("addNewDepartment", department);
            }

            departmentRepository.CreateNewDepartment(department);
            //var depts = departmentRepository.GetDepartments();
            //return View()
            return RedirectToAction(actionName: "GetDepartments", controllerName: "Department");
        }

    }
}
