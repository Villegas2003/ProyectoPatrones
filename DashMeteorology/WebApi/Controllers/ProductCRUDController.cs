using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCRUDController : ControllerBase
    {

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(Product product)
        {
            var um = new ProductManager();
            try
            {
                um.Create(product);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
           
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Product product)
        {
            var um = new ProductManager();

            try 
            {
                um.Delete(product);
                return Ok(product);
            }catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }

            
            
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Product product)
        {
            var um = new ProductManager();
            try
            {
                um.Update(product);
                return Ok(product);
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
