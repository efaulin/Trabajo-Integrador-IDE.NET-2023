namespace Blazor.Negocio
{
    public class Conexion
    {
        public static string defaultUrl { get { return "http://localhost:5021/api/"; } }
        public static readonly HttpClient _http = new HttpClient();
        public static HttpClient http { get { return _http; } }
    }
}
