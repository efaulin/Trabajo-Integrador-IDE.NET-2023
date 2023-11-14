using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PrecioServicio
    {
        static readonly string defaultUrl = Conexion.defaultUrl + "PrecioServicio/";
        public static async Task<Entidad.Models.PrecioServicio?> GetOne(int id)
        {
            var response = await Conexion.http.GetStringAsync(defaultUrl + "GetOne/" + id.ToString());
            var data = JsonConvert.DeserializeObject<Entidad.Models.PrecioServicio>(response);           
            return data;
        }

        public static async Task<Entidad.Models.PrecioServicio> create(Entidad.Models.PrecioServicio prsv)
        {
            Entidad.Api.PrecioServicioApi srv = GetApi(prsv);
            var response = await Conexion.http.PostAsJsonAsync(defaultUrl + "Create", srv);
            var data = JsonConvert.DeserializeObject<int>(await response.Content.ReadAsStringAsync());
            Entidad.Models.PrecioServicio createdServ = (await GetOne(data))!;
            return createdServ;
        }

        public static Entidad.Api.PrecioServicioApi GetApi(Entidad.Models.PrecioServicio psrv)
        {
            Entidad.Api.PrecioServicioApi api = new Entidad.Api.PrecioServicioApi();
            api.FechaPrecio = psrv.FechaPrecio ;
            api.PrecioServicio1 = psrv.PrecioServicio1 ;
            api.IdServicio = psrv.IdServicio;
            return api;
        }
    }
}
