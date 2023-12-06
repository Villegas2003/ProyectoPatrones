using CoreApp;
using DataAccess;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(DTOs.Route route)
        {
            
            try
            {
                var routeAdapter = new RouteCRUDFactory();
                var um = new RouteManager(routeAdapter);
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
        public async Task<IActionResult> Delete(DTOs.Route route)
        {

            try
            {
                var routeAdapter = new RouteCRUDFactory();
                var um = new RouteManager(routeAdapter);
                um.Delete(route);
                return Ok(route);
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(DTOs.Route route)
        {

            try
            {
                var routeAdapter = new RouteCRUDFactory();
                var um = new RouteManager(routeAdapter);
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
                var routeAdapter = new RouteCRUDFactory();
                var um = new RouteManager(routeAdapter);
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
