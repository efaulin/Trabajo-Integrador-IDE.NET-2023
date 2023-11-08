using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PrecioServicioController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public PrecioServicioController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetPrecioServicio")]
        public ActionResult<IEnumerable<PrecioServicio>> GetAll()
        {
            try
            {
                return _dbContext.PrecioServicios.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{IdPrecio}")]
        public ActionResult<PrecioServicio> GetOne(int idPrecioServicio)
        {
            try
            {
                PrecioServicio? tpHbt = _dbContext.PrecioServicios.FirstOrDefault(e => e.IdPrecioServicio == idPrecioServicio);
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
        public ActionResult<PrecioServicio> Create(PrecioServicio tmpPcSrv)
        {
            try
            {
                if (!Validate(tmpPcSrv))
                {
                    return BadRequest();
                }
                _dbContext.PrecioServicios.Add(tmpPcSrv);
                _dbContext.SaveChanges();
                _dbContext.Update(tmpPcSrv);
                return tmpPcSrv;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idPrecio}")]
        public ActionResult Update(int idPrecioServicio, PrecioServicio pcSrv)
        {
            try
            {
                if (idPrecioServicio != pcSrv.IdPrecioServicio || !Validate(pcSrv))
                {
                    return BadRequest();
                }
                _dbContext.PrecioServicios.Entry(pcSrv).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idPrecio}")]
        public ActionResult Delete(int idPrecioServicio)
        {
            try
            {
                PrecioServicio? tpHbt = _dbContext.PrecioServicios.FirstOrDefault(e => e.IdPrecioServicio == idPrecioServicio);
                if (tpHbt == null) { return NotFound(); }
                _dbContext.PrecioServicios.Remove(tpHbt);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idServicio}")]
        public ActionResult<IEnumerable<PrecioServicio>> GetAllOfServicio(int idServicio)
        {
            try
            {
                return _dbContext.PrecioServicios.Where(e => e.IdServicio == idServicio).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary>
        /// Validaciones a cumplir de un objeto PrecioServicio
        /// </summary>
        /// <param name="tpHbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool Validate(PrecioServicio pcSrv)
        {
            if (pcSrv.PrecioServicio1 <= 0)
            { return false; }
            if (pcSrv.IdServicio <= 0)
            { return false; }
            if (pcSrv.IdServicioNavigation == null)
            { return false; }
            if (_dbContext.Servicios.Find(pcSrv.IdServicio) == null)
            { return false; }
            return true;
        }
    }
}
