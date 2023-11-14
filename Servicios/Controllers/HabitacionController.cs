using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Entidad.Api;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Datos;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HabitacionController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public HabitacionController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetHabitacion")]
        public ActionResult<IEnumerable<Habitacion>> GetAll()
        {
            try
            {
                return _dbContext.Habitacions.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{IdHabitacion}")]
        public ActionResult<Habitacion> GetOne(int IdHabitacion)
        {
            try
            {
                Habitacion? tmpHbt = _dbContext.Habitacions.Find(IdHabitacion);
                if (tmpHbt == null)
                {
                    return NotFound();
                }
                return tmpHbt;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<int> Create(HabitacionApi hbtApi)
        {
            try
            {
                Habitacion? hbt = new Habitacion();
                hbt.NumeroHabitacion = hbtApi.NumeroHabitacion;
                hbt.PisoHabitacion = hbtApi.PisoHabitacion;
                hbt.Estado = hbtApi.Estado;
                hbt.IdTipoHabitacion = hbtApi.IdTipoHabitacion;
                hbt.IdTipoHabitacionNavigation = _dbContext.TipoHabitacions.Find(hbtApi.IdTipoHabitacion)!;
                hbt.Reservas = new List<Reserva>();
                if (!ValidateCreate(hbt))
                {
                    return BadRequest();
                }
                _dbContext.Habitacions.Add(hbt);
                _dbContext.SaveChanges();
                _dbContext.Update(hbt);
                return hbt.IdHabitacion;
            }
            catch (Exception ex)
            {
                return Problem(statusCode:500, detail:ex.Message);
            }
        }

        [HttpPut("{idHabitacion}")]
        public ActionResult Update(int idHabitacion, HabitacionApi hbtApi)
        {
            try
            {
                Habitacion? hbt = _dbContext.Habitacions.Find(hbtApi.IdHabitacion);
                if (hbt == null || idHabitacion != hbt.IdHabitacion) { return NotFound(); }
                else
                {
                    hbt.NumeroHabitacion = hbtApi.NumeroHabitacion;
                    hbt.PisoHabitacion = hbtApi.PisoHabitacion;
                    hbt.Estado = hbtApi.Estado;
                    hbt.IdTipoHabitacion = hbtApi.IdTipoHabitacion;
                    hbt.IdTipoHabitacionNavigation = _dbContext.TipoHabitacions.Find(hbtApi.IdTipoHabitacion)!;
                    hbt.Reservas = _dbContext.Reservas.Join(_dbContext.Habitacions,
                        r => r.IdHabitacion,
                        h => h.IdHabitacion,
                        (r, h) => r
                        ).Where(e => e.IdHabitacion == hbt.IdHabitacion).ToList();
                }
                if (!ValidateUpdate(hbt))
                {
                    return BadRequest();
                }
                _dbContext.Habitacions.Entry(hbt).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idHabitacion}")]
        public ActionResult Delete(int idHabitacion)
        {
            try
            {
                Habitacion? hbt = _dbContext.Habitacions.Find(idHabitacion);
                if (hbt == null) { return NotFound(); }
                _dbContext.Habitacions.Remove(hbt);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary></summary>
        /// <returns>Lista de habitaciones dadas de alta (hbt.estado == true)</returns>
        [HttpGet(Name = "GetHabitacionAllEnabled")]
        public ActionResult<IEnumerable<Habitacion>> GetAllEnabled()
        {
            try
            {
                return _dbContext.Habitacions.Where(hbt => hbt.Estado == true).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary></summary>
        /// <param name="amountPeople">capacidad de personas (minima) deseada</param>
        /// <returns>Listado de habitaciones con capacidad igual o mayor de personas</returns>
        [HttpGet("{amountPeople}")]
        public ActionResult<IEnumerable<Habitacion>> GetForAmountOfPeople(int amountPeople)
        {
            try
            {
                return _dbContext.Habitacions.Where(hbt => hbt.IdTipoHabitacionNavigation.NumeroCamas >= amountPeople).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{piso}")]
        public ActionResult<IEnumerable<Habitacion>> GetByPiso(int piso)
        {
            try
            {
                return _dbContext.Habitacions.Where(e => e.PisoHabitacion == piso).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{nro}")]
        public ActionResult<IEnumerable<Habitacion>> GetByNro(int nro)
        {
            try
            {
                return _dbContext.Habitacions.Where(e => e.NumeroHabitacion == nro).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{piso}/{nro}")]
        public ActionResult<Habitacion> GetByPiso_Nro(int piso, int nro)
        {
            try
            {
                Habitacion? tmpHbt = _dbContext.Habitacions.FirstOrDefault(e => e.PisoHabitacion == piso && e.NumeroHabitacion == nro);
                if (tmpHbt == null)
                {
                    return NotFound();
                }
                return tmpHbt;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idTipoHabitacion}")]
        public ActionResult<IEnumerable<Habitacion>> GetAllOfTipoHabitacion(int idTipoHabitacion)
        {
            try
            {
                return _dbContext.Habitacions.Where(e => e.IdTipoHabitacion == idTipoHabitacion).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary>
        /// Validaciones a cumplir de un objeto habitacion
        /// </summary>
        /// <param name="hbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool ValidateCreate(Habitacion hbt)
        {
            if (hbt.IdTipoHabitacionNavigation == null)
            { return false; }
            if (hbt.Reservas == null)
            { return false; }
            if (_dbContext.Habitacions.FirstOrDefault(e => e.NumeroHabitacion == hbt.NumeroHabitacion && e.PisoHabitacion == hbt.NumeroHabitacion) != null)
            { return false; }
            return true;
        }

        private bool ValidateUpdate(Habitacion hbt)
        {
            if (hbt.IdTipoHabitacionNavigation == null)
            { return false; }
            if (hbt.Reservas == null)
            { return false; }
            return true;
        }
    }
}
