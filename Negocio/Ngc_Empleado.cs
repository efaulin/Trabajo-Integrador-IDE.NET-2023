using Entidad.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Empleado
    {
        static readonly string defaultUrl = Conexion.defaultUrl + "Empleado/";
        public static async Task<Entidad.Models.Empleado?> GetByUsuario_Contraseña(string usuario, string contra)
        {
            var result = await Conexion.http.GetAsync(defaultUrl + "GetByUsuario_Contraseña/" + usuario + "/" + contra)!;
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Entidad.Models.Empleado>(await result.Content.ReadAsStringAsync())!;
            }
            else { return null; }
        }

        public static async Task<Entidad.Models.Empleado?> GetOne(int id)
        {
            Task<Entidad.Models.Empleado?> task = Conexion.http.GetFromJsonAsync<Entidad.Models.Empleado?>(defaultUrl + "GetOne/" + id)!;
            Entidad.Models.Empleado? hpd = await task;
            return hpd;
        }

        public static async Task<List<Entidad.Models.Empleado>> GetAll()
        {
            Task<List<Entidad.Models.Empleado>> task = Conexion.http.GetFromJsonAsync<List<Entidad.Models.Empleado>>(defaultUrl + "GetAll")!;
            List<Entidad.Models.Empleado> lstHpd = await task;
            return lstHpd;
        }

        public static async Task<Entidad.Models.Empleado?> Create(Entidad.Models.Empleado emp)
        {
            var result = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", emp);
            if (result.IsSuccessStatusCode)
            {
                int id = JsonConvert.DeserializeObject<int>(await result.Content.ReadAsStringAsync())!;
                Entidad.Models.Empleado createdHpd = (await GetOne(id))!;
                return createdHpd;
            }
            else { return null; }
        }

        public static async Task<bool> Update(Entidad.Models.Empleado emp)
        {
            var result = await Conexion.http.PutAsJsonAsync(defaultUrl + "Update/" + emp.IdEmpleado, emp);
            return result.IsSuccessStatusCode;
        }

        public static async Task<bool> Delete(Entidad.Models.Empleado emp)
        {
            var result = await Conexion.http.DeleteAsync(defaultUrl + "Delete/" + emp.IdEmpleado);
            return result.IsSuccessStatusCode;
        }
    }
}
