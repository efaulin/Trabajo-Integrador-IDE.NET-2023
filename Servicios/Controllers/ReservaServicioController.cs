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
            bool control = true;
            Reserva? rsv = _dbContext.Reservas.Find(lstSrvApi.First().IdReserva);
            if (rsv == null) { return NotFound(); }
            List<Servicio> lstSrv = new List<Servicio>();
            lstSrvApi.ForEach(x => { lstSrv.Add(_dbContext.Servicios.Find(x.IdServicio)!); });

            var srv_rsvSrv = _dbContext.Servicios.Join(_dbContext.ReservaServicios,
                s => s.IdServicio,
                rs => rs.IdServicio,
                (s, rs) => new { s, rs }
                ).Where(e => e.rs.IdReserva == rsv.IdReserva).ToList();

            List<Servicio> lstGuardada = new List<Servicio>();
            srv_rsvSrv.ForEach(x => { lstGuardada.Add(x.s); });

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