using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeService _EmployeeService;

        public EmployeeController (EmployeeService employeeService)
        {
            _EmployeeService = employeeService;
        }
        
        [HttpGet("GetEmployee")]
        public IActionResult GetEmployee(int Id)
        {
            return Ok(_EmployeeService.GetEmployee(Id));
        }

        [HttpGet("GetAllEmployee")]

        public IActionResult GetAllEmployee()
        {
            return Ok(_EmployeeService.GetAllEmployee());
        }

        [HttpPost("SaveEmployee")]

        public IActionResult SaveEmployee(Employee employee)
        {
            return Ok(_EmployeeService.SaveEmployee(employee)); 
        }

        [HttpPut("UpdateEmployee")]

        public IActionResult UpdateEmployee(Employee employee)
        {
            return Ok(_EmployeeService.UpdateEmployee(employee));
        }

        [HttpDelete("DeleteEmployee")]

        public IActionResult DeleteEmployee(int id)
        {
            return Ok(_EmployeeService.DeleteEmployee(id));
        }
    }
}
