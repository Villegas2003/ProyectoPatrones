using CoreApp;
using DataAccess;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

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
            
            try
            {
                var carriersAdapter = new CarriersCRUDFactory();
                var um = new CarriersManager(carriersAdapter);
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

            try
            {
                var carriersAdapter = new CarriersCRUDFactory();
                var um = new CarriersManager(carriersAdapter);
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

            try
            {
                var carriersAdapter = new CarriersCRUDFactory();
                var um = new CarriersManager(carriersAdapter);
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
                var carriersAdapter = new CarriersCRUDFactory();
                var um = new CarriersManager(carriersAdapter);
                return Ok(um.RetrieveAll());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }




    }
}
