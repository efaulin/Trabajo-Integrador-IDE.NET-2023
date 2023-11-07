using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string Descripcion { get; set; } = null!;

    public PrecioServicio Precio
    {
        get
        {
            if (PrecioServicios.Count == 0)
            {
                return new PrecioServicio();
            }
            else
            {
                return PrecioServicios.Last();
            }
        }
    }

    public virtual ICollection<PrecioServicio> PrecioServicios { get; set; } = new List<PrecioServicio>();

    public virtual ICollection<ReservaServicio> ReservaServicios { get; set; } = new List<ReservaServicio>();
}
