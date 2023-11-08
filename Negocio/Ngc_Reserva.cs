using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Security.Cryptography;

namespace Negocio
{
    public class Reserva
    {
        static DBContext dBContext = DBContext.dBContext;
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

        public static async Task<bool> Create(Entidad.Models.Reserva rsv, List<Entidad.Models.Servicio> lstSrv)
        {
            try
            {
                dBContext.Reservas.Add(rsv);
                dBContext.SaveChanges();
                dBContext.Update(rsv);
                Task<bool> result = SaveServicios(rsv, lstSrv);
                if (await result) { return true; }
                else { return false; }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> Update(Entidad.Models.Reserva rsv, List<Entidad.Models.Servicio> lstSrv)
        {
            try
            {
                dBContext.Update(rsv);
                dBContext.SaveChanges();
                Task<bool> result = SaveServicios(rsv, lstSrv);
                if (await result) { return true; }
                else { return false; }
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Entidad.Models.Reserva rsv)
        {
            try
            {
                dBContext.Remove(rsv);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Validate(Entidad.Models.Reserva rsv)
        {
            if (rsv.CantidadPersonas <= 0) { return false; }
            if (rsv.CantidadPersonas > rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation.NumeroCamas) { return false; }
            if (rsv.FechaInicioReserva.CompareTo(rsv.FechaFinReserva) >= 0) { return false; }
            return true;
        }

        public static List<Entidad.Models.Reserva> GetAllOfServicio(int idServicio)
        {
            List<Entidad.Models.ReservaServicio> lstRsvSrv = ReservaServicio.GetAllOfServicio(idServicio);
            List<Entidad.Models.Reserva> lstRsv = new List<Entidad.Models.Reserva>();
            lstRsvSrv.ForEach(r => { lstRsv.Add(Reserva.GetOne(r.IdReserva)!); });
            return lstRsv;
        }


        private static async Task<bool> SaveServicios(Entidad.Models.Reserva rsv, List<Entidad.Models.Servicio> lstSrv)
        {
            bool control = true;
            Task<List<Entidad.Models.Servicio>> getlstGuardada = Servicio.GetAllOfReserva(rsv.IdReserva);
            List<Entidad.Models.Servicio> lstGuardada = await getlstGuardada;

            //Guardo las nuevas relaciones
            foreach (Entidad.Models.Servicio tmpSrv in lstSrv)
            {
                if (!lstGuardada.Contains(tmpSrv))
                {
                    Entidad.Models.ReservaServicio newRsvSrv = new Entidad.Models.ReservaServicio();
                    newRsvSrv.IdReserva = rsv.IdReserva;
                    newRsvSrv.IdServicio = tmpSrv.IdServicio;
                    if (!ReservaServicio.Create(newRsvSrv))
                    {
                        control = false;
                    }
                }
            }
            //Borro las que ya no se relacionan
            foreach (Entidad.Models.Servicio dbSrv in lstGuardada)
            {
                if (!lstSrv.Contains(dbSrv))
                {
                    Entidad.Models.ReservaServicio delRsrSrv = ReservaServicio.GetByReserva_Servicio(rsv.IdReserva, dbSrv.IdServicio)!;
                    if (!ReservaServicio.Delete(delRsrSrv))
                    {
                        control = false;
                    }
                }
            }

            return control;
        }
    }
}
