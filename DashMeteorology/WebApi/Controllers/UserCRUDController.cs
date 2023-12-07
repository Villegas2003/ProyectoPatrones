
using CoreApp;
using DataAccess;
using DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(User user)
        {
            try
            {
                var userAdapter = new UserCRUDFactory();
                var um = new UserManager(userAdapter);
                um.Create(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(User user)
        {
            try
            {
                var userAdapter = new UserCRUDFactory();
                var um = new UserManager(userAdapter);
                um.Delete(user);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(User user)
        {
            try
            {
                var userAdapter = new UserCRUDFactory();
                var um = new UserManager(userAdapter);
                um.Update(user);
                return Ok(user);
            }catch(Exception ex)
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
                var userAdapter = new UserCRUDFactory();
                var um = new UserManager(userAdapter);
                return Ok(um.RetrieveAll());
            }catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
