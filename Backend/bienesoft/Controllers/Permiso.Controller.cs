using Bienesof.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bienesof.Controllers
{
    [ApiController]
    [Route("Api[Controller]")]
    public class PermisoController : Controller
    {
        [HttpPost("CreatePermiso")]

        public IActionResult Create(PermisoModel permiso)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpGet("GetPermiso")]

        public IActionResult Get(int Id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());

            }
        }
        [HttpPut("UpdatePermiso")]

        public IActionResult Update(int Id,PermisoModel permiso)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());

            }
        }
        [HttpDelete("DeletePermiso")]

        public IActionResult Delete(int Id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());

            }
        }
    }
}
