using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba.DAL
{
    public class AreaDAL
    {
        private PruebaContext _context;

        public AreaDAL(PruebaContext context)
        {
            _context = context;
        }
        public List<Area> ObtenerTodos()
        {
            try
            {
                var listado = _context.Areas.ToList();
                return listado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Area ObtenerById(int Id)
        {
            try
            {
                var item = _context.Areas.SingleOrDefault(x => x.IdArea == Id);
                return item;
            }
            catch
            {
                throw;
            }
        }

        public int Insertar(Area model)
        {
            try
            {
                _context.Areas.Add(model);
                _context.SaveChanges();
                return model.IdArea;
            }
            catch
            {
                throw;
            }
        }

        public int Modificar(int Id, Area model)
        {
            try
            {
                var currentItem = _context.Areas.SingleOrDefault(x => x.IdArea == Id);
                _context.Entry(currentItem).CurrentValues.SetValues(model);
                _context.SaveChanges();
                return model.IdArea;
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
                var item = _context.Areas.SingleOrDefault(x => x.IdArea == Id);
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
