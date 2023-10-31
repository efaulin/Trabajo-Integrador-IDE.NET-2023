using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.Models;
using Datos;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Negocio
{
    public class Huesped
    {
        static Datos.DBContext dBContext = DBContext.dBContext;
        public static List<Entidad.Models.Huesped> GetAll()
        {
            List<Entidad.Models.Huesped> huespeds = dBContext.Huespeds.ToList();
            foreach (Entidad.Models.Huesped hpd in huespeds)
            {
                hpd.Reservas = dBContext.Reservas.Where(rsv => rsv.IdHuesped == hpd.IdHuesped).ToList();
            }
            return huespeds;
        }
        public static Entidad.Models.Huesped? GetOne(int id)
        {
            Entidad.Models.Huesped? hpd = dBContext.Huespeds.Find(id);
            if (hpd != null)
            {
                hpd.Reservas = dBContext.Reservas.Where(rsv => rsv.IdHuesped == hpd.IdHuesped).ToList();
            }
            return hpd;
        }
        public static bool Create(Entidad.Models.Huesped hpd)
        {
            try
            {
                dBContext.Huespeds.Add(hpd);
                dBContext.SaveChanges();
                dBContext.Update(hpd);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Update(Entidad.Models.Huesped hpd)
        {
            try
            {
                dBContext.Update(hpd);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Entidad.Models.Huesped hpd)
        {
            //return Datos.Habitacion.Delete(id);
            try
            {
                dBContext.Huespeds.Remove(hpd);
                dBContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="tipo">ingrese uno de estos 3 valores: DNI, LE, LC</param>
        /// <param name="nro">numero de documento de huesped a buscar</param>
        /// <returns>Entidad Huesped correspondiente al tipo y numero de documento ingresado por parametro</returns>
        public static Entidad.Models.Huesped? GetByTipo_NroDocumento(string tipo, string nro)
        {
            return dBContext.Huespeds.FirstOrDefault(hsp => hsp.TipoDocumento == tipo && hsp.NumeroDocumento == nro);
        }

        /// <summary></summary>
        /// <param name="nro">numero de documento de huesped a buscar</param>
        /// <returns>Lista de huespedes que contengan total o parcialmente el numero ingresado</returns>
        public static List<Entidad.Models.Huesped> GetByNroDocumento(string nro)
        {
            return dBContext.Huespeds.Where(hsp => hsp.NumeroDocumento.Contains(nro)).ToList();
        }
    }
}
