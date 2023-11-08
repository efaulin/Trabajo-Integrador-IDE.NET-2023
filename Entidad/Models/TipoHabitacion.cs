using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class TipoHabitacion
{
    public int IdTipoHabitacion { get; set; }

    public int NumeroCamas { get; set; }

    public string Descripcion { get; set; } = null!;

    public PrecioTipoHabitacion Precio
    {
        get
        {
            if (PrecioTipoHabitacions.Count == 0)
            {
                return new PrecioTipoHabitacion();
            }
            else
            {
                return PrecioTipoHabitacions.Last();
            }
        }
    }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();

    public virtual ICollection<PrecioTipoHabitacion> PrecioTipoHabitacions { get; set; } = new List<PrecioTipoHabitacion>();
}
