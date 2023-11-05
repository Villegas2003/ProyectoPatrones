using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForeCastCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(ForeCastDTO foreCast)
        {
            var um = new ForeCastManager();
            try
            {
                um.Create(foreCast);
                return Ok(foreCast);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(ForeCastDTO foreCast)
        {
            var um = new ForeCastManager();
            try
            {
                um.Delete(foreCast);
                return Ok(foreCast);
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(ForeCastDTO foreCast)
        {
            var um = new ForeCastManager();
            try
            {
                um.Update(foreCast);
                return Ok(foreCast);
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
                var um = new ForeCastManager();
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
