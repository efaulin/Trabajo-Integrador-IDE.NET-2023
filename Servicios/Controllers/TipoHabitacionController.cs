using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TipoHabitacionController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public TipoHabitacionController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetTipoHabitacion")]
        public ActionResult<IEnumerable<TipoHabitacion>> GetAll()
        {
            try
            {
                return _dbContext.TipoHabitacions.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{IdTipoHabitacion}")]
        public ActionResult<TipoHabitacion> GetOne(int IdTipoHabitacion)
        {
            try
            {
                TipoHabitacion? tmpHbt = _dbContext.TipoHabitacions.Find(IdTipoHabitacion);
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
        public ActionResult<int> Create(Entidad.Api.TipoHabitacionApi api)
        {
            try
            {
                TipoHabitacion thbt = new TipoHabitacion();
                thbt.Habitacions = new List<Habitacion>();
                thbt.PrecioTipoHabitacions = new List<PrecioTipoHabitacion>();
                thbt.Descripcion = api.Descripcion;
                thbt.NumeroCamas = api.NumeroCamas;

                if (!Validate(thbt))
                {
                    return BadRequest();
                }
                _dbContext.TipoHabitacions.Add(thbt);
                _dbContext.SaveChanges();
                _dbContext.Update(thbt);
                return thbt.IdTipoHabitacion;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idTipoHabitacion}")]
        public ActionResult Update(int idTipoHabitacion, Entidad.Api.TipoHabitacionApi api)
        {
            try
            {
                TipoHabitacion thbt = _dbContext.TipoHabitacions.Find(api.IdTipoHabitacion)!;                
                if (idTipoHabitacion != api.IdTipoHabitacion || thbt == null)
                {
                    return BadRequest();
                }
                thbt.Descripcion = api.Descripcion;
                thbt.NumeroCamas = api.NumeroCamas;
                _dbContext.TipoHabitacions.Entry(thbt).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idTipoHabitacion}")]
        public ActionResult Delete(int idTipoHabitacion)
        {
            try
            {
                TipoHabitacion? tpHbt = _dbContext.TipoHabitacions.Find(idTipoHabitacion);
                if (tpHbt == null) { return NotFound(); }
                _dbContext.TipoHabitacions.Remove(tpHbt);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary>
        /// Validaciones a cumplir de un objeto TipoHabitacion
        /// </summary>
        /// <param name="tpHbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool Validate(TipoHabitacion tpHbt)
        {
            if (tpHbt.PrecioTipoHabitacions == null)
            { return false; }
            if (tpHbt.NumeroCamas <= 0)
            { return false; }
            if (tpHbt.Descripcion == "" || tpHbt.Descripcion[0].ToString() == " ")
            { return false; }
            return true;
        }
    }
}
