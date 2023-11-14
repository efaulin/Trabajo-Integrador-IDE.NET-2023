using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class InformePorFecha
    {
        public DateTime Fecha { get; set; }
        public decimal Recaudacion { get; set; }
        public List<DetalleReserva> Detalles { get; set; }
    }

    public class DetalleReserva
    {
        public string NombreCliente { get; set; }
        public decimal PrecioHabitacion { get; set; }
        public decimal PrecioServicios { get; set; }
    }

    public class Ngc_Informe
    {
        private DateTime? fechaDesde = null;
        private DateTime? fechaHasta = null;
        private Datos.DBContext context = new Datos.DBContext();

        public Ngc_Informe(DateTime _fechaDesde, DateTime _fechaHasta)
        {
            fechaDesde = _fechaDesde;
            fechaHasta = _fechaHasta;
        }

        public List<InformePorFecha> EmitirInforme()
        {
            // Obtener todas las reservas dentro del rango de fechas
            List<Entidad.Models.Reserva> reservas = context.Reservas
                .Where(reserva => reserva.FechaInicioReserva >= fechaDesde && reserva.FechaInicioReserva <= fechaHasta)
                .ToList();

            // Lista para almacenar el informe por fecha
            List<InformePorFecha> informe = new List<InformePorFecha>();

            // Calcular la recaudación para cada reserva
            foreach (Entidad.Models.Reserva reserva in reservas)
            {
                decimal precioHabitacion = CalcularPrecioHabitacion(reserva);
                decimal precioServicios = CalcularPrecioServicios(reserva);
                decimal recaudacionReserva = precioHabitacion + precioServicios;

                // Agregar la información al informe por fecha
                InformePorFecha informeFecha = informe.FirstOrDefault(i => i.Fecha == reserva.FechaInicioReserva.Date);

                if (informeFecha == null)
                {
                    informeFecha = new InformePorFecha
                    {
                        Fecha = reserva.FechaInicioReserva.Date,
                        Recaudacion = recaudacionReserva,
                        Detalles = new List<DetalleReserva>()
                    };

                    informe.Add(informeFecha);
                }
                else
                {
                    informeFecha.Recaudacion += recaudacionReserva;
                }

                // Agregar detalles de la reserva al informe por fecha
                informeFecha.Detalles.Add(new DetalleReserva
                {
                    NombreCliente = reserva.IdHuesped,
                    PrecioHabitacion = precioHabitacion,
                    PrecioServicios = precioServicios
                });
            }

            return informe;
        }

        private decimal CalcularPrecioHabitacion(Entidad.Models.Reserva reserva)
        {
            // Obtener el precio de la habitación para la reserva
            decimal precioHabitacion = 0;

            // Obtener el tipo de habitación asociado a la habitación de la reserva
            var tipoHabitacion = context.TipoHabitacions
                .Where(th => th.IdTipoHabitacion == reserva.Habitacion.IdTipoHabitacion)
                .FirstOrDefault();

            if (tipoHabitacion != null)
            {
                // Obtener el precio más reciente de la habitación
                var precioTipoHabitacion = context.PrecioTipoHabitacions
                    .Where(p => p.IdTipoHabitacion == tipoHabitacion.IdTipoHabitacion &&
                                p.FechaPrecio >= fechaDesde && p.FechaPrecio <= fechaHasta)
                    .OrderByDescending(p => p.FechaPrecio)
                    .FirstOrDefault();

                if (precioTipoHabitacion != null)
                {
                    precioHabitacion = precioTipoHabitacion.PrecioHabitacion;
                }
            }

            return precioHabitacion;
        }

        private decimal CalcularPrecioServicios(Entidad.Models.Reserva reserva)
        {
            // Obtener el precio total de los servicios para la reserva
            decimal precioServicios = 0;

            // Obtener la lista de servicios asociados a la reserva
            var serviciosReserva = reserva.ReservaServicios.Select(rs => rs.Servicio).ToList();

            foreach (var servicio in serviciosReserva)
            {
                // Obtener el precio más reciente del servicio
                var precioServicio = context.PrecioServicios
                    .Where(ps => ps.IdServicio == servicio.IdServicio &&
                                 ps.FechaPrecio >= fechaDesde && ps.FechaPrecio <= fechaHasta)
                    .OrderByDescending(ps => ps.FechaPrecio)
                    .FirstOrDefault();

                if (precioServicio != null)
                {
                    precioServicios += precioServicio.PrecioServicio1;
                }
            }

            return precioServicios;
        }

    }
}
