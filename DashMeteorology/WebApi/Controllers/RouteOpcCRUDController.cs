using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RouteOpcCRUDController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(RouteOpc route)
        {
            var um = new RouteManagerOpc();
            try
            {
                um.Create(route);
                return Ok(route);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(RouteOpc route)
        {
            var um = new RouteManagerOpc();

            try
            {
                um.Delete(route);
                return Ok(route);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }



        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(RouteOpc route)
        {
            var um = new RouteManagerOpc();
            try
            {
                um.Update(route);
                return Ok(route);
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
                var um = new ProductManager();
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
