namespace Negocio
{
    public class Habitacion
    {
        public static List<Entidad.Habitacion> getAll()
        {
            List<Entidad.Habitacion> habitaciones = Datos.Habitacion.getAll().FindAll( delegate (Entidad.Habitacion hbt) { return hbt.estado == true; });
            return habitaciones;
        }
        public static Entidad.Habitacion Create(Entidad.Habitacion hbt) { return Datos.Habitacion.Create(hbt); }
        public static bool Delete(int id)
        {
            //return Datos.Habitacion.Delete(id);
            Entidad.Habitacion hbt = Datos.Habitacion.getOne(id);
            if (hbt != null)
            {
                hbt.estado = false;
                Datos.Habitacion.Update(hbt);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Entidad.Habitacion> getAllDisabled()
        {
            List<Entidad.Habitacion> habitaciones = Datos.Habitacion.getAll().FindAll(delegate (Entidad.Habitacion hbt) { return hbt.estado == false; });
            return habitaciones;
        }
    }

    public class TipoHabitacion
    {
        public static List<Entidad.TipoHabitacion> getAll() { return Datos.TipoHabitacion.getAll(); }
        public static Entidad.TipoHabitacion getOne(int id) { return Datos.TipoHabitacion.getOne(id); }
    }
}