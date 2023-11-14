using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Api;
public partial class PrecioTipoHabitacionApi
{
    public int IdPrecioTipoHabitacion { get; set; }

    public DateTime FechaPrecio { get; set; }

    public double PrecioHabitacion { get; set; }

    public int IdTipoHabitacion { get; set; }

}
