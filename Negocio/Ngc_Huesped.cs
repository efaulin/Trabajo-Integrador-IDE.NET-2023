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
        public static List<Entidad.Models.Huesped> getAll(DBContext dBContext)
        {
            List<Entidad.Models.Huesped> huespeds = dBContext.Huespeds.ToList();
            foreach (Entidad.Models.Huesped hpd in huespeds)
            {
                hpd.Reservas = dBContext.Reservas.Where(rsv => rsv.IdHuesped == hpd.IdHuesped).ToList();
            }
            return huespeds;
        }
        public static void Create(Entidad.Models.Huesped hpd, DBContext dBContext)
        {
            dBContext.Huespeds.Add(hpd);
            dBContext.SaveChanges();
            dBContext.Update(hpd);
        }
        public static void Update(Entidad.Models.Huesped hpd, DBContext dBContext)
        {
            dBContext.Update(hpd);
            dBContext.SaveChanges();
        }
    }
}
