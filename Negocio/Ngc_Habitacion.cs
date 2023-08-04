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
        public static void Create(Entidad.Models.TipoHabitacion tipHbt, DBContext dBContext)
        {
            dBContext.TipoHabitacions.Add(tipHbt);
            dBContext.SaveChanges();
            dBContext.Update(tipHbt);
        }
        public static void Update(Entidad.Models.TipoHabitacion tipHbt, DBContext dBContext)
        {
            dBContext.Update(tipHbt);
            dBContext.SaveChanges();
        }
        public static bool Delete(Entidad.Models.TipoHabitacion tipHbt, DBContext dBContext)
        {
            if (tipHbt != null)
            {
                dBContext.TipoHabitacions.Remove(tipHbt);
                dBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class PrecioTipoHabitacion
    {
        public static List<Entidad.Models.PrecioTipoHabitacion> getAll(DBContext dBContext)
        {
            List<Entidad.Models.PrecioTipoHabitacion> lstPresTipHbt = dBContext.PrecioTipoHabitacions.ToList();
            foreach (Entidad.Models.PrecioTipoHabitacion PresTipHbt in lstPresTipHbt)
            {
                PresTipHbt.IdTipoHabitacionNavigation = TipoHabitacion.getOne(PresTipHbt.IdTipoHabitacion, dBContext);
            }
            return lstPresTipHbt;
        }

        public static Entidad.Models.PrecioTipoHabitacion getOne(int id, DBContext dBContext)
        {
            Entidad.Models.PrecioTipoHabitacion PresTipHbt = dBContext.PrecioTipoHabitacions.Find(id);
            if (PresTipHbt != null)
            {
                PresTipHbt.IdTipoHabitacionNavigation = TipoHabitacion.getOne(PresTipHbt.IdTipoHabitacion, dBContext);
            }
            return PresTipHbt;
        }

        public static void Create(Entidad.Models.PrecioTipoHabitacion PresTipHbt, DBContext dBContext)
        {
            dBContext.PrecioTipoHabitacions.Add(PresTipHbt);
            dBContext.SaveChanges();
            dBContext.Update(PresTipHbt);
        }

        public static void Update(Entidad.Models.PrecioTipoHabitacion PresTipHbt, DBContext dBContext)
        {
            dBContext.Update(PresTipHbt);
            dBContext.SaveChanges();
        }

        public static bool Delete(Entidad.Models.PrecioTipoHabitacion PresTipHbt, DBContext dBContext)
        {
            if (PresTipHbt != null)
            {
                dBContext.PrecioTipoHabitacions.Remove(PresTipHbt);
                dBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}