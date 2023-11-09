using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;
using System.Reflection.PortableExecutable;
using Entidad.Api;

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
        public ActionResult<int> Create(ReservaServicioApi api)
        {
            try
            {
                ReservaServicio rsv = new ReservaServicio();
                rsv.IdReservaServicio = api.IdReservaServicio;
                rsv.IdServicio = api.IdServicio;
                rsv.IdReserva = api.IdReserva;
                rsv.IdReservaNavigation = _dbContext.Reservas.Find(api.IdReserva)!;
                rsv.IdServicioNavigation = _dbContext.Servicios.Find(api.IdServicio)!;
                if (!Validate(rsv))
                {
                    return BadRequest();
                }
                _dbContext.ReservaServicios.Add(rsv);
                _dbContext.SaveChanges();
                _dbContext.Update(rsv);
                return rsv.IdReservaServicio;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idReservaServicio}")]
        public ActionResult Update(int idReservaServicio, ReservaServicioApi api)
        {
            try
            {
                ReservaServicio? rsv = _dbContext.ReservaServicios.Find(api.IdReservaServicio);
                if (rsv == null || idReservaServicio != rsv.IdReservaServicio || !Validate(rsv))
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

        [HttpPut]
        public ActionResult<bool> SaveServicios(List<ReservaServicioApi> lstSrvApi)
        {
            Reserva? rsv = _dbContext.Reservas.Find(lstSrvApi.First().IdReserva);
            if (rsv == null) { return NotFound(); }
            List<ReservaServicio> lstGuardada = _dbContext.ReservaServicios.Where(e => e.IdReserva == rsv.IdReserva).ToList();
            foreach (ReservaServicio rsvSrv in lstGuardada)
            {
                if (lstSrvApi.FirstOrDefault(e => e.IdReserva == rsvSrv.IdReserva && e.IdServicio == rsvSrv.IdServicio) == null)
                {
                    try { _dbContext.ReservaServicios.Remove(rsvSrv); }
                    catch { return false; }
                }
            }
            foreach (ReservaServicioApi api in lstSrvApi)
            {
                if (lstGuardada.FirstOrDefault(e => e.IdReserva == api.IdReserva && e.IdServicio == api.IdServicio) == null)
                {
                    var tmp = new ReservaServicio();
                    tmp.IdServicio = api.IdServicio;
                    tmp.IdReserva = api.IdReserva;
                    tmp.IdReservaNavigation = _dbContext.Reservas.Find(api.IdReserva)!;
                    tmp.IdServicioNavigation = _dbContext.Servicios.Find(api.IdServicio)!;
                    if (tmp.IdReservaNavigation == null || tmp.IdServicioNavigation == null) { return NotFound(); }
                    try { _dbContext.ReservaServicios.Add(tmp); }
                    catch { return false; }
                }
            }
            try { _dbContext.SaveChanges(); }
            catch { return false; }
            return true;
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