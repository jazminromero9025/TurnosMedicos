using Turnos.Infraestructura;
using Turnos.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace TurnosApi.Controllers
{


    [ApiController]
    [Route("api/[Controller]")]

    public class EspecialidadesControllers : ControllerBase
    {
        private readonly TurnosDbContext _context;

        public EspecialidadesControllers(TurnosDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Especialidad>> GetEspecialidades()
        {
            return _context.Especialidades.ToList();

        }

        [HttpGet("{id}")]
        public ActionResult<Especialidad> GetEspecialidad(int id)
        {
            var especialidad = _context.Especialidades.Find(id);
            if(especialidad == null)
            {
                return NotFound();
            }

            return especialidad;
        }



        [HttpPost] //agregar
        public ActionResult PostEspecialidad(Especialidad especialidad)
        {
            _context.Especialidades.Add(especialidad);
            _context.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public ActionResult PutEspecialidad(int id, Especialidad especialidadActualizada)
        {
            var especialidad = _context.Especialidades.Find(id);
            if(especialidad == null)
            {
                return NotFound();
            }

            especialidad.Name = especialidadActualizada.Name;
            _context.SaveChanges();
            return Ok();


        }


        [HttpDelete("{id}")]
        public ActionResult DeleteEspecialidad(int id)
        {
            var especialidad = _context.Especialidades.Find(id);
            if(especialidad == null)
            {
                return NotFound();
            }

            _context.Especialidades.Remove(especialidad);
            _context.SaveChanges();
            return Ok();




        }






    }
}
