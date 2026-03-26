using Turnos.Infraestructura;
using Turnos.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Turnos.Domain.Interface;


namespace TurnosApi.Controllers
{


    [ApiController]
    [Route("api/[Controller]")]

    public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadService _EspecialidadService;

        public EspecialidadesController(IEspecialidadService _EspecialidadService)
        {
            this._EspecialidadService = _EspecialidadService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidad>>> GetEspecialidades()
        {
            var especialidades = await _EspecialidadService.ObtenerTodas();
            return Ok(especialidades);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidad>> GetEspecialidadId(int id)
        {
            var especialidad = await _EspecialidadService.ObtenerPorId(id);

            if (especialidad == null)
            {
                return NotFound();
            }

            return Ok(especialidad);
        }
        



        [HttpPost] //agregar
        public async Task<ActionResult> PostEspecialidad(Especialidad especialidad)
        {
            await _EspecialidadService.CrearEspecialidad(especialidad);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutEspecialidad(int id, Especialidad especialidadActualizada)
        {
            var existente = await _EspecialidadService.ObtenerPorId(id);

            if (existente == null)
            {
                return NotFound();
            }

            await _EspecialidadService.ActualizarEspecialidad(id, especialidadActualizada);

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEspecialidad(int id)
        {
            var especialidad = await _EspecialidadService.ObtenerPorId(id);

            if (especialidad == null)
            {
                return NotFound();
            }

            await _EspecialidadService.EliminarEspecialidad(id);

            return Ok();
        }





    }
}
