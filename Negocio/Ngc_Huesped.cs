using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.Models;
using Datos;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System.Net.Http.Json;
using Microsoft.EntityFrameworkCore;
using Entidad.Api;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace Negocio
{
    public class Huesped
    {
        static readonly string defaultUrl = Conexion.defaultUrl + "Huesped/";
        public static async Task<List<Entidad.Models.Huesped>> GetAll()
        {
            Task<List<Entidad.Models.Huesped>> task = Conexion.http.GetFromJsonAsync<List<Entidad.Models.Huesped>>(defaultUrl + "GetAll")!;
            List<Entidad.Models.Huesped> lstHpd = await task;
            foreach (Entidad.Models.Huesped hpd in lstHpd)
            {
                await Initialize(hpd);
            }
            return lstHpd;
        }

        public static async Task<Entidad.Models.Huesped?> GetOne(int id)
        {
            Task<Entidad.Models.Huesped> task = Conexion.http.GetFromJsonAsync<Entidad.Models.Huesped?>(defaultUrl + "GetOne/" + id)!;
            Entidad.Models.Huesped hpd = await task;
            if (hpd != null)
            {
                await Initialize(hpd);
            }
            return hpd;
        }
        public static async Task<Entidad.Models.Huesped?> Create(Entidad.Models.Huesped hpd)
        {
            HuespedApi api = GetApi(hpd);
            var result = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", api);
            if (result.IsSuccessStatusCode)
            {
                int id = JsonConvert.DeserializeObject<int>(await result.Content.ReadAsStringAsync())!;
                Entidad.Models.Huesped createdHpd = (await GetOne(id))!;
                return createdHpd;
            }
            else { return null; }
        }
        public static async Task<bool> Update(Entidad.Models.Huesped hpd)
        {
            HuespedApi api = GetApi(hpd);
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/" + hpd.IdHuesped, api);
            return result.IsSuccessStatusCode;
        }
        public static async Task<bool> Delete(Entidad.Models.Huesped hpd)
        {
            var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + hpd.IdHuesped);
            return result.IsSuccessStatusCode;
        }

        /// <summary>
        /// </summary>
        /// <param name="tipo">ingrese uno de estos 3 valores: DNI, LE, LC</param>
        /// <param name="nro">numero de documento de huesped a buscar</param>
        /// <returns>Entidad Huesped correspondiente al tipo y numero de documento ingresado por parametro</returns>
        public static async Task<Entidad.Models.Huesped?> GetByTipo_NroDocumento(string tipo, string nro)
        {
            Entidad.Models.Huesped? rsv = await Conexion.http.GetFromJsonAsync<Entidad.Models.Huesped?>(defaultUrl + "GetByTipo_NroDocumento/" + tipo + "/" + nro);
            if (rsv != null)
            {
                await Initialize(rsv);
            }
            return rsv;
        }

        /// <summary></summary>
        /// <param name="nro">numero de documento de huesped a buscar</param>
        /// <returns>Lista de huespedes que contengan total o parcialmente el numero ingresado</returns>
        public static async Task<List<Entidad.Models.Huesped>> GetByNroDocumento(string nro)
        {
            Task<List<Entidad.Models.Huesped>> task = Conexion.http.GetFromJsonAsync<List<Entidad.Models.Huesped>>(defaultUrl + "GetByNroDocumento/" + nro)!;
            List<Entidad.Models.Huesped> lstHpd = await task;
            foreach (Entidad.Models.Huesped hpd in lstHpd)
            {
                await Initialize(hpd);
            }
            return lstHpd;
        }

        private static async Task Initialize(Entidad.Models.Huesped hpd)
        {
            hpd.Reservas = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.Reserva>>(Conexion.defaultUrl + "Reserva/GetAllOfHuesped/" + hpd.IdHuesped))!;
            foreach (Entidad.Models.Reserva rsv in hpd.Reservas)
            {
                rsv.IdHabitacionNavigation = (await Conexion.http.GetFromJsonAsync<Entidad.Models.Habitacion>(Conexion.defaultUrl + "Habitacion/GetOne/" + rsv.IdHabitacion))!;
                rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation = await TipoHabitacion.GetOne(rsv.IdHabitacionNavigation.IdTipoHabitacion);
            }
        }

        private static HuespedApi GetApi(Entidad.Models.Huesped hpd)
        {
            HuespedApi api = new HuespedApi();
            api.IdHuesped = hpd.IdHuesped;
            api.Nombre = hpd.Nombre;
            api.Apellido = hpd.Apellido;
            api.NumeroDocumento = hpd.NumeroDocumento;
            api.TipoDocumento = hpd.TipoDocumento;
            return api;
        }
    }
}
