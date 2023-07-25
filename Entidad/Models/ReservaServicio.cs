using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class ReservaServicio
{
    public int IdReserva { get; set; }

    public int IdServicio { get; set; }

    public virtual Reserva IdReservaNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
