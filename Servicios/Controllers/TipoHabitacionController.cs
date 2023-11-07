using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoHabitacionController : ControllerBase
    {
        private readonly Datos.DBContext _dbContext;
        public TipoHabitacionController(Datos.DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetTipoHabitacion")]
        public ActionResult<IEnumerable<TipoHabitacion>> GetAll()
        {
            return _dbContext.TipoHabitacions.ToList();
        }

        [HttpGet("{IdTipoHabitacion}")]
        public ActionResult<TipoHabitacion> GetOne(int id)
        {
            TipoHabitacion? tmpTpHbt = _dbContext.TipoHabitacions.Find(id);
            if (tmpTpHbt == null)
            {
                return NotFound();
            }
            return tmpTpHbt;
        }

        [HttpPost]
        public ActionResult<TipoHabitacion> Create(TipoHabitacion tmpTpHbt)
        {
            _dbContext.TipoHabitacions.Add(tmpTpHbt);
            _dbContext.SaveChanges();
            _dbContext.Update(tmpTpHbt);
            return CreatedAtAction(nameof(GetOne), tmpTpHbt);
        }

        [HttpPut("{idTipoHabitacion}")]
        public ActionResult Update(int idTipoHabitacion, TipoHabitacion tpHbt)
        {
            if (idTipoHabitacion != tpHbt.IdTipoHabitacion)
            {
                return BadRequest();
            }
            _dbContext.TipoHabitacions.Entry(tpHbt).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{idTipoHabitacion}")]
        public ActionResult<TipoHabitacion> Delete(int idTipoHabitacion)
        {
            TipoHabitacion? tpHbt = _dbContext.TipoHabitacions.Find(idTipoHabitacion);
            if (tpHbt == null) { return NotFound();}
            _dbContext.TipoHabitacions.Remove(tpHbt);
            _dbContext.SaveChanges();
            return tpHbt;
        }
    }
}
