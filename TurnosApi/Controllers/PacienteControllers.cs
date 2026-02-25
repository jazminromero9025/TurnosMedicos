using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turnos.Application.Services;
using Turnos.Domain.Entities;
using Turnos.Infraestructura;
using Turnos.Infraestructura.Repositories;
using Turnos.Application.Services;


namespace TurnosApi.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]

    public class PacienteControllers : ControllerBase
    {
        private readonly PacienteService _pacienteService;

        public PacienteControllers(PacienteService paciente)
        {
            this._pacienteService = paciente;
        }


        //GET: API Paciente
        [HttpGet]
        public async Task<ActionResult> ObtenerTodos()
        {
            var paciente = await _pacienteService.ObtenerTodos();
            return Ok(paciente);
        }



        //Get: Api id
        [HttpGet("{Id)}"]
        public async Task<IActionResult> ObtenerPorId (int id)
        {
            var paciente = await _pacienteService.ObtenerPorId(id);
            if(paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }


        //Post: Api paciente
        [HttpPost]

        public async Task<IActionResult> Crear(Paciente paciente)
        {

            _pacienteService.CrearPaciente(paciente);
            return Ok(paciente);
        }


        [HttpDelete]
        public async Task<IActionResult> Elimiar(int id)
        {
            await _pacienteService.EliminarPaciente(id);
            return NoContent();


        }

    }
}
