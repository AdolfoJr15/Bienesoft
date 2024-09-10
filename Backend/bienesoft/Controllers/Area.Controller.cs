using Bienesof.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bienesof.Controllers
{
    [ApiController]
    [Route("Api[Controller]")]
    public class AreaController : Controller
    {

        [HttpPost("CreaArea")]

        public IActionResult Create(AreaModel area)
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
        [HttpGet("GetArea")]

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
        [HttpPut("UpdateArea")]

        public IActionResult Update(int Id, AreaModel area)
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
        [HttpDelete("DeleteArea")]

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
