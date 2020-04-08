using System.Threading.Tasks;
using Escalav3.Models;
using Escalav3.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escalav3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreDetailsController : Controller
    {
        public IDataService _data { get; }
        public StoreDetailsController(IDataService data)
        {
            _data = data;

        }
        //GetAllStore
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _data.GetAllStoresAsync(true);
                return Ok(result);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }
        //GetStoreByIdAsync
        [HttpGet("{StoreId}")]
        public async Task<IActionResult> GetStoreByIdAsync(int StoreId)
        {
            try
            {
                var result = await _data.GetStoreByIdAsync(StoreId, true);
                return Ok(result);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Store model)
        {
            try
            {
                _data.Add(model);
                if (await _data.SaveChangesAsync())
                {
                    return Created($"/{model.StoreId}", model);
                }
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }

        [HttpPut("{StoreId}")]
        public async Task<IActionResult> Put(int StoreId, Store model)
        {
            try
            {
                var Store = await _data.GetStoreByIdAsync(StoreId, false);
                if (Store == null) return NotFound();

                _data.Update(model);

                if (await _data.SaveChangesAsync())
                {
                    return Created($"/StoreDetails/{model.StoreId}", model);
                }
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
            return BadRequest();
        }

        [HttpDelete("{StoreId}")]
        public async Task<IActionResult> Delete(int StoreId)
        {
            try
            {
                var Store = await _data.GetStoreByIdAsync(StoreId, false);
                if (Store == null) return NotFound();

                _data.Delete(Store);
                if (await _data.SaveChangesAsync())
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