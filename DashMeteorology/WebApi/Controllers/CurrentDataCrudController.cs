using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CurrentDataCrudController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
      public async Task<IActionResult> Create(CurrentDataDTO currentData)
      {
            var um = new CurrentDataManager();
            try
            {
                um.Create(currentData);
                return Ok(currentData);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
      }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(CurrentDataDTO currentData)
        {
            var um = new CurrentDataManager();
            try
            {
                um.Delete(currentData);
                return Ok(currentData);
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(CurrentDataDTO currentData)
        {
            var um = new CurrentDataManager();
            try
            {
                um.Update(currentData);
                return Ok(currentData);
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
                var um = new CurrentDataManager();
                return Ok(um.RetrieveAll());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }




    }
}
