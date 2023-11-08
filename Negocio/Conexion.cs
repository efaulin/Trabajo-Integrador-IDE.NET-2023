using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Negocio
{
    public sealed class Conexion
    {
        private Conexion() { }
        private static Conexion? instancia;
        private HttpClient httpClient = new HttpClient();

        public HttpClient HttpClient { get { return httpClient; } }

        public static Conexion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Conexion();
                    instancia.httpClient.DefaultRequestHeaders.Accept.Clear();
                    instancia.HttpClient.DefaultRequestHeaders.Accept.Add
                        (new MediaTypeWithQualityHeaderValue("application/json"));
                }
                return instancia;
            }
        }
    }
}
