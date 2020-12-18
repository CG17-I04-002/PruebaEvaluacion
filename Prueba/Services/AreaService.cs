using Prueba.DAL;
using Prueba.Entities;
using System;
using System.Collections.Generic;

namespace Prueba.Services
{
    public class AreaService
    {
        public List<Area> ObtenerTodos()
        {
            try
            {
                using (PruebaContext context = new PruebaContext())
                {
                    AreaDAL dal = new AreaDAL(context);
                    return dal.ObtenerTodos();
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    AreaDAL dal = new AreaDAL(context);
                    return dal.ObtenerById(Id);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    AreaDAL dal = new AreaDAL(context);
                    return dal.Insertar(model);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    AreaDAL dal = new AreaDAL(context);
                    return dal.Modificar(Id, model);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    AreaDAL dal = new AreaDAL(context);
                    return dal.Eliminar(Id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
