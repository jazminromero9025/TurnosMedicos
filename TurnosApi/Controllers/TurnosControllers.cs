using Microsoft.AspNetCore.Mvc;
using Turnos.Application.Services;
using Turnos.Domain.Entities;



namespace TurnosApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]


    public class TurnosControllers : ControllerBase
    {

        private readonly TurnoService _turnoService;

        public TurnosControllers(TurnoService turnoService)
        {
            this._turnoService = turnoService;
        }


        [HttpGet]
        public ActionResult<List<Turno>> ObtenerTodos()
        {

            return _turnoService.ObtenerTurnos();
        }



        [HttpGet("{id}")]

        public ActionResult<Turno> ObtenerPorId(int id)
        {
            var turno = _turnoService.ObtenerPorId(id);
            if (turno == null)
            {
                return NotFound();

            }

            return turno;

        }



        [HttpPost]
        public IActionResult Crear([FromBody] Turno turno)
        {
            _turnoService.CrearTurno(turno);
            return Ok();
        }


        [HttpDelete("{id}")]

        public IActionResult Eliminar(int id)
        {
            _turnoService.EliminarTurno(id);
            return NoContent();

        }



    }
}
