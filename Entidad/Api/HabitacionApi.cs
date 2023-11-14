using System;
using System.Collections.Generic;

namespace Entidad.Api;

public partial class HabitacionApi
{
    public int IdHabitacion { get; set; }

    public bool Estado { get; set; }

    public int NumeroHabitacion { get; set; }

    public int PisoHabitacion { get; set; }

    public int IdTipoHabitacion { get; set; }
}
