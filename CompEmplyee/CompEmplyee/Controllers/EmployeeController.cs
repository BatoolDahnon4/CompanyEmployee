using CompEmplyee.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompEmplyee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
     
        private IEmployeeRepo _employeeRepo;

        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
            
        }

        [HttpGet]
        [Route("getEmployees")]
        public async Task<ActionResult<Employee>> GetEmployee()
        {
            var emp = _employeeRepo.Get();
            return Ok(emp);
        }

        [HttpGet]
        [Route("getStudentById")]
        public async Task<ActionResult<Employee>> GetEmployee(int Id)
        {
            var emp = _employeeRepo.GetId(Id);
     
            if (emp == null)
                return BadRequest("There is no employees found");

            return Ok(emp);
        }

        [HttpPost]
        [Route("addEmployee")]
        public async Task<ActionResult<Employee>>AddEmployee(Employee request)
        {
            var emp = _employeeRepo.Addemployee(request);
            return Ok(emp);
        }

        [HttpPut]
        [Route("updateEmployee")]
        public async Task<ActionResult<Employee>> UpdateEmployee(Employee request)
        {
            var emp = _employeeRepo.updateEmployee(request);
  
            if (emp == null)
                return BadRequest("There is no employees found");

          
            return Ok(emp);
        }

   
        [HttpDelete]
        [Route("deleteEmployee")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int Id)
            {
            var emp = _employeeRepo.Delete(Id);
       
            return Ok(emp);
        }


    }
}
