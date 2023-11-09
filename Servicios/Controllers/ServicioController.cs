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
        [HttpGet(Name = "GetAllOfReserva")]
        public ActionResult<IEnumerable<Servicio>> GetAllOfReserva(int idReserva)
        {
            try
            {
                return _dbContext.Servicios.Join(_dbContext.ReservaServicios,
                    s => s.IdServicio,
                    rs => rs.IdServicio,
                    (s, rs) => s
                    ).ToList();
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
