using bienesoft.Funcions;
using bienesoft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bienesoft.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AprendizController : Controller
    {
        public GeneralFunction GeneralFunction;


        [HttpPost("CreateAprendiz")]
        public IActionResult Create(AprendizModel Aprendiz)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());

            }
        }
        [HttpGet("GetAprendiz")]

        public IActionResult Get(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                {
                    GeneralFunction.Addlog(ex.Message);
                    return StatusCode(500, ex.ToString());
                }
            }
        }
        [HttpGet("GetsAprendiz")]
        public IActionResult Gets(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                {
                    GeneralFunction.Addlog(ex.Message);
                    return StatusCode(500, ex.ToString());
                }
            }
        }
        [HttpPost("UpdateAprendiz")]
        public IActionResult Update(int Id, AprendizModel Aprendiz)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpDelete("DeleteAprendiz")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                GeneralFunction.Addlog(ex.Message);
                return StatusCode(500, ex.ToString());
            }
        }

    }
}
