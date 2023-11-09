using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Datos;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ServicioController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public ServicioController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetServicio")]
        public ActionResult<IEnumerable<Servicio>> GetAll()
        {
            try
            {
                return _dbContext.Servicios.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{IdServicio}")]
        public ActionResult<Servicio> GetOne(int IdServicio)
        {
            try
            {
                Servicio? tmpHbt = _dbContext.Servicios.Find(IdServicio);
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
        public ActionResult<int> Create(Entidad.Api.ServicioApi api)
        {
            try
            {
                Servicio srv = new Servicio();
                srv.Descripcion = api.Descripcion;  
                srv.PrecioServicios = new List<PrecioServicio>();
                if (!Validate(srv))
                {
                    return BadRequest();
                }
                _dbContext.Servicios.Add(srv);
                _dbContext.SaveChanges();
                _dbContext.Update(srv);
                return srv.IdServicio;
            }
            catch (Exception ex)
            {
                return Problem(statusCode:500, detail:ex.Message);
            }
        }

        [HttpPut("{idServicio}")]
        public ActionResult Update(int idServicio, Entidad.Api.ServicioApi api)
        {
            try
            {
                Servicio srv = _dbContext.Servicios.Find(idServicio);
                if (idServicio != api.IdServicio || srv == null)
                {
                    return BadRequest();
                }
                srv.Descripcion = api.Descripcion;
                _dbContext.Servicios.Entry(srv).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idServicio}")]
        public ActionResult Delete(int idServicio)
        {
            try
            {
                Servicio? hbt = _dbContext.Servicios.Find(idServicio);
                if (hbt == null) { return NotFound(); }
                _dbContext.Servicios.Remove(hbt);
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
        /// <returns>Lista de servicios pertenecientes a la reserva de id ingresado</returns>
        [HttpGet("{idReserva}")]
        public ActionResult<IEnumerable<Servicio>> GetAllOfReserva(int idReserva)
        {
            try
            {
                var lstRelacionada = _dbContext.ReservaServicios.Join(_dbContext.Servicios,
                    rs => rs.IdServicio,
                    s => s.IdServicio,
                    (rs, s) => new { rs, s }
                    ).Where(e => e.rs.IdReserva == idReserva).ToList();
                List<Servicio> list = new List<Servicio>();
                foreach (var xd in lstRelacionada)
                {
                    list.Add(xd.s);
                }
                return list;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        private bool Validate(Servicio srv)
        {
            if (srv.PrecioServicios == null)
            { return false; }
            if (srv.Descripcion.Length == 0 || srv.Descripcion[0].ToString() == " ")
            { return false; }
            return true;
        }
    }
}
