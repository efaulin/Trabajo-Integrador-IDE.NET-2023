using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;

namespace Negocio
{
    public class ReservaServicio
    {
        static readonly DBContext dBContext = DBContext.dBContext;
        static readonly string defaultUrl = Conexion.defaultUrl + "ReservaServicio/";
        public static async Task<Entidad.Models.ReservaServicio?> GetOne(int id)
        {
            Entidad.Models.ReservaServicio? srv = await Conexion.http.GetFromJsonAsync<Entidad.Models.ReservaServicio>(defaultUrl + "GetOne/" + id);
            if (srv != null)
            {
                Initialize(srv);
            }
            return srv;
        }
        public static async Task<List<Entidad.Models.ReservaServicio>> GetAll()
        {
            List<Entidad.Models.ReservaServicio> rsvSrv = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.ReservaServicio>>(defaultUrl + "GetAll"))!;
            foreach (Entidad.Models.ReservaServicio srv in rsvSrv)
            {
                Initialize(srv);
            }
            return rsvSrv;
        }
        public static async Task<Entidad.Models.ReservaServicio> Create(Entidad.Models.ReservaServicio srv)
        {
            Entidad.Api.ReservaServicioApi rsvSrvApi = GetApi(srv);
            var result = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", rsvSrvApi);
            int id = JsonConvert.DeserializeObject<int>(await result.Content.ReadAsStringAsync())!;
            Entidad.Models.ReservaServicio createdRsvSrv = (await GetOne(id))!;
            return createdRsvSrv;
        }
        public static async Task<bool> Delete(Entidad.Models.ReservaServicio srv)
        {
            var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + srv.IdReservaServicio);
            return result.IsSuccessStatusCode;
        }
        public static async Task<bool> Update(Entidad.Models.ReservaServicio srv)
        {
            Entidad.Api.ReservaServicioApi api = GetApi(srv);
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/" + srv.IdServicio, api);
            return result.IsSuccessStatusCode;
        }

        /// <summary></summary>
        /// <param name="idReserva"></param>
        /// <returns>Lista de ReservaServicio que contengan el id reserva recibido</returns>
        public static async Task<List<Entidad.Models.ReservaServicio>> GetAllOfReserva(int idReserva)
        {
            List<Entidad.Models.ReservaServicio> response = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.ReservaServicio>>(defaultUrl + "GetAllOfReserva/" + idReserva))!;
            foreach (Entidad.Models.ReservaServicio srv in response)
            {
                Initialize(srv);
            }
            return response;
        }

        /// <summary></summary>
        /// <param name="idServicio"></param>
        /// <returns>Lista de ReservaServicio que contengan el id servicio recibido</returns>
        public static async Task<List<Entidad.Models.ReservaServicio>> GetAllOfServicio(int idServicio)
        {
            List<Entidad.Models.ReservaServicio> response = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.ReservaServicio>>(defaultUrl + "GetAllOfServicio/" + idServicio))!;
            foreach (Entidad.Models.ReservaServicio srv in response)
            {
                Initialize(srv);
            }
            return response;
        }

        /// <summary></summary>
        /// <param name="idReserva"></param>
        /// <param name="idServicio"></param>
        /// <returns>Entidad ReservaSerivico que relaciona los id's de reserva y servicios</returns>
        public static async Task<Entidad.Models.ReservaServicio?> GetByReserva_Servicio(int idReserva, int idServicio)
        {
            Entidad.Models.ReservaServicio? srv = await Conexion.http.GetFromJsonAsync<Entidad.Models.ReservaServicio>(defaultUrl + "GetByReserva_Servicio/" + idReserva + "/" + idServicio);
            if (srv != null)
            {
                Initialize(srv);
            }
            return srv;
        }

        private static Entidad.Api.ReservaServicioApi GetApi(Entidad.Models.ReservaServicio rsvSrv)
        {
            Entidad.Api.ReservaServicioApi api = new Entidad.Api.ReservaServicioApi();
            api.IdReservaServicio = rsvSrv.IdReservaServicio;
            api.IdServicio = rsvSrv.IdServicio;
            api.IdReserva = rsvSrv.IdReserva;
            return api;
        }

        private static async void Initialize(Entidad.Models.ReservaServicio srv)
        {
            srv.IdServicioNavigation = (await Servicio.GetOne(srv.IdServicio))!;
            srv.IdReservaNavigation = (await Reserva.GetOne(srv.IdReserva))!;
        }

        public static async Task<bool> SaveServicios(List<Entidad.Models.ReservaServicio> lstTpm)
        {
            List<Entidad.Api.ReservaServicioApi> lstApi = new List<Entidad.Api.ReservaServicioApi>();
            foreach (Entidad.Models.ReservaServicio rsvSrv in lstTpm)
            {
                lstApi.Add(GetApi(rsvSrv));
            }
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "SaveServicios", lstApi);
            return result.IsSuccessStatusCode;
        }
    }
}