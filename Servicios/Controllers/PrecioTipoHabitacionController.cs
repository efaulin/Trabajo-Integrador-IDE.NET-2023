using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PrecioTipoHabitacionController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public PrecioTipoHabitacionController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetPrecioTipoHabitacion")]
        public ActionResult<IEnumerable<PrecioTipoHabitacion>> GetAll()
        {
            try
            {
                return _dbContext.PrecioTipoHabitacions.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idPrecioTipoHabitacion}")]
        public ActionResult<PrecioTipoHabitacion> GetOne(int idPrecioTipoHabitacion)
        {
            try
            {
                PrecioTipoHabitacion? tpHbt = _dbContext.PrecioTipoHabitacions.FirstOrDefault(e => e.IdPrecioTipoHabitacion == idPrecioTipoHabitacion);
                if (tpHbt == null)
                {
                    return NotFound();
                }
                return tpHbt;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<int> Create(Entidad.Api.PrecioTipoHabitacionApi api)
        {
            try
            {
                PrecioTipoHabitacion prsTip = new PrecioTipoHabitacion();
                prsTip.PrecioHabitacion = api.PrecioHabitacion;
                prsTip.IdTipoHabitacion = api.IdTipoHabitacion;
                prsTip.FechaPrecio = api.FechaPrecio;
                prsTip.IdTipoHabitacionNavigation = _dbContext.TipoHabitacions.Find(api.IdTipoHabitacion)!;
                if (!Validate(prsTip))
                {
                    return BadRequest();
                }
                _dbContext.PrecioTipoHabitacions.Add(prsTip);
                _dbContext.SaveChanges();
                _dbContext.Update(prsTip);
                return prsTip.IdPrecioTipoHabitacion;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idPrecio}")]
        public ActionResult Update(int idPrecioTipoHabitacion, PrecioTipoHabitacion pcTpHbt)
        {
            try
            {
                if (idPrecioTipoHabitacion != pcTpHbt.IdPrecioTipoHabitacion || !Validate(pcTpHbt))
                {
                    return BadRequest();
                }
                _dbContext.PrecioTipoHabitacions.Entry(pcTpHbt).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idPrecio}")]
        public ActionResult Delete(int idPrecioTipoHabitacion)
        {
            try
            {
                PrecioTipoHabitacion? tpHbt = _dbContext.PrecioTipoHabitacions.FirstOrDefault(e => e.IdPrecioTipoHabitacion == idPrecioTipoHabitacion);
                if (tpHbt == null) { return NotFound(); }
                _dbContext.PrecioTipoHabitacions.Remove(tpHbt);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idTipoHabitacion}")]
        public ActionResult<IEnumerable<PrecioTipoHabitacion>> GetAllOfTipoHabitacion(int idTipoHabitacion)
        {
            try
            {
                return _dbContext.PrecioTipoHabitacions.Where(e => e.IdTipoHabitacion == idTipoHabitacion).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary>
        /// Validaciones a cumplir de un objeto PrecioTipoHabitacion
        /// </summary>
        /// <param name="tpHbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool Validate(PrecioTipoHabitacion pcTpHbt)
        {
            if (pcTpHbt.IdTipoHabitacion <= 0)
            { return false; }
            if (pcTpHbt.PrecioHabitacion <= 0)
            { return false; }
            if (pcTpHbt.IdTipoHabitacionNavigation == null)
            { return false; }
            if (_dbContext.TipoHabitacions.Find(pcTpHbt.IdTipoHabitacion) == null) { return false; }
            return true;
        }
    }
}
