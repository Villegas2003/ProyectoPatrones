using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarriersCrudController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
      public async Task<IActionResult> Create(Carriers carriers)
      {
            var um = new CarriersManager();
            try
            {
                um.Create(carriers);
                return Ok(carriers);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
      }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Carriers carriers)
        {
            var um = new CarriersManager();
            try
            {
                um.Delete(carriers);
                return Ok(carriers);
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Carriers carriers)
        {
            var um = new CarriersManager();
            try
            {
                um.Update(carriers);
                return Ok(carriers);
            } catch (Exception ex) 
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
                var um = new CarriersManager();
                return Ok(um.RetrieveAll());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }




    }
}
