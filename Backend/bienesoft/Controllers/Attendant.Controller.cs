using Bienesoft.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bienesoft.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class AttendantController : Controller
    {
        [HttpPost]
        public IActionResult ReturAttendant(AttendantModel attendant )
        {
            return Ok(attendant.Nom_Acudiente);
        }
    }
}
