using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.DAL
{
    public class EmpleadoHabilidadDAL
    {
        private PruebaContext _context;

        public EmpleadoHabilidadDAL(PruebaContext context)
        {
            _context = context;
        }
        public List<EmpleadoHabilidad> ObtenerTodos()
        {
            try
            {
                var listado = _context.EmpleadoHabilidads.ToList();
                return listado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public EmpleadoHabilidad ObtenerById(int Id)
        {
            try
            {
                var item = _context.EmpleadoHabilidads.SingleOrDefault(x => x.IdHabilidad == Id);
                return item;
            }
            catch
            {
                throw;
            }
        }

        public int Insertar(EmpleadoHabilidad model)
        {
            try
            {
                _context.EmpleadoHabilidads.Add(model);
                _context.SaveChanges();
                return model.IdHabilidad;
            }
            catch
            {
                throw;
            }
        }

        public int Modificar(int Id, EmpleadoHabilidad model)
        {
            try
            {
                var currentItem = _context.EmpleadoHabilidads.SingleOrDefault(x => x.IdHabilidad == Id);
                _context.Entry(currentItem).CurrentValues.SetValues(model);
                _context.SaveChanges();
                return model.IdHabilidad;
            }
            catch
            {
                throw;
            }
        }
        public bool Eliminar(int Id)
        {
            try
            {
                var item = _context.EmpleadoHabilidads.SingleOrDefault(x => x.IdHabilidad == Id);
                _context.Remove(item);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
