using System.Threading.Tasks;
using Escalav3.Models;
using Escalav3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escalav3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VacationDetailsController : Controller
    {
        public IDataService _repo { get; }
        public VacationDetailsController(IDataService repo)
        {
            _repo = repo;

        }
        //GetAllVacation
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllVacationsAsync();
                return Ok(result);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }
        //GetVacationByIdAsync
        [HttpGet("{VacationId}")]
        public async Task<IActionResult> GetVacationByIdAsync(int VacationId)
        {
            try
            {
                var result = await _repo.GetVacationByIdAsync(VacationId);
                return Ok(result);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Vacation model)
        {
            try
            {
                _repo.Add(model);
                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/{model.Id}", model);
                }
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }

        [HttpPut("{VacationId}")]
        public async Task<IActionResult> Put(int VacationId, Vacation model)
        {
            try
            {
                var Vacation = await _repo.GetVacationByIdAsync(VacationId);
                if (Vacation == null) return NotFound();

                _repo.Update(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/VacationDetails/{model.Id}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }

        [HttpDelete("{VacationId}")]
        public async Task<IActionResult> Delete(int VacationId)
        {
            try
            {
                var Vacation = await _repo.GetVacationByIdAsync(VacationId);
                if (Vacation == null) return NotFound();

                _repo.Delete(Vacation);
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