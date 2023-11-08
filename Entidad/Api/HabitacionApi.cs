using System;
using System.Collections.Generic;

namespace Entidad.Api;

public partial class HabitacionApi
{
    private int _id;
    public int IdHabitacion { get { return _id; } }

    public bool Estado { get; }

    public int NumeroHabitacion { get; }

    public int PisoHabitacion { get; set; }

    public int IdTipoHabitacion { get; set; }
}
