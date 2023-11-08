using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Empleado
    {
        static Datos.DBContext dBContext = Datos.DBContext.dBContext;
        public static Entidad.Models.Empleado? GetByUsuario_Contraseña(string usuario, string contra)
        {
            return dBContext.Empleados.FirstOrDefault(e => e.NombreUsuario == usuario && e.Password == contra);
        }

        public static Entidad.Models.Empleado? GetOne(int id)
        {
            Entidad.Models.Empleado? emp = dBContext.Empleados.Find(id);
            return emp;
        }

        public static List<Entidad.Models.Empleado> GetAll()
        {
            List<Entidad.Models.Empleado> lstEmp = dBContext.Empleados.ToList();
            return lstEmp;
        }

        public static bool Create(Entidad.Models.Empleado emp)
        {
            try
            {
                dBContext.Empleados.Add(emp);
                dBContext.SaveChanges();
                dBContext.Update(emp);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Entidad.Models.Empleado emp)
        {
            try
            {
                dBContext.Update(emp);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Entidad.Models.Empleado emp)
        {
            try
            {
                dBContext.Empleados.Remove(emp);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
