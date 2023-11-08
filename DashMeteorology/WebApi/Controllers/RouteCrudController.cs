﻿using CoreApp;
using DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RouteCrudController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
      public async Task<IActionResult> Create(Route route)
      {
            var um = new RouteManager();
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
        public async Task<IActionResult> Delete(Route route)
        {
            var um = new RouteManager();
            try
            {
                um.Delete(route);
                return Ok(route);
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update(Route route)
        {
            var um = new RouteManager();
            try
            {
                um.Update(route);
                return Ok(route);
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
                var um = new RouteManager();
                return Ok(um.RetrieveAll());
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }




    }
}
