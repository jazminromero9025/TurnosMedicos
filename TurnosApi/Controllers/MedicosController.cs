using Microsoft.EntityFrameworkCore;
using Turnos.Infraestructura;
using Turnos.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Identity.Client;
using Turnos.Application.Services;
using Turnos.Domain.Interface;



namespace TurnosApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class MedicosController : ControllerBase
    {
        private readonly IMedicoService _medicoService;

        public MedicosController(IMedicoService medicoService)
        {
            this._medicoService = medicoService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medico>>> GetMedicos()
        {
            var medico = await _medicoService.ObtenerTodos();
            return Ok(medico);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Medico>> GetMedico(int id)
        {
            var medico = await _medicoService.ObtenerPorId(id);
            if (medico == null)
            {
                return NotFound();
            }

            return Ok(medico);

        }


        [HttpPost]//agregar
        public async Task< ActionResult<Medico>> PostMedico(Medico medico)
        {
            await _medicoService.CrearMedico(medico);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMedico(int id)
        {
             await _medicoService.EliminarMedico(id);
            return Ok();

        }

        //put, para actualizar un medico
        [HttpPut("{id}")]
        public async Task<ActionResult> PutMedico(int id, Medico medicoActualizado)
        {
            var medico = await _medicoService.ObtenerPorId(id);
            if (medico == null)
            {
                return NotFound();
            }


            medico.Nombre = medicoActualizado.Nombre;
            medico.Apellido = medicoActualizado.Apellido;
            medico.Especialidad = medicoActualizado.Especialidad;
            await _medicoService.ActualizarMedico(medico);
            return Ok();

        }







    }
}



    

