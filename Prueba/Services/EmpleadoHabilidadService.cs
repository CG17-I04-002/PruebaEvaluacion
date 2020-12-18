using Prueba.DAL;
using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Services
{
    public class EmpleadoHabilidadService
    {
        public List<EmpleadoHabilidad> ObtenerTodos()
        {
            try
            {
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoHabilidadDAL dal = new EmpleadoHabilidadDAL(context);
                    return dal.ObtenerTodos();
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoHabilidadDAL dal = new EmpleadoHabilidadDAL(context);
                    return dal.ObtenerById(Id);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoHabilidadDAL dal = new EmpleadoHabilidadDAL(context);
                    return dal.Insertar(model);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoHabilidadDAL dal = new EmpleadoHabilidadDAL(context);
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
                    EmpleadoHabilidadDAL dal = new EmpleadoHabilidadDAL(context);
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
