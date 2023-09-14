using Assignment4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> Employees = new List<Employee>
        {
            new Employee(){EmpId=1, EmpName="sam",Destination="Manager"},
            new Employee(){EmpId=2, EmpName="Amit",Destination="HR"},
            new Employee(){EmpId=3, EmpName="Virat",Destination="Developer"},
            new Employee(){EmpId=4, EmpName="Vijay",Destination="Tester"},
            new Employee(){EmpId=5, EmpName="Suriya",Destination="Manager"},

        };
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(Employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Invalid Employee data.");
            }

            employee.EmpId = Employees.Max(e => e.EmpId) + 1; // Generate a new ID
            Employees.Add(employee);

            return CreatedAtAction(nameof(Get), new { id = employee.EmpId }, employee);
        }
    }
}
