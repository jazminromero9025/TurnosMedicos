using Microsoft.AspNetCore.Mvc;
using Turnos.Application.Services;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;



namespace TurnosApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]


    public class TurnosController : ControllerBase
    {

        private readonly ITurnoService _turnoService;

        public TurnosController(ITurnoService turnoService)
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
            try
            {
                _turnoService.CrearTurno(turno);
                return CreatedAtAction(nameof(ObtenerPorId), new { id = turno.Id }, turno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




        [HttpPut ("{id}")]

        public IActionResult Actualizar(int id, [FromBody] Turno turno)
        {
            if(id != turno.Id)
            {
                return BadRequest();
            }

            _turnoService.ActualizarTurno(turno);
            return NoContent();

        }


        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            try
            {
                _turnoService.EliminarTurno(id);
                return NoContent(); // 204
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }




    }
}
