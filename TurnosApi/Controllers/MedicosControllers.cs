using Microsoft.EntityFrameworkCore;
using Turnos.Infraestructura;
using Turnos.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Identity.Client;



namespace TurnosApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class MedicosControllers : ControllerBase
    {
        private readonly TurnosDbContext _context;

        public MedicosControllers(TurnosDbContext context)
        {
            this._context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Medico>> GetMedicos()
        {
            return _context.Medicos.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Medico> GetMedico(int id)
        {
            Medico medico = _context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }

            return medico;

        }


        [HttpPost]//agregar
        public ActionResult<Medico> PostMedico(Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        public ActionResult DeleteMedico(int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }

            _context.Medicos.Remove(medico);
            _context.SaveChanges();
            return Ok();

        }

        //put, para actualizar un medico
        [HttpPut("{id}")]
        public ActionResult PutMedico(int id, Medico medicoActualizado)
        {
            Medico med = _context.Medicos.Find(id);
            if (med == null)
            {
                return NotFound();
            }


            med.Name = medicoActualizado.Name;
            med.Apellido = medicoActualizado.Apellido;
            med.Especialidad = medicoActualizado.Especialidad;
            _context.SaveChanges();
            return Ok();

        }







    }
}



    }
}
