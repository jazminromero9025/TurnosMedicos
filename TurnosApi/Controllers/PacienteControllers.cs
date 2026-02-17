using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turnos.Domain.Entities;
using Turnos.Infraestructura;



namespace TurnosApi.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]

    public class PacienteControllers : ControllerBase
    {
        private readonly TurnosDbContext _context;

        public PacienteControllers(TurnosDbContext context)
        {
            this._context = context;
        }


        //GET: API Paciente
        [HttpGet]
        public ActionResult Paciente()
        {
            var paciente = _context.Pacientes.ToList();
            return Ok(paciente);
        }



        //Get: Api id
        [HttpGet("{Id)}"]
        public IActionResult GetbyId (int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if(paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }


        //Post: Api paciente
        [HttpPost]

        public IActionResult Post(Paciente paciente)
        {

            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            return Ok(paciente);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if(paciente == null)
            {
                return NotFound();
            }

            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();
            return NoContent();


        }

    }
}
