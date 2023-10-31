using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Huesped
{
    public int IdHuesped { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public string nombreCompleto()
    {
        return Nombre + " " + Apellido;
    }
}
