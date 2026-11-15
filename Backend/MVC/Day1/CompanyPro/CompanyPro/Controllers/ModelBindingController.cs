using CompanyPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPro.Controllers
{
    public class ModelBindingController : Controller
    {
        // Primitive DT
        // arrays
        // List, Dicitory
        // Complex DT


        // /ModelBinding/Primitive?age=34&name=men3m
        //https://localhost:7011/ModelBinding/Primitive/44?age=34&name=men3m
        public IActionResult Primitive(int age, int id, string name)
        {
            return Content($"age = {age}, name = {name}, id={id}");
        }

        //// /ModelBinding/Primitive?age=34&name=men3m
        ////https://localhost:7011/ModelBinding/Primitive_arrays/colors[0]=red&colors[1]=blue
        ////https://localhost:7011/ModelBinding/Primitive_arrays/colors[0]=red&colors[3]=blue
        //public IActionResult arrays(string[] colors, int num)
        //{
        //    foreach(var color in colors)
        //    {
        //        Console.WriteLine(color);
        //    }
        //    return Content($"colors recieved");
        //}

        //// /ModelBinding/Primitive?age=34&name=men3m
        ////https://localhost:7011/ModelBinding/Dictionary?name=ali&phones[x]=0234&phones[y]=23532
        //public IActionResult Dictionary(Dictionary<string, string> phones, string name)
        //{
        //    foreach(var kvp in phones)
        //    {
        //        Console.WriteLine($"{kvp.Key} {kvp.Value}");
        //    }
        //    return Content("done");
        //}


        // https://localhost:7011/ModelBinding/Complex?did=2&name=SD&location=cairo
        // https://localhost:7011/ModelBinding/Complex?department.did=2&department.Name=SD&department.location=cairo&emp.Name=men3m&emp.id=23
        // https://localhost:7011/ModelBinding/Complex?department.did=2&department.Name=SD&department.location=cairo&emp.Name=men3m&emp.id=23&department.Employees[0].Id=4&department.Employees[0].Name=mohsen
        public IActionResult Complex(Department department, Employee emp)
        {
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(department));
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(emp));
            return Content("done");
        }


    }
}
