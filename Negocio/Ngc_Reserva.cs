using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Reserva
    {
        static Datos.DBContext dBContext = DBContext.dBContext;
        public static List<Entidad.Models.Reserva> GetAll()
        {
            List<Entidad.Models.Reserva> lstRsv = dBContext.Reservas.ToList();
            foreach (Entidad.Models.Reserva rsv in lstRsv)
            {
                if (rsv.IdHabitacionNavigation != null)
                {
                    rsv.IdHabitacionNavigation = dBContext.Habitacions.Find(rsv.IdHabitacion)!;
                    rsv.IdHuespedNavigation = dBContext.Huespeds.Find(rsv.IdHuesped)!;
                }
            }
            return lstRsv;
        }

        public static Entidad.Models.Reserva? GetOne(int id)
        {
            Entidad.Models.Reserva? rsv = dBContext.Reservas.Find(id);
            if (rsv != null)
            {
                if (rsv.IdHabitacionNavigation != null)
                {
                    rsv.IdHabitacionNavigation = dBContext.Habitacions.Find(rsv.IdHabitacion)!;
                    rsv.IdHuespedNavigation = dBContext.Huespeds.Find(rsv.IdHuesped)!;
                }
            }
            return rsv;
        }

        public static void Create(Entidad.Models.Reserva rsv)
        {
            //Preferible pasar un booleano y encerrar Add(), SaveChanges() y Update() en un TryCatch
            dBContext.Reservas.Add(rsv);
            dBContext.SaveChanges();
            dBContext.Update(rsv);
        }

        public static void Update(Entidad.Models.Reserva rsv)
        {
            dBContext.Update(rsv);
            dBContext.SaveChanges();
        }

        public static void Delete(Entidad.Models.Reserva rsv)
        {
            dBContext.Remove(rsv);
            dBContext.SaveChanges();
        }
    }
}
