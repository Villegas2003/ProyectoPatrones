using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(HistoryDTO history)
        {
            var um = new HistoryManager();
            try
            {
                um.Create(history);
                return Ok(history);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(HistoryDTO history)
        {
            var um = new HistoryManager();
            try
            {
                um.Delete(history);
                return Ok(history);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(HistoryDTO history)
        {
            var um = new HistoryManager();
            try
            {
                um.Update(history);
                return Ok(history);
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
                var um = new HistoryManager();
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
