using System.Net.Http.Json;
using Entidad.Models;

namespace Blazor.Negocio
{
    public class EmpleadoServicio
    {
        static readonly string defaultUrl = Conexion.defaultUrl + "Empleado/";
        public static async Task<List<Empleado>> GetAll()
        {
            var result = await Conexion.http.GetFromJsonAsync<List<Empleado>>("http://localhost:7110/api/Empleado/GetAll");
            return result!;
        }

        public static async Task<Empleado> GetOne(int id)
        {
            var result = await Conexion.http.GetFromJsonAsync<Empleado>(defaultUrl + "GetOne/" + id.ToString());
            return result!;
        }

        public static async Task<bool> Create(Empleado emp)
        {
            var result = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create/", emp);
            return result.IsSuccessStatusCode;
        }

        public static async Task<bool> Update(Empleado emp)
        {
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/", emp);
            return result.IsSuccessStatusCode;
        }

        public static async Task<bool> Delete(Empleado emp)
        {
            var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + emp.IdEmpleado);
            return result.IsSuccessStatusCode;
        }
    }
}
