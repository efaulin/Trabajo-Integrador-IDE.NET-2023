using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PrecioServicio> PrecioServicios { get; set; } = new List<PrecioServicio>();
}
