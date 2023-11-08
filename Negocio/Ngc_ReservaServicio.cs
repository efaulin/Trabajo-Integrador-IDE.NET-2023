using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ReservaServicio
    {
        static DBContext dBContext = DBContext.dBContext;
        public static Entidad.Models.ReservaServicio? GetOne(int id)
        {
            Entidad.Models.ReservaServicio? srv = dBContext.ReservaServicios.Find(id);
            /*if (srv != null)
            {
                srv.IdServicioNavigation = dBContext.Servicios.FirstOrDefault(sr => sr.IdServicio == srv.IdServicio)!;
                srv.IdReservaNavigation = dBContext.Reservas.FirstOrDefault(rs => rs.IdReserva == srv.IdReserva)!;
            }*/
            return srv;
        }
        public static List<Entidad.Models.ReservaServicio> GetAll()
        {
            List<Entidad.Models.ReservaServicio> rsvSrv = dBContext.ReservaServicios.ToList();
            /*foreach (Entidad.Models.ReservaServicio srv in rsvSrv)
            {
                srv.IdServicioNavigation = dBContext.Servicios.FirstOrDefault(sr => sr.IdServicio == srv.IdServicio)!;
                srv.IdReservaNavigation = dBContext.Reservas.FirstOrDefault(rs => rs.IdReserva == srv.IdReserva)!;
            }*/
            return rsvSrv;
        }
        public static bool Create(Entidad.Models.ReservaServicio srv)
        {
            try
            {
                dBContext.ReservaServicios.Add(srv);
                dBContext.SaveChanges();
                dBContext.Update(srv);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Entidad.Models.ReservaServicio srv)
        {
            //return Datos.Habitacion.Delete(id);
            try
            {
                dBContext.ReservaServicios.Remove(srv);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Update(Entidad.Models.ReservaServicio srv)
        {
            try
            {
                dBContext.Update(srv);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary></summary>
        /// <param name="idReserva"></param>
        /// <returns>Lista de ReservaServicio que contengan el id reserva recibido</returns>
        public static List<Entidad.Models.ReservaServicio> GetAllOfReserva(int idReserva)
        {
            List<Entidad.Models.ReservaServicio> lstRsvSrv = dBContext.ReservaServicios.Where(e => e.IdReserva == idReserva).ToList();
            /*foreach (Entidad.Models.ReservaServicio srv in lstRsvSrv)
            {
                srv.IdServicioNavigation = dBContext.Servicios.FirstOrDefault(sr => sr.IdServicio == srv.IdServicio)!;
                srv.IdReservaNavigation = dBContext.Reservas.FirstOrDefault(rs => rs.IdReserva == srv.IdReserva)!;
            }*/
            return lstRsvSrv;
        }

        /// <summary></summary>
        /// <param name="idServicio"></param>
        /// <returns>Lista de ReservaServicio que contengan el id servicio recibido</returns>
        public static List<Entidad.Models.ReservaServicio> GetAllOfServicio(int idServicio)
        {
            List<Entidad.Models.ReservaServicio> lstRsvSrv = dBContext.ReservaServicios.Where(e => e.IdServicio == idServicio).ToList();
            /*foreach (Entidad.Models.ReservaServicio srv in lstRsvSrv)
            {
                srv.IdServicioNavigation = dBContext.Servicios.FirstOrDefault(sr => sr.IdServicio == srv.IdServicio)!;
                srv.IdReservaNavigation = dBContext.Reservas.FirstOrDefault(rs => rs.IdReserva == srv.IdReserva)!;
            }*/
            return lstRsvSrv;
        }

        /// <summary></summary>
        /// <param name="idReserva"></param>
        /// <param name="idServicio"></param>
        /// <returns>Entidad ReservaSerivico que relaciona los id's de reserva y servicios</returns>
        public static Entidad.Models.ReservaServicio? GetByReserva_Servicio(int idReserva, int idServicio)
        {
            Entidad.Models.ReservaServicio? srv = dBContext.ReservaServicios.FirstOrDefault(e => e.IdReserva == idReserva && e.IdServicio == idServicio);
            /*if (srv != null)
            {
                srv.IdServicioNavigation = dBContext.Servicios.FirstOrDefault(sr => sr.IdServicio == srv.IdServicio)!;
                srv.IdReservaNavigation = dBContext.Reservas.FirstOrDefault(rs => rs.IdReserva == srv.IdReserva)!;
            }*/
            return srv;
        }
    }
}