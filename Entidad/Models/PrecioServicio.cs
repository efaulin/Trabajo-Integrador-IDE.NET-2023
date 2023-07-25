using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class PrecioServicio
{
    public int IdPrecioServicio { get; set; }

    public DateTime FechaPrecio { get; set; }

    public double PrecioServicio1 { get; set; }

    public int IdServicio { get; set; }

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
