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

        public static List<Entidad.Models.Empleado> GetAll()
        {
            List<Entidad.Models.Empleado> lstEmp = dBContext.Empleados.ToList();
            return lstEmp;
        }
    }
}
