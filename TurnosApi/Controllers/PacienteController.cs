using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turnos.Application.Services;
using Turnos.Domain.Entities;
using Turnos.Infraestructura;
using Turnos.Infraestructura.Repositories;
using Turnos.Application.Services;
using Turnos.Domain.Interface;


namespace TurnosApi.Controllers
{

    [ApiController]
 
    [Route("api/[controller]")]

    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService paciente)
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
        [HttpGet("{id}")]
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

            await _pacienteService.CrearPaciente(paciente);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = paciente.Id }, paciente);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _pacienteService.EliminarPaciente(id);
            return NoContent();


        }

    }
}
