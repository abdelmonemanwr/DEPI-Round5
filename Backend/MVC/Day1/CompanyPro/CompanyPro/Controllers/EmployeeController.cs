using CompanyPro.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository employeeRepository;
        public EmployeeController()
        {
            
        }

        public string First()
        {
            return "first";
        }

        public ContentResult Second()
        {
            //var content = new ContentResult();
            //content.Content = "second";
            //return content;

            return new ContentResult
            {
                Content = "Second",
                StatusCode = 200
            };
        }


        public ViewResult ShowView()
        {
            var view = new ViewResult();
            view.ViewName = "myview";
            return view;
        }
        public ViewResult ShowView2()
        {
            return CreateView("myview");
            //return View("myview2");
        }

        private ViewResult CreateView(string viewName)
        {
            var view = new ViewResult();
            view.ViewName = viewName;
            return view;
        }

        public IActionResult ShowMix(bool isView)
        {
            if (isView)
            {
                return new ViewResult
                {
                    ViewName = "myview"
                };
            }
            else
            {
                return new ContentResult
                {
                    Content = "Second"
                };
            }
        }

        public IActionResult GetEmployees()
        {
            employeeRepository = new EmployeeRepository();
            var employeesModel = employeeRepository.GetEmployees();
            return View("showEmployees", employeesModel);
        }

    }
}
