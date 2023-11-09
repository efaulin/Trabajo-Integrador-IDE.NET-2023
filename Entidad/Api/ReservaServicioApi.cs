using Entidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidad.Api;
public partial class ReservaServicioApi
{
    public int IdReservaServicio { get; set; }

    public int IdReserva { get; set; }

    public int IdServicio { get; set; }
}