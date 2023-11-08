using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using Datos;
using System.Text.RegularExpressions;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HuespedController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public HuespedController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetHuesped")]
        public ActionResult<IEnumerable<Huesped>> GetAll()
        {
            try
            {
                return _dbContext.Huespeds.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{idHuesped}")]
        public ActionResult<Huesped> GetOne(int id)
        {
            try
            {
                Huesped? hpd = _dbContext.Huespeds.Find(id);
                if (hpd == null)
                {
                    return NotFound();
                }
                return hpd;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<Huesped> Create(Huesped hpd)
        {
            try
            {
                if (!Validate(hpd))
                {
                    return BadRequest();
                }
                _dbContext.Huespeds.Add(hpd);
                _dbContext.SaveChanges();
                _dbContext.Update(hpd);
                return hpd;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpPut("{idHuesped}")]
        public ActionResult Update(int idHuesped, Huesped hpd)
        {
            try
            {
                if (idHuesped != hpd.IdHuesped || !Validate(hpd))
                {
                    return BadRequest();
                }
                _dbContext.Huespeds.Entry(hpd).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idHuesped}")]
        public ActionResult Delete(int idHuesped)
        {
            try
            {
                Huesped? hpd = _dbContext.Huespeds.Find(idHuesped);
                if (hpd == null) { return NotFound(); }
                _dbContext.Huespeds.Remove(hpd);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{tipo, nro}")]
        public ActionResult<Huesped> GetByTipo_NroDocumento(string tipo, string nro)
        {
            try
            {
                Huesped? hpd = _dbContext.Huespeds.FirstOrDefault(hsp => hsp.TipoDocumento == tipo && hsp.NumeroDocumento == nro);
                if (hpd == null)
                {
                    return NotFound();
                }
                return hpd;
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{nro}")]
        public ActionResult<IEnumerable<Huesped>> GetByNroDocumento(string nro)
        {
            try
            {
                return _dbContext.Huespeds.Where(hsp => hsp.NumeroDocumento.Contains(nro)).ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        /// <summary>
        /// Validaciones a cumplir de un objeto Huesped
        /// </summary>
        /// <param name="tpHbt"></param>
        /// <returns>Si pasa las validaciones "True", caso contrario "False"</returns>
        private bool Validate(Huesped hpd)
        {
            if (hpd.TipoDocumento != "DNI" && hpd.TipoDocumento != "LE" && hpd.TipoDocumento != "LC")
            { return false; }
            if (!Regex.IsMatch(hpd.NumeroDocumento, @"[0-9]{7,9}"))
            { return false; }
            if (hpd.Nombre.Length == 0 || hpd.Apellido.Length == 0)
            { return false; }
            return true;
        }
    }
}