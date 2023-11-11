using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Security.Cryptography;
using System.Net.Http.Json;
using Entidad.Api;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Negocio
{
    public class Reserva
    {
        static readonly string defaultUrl = Conexion.defaultUrl + "Reserva/";
        public static async Task<List<Entidad.Models.Reserva>> GetAll()
        {
            Task<List<Entidad.Models.Reserva>> task = Conexion.http.GetFromJsonAsync<List<Entidad.Models.Reserva>>(defaultUrl + "GetAll")!;
            List<Entidad.Models.Reserva> lstRsv = await task;
            foreach (Entidad.Models.Reserva rsv in lstRsv)
            {
                await Initialize(rsv);
            }
            return lstRsv;
        }

        public static async Task<Entidad.Models.Reserva?> GetOne(int id)
        {
            Entidad.Models.Reserva? rsv = await Conexion.http.GetFromJsonAsync<Entidad.Models.Reserva>(defaultUrl + "GetOne/" + id);
            if (rsv != null)
            {
                await Initialize(rsv);
            }
            return rsv;
        }

        public static async Task<Entidad.Models.Reserva?> Create(Entidad.Models.Reserva rsv)
        {
            ReservaApi rsvApi = GetApi(rsv);
            var result = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", rsvApi);
            if (result.IsSuccessStatusCode)
            {
                int id = JsonConvert.DeserializeObject<int>(await result.Content.ReadAsStringAsync())!;
                Entidad.Models.Reserva createdRsv = (await GetOne(id))!;
                return createdRsv;
            }
            else { return null; }
        }

        public static async Task<bool> Update(Entidad.Models.Reserva rsv)
        {
            ReservaApi rsvApi = GetApi(rsv);
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/" + rsv.IdReserva, rsvApi);
            return result.IsSuccessStatusCode;
        }

        public static async Task<bool> Delete(Entidad.Models.Reserva rsv)
        {
            var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + rsv.IdReserva);
            return result.IsSuccessStatusCode;
        }

        public static bool Validate(Entidad.Models.Reserva rsv)
        {
            if (rsv.CantidadPersonas <= 0) { return false; }
            if (rsv.CantidadPersonas > rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation.NumeroCamas) { return false; }
            if (rsv.FechaInicioReserva.CompareTo(rsv.FechaFinReserva) >= 0) { return false; }
            return true;
        }

        public static async Task<List<Entidad.Models.Reserva>> GetAllOfServicio(int idServicio)
        {
            List<Entidad.Models.Reserva> lstRsv = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.Reserva>>(defaultUrl + "GetAllOfServicio/" + idServicio))!;
            foreach (Entidad.Models.Reserva rsv in lstRsv)
            {
                await Initialize(rsv);
            }
            return lstRsv;
        }


        /*private static async Task<bool> SaveServicios(Entidad.Models.Reserva rsv, List<Entidad.Models.Servicio> lstSrv)
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
        }*/

        private static async Task Initialize(Entidad.Models.Reserva rsv)
        {
            Task<Entidad.Models.Habitacion> getHbt = Conexion.http.GetFromJsonAsync<Entidad.Models.Habitacion>(Conexion.defaultUrl + "Habitacion/GetOne/" + rsv.IdHabitacion)!;
            rsv.IdHabitacionNavigation = await getHbt;
            Task<Entidad.Models.TipoHabitacion> getTipo = TipoHabitacion.GetOne(rsv.IdHabitacionNavigation.IdTipoHabitacion)!;
            rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation = await getTipo;
            rsv.IdHuespedNavigation = Huesped.GetOne(rsv.IdHuesped)!;
        }

        private static ReservaApi GetApi(Entidad.Models.Reserva rsv)
        {
            ReservaApi rsvApi = new ReservaApi();
            rsvApi.IdReserva = rsv.IdReserva;
            rsvApi.FechaInscripcion = rsv.FechaInscripcion;
            rsvApi.FechaInicioReserva = rsv.FechaInicioReserva;
            rsvApi.FechaFinReserva = rsv.FechaFinReserva;
            rsvApi.EstadoReserva = rsv.EstadoReserva;
            rsvApi.CantidadPersonas = rsv.CantidadPersonas;
            rsvApi.IdHabitacion = rsv.IdHabitacion;
            rsvApi.IdHuesped = rsv.IdHuesped;
            return rsvApi;
        }
    }
}
