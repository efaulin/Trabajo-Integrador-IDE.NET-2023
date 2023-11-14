using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Api
{
    public class HuespedApi
    {
        public int IdHuesped { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string NumeroDocumento { get; set; } = null!;

        public string TipoDocumento { get; set; } = null!;
    }
}
