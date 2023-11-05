using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitieCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CitieDTO citie)
        {
            var um = new CitieManager();
            try
            {
                um.Create(citie);
                return Ok(citie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
           
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(CitieDTO citie)
        {
            var um = new CitieManager();

            try 
            {
                um.Delete(citie);
                return Ok(citie);
            }catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }

            
            
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(CitieDTO citie)
        {
            var um = new CitieManager();
            try
            {
                um.Update(citie);
                return Ok(citie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("RetrieveAll")]
        public async Task<IActionResult> RetrieveAll()
        {
            try
            {
                var um = new CitieManager();
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
