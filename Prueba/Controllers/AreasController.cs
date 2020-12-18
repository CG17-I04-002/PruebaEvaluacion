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
    public class AreasController : ControllerBase
    {
        //private readonly PruebaContext _context;
        public AreaService servicio = new AreaService();

        // GET: api/Areas
        [HttpGet]
        public ActionResult<IEnumerable<Area>> GetAreas()
        {
            return servicio.ObtenerTodos();
        }

        // GET: api/Areas/5
        [HttpGet("{id}")]
        public ActionResult<Area> GetArea(int id)
        {
            //var area = await _context.Areas.FindAsync(id);
            var area = servicio.ObtenerById(id);
            if (area == null)
            {
                return NotFound();
            }

            return area;
        }

        // PUT: api/Areas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutArea(int id, Area area)
        {
            if (id != area.IdArea)
            {
                return BadRequest();
            }

            servicio.Modificar(id, area);

            
            return NoContent();
        }

        // POST: api/Areas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Area> PostArea(Area area)
        {
            //_context.Areas.Add(area);
            servicio.Insertar(area);

            return CreatedAtAction("GetArea", new { id = area.IdArea }, area);
        }

        // DELETE: api/Areas/5
        [HttpDelete("{id}")]
        public ActionResult<Area> DeleteArea(int id)
        {
            //var area = await _context.Areas.FindAsync(id);
            var area = servicio.ObtenerById(id);
            if (area == null)
            {
                return NotFound();
            }

            servicio.Eliminar(id);
            return area;
        }

    }
}
