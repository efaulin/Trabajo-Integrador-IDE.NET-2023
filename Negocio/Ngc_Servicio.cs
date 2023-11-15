using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Datos;
using Newtonsoft.Json;

namespace Negocio
{
    public class Servicio
    {
        static readonly string defaultUrl = Conexion.defaultUrl + "Servicio/";
        public static async Task<Entidad.Models.Servicio?> GetOne(int id)
        {
            var response = await Conexion.http.GetStringAsync(defaultUrl + "GetOne/" + id.ToString());
            var data = JsonConvert.DeserializeObject<Entidad.Models.Servicio>(response);
            return data;
        }
        public static async Task<List<Entidad.Models.Servicio>> GetAll() { 
            var response = await Conexion.http.GetStringAsync(defaultUrl + "GetAll");
            var data = JsonConvert.DeserializeObject<List<Entidad.Models.Servicio>>(response);
            //if(data != null)
            //{
            //    foreach (Entidad.Models.Servicio srv in data)
            //    {
            //        srv.PrecioServicios = dBContext.PrecioServicios.Where(prcSrv => prcSrv.IdServicio == srv.IdServicio).ToList();
            //    }
            //}
            return data;
        }

        public static async Task<Entidad.Models.Servicio> Create(Entidad.Models.Servicio srv)
        {
            Entidad.Api.ServicioApi srvApi = GetApi(srv);
            var response = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", srvApi);
            int data = JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
            Entidad.Models.Servicio createdServ = (await GetOne(data))!;
            return createdServ;          
        }
        public static async Task<bool> Delete(Entidad.Models.Servicio srv)
        {
            try
            {
                var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + srv.IdServicio);
                return result.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<bool> Update(Entidad.Models.Servicio srv)
        {
            try
            {
                Entidad.Api.ServicioApi srvApi = GetApi(srv);
                var response = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/" + srvApi.IdServicio, srvApi);
                return response.IsSuccessStatusCode;
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
            List<Entidad.Models.Servicio> lstSrv = new List<Entidad.Models.Servicio>();
            Task<List<Entidad.Models.ReservaServicio>> getlstRsvSrv = Conexion.http.GetFromJsonAsync<List<Entidad.Models.ReservaServicio>>(defaultUrl + "GetAllOfReserva/" + idReserva)!;
            List<Entidad.Models.ReservaServicio> lst = await getlstRsvSrv;
            
            foreach (var rs in lst)
            {
                lstSrv.Add((await GetOne(rs.IdServicio))!);
            }

            foreach (var srv in lstSrv)
            {
                await Initialize(srv);
            }
            
            //getlstRsvSrv.Wait();
            return lstSrv;
        }

        /// <summary>
        /// </summary>
        /// <param name="fecha">fecha a buscar</param>
        /// <param name="tipHbt">tipoHabitacion de precio a buscar</param>
        /// <returns>Entidad precioServicio de un Servicio que pertenezca a la fecha ingresada</returns>
        public static Entidad.Models.PrecioServicio? DevPrecioFecha(DateTime fecha, Entidad.Models.Servicio srv)
        {
            Entidad.Models.PrecioServicio? precioBuscado = null;
            foreach (var preSrv in srv.PrecioServicios)
            {
                if (precioBuscado == null && preSrv.FechaPrecio <= fecha)
                {
                    precioBuscado = preSrv;
                }
                else if (precioBuscado != null)
                {
                    if (preSrv.FechaPrecio > precioBuscado.FechaPrecio && preSrv.FechaPrecio <= fecha)
                    {
                        precioBuscado = preSrv;
                    }
                }
            }
            return precioBuscado;
        }

        private static async Task Initialize(Entidad.Models.Servicio srv)
        {
            Task<List<Entidad.Models.PrecioServicio>> getPrcSrv = Conexion.http.GetFromJsonAsync<List<Entidad.Models.PrecioServicio>>(Conexion.defaultUrl + "PrecioServicio/GetAllOfServicio/" + srv.IdServicio)!;
            srv.PrecioServicios = await getPrcSrv;
        }

        public static Entidad.Api.ServicioApi GetApi(Entidad.Models.Servicio srv)
        {
            Entidad.Api.ServicioApi api = new Entidad.Api.ServicioApi();
            api.Descripcion = srv.Descripcion;
            api.IdServicio = srv.IdServicio;
          
            return api;
        }
    }
}
