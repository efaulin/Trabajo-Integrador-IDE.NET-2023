using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;
using System.Reflection.PortableExecutable;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ReservaServicioController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public ReservaServicioController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetReservaServicio")]
        public ActionResult<IEnumerable<ReservaServicio>> GetAll()
        {
            try
            {
                return _dbContext.ReservaServicios.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idReservaServicio}")]
        public ActionResult<ReservaServicio> GetOne(int idReservaServicio)
        {
            try
            {
                ReservaServicio? rsv = _dbContext.ReservaServicios.Find(idReservaServicio);
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
        public ActionResult<ReservaServicio> Create(ReservaServicio rsv)
        {
            try
            {
                if (!Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.ReservaServicios.Add(rsv);
                _dbContext.SaveChanges();
                _dbContext.Update(rsv);
                return rsv;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idReservaServicio}")]
        public ActionResult Update(int idReservaServicio, ReservaServicio rsv)
        {
            try
            {
                if (idReservaServicio != rsv.IdReservaServicio || !Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.ReservaServicios.Entry(rsv).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idReservaServicio}")]
        public ActionResult Delete(int idReservaServicio)
        {
            try
            {
                ReservaServicio? rsv = _dbContext.ReservaServicios.Find(idReservaServicio);
                if (rsv == null) { return NotFound(); }
                _dbContext.ReservaServicios.Remove(rsv);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary></summary>
        /// <param name="idReserva"></param>
        /// <returns>Lista de ReservaServicio que contengan el id reserva recibido</returns>
        [HttpGet("{idReserva}")]
        public ActionResult<IEnumerable<ReservaServicio>> GetAllOfReserva(int idReserva)
        {
            try
            {
                return _dbContext.ReservaServicios.Where(e => e.IdReserva == idReserva).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary></summary>
        /// <param name="idServicio"></param>
        /// <returns>Lista de ReservaServicio que contengan el id servicio recibido</returns>
        [HttpGet("{idServicio}")]
        public ActionResult<IEnumerable<ReservaServicio>> GetAllOfServicio(int idServicio)
        {
            try
            {
                return _dbContext.ReservaServicios.Where(e => e.IdServicio == idServicio).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary></summary>
        /// <param name="idReserva"></param>
        /// <param name="idServicio"></param>
        /// <returns>Entidad ReservaSerivico que relaciona los id's de reserva y servicios</returns>
        [HttpGet("{idReserva}/{idServicio}")]
        public ActionResult<ReservaServicio> GetByReserva_Servicio(int idReserva, int idServicio)
        {
            try
            {
                ReservaServicio? rsv = _dbContext.ReservaServicios.FirstOrDefault(e => e.IdReserva == idReserva && e.IdServicio == idServicio);
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

        /// <summary>
        /// Validaciones a cumplir de un objeto ReservaServicio
        /// </summary>
        /// <param name="tpHbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool Validate(ReservaServicio rsv)
        {
            if (rsv.IdReserva == 0 || rsv.IdServicio == 0)
            { return false; }
            if (rsv.IdServicioNavigation == null || rsv.IdReservaNavigation == null)
            { return false; }
            return true;
        }
    }
}