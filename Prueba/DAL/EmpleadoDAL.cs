using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.DAL
{
    public class EmpleadoDAL
    {
        private PruebaContext _context;

        public EmpleadoDAL(PruebaContext context)
        {
            _context = context;
        }
        public List<Empleado> ObtenerTodos()
        {
            try
            {
                var listado = _context.Empleados.ToList();
                return listado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //--------------------------

        public Empleado ObtenerById(int Id)
        {
            try
            {
                var item = _context.Empleados.SingleOrDefault(x => x.IdEmpleado == Id);
                return item;
            }
            catch
            {
                throw;
            }
        }

        public int Insertar(Empleado model)
        {
            try
            {
                _context.Empleados.Add(model);
                _context.SaveChanges();
                return model.IdEmpleado;
            }
            catch
            {
                throw;
            }
        }

        public int Modificar(int Id, Empleado model)
        {
            try
            {
                var currentItem = _context.Empleados.SingleOrDefault(x => x.IdEmpleado == Id);
                _context.Entry(currentItem).CurrentValues.SetValues(model);
                _context.SaveChanges();
                return model.IdEmpleado;
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
                var item = _context.Empleados.SingleOrDefault(x => x.IdEmpleado == Id);
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
