using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Entidad.Api;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ReservaController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public ReservaController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetReserva")]
        public ActionResult<IEnumerable<Reserva>> GetAll()
        {
            try
            {
                return _dbContext.Reservas.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idReserva}")]
        public ActionResult<Reserva> GetOne(int idReserva)
        {
            try
            {
                Reserva? rsv = _dbContext.Reservas.Find(idReserva);
                if (rsv == null)
                {
                    return NotFound();
                }
                return rsv;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<int> Create(ReservaApi rsvApi)
        {
            try
            {
                Reserva rsv = new Reserva();
                rsv.FechaInscripcion = rsvApi.FechaInscripcion;
                rsv.FechaInicioReserva = rsvApi.FechaInicioReserva;
                rsv.FechaFinReserva = rsvApi.FechaFinReserva;
                rsv.EstadoReserva = rsvApi.EstadoReserva;
                rsv.CantidadPersonas = rsvApi.CantidadPersonas;
                rsv.IdHabitacion = rsvApi.IdHabitacion;
                rsv.IdHuesped = rsvApi.IdHuesped;
                rsv.IdHabitacionNavigation = _dbContext.Habitacions.Find(rsvApi.IdHabitacion)!;
                rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation = _dbContext.TipoHabitacions.Find(rsv.IdHabitacionNavigation.IdTipoHabitacion)!;
                rsv.IdHuespedNavigation = _dbContext.Huespeds.Find(rsvApi.IdHuesped)!;
                if (!Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.Reservas.Add(rsv);
                _dbContext.SaveChanges();
                _dbContext.Update(rsv);
                return rsv.IdReserva;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idReserva}")]
        public ActionResult Update(int idReserva, ReservaApi rsvApi)
        {
            try
            {
                Reserva? rsv = _dbContext.Reservas.Find(rsvApi.IdReserva);
                if (rsv == null) {  return NotFound(); }
                else
                {
                    rsv.IdReserva = rsvApi.IdReserva;
                    rsv.FechaInscripcion = rsvApi.FechaInscripcion;
                    rsv.FechaInicioReserva = rsvApi.FechaInicioReserva;
                    rsv.FechaFinReserva = rsvApi.FechaFinReserva;
                    rsv.EstadoReserva = rsvApi.EstadoReserva;
                    rsv.CantidadPersonas = rsvApi.CantidadPersonas;
                    rsv.IdHabitacion = rsvApi.IdHabitacion;
                    rsv.IdHuesped = rsvApi.IdHuesped;
                    rsv.IdHabitacionNavigation = _dbContext.Habitacions.Find(rsvApi.IdHabitacion)!;
                    rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation = _dbContext.TipoHabitacions.Find(rsv.IdHabitacionNavigation.IdTipoHabitacion)!;
                    rsv.IdHuespedNavigation = _dbContext.Huespeds.Find(rsvApi.IdHuesped)!;
                }
                if (idReserva != rsv.IdReserva || !Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.Reservas.Entry(rsv).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idReserva}")]
        public ActionResult Delete(int idReserva)
        {
            try
            {
                Reserva? rsv = _dbContext.Reservas.Find(idReserva);
                if (rsv == null) { return NotFound(); }
                _dbContext.Reservas.Remove(rsv);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idServicio}")]
        public ActionResult<IEnumerable<Reserva>> GetAllOfServicio(int idServicio)
        {
            try
            {
                return _dbContext.ReservaServicios.Join(_dbContext.Servicios,
                    rs => rs.IdServicio,
                    s => s.IdServicio,
                    (rs, s) => rs
                    ).Where(e => e.IdServicio == idServicio).Join(_dbContext.Reservas,
                    rs => rs.IdReserva,
                    r => r.IdReserva,
                    (rs, r) => r).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idHabitacion}")]
        public ActionResult<IEnumerable<Reserva>> GetAllOfHabitacion(int idHabitacion)
        {
            try
            {
                return _dbContext.Reservas.Where(e => e.IdHabitacion == idHabitacion).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idHuesped}")]
        public ActionResult<IEnumerable<Reserva>> GetAllOfHuesped(int idHuesped)
        {
            try
            {
                return _dbContext.Reservas.Where(e => e.IdHuesped == idHuesped).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet(Name = "GetAllBetween")]
        public ActionResult<IEnumerable<Reserva>> GetAllBetween(DateTime desde, DateTime hasta)
        {
            try
            {
                if (desde.CompareTo(hasta) > 0) { return BadRequest(); }
                return _dbContext.Reservas
                    .Where(reserva => reserva.FechaInicioReserva >= desde && reserva.FechaInicioReserva <= hasta)
                    .ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary>
        /// Validaciones a cumplir de un objeto Reserva
        /// </summary>
        /// <param name="tpHbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool Validate(Reserva rsv)
        {
            if (rsv.CantidadPersonas <= 0) { return false; }
            if (rsv.CantidadPersonas > rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation.NumeroCamas) { return false; }
            if (rsv.FechaInicioReserva.CompareTo(rsv.FechaFinReserva) >= 0) { return false; }
            return true;
        }
    }
}