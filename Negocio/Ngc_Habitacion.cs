using Datos;
using Entidad.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Negocio
{
    public class Habitacion
    {
        static readonly DBContext dBContext = DBContext.dBContext;
        static readonly string defaultUrl = Conexion.defaultUrl + "Habitacion/";
        public static async Task<Entidad.Models.Habitacion?> GetOne(int id)
        {
            Task<Entidad.Models.Habitacion?> task = Conexion.http.GetFromJsonAsync<Entidad.Models.Habitacion>(defaultUrl + "GetOne/" + id);
            Entidad.Models.Habitacion? hbt = await task;
            task.Wait();
            if (hbt != null)
            {
                Initialize(hbt);
            }
            return hbt;
        }

        public static async Task<List<Entidad.Models.Habitacion>> GetAll()
        {
            List<Entidad.Models.Habitacion> response = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.Habitacion>>(defaultUrl + "GetAll"))!;
            foreach (Entidad.Models.Habitacion hbt in response!)
            {
                Initialize(hbt);
            }
            return response!;
        }

        public static async Task<Entidad.Models.Habitacion> Create(Entidad.Models.Habitacion hbt)
        {
            Entidad.Api.HabitacionApi hbtApi = GetApi(hbt);
            var result = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", hbtApi);
            int id = JsonConvert.DeserializeObject<int>(await result.Content.ReadAsStringAsync())!;
            Entidad.Models.Habitacion createdHbt = (await GetOne(id))!;
            return createdHbt;
        }
        public static async Task<bool> Delete(Entidad.Models.Habitacion hbt)
        {
            var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + hbt.IdHabitacion);
            return result.IsSuccessStatusCode;
        }

        public static async Task<bool> Update(Entidad.Models.Habitacion hbt)
        {
            Entidad.Api.HabitacionApi hbtApi = GetApi(hbt);
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/" + hbtApi.IdHabitacion, hbtApi);
            return result.IsSuccessStatusCode;
        }

        /// <summary></summary>
        /// <returns>Lista de habitaciones dadas de alta (hbt.estado == true)</returns>
        public static async Task<List<Entidad.Models.Habitacion>> GetAllEnabled()
        {
            List<Entidad.Models.Habitacion> response = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.Habitacion>>(defaultUrl + "GetAllEnabled"))!;
            foreach (Entidad.Models.Habitacion hbt in response!)
            {
                Initialize(hbt);
            }
            return response!;
        }

        /// <summary></summary>
        /// <param name="start">fecha de inicio</param>
        /// <param name="end">fecha de final</param>
        /// <returns>Lista de habitaciones disponibles para un intervalo de fechas</returns>
        public static async Task<List<Entidad.Models.Habitacion>> GetAvailableBetween(DateTime start, DateTime end)
        {
            return TakeAvailable(await GetAllEnabled(), start, end);
        }

        /// <summary>
        /// Toma una lista de habitaciones y devuelve las habitaciones disponibles (sin reservas "En espera" o "En curso") para un intervalo de fechas
        /// </summary>
        /// <param name="lstHbt">listado de habitaciones a filtrar</param>
        /// <param name="start">fecha de inicio</param>
        /// <param name="end">fecha de fin</param>
        /// <returns>Listado de habitaciones disponibles</returns>
        public static List<Entidad.Models.Habitacion> TakeAvailable(List<Entidad.Models.Habitacion> lstHbt, DateTime start, DateTime end)
        {
            return lstHbt.FindAll(hbt =>
                hbt.Reservas.ToList().Find(rsv =>
                    (rsv.EstadoReserva == "En espera" || rsv.EstadoReserva == "En curso") && !(rsv.FechaInicioReserva.CompareTo(end) >= 0 || rsv.FechaFinReserva.CompareTo(start) <= 0)
                ) == null || hbt.Reservas.Count == 0
            );
        }

        /// <summary></summary>
        /// <param name="amountPeople">capacidad de personas (minima) deseada</param>
        /// <returns>Listado de habitaciones con capacidad igual o mayor de personas</returns>
        public static async Task<List<Entidad.Models.Habitacion>> GetForAmountOfPeople(int amountPeople)
        {
            List<Entidad.Models.Habitacion> response = (await Conexion.http.GetFromJsonAsync<List<Entidad.Models.Habitacion>>(defaultUrl + "GetForAmountOfPeople/" + amountPeople))!;
            foreach (Entidad.Models.Habitacion hbt in response!)
            {
                Initialize(hbt);
            }
            return response!;
        }
        /*public static List<Entidad.Models.Habitacion> GetByPiso(int piso)
        {
            return GetAll().FindAll(hbt => hbt.PisoHabitacion == piso);
        }
        public static List<Entidad.Models.Habitacion> GetByNro(int nro)
        {
            return GetAll().FindAll(hbt => hbt.NumeroHabitacion == nro);
        }
        public static Entidad.Models.Habitacion? GetByPiso_Nro(int piso, int nro)
        {
            return GetAll().Find(hbt => hbt.PisoHabitacion == piso && hbt.NumeroHabitacion == nro);
        }*/

        public static async void Initialize(Entidad.Models.Habitacion hbt)
        {
            hbt.IdTipoHabitacionNavigation = TipoHabitacion.GetOne(hbt.IdTipoHabitacion)!;
            List<Entidad.Models.Reserva>? rsv = await Conexion.http.GetFromJsonAsync<List<Entidad.Models.Reserva>>(Conexion.defaultUrl + "Reserva/GetAllOfHabitacion/" + hbt.IdHabitacion);
            if (rsv == null)
            {
                hbt.Reservas = new List<Entidad.Models.Reserva>();
            }
            else
            {
                hbt.Reservas = rsv;
            }
        }

        public static Entidad.Api.HabitacionApi GetApi(Entidad.Models.Habitacion hbt)
        {
            Entidad.Api.HabitacionApi api = new Entidad.Api.HabitacionApi();
            api.IdHabitacion = hbt.IdHabitacion;
            api.Estado = hbt.Estado;
            api.NumeroHabitacion = hbt.NumeroHabitacion;
            api.PisoHabitacion = hbt.PisoHabitacion;
            api.IdTipoHabitacion = hbt.IdTipoHabitacion;
            return api;
        }
    }

    public class TipoHabitacion
    {
        static Datos.DBContext dBContext = Datos.DBContext.dBContext;
        public static List<Entidad.Models.TipoHabitacion> GetAll()
        {
            List<Entidad.Models.TipoHabitacion> lstTipHbt = dBContext.TipoHabitacions.ToList();
            foreach (Entidad.Models.TipoHabitacion tipHbt in lstTipHbt)
            {
                tipHbt.PrecioTipoHabitacions = dBContext.PrecioTipoHabitacions.Where(tip => tip.IdTipoHabitacion == tipHbt.IdTipoHabitacion).ToList();
            }
            return lstTipHbt;
        }
        public static Entidad.Models.TipoHabitacion? GetOne(int id)
        {
            Entidad.Models.TipoHabitacion? tipHbt = dBContext.TipoHabitacions.Find(id);
            if (tipHbt != null)
            {
                tipHbt.PrecioTipoHabitacions = dBContext.PrecioTipoHabitacions.Where(tip => tip.IdTipoHabitacion == tipHbt.IdTipoHabitacion).ToList();
            }
            return tipHbt;
        }
        public static void Create(Entidad.Models.TipoHabitacion tipHbt)
        {
            dBContext.TipoHabitacions.Add(tipHbt);
            dBContext.SaveChanges();
            dBContext.Update(tipHbt);
        }
        public static void Update(Entidad.Models.TipoHabitacion tipHbt)
        {
            dBContext.Update(tipHbt);
            dBContext.SaveChanges();
        }
        public static bool Delete(Entidad.Models.TipoHabitacion tipHbt)
        {
            try
            {
                if (tipHbt != null)
                {
                    dBContext.TipoHabitacions.Remove(tipHbt);
                    dBContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }           
        }

        /// <summary>
        /// </summary>
        /// <param name="fecha">fecha a buscar</param>
        /// <param name="tipHbt">tipoHabitacion de precio a buscar</param>
        /// <returns>Entidad precioTipoHabitacion de un tipoHabitacion que pertenezca a la fecha ingresada</returns>
        public static Entidad.Models.PrecioTipoHabitacion? DevPrecioFecha(DateTime fecha, Entidad.Models.TipoHabitacion tipHbt)
        {
            Entidad.Models.PrecioTipoHabitacion? precioBuscado = null;
            foreach (var preTipHbt in tipHbt.PrecioTipoHabitacions)
            {
                if (precioBuscado == null && preTipHbt.FechaPrecio <= fecha)
                {
                    precioBuscado = preTipHbt;
                }
                else if (precioBuscado != null)
                {
                    if (preTipHbt.FechaPrecio > precioBuscado.FechaPrecio && preTipHbt.FechaPrecio <= fecha)
                    {
                        precioBuscado = preTipHbt;
                    }
                }              
            }
            return precioBuscado;
        }

    }

    public class PrecioTipoHabitacion
    {
        static Datos.DBContext dBContext = Datos.DBContext.dBContext;
        public static List<Entidad.Models.PrecioTipoHabitacion> GetAll()
        {
            List<Entidad.Models.PrecioTipoHabitacion> lstPresTipHbt = dBContext.PrecioTipoHabitacions.ToList();
            foreach (Entidad.Models.PrecioTipoHabitacion PresTipHbt in lstPresTipHbt)
            {
                PresTipHbt.IdTipoHabitacionNavigation = TipoHabitacion.GetOne(PresTipHbt.IdTipoHabitacion)!;
            }
            return lstPresTipHbt;
        }

        public static Entidad.Models.PrecioTipoHabitacion? GetOne(int id)
        {
            Entidad.Models.PrecioTipoHabitacion? PresTipHbt = dBContext.PrecioTipoHabitacions.Find(id);
            if (PresTipHbt != null)
            {
                PresTipHbt.IdTipoHabitacionNavigation = TipoHabitacion.GetOne(PresTipHbt.IdTipoHabitacion)!;
            }
            return PresTipHbt;
        }

        public static void Create(Entidad.Models.PrecioTipoHabitacion PresTipHbt)
        {
            dBContext.PrecioTipoHabitacions.Add(PresTipHbt);
            dBContext.SaveChanges();
            dBContext.Update(PresTipHbt);
        }

        public static void Update(Entidad.Models.PrecioTipoHabitacion PresTipHbt)
        {
            dBContext.Update(PresTipHbt);
            dBContext.SaveChanges();
        }

        public static bool Delete(Entidad.Models.PrecioTipoHabitacion PresTipHbt)
        {
            if (PresTipHbt != null)
            {
                dBContext.PrecioTipoHabitacions.Remove(PresTipHbt);
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