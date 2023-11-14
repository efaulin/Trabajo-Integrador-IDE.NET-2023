using Microsoft.AspNetCore.Mvc;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Datos;

namespace Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public EmpleadoController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        [HttpGet(Name = "GetEmpleado")]
        public ActionResult<IEnumerable<Empleado>> GetAll()
        {
            try
            {
                return _dbContext.Empleados.ToList();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{IdEmpleado}")]
        public ActionResult<Empleado> GetOne(int idEmpleado)
        {
            try
            {
                Empleado? tmpHbt = _dbContext.Empleados.Find(idEmpleado);
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
        public ActionResult<int> Create(Empleado tmpHbt)
        {
            try
            {
                if (!Validate(tmpHbt))
                {
                    return BadRequest();
                }
                _dbContext.Empleados.Add(tmpHbt);
                _dbContext.SaveChanges();
                _dbContext.Update(tmpHbt);
                return tmpHbt.IdEmpleado;
            }
            catch (Exception ex)
            {
                return Problem(statusCode:500, detail:ex.Message);
            }
        }

        [HttpPut("{idEmpleado}")]
        public ActionResult Update(int idEmpleado, Empleado hbt)
        {
            try
            {
                if (idEmpleado != hbt.IdEmpleado || !Validate(hbt))
                {
                    return BadRequest();
                }
                _dbContext.Empleados.Entry(hbt).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpDelete("{idEmpleado}")]
        public ActionResult Delete(int idEmpleado)
        {
            try
            {
                Empleado? hbt = _dbContext.Empleados.Find(idEmpleado);
                if (hbt == null) { return NotFound(); }
                _dbContext.Empleados.Remove(hbt);
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return Problem(statusCode: 500, detail: ex.Message);
            }
        }

        [HttpGet("{usuario}/{contra}")]
        public ActionResult<Empleado> GetByUsuario_Contraseña(string usuario, string contra)
        {
            try
            {
                Empleado? tmpHbt = _dbContext.Empleados.FirstOrDefault(e => e.NombreUsuario == usuario && e.Password == contra);
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

        private bool Validate(Empleado emp)
        {
            if (emp.NombreUsuario.Length == 0 || emp.Password.Length == 0)
            { return false; }
            if (emp.NombreUsuario[0].ToString() == " " || emp.Password[0].ToString() == " ")
            { return false; }
            if (emp.TipoUsuario != "Recepcionista" && emp.TipoUsuario != "Gerente")
            { return false; }
            return true;
        }
    }
}
