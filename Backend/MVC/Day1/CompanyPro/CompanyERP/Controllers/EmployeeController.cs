using CompanyPro.Repositories;
using CompanyPro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;

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

        public IActionResult GetEmployees_old()
        {
            // extra data
            string msg = "this is lec 4";
            int temp = 37;
            List<string> branches = ["Cairo", "Menoufia", "Sohag", "Alex"];
            string color = "blue";

            //Dictionary<string, ??> ViewData
            ViewData["Msg"] = msg;
            ViewBag.Msg = "this is mvc course";
            ViewBag.Round = 5;
            ViewData["Temp"] = temp;
            ViewData["Branches"] = branches;
            ViewData["Color"] = color;
            ViewData["Round"] = "Round5";

            employeeRepository = new EmployeeRepository();
            var employeesModel = employeeRepository.GetEmployees();
            return View("showEmployees", employeesModel);
        }
        
        public IActionResult GetEmployees()
        {
            // extra data
            string msg = "this is lec 4";
            int temp = 37;
            List<string> branches = ["Cairo", "Menoufia", "Sohag", "Alex"];
            string color = "blue";

            employeeRepository = new EmployeeRepository();
            var employeesModel = employeeRepository.GetEmployees();

            GetEmployeesViewModel employeesViewModel = new();

            List<EmployeeDataViewModel> empData = new();
            foreach(var empModel in employeesModel)
            {
                empData.Add(
                    new EmployeeDataViewModel()
                    {
                        Eid = empModel.Id,
                        DeptName = empModel.Department.Name,
                        EmpName = empModel.Name,
                        ImageUrl = empModel.ImageUrl,
                    }
                );
            }

            employeesViewModel.EmpData = empData;
            employeesViewModel.Color = color;
            employeesViewModel.Msg = msg;
            employeesViewModel.Branches = branches;
            employeesViewModel.Temperature = temp;

            return View("showEmployeesVM", employeesViewModel);
        }

    }
}
