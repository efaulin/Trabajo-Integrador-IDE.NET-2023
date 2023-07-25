using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class PrecioTipoHabitacion
{
    public int IdPrecioTipoHabitacion { get; set; }

    public DateTime FechaPrecio { get; set; }

    public double PrecioHabitacion { get; set; }

    public int IdTipoHabitacion { get; set; }

    public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; } = null!;
}
