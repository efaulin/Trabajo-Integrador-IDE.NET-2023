using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Habitacion
{
    public int IdHabitacion { get; set; }

    public bool Estado { get; set; }

    public int NumeroHabitacion { get; set; }

    public int PisoHabitacion { get; set; }

    public int IdTipoHabitacion { get; set; }

    public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
