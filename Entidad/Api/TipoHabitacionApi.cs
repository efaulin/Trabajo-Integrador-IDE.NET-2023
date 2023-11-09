using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Api;
public partial class TipoHabitacionApi
{
    public int IdTipoHabitacion { get; set; }

    public int NumeroCamas { get; set; }

    public string Descripcion { get; set; } = null!;

}