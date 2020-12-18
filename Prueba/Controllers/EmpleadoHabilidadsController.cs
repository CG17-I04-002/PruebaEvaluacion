using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba.Entities;
using Prueba.Services;

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoHabilidadsController : ControllerBase
    {
        public EmpleadoHabilidadService servicio = new EmpleadoHabilidadService();

        // GET: api/EmpleadoHabilidads
        [HttpGet]
        public ActionResult<IEnumerable<EmpleadoHabilidad>> GetEmpleadoHabilidads()
        {
            return servicio.ObtenerTodos();
        }

        // GET: api/EmpleadoHabilidads/5
        [HttpGet("{id}")]
        public ActionResult<EmpleadoHabilidad> GetEmpleadoHabilidad(int id)
        {
            var empleadoHabilidad = servicio.ObtenerById(id);

            if (empleadoHabilidad == null)
            {
                return NotFound();
            }

            return empleadoHabilidad;
        }

        // PUT: api/EmpleadoHabilidads/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutEmpleadoHabilidad(int id, EmpleadoHabilidad empleadoHabilidad)
        {
            if (id != empleadoHabilidad.IdHabilidad)
            {
                return BadRequest();
            }

            servicio.Modificar(id, empleadoHabilidad);

            return NoContent();
        }

        // POST: api/EmpleadoHabilidads
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<EmpleadoHabilidad> PostEmpleadoHabilidad(EmpleadoHabilidad empleadoHabilidad)
        {
            servicio.Insertar(empleadoHabilidad);

            return CreatedAtAction("GetEmpleadoHabilidad", new { id = empleadoHabilidad.IdHabilidad }, empleadoHabilidad);
        }

        // DELETE: api/EmpleadoHabilidads/5
        [HttpDelete("{id}")]
        public ActionResult<EmpleadoHabilidad> DeleteEmpleadoHabilidad(int id)
        {
            var empleadoHabilidad = servicio.ObtenerById(id);
            if (empleadoHabilidad == null)
            {
                return NotFound();
            }

            servicio.Eliminar(id);

            return empleadoHabilidad;
        }
    }
}
