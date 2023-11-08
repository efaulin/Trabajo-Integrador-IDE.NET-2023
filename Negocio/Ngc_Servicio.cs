using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;

namespace Negocio
{
    public class Servicio
    {
        static DBContext dBContext = DBContext.dBContext;
        public static async Task<Entidad.Models.Servicio?> GetOne(int id)
        {
            var response = await Conexion.Instancia.HttpClient.GetStringAsync("http://localhost:7110/api/Servicio/GetOne/" + id.ToString());
            var data = JsonConvert.DeserializeObject<Entidad.Models.Servicio>(response);
            if (data != null)
            {
                data.PrecioServicios = dBContext.PrecioServicios.Where(prcSrv => prcSrv.IdServicio == data.IdServicio).ToList();
            }
            return data;
            //Entidad.Models.Servicio? srv = dBContext.Servicios.Find(id);
            //if (srv != null)
            //{
            //    srv.PrecioServicios = dBContext.PrecioServicios.Where(prcSrv => prcSrv.IdServicio == srv.IdServicio).ToList();
            //}
            //return srv;
        }
        public static async Task<List<Entidad.Models.Servicio>> GetAll() { 
            var response = await Conexion.Instancia.HttpClient.GetStringAsync("http://localhost:7110/api/Servicio/GetAll/");
            var data = JsonConvert.DeserializeObject<List<Entidad.Models.Servicio>>(response);
            return data;
            //List<Entidad.Models.Servicio> servicios = dBContext.Servicios.ToList();
            //foreach (Entidad.Models.Servicio srv in servicios)
            //{
            //    srv.PrecioServicios = dBContext.PrecioServicios.Where(prcSrv => prcSrv.IdServicio == srv.IdServicio).ToList();
            //}
            //return servicios;
        }
        public static bool Create(Entidad.Models.Servicio srv)
        {
            try
            {
                dBContext.Servicios.Add(srv);
                dBContext.SaveChanges();
                dBContext.Update(srv);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Entidad.Models.Servicio srv)
        {
            //return Datos.Habitacion.Delete(id);
            try
            {
                dBContext.Servicios.Remove(srv);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Update(Entidad.Models.Servicio srv)
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
        /// <returns>Lista de servicios pertenecientes a la reserva de id ingresado</returns>
        public async static Task<List<Entidad.Models.Servicio>> GetAllOfReserva(int idReserva)
        {
            
            List<Entidad.Models.ReservaServicio> lstRsvSrv = ReservaServicio.GetAllOfReserva(idReserva);
            List<Entidad.Models.Servicio> lstSrv = new List<Entidad.Models.Servicio>();
            lstRsvSrv.ForEach(async r => {
                lstSrv.Add(await Servicio.GetOne(r.IdServicio)!);
                });

            return lstSrv;
        }
    }
}
