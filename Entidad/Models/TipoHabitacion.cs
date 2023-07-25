using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class TipoHabitacion
{
    public int IdTipoHabitacion { get; set; }

    public int NumeroCamas { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();

    public virtual ICollection<PrecioTipoHabitacion> PrecioTipoHabitacions { get; set; } = new List<PrecioTipoHabitacion>();
}
