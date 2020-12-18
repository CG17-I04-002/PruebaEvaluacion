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
    public class EmpleadoesController : ControllerBase
    {
        public EmpleadoService servicio = new EmpleadoService();

        // GET: api/Empleadoes
        [HttpGet]
        public ActionResult<IEnumerable<Empleado>> GetEmpleados()
        {
            return servicio.ObtenerTodos();
        }

        // GET: api/Empleadoes/5
        [HttpGet("{id}")]
        public ActionResult<Empleado> GetEmpleado(int id)
        {
            var empleado = servicio.ObtenerById(id);

            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;
        }

        // PUT: api/Empleadoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutEmpleado(int id, Empleado empleado)
        {
            if (id != empleado.IdEmpleado)
            {
                return BadRequest();
            }

            servicio.Modificar(id, empleado);

            return NoContent();
        }

        // POST: api/Empleadoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Empleado> PostEmpleado(Empleado empleado)
        {
            servicio.Insertar(empleado);

            return CreatedAtAction("GetEmpleado", new { id = empleado.IdEmpleado }, empleado);
        }

        // DELETE: api/Empleadoes/5
        [HttpDelete("{id}")]
        public ActionResult<Empleado> DeleteEmpleado(int id)
        {
            var empleado = servicio.ObtenerById(id);
            if (empleado == null)
            {
                return NotFound();
            }

            return empleado;
        }
    }
}
