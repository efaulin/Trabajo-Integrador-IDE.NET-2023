using System;
using System.Collections.Generic;

namespace Entidad.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string TipoUsuario { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;
}
