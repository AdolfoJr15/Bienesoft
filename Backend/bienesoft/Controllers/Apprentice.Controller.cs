using bienesoft.Funcions;
using bienesoft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bienesoft.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ApprenticeController : Controller
    {
        public GeneralFunction GeneralFunction;


        [HttpPost("CreateApprentice")]
        public IActionResult Create(ApprenticeModel Aprendiz)
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
        [HttpGet("GetApprentice")]

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
        [HttpGet("GetsApprentice")]
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
        [HttpPost("UpdateApprentice")]
        public IActionResult Update(int Id, ApprenticeModel Aprendiz)
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
        [HttpDelete("DeleteApprentice")]
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
