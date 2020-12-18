using Prueba.DAL;
using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Services
{
    public class EmpleadoService
    {
        public List<Empleado> ObtenerTodos()
        {
            try
            {
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoDAL dal = new EmpleadoDAL(context);
                    return dal.ObtenerTodos();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Empleado ObtenerById(int Id)
        {
            try
            {
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoDAL dal = new EmpleadoDAL(context);
                    return dal.ObtenerById(Id);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoDAL dal = new EmpleadoDAL(context);
                    return dal.Insertar(model);
                }
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
                using (PruebaContext context = new PruebaContext())
                {
                    EmpleadoDAL dal = new EmpleadoDAL(context);
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
                    EmpleadoDAL dal = new EmpleadoDAL(context);
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
