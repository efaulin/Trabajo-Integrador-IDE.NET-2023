using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Api
{
    public class EmpleadoApi
    {
        public int IdEmpleado { get; set; }

        public string TipoUsuario { get; set; } = null!;

        public string NombreUsuario { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
