using Entidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Api
{
    public class ReservaApi
    {
        public int IdReserva { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public DateTime FechaInicioReserva { get; set; }

        public DateTime FechaFinReserva { get; set; }

        public string EstadoReserva { get; set; } = null!;

        public int CantidadPersonas { get; set; }

        public int IdHabitacion { get; set; }

        public int IdHuesped { get; set; }
    }
}
