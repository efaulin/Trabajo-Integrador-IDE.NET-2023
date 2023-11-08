using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

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
        public ActionResult<Reserva> Create(ReservaApi rsvApi)
        {
            try
            {
                Reserva rsv = rsvApi.rsv;
                List<Servicio> lstSrv = rsvApi.lstSrv;
                if (!Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.Reservas.Add(rsv);
                _dbContext.SaveChanges();
                _dbContext.Update(rsv);
                if (SaveServicios(rsv, lstSrv)) { return rsv; }
                else { return Problem(statusCode: 409, detail: "Problemas al cargar los servicios"); ; }
                
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
                Reserva rsv = rsvApi.rsv;
                List<Servicio> lstSrv = rsvApi.lstSrv;
                if (idReserva != rsv.IdHuesped || !Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.Reservas.Entry(rsv).State = EntityState.Modified;
                _dbContext.SaveChanges();
                if (SaveServicios(rsv, lstSrv)) { return NoContent(); }
                else { return Problem(statusCode: 409, detail: "Problemas al cargar los servicios"); }
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
                return _dbContext.Reservas.Join(_dbContext.ReservaServicios,
                    r => r.IdReserva,
                    rs => rs.IdReserva,
                    (r, rs) => r
                    ).ToList();
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
                return _dbContext.Reservas.Join(_dbContext.Habitacions,
                    r => r.IdHabitacion,
                    h => h.IdHabitacion,
                    (r, rs) => r
                    ).ToList();
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

        private bool SaveServicios(Reserva rsv, List<Servicio> lstSrv)
        {
            bool control = true;
            List<Servicio> lstGuardada = _dbContext.Servicios.Join(_dbContext.ReservaServicios,
                s => s.IdServicio,
                rs => rs.IdServicio,
                (s, rs) => s
                ).ToList();

            //Guardo las nuevas relaciones
            foreach (Servicio tmpSrv in lstSrv)
            {
                if (!lstGuardada.Contains(tmpSrv))
                {
                    ReservaServicio newRsvSrv = new ReservaServicio();
                    newRsvSrv.IdReserva = rsv.IdReserva;
                    newRsvSrv.IdServicio = tmpSrv.IdServicio;
                    try
                    {
                        _dbContext.ReservaServicios.Add(newRsvSrv);
                        _dbContext.SaveChanges();
                        _dbContext.Update(newRsvSrv);
                    }
                    catch
                    {
                        control = false;
                    }
                }
            }
            //Borro las que ya no se relacionan
            foreach (Servicio dbSrv in lstGuardada)
            {
                if (!lstSrv.Contains(dbSrv))
                {
                    ReservaServicio delRsrSrv = _dbContext.ReservaServicios.First(e => e.IdReserva == rsv.IdReserva && e.IdServicio == dbSrv.IdServicio);
                    try
                    {
                        _dbContext.ReservaServicios.Remove(delRsrSrv);
                        _dbContext.SaveChanges();
                    }
                    catch
                    {
                        control = false;
                    }
                }
            }

            return control;
        }
    }
}