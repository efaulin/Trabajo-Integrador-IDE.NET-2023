using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public DateTime FechaInscripcion { get; set; }

    public DateTime FechaInicioReserva { get; set; }

    public DateTime FechaFinReserva { get; set; }

    public string EstadoReserva { get; set; } = null!;

    public int CantidadPersonas { get; set; }

    public int IdHabitacion { get; set; }

    public int IdHuesped { get; set; }

    public virtual Habitacion IdHabitacionNavigation { get; set; } = null!;

    public virtual Huesped IdHuespedNavigation { get; set; } = null!;
}
