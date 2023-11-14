using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class InformePorFecha
    {
        public DateTime Fecha { get; set; }
        public double Recaudacion { get; set; }
        public List<DetalleReserva> Detalles { get; set; }
    }

    public class DetalleReserva
    {
        public string NombreCliente { get; set; }
        public double PrecioHabitacion { get; set; }
        public double PrecioServicios { get; set; }
    }

    public class Informe
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public Informe(DateTime _fechaDesde, DateTime _fechaHasta)
        {
            fechaDesde = _fechaDesde;
            fechaHasta = _fechaHasta;
        }

        public async Task<List<InformePorFecha>> EmitirInforme()
        {
            // Obtener todas las reservas dentro del rango de fechas
            List<Entidad.Models.Reserva> reservas = await Reserva.GetAllBetween(fechaDesde, fechaHasta);

            // Lista para almacenar el informe por fecha
            List<InformePorFecha> informe = new List<InformePorFecha>();

            // Calcular la recaudación para cada reserva
            foreach (Entidad.Models.Reserva reserva in reservas)
            {
                double precioHabitacion = CalcularPrecioHabitacion(reserva);
                double precioServicios = await CalcularPrecioServicios(reserva);
                double recaudacionReserva = precioHabitacion + precioServicios;

                // Agregar la información al informe por fecha
                InformePorFecha? informeFecha = informe.FirstOrDefault(i => i.Fecha == reserva.FechaInicioReserva.Date);

                if (informeFecha == null)
                {
                    informeFecha = new InformePorFecha
                    {
                        Fecha = reserva.FechaFinReserva.Date,
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
                    NombreCliente = reserva.IdHuesped.ToString(),
                    PrecioHabitacion = precioHabitacion,
                    PrecioServicios = precioServicios
                });
            }

            return informe;
        }

        private static double CalcularPrecioHabitacion(Entidad.Models.Reserva reserva)
        {
            // Obtener el precio de la habitación para la reserva
            double precioHabitacion = 0;

            // Obtener el tipo de habitación asociado a la habitación de la reserva
            var tipoHabitacion = reserva.IdHabitacionNavigation.IdTipoHabitacionNavigation;

            if (tipoHabitacion != null)
            {
                // Obtener el precio más reciente de la habitación, en comparacion con fecha hasta
                var precioTipoHabitacion = TipoHabitacion.DevPrecioFecha(reserva.FechaFinReserva, tipoHabitacion);

                if (precioTipoHabitacion != null)
                {
                    precioHabitacion = precioTipoHabitacion.PrecioHabitacion;
                }
            }

            return precioHabitacion;
        }

        private static async Task<double> CalcularPrecioServicios(Entidad.Models.Reserva reserva)
        {
            // Obtener el precio total de los servicios para la reserva
            double precioServicios = 0;

            // Obtener la lista de servicios asociados a la reserva
            var serviciosReserva = await Servicio.GetAllOfReserva(reserva.IdReserva);

            foreach (var servicio in serviciosReserva)
            {
                // Obtener el precio más reciente del servicio
                var precioServicio = Servicio.DevPrecioFecha(reserva.FechaFinReserva, servicio);

                if (precioServicio != null)
                {
                    precioServicios += precioServicio.PrecioServicio1;
                }
            }

            return precioServicios;
        }

    }
}
