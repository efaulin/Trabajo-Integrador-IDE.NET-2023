using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Negocio
{
    public class Conexion
    {
        public static string defaultUrl { get { return "http://localhost:5021/api/"; } }
        public static readonly HttpClient _http = new HttpClient();
        public static HttpClient http { get { return _http; } }
    }
}
