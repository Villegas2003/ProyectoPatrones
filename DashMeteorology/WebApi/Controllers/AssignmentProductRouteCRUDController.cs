using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentProductRouteCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(AssignmentProductRoute assignmentProductRoute)
        {
            var um = new AssignmentProductRouteManager();
            try
            {
                um.Create(assignmentProductRoute);
                return Ok(assignmentProductRoute);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(AssignmentProductRoute assignmentProductRoute)
        {
            var um = new AssignmentProductRouteManager();
            try
            {
                um.Delete(assignmentProductRoute);
                return Ok(assignmentProductRoute);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(AssignmentProductRoute assignmentProductRoute)
        {
            var um = new AssignmentProductRouteManager();
            try
            {
                um.Update(assignmentProductRoute);
                return Ok(assignmentProductRoute);
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
                var um = new AssignmentProductRouteManager();
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
