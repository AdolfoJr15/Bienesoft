using Bienesoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bienesoft.Controllers;

    [ApiController]
    [Route("Api/[Controller]")]
    public class ProgramController : Controller
    {
        [HttpPost]
        public IActionResult CreateProgram(ProgramModel program)
        {
            return Ok("Programa resgitrado exitosamente" + " " +program.Nom_Programa);
        }

        [HttpGet("ConsulProgram")]
        public IActionResult Get(int id) 
        {
        try
        {
            return Ok();
        }
        catch (Exception ex) 
        {
            return StatusCode (500, ex.ToString());
        }
        }

    }
    

