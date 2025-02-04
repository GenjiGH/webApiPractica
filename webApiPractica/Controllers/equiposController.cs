using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace webApiPractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContext;
        public equiposController(equiposContext equiposContext) { 
            _equiposContext = equiposContext;
        }

        /// <summary>
        /// ENdpoint que retorna el listado de todos los equipos existentes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get() {
            List<equipos> ListadoEquipo = (from e in _equiposContext.equipos select e).ToList();
            if(ListadoEquipo.Count() == 0)
            {
                return NotFound();
            }
            return Ok(ListadoEquipo);
        }
    }
}
