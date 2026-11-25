using Day1.Models;
using Day1.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    //[Route("api/[Controller]/[Action]")]
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            var emps = employeeRepository.GetEmployees();
            return Ok(emps);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var emp = employeeRepository.GetEmployeeById(id);
            if(emp is null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        [HttpGet("{name:alpha}")]
        public ActionResult<Employee> GetEmployeeByName(string name)
        {
            var emp = employeeRepository.GetEmployeeByName(name);
            if (emp is null)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        [HttpPost]
        public ActionResult AddNewEmployee(Employee emp)
        {
            if(emp is null)
            {
                return BadRequest();
            }

            if(ModelState.IsValid==false)
            {
                return BadRequest(ModelState);
            }


            employeeRepository.AddNewEmployee(emp);
            //return Created("test", new {emp.Id});
            return CreatedAtAction($"GetEmployeeById/{emp.Id}", new {});
        }

        // api/employee/2
        [HttpPut("{id:int}")]
        public ActionResult EditNewEmployee(
            int id,
            [FromHeader] string test, 
            [FromBody]Employee emp)
        {
            if(emp is null)
            {
                return BadRequest();
            }

            if(ModelState.IsValid==false)
            {
                return BadRequest(ModelState);
            }

            if(id != emp.Id)
            {
                return BadRequest();
            }

            employeeRepository.UpdateEmployee(id, emp);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteEmployee(int id)
        {
            employeeRepository.DeleteEmployee(id);
            return Ok();
        }


    }
}
