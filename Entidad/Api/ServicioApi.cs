using Entidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Api
{
    public class ServicioApi
    {
        public int IdServicio { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}