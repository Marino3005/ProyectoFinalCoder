using EntregaCoder.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntregaCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NombreController : ControllerBase
    {
        [HttpGet("GetNombreProyecto")]
        public string getNombre()
        {
            return Nombre.getNombreProyecto();
        }
    }
}
