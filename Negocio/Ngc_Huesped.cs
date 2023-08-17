using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.Models;
using Datos;

namespace Negocio
{
    public class Huesped
    {
        static Datos.DBContext dBContext = DBContext.dBContext;
        public static List<Entidad.Models.Huesped> getAll()
        {
            List<Entidad.Models.Huesped> huespeds = dBContext.Huespeds.ToList();
            foreach (Entidad.Models.Huesped hpd in huespeds)
            {
                hpd.Reservas = dBContext.Reservas.Where(rsv => rsv.IdHuesped == hpd.IdHuesped).ToList();
            }
            return huespeds;
        }
        public static void Create(Entidad.Models.Huesped hpd)
        {
            dBContext.Huespeds.Add(hpd);
            dBContext.SaveChanges();
            dBContext.Update(hpd);
        }
        public static void Update(Entidad.Models.Huesped hpd)
        {
            dBContext.Update(hpd);
            dBContext.SaveChanges();
        }
        public static bool Delete(Entidad.Models.Huesped hpd)
        {
            //return Datos.Habitacion.Delete(id);
            if (hpd != null)
            {
                dBContext.Huespeds.Remove(hpd);
                dBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
