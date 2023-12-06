using CoreApp;
using DataAccess;
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
            
            try
            {
                var productAdapter = new ProductCRUDFactory();
                var um = new ProductManager(productAdapter);
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

            try 
            {
                var productAdapter = new ProductCRUDFactory();
                var um = new ProductManager(productAdapter);
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
            try
            {
                var productAdapter = new ProductCRUDFactory();
                var um = new ProductManager(productAdapter);
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
                var productAdapter = new ProductCRUDFactory();
                var um = new ProductManager(productAdapter);
                return Ok(um.RetrieveAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
