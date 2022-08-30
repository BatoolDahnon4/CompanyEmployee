using CompEmplyee.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompEmplyee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyRepo _companyRepo;

        public CompanyController(ICompanyRepo companyRepo)
        {
            _companyRepo = companyRepo;

        }
        [HttpGet]
        [Route("getComapny")]
        public async Task<ActionResult<Company>> GetCompany()
        {
            var emp = _companyRepo.Get();
            return Ok(emp);
        }

        [HttpGet]
        [Route("getCompanyById")]
        public async Task<ActionResult<Company>> GetEmployee(int Id)
        {
            var emp = _companyRepo.GetId(Id);

            if (emp == null)
                return BadRequest("There is no employees found");

            return Ok(emp);
        }

        [HttpPost]
        [Route("addCompany")]
        public async Task<ActionResult<Company>> AddEmployee(Company request)
        {
            var emp = _companyRepo.Addemployee(request);
            return Ok(emp);
        }

        [HttpPut]
        [Route("updateCompany")]
        public async Task<ActionResult<Company>> UpdateCompany(Company request)
        {
            var emp = _companyRepo.updateEmployee(request);

            if (emp == null)
                return BadRequest("There is no employees found");


            return Ok(emp);
        }


        [HttpDelete]
        [Route("deleteCompany")]
        public async Task<ActionResult<Company>> DeleteCompany(int Id)
        {
            var emp = _companyRepo.Delete(Id);

            return Ok(emp);
        }


    }
}
