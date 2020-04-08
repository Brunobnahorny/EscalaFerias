using System.Threading.Tasks;
using Escalav3.Models;
using Escalav3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escalav3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : Controller
    {
        public IDataService _repo { get; }
        public EmployeeDetailsController(IDataService repo)
        {
            _repo = repo;

        }
        //GetAllEmployee
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllEmployeesAsync(true);
                return Ok(result);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }
        //GetEmployeeByIdAsync
        [HttpGet("{EmployeeId}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(int EmployeeId)
        {
            try
            {
                var result = await _repo.GetEmployeeByIdAsync(EmployeeId, true);
                 if (result == null) return NotFound();
                return Ok(result);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Employee model)
        {
            try
            {
                _repo.Add(model);
                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/{model.EmployeeId}", model);
                }
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }

        [HttpPut("{EmployeeId}")]
        public async Task<IActionResult> Put(int employeeId, Employee model)
        {
            try
            {
                var employee = await _repo.GetEmployeeByIdAsync(employeeId, false);
                if (employee == null) return NotFound();

                _repo.Update(model);


                if (await _repo.SaveChangesAsync())
                {
                    return Created($"api/EmployeeDetails/{model.EmployeeId}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }

        [HttpDelete("{EmployeeId}")]
        public async Task<IActionResult> Delete(int employeeId)
        {
            try
            {
                var employee = await _repo.GetEmployeeByIdAsync(employeeId, false);
                if (employee == null) return NotFound();

                _repo.Delete(employee);
                if (await _repo.SaveChangesAsync())
                {
                    return Ok();
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }


    
    
    }
}