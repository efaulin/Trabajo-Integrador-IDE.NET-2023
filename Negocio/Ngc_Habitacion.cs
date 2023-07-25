using Datos;
using Entidad.Models;
using Microsoft.EntityFrameworkCore;

namespace Negocio
{
    public class Habitacion
    {
        public static List<Entidad.Models.Habitacion> getAll(DBContext dBContext)
        {
            List<Entidad.Models.Habitacion> habitaciones = dBContext.Habitacions.ToList();
            foreach (Entidad.Models.Habitacion hbt in habitaciones)
            {
                hbt.IdTipoHabitacionNavigation = TipoHabitacion.getOne(hbt.IdTipoHabitacion, dBContext);
            }
            return habitaciones;
        }
        public static void Create(Entidad.Models.Habitacion hbt, DBContext dBContext)
        {
            dBContext.Habitacions.Add(hbt);
            dBContext.SaveChanges();
            dBContext.Update(hbt);
        }
        public static bool Delete(Entidad.Models.Habitacion hbt, DBContext dBContext)
        {
            //return Datos.Habitacion.Delete(id);
            if (hbt != null)
            {
                dBContext.Habitacions.Remove(hbt);
                dBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Update(Entidad.Models.Habitacion hbt, DBContext dBContext)
        {
            dBContext.Update(hbt);
            dBContext.SaveChanges();
        }
    }

    public class TipoHabitacion
    {
        public static List<Entidad.Models.TipoHabitacion> getAll(DBContext dBContext)
        {
            List<Entidad.Models.TipoHabitacion> lstTipHbt = dBContext.TipoHabitacions.ToList();
            foreach (Entidad.Models.TipoHabitacion tipHbt in lstTipHbt)
            {
                tipHbt.PrecioTipoHabitacions = dBContext.PrecioTipoHabitacions.Where(tip => tip.IdTipoHabitacion == tipHbt.IdTipoHabitacion).ToList();
            }
            return lstTipHbt;
        }
        public static Entidad.Models.TipoHabitacion getOne(int id, DBContext dBContext)
        {
            Entidad.Models.TipoHabitacion tipHbt = dBContext.TipoHabitacions.Find(id);
            if (tipHbt != null)
            {
                tipHbt.PrecioTipoHabitacions = dBContext.PrecioTipoHabitacions.Where(tip => tip.IdTipoHabitacion == tipHbt.IdTipoHabitacion).ToList();
            }
            return tipHbt;
        }
    }
}