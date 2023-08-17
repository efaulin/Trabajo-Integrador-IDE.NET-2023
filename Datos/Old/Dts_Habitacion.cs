using Entidad;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Old
{
    public class Habitacion
    {
        public static List<Entidad.Old.Habitacion> getAll()
        {
            List<string[]> habitaciones = BBDD.ArrayHabitacion();
            List<string[]> rlcHbtXTipHbt = BBDD.ArrayTipoHabitacionHabitacion();

            List<Entidad.Old.Habitacion> lstHabitacion = new List<Entidad.Old.Habitacion> ();
            foreach (string[] hab in habitaciones)
            {
                Entidad.Old.TipoHabitacion? tipHbt = null;
                int count = 0;
                while (tipHbt == null && count < rlcHbtXTipHbt.Count())
                {
                    string[] tmp = (string[])rlcHbtXTipHbt[count];
                    if (tmp[0] == hab[0])
                    {
                        //asigno valor en "tipHbt" con un metodo en Datos.TipoHabitacion que me devuelva un obj. TipoHabitacion
                        tipHbt = TipoHabitacion.getOne(int.Parse(tmp[1]));
                    }
                    else
                    {
                        count ++;
                    }
                }
                //Para esta prueba consideramos que no exiten reservas en el sistema
                Entidad.Old.Habitacion habitacion = new Entidad.Old.Habitacion(int.Parse(hab[0]), int.Parse(hab[1]), bool.Parse(hab[2]), int.Parse(hab[3]), int.Parse(hab[4]), tipHbt, new List<Entidad.Old.Reserva>());
                lstHabitacion.Add(habitacion);
            }

            return lstHabitacion;
        }

        public static Entidad.Old.Habitacion getOne(int id)
        {
            List<string[]> habitaciones = BBDD.ArrayHabitacion();
            List<string[]> rlcHbtXTipHbt = BBDD.ArrayTipoHabitacionHabitacion();

            Entidad.Old.Habitacion? hbt = null;
            int count = 0;
            while (hbt == null && count < habitaciones.Count())
            {
                string[] tmp = (string[])habitaciones[count];
                if (id == int.Parse(tmp[0]))
                {
                    Entidad.Old.TipoHabitacion? tipHbt = null;
                    int count2 = 0;
                    while (tipHbt == null && count2 < rlcHbtXTipHbt.Count())
                    {
                        string[] tmp2 = (string[])rlcHbtXTipHbt[count2];
                        if (tmp[0] == tmp2[0])
                        {
                            //asigno valor en "tipHbt" con un metodo en Datos.TipoHabitacion que me devuelva un obj. TipoHabitacion
                            tipHbt = TipoHabitacion.getOne(int.Parse(tmp2[1]));
                        }
                        else
                        {
                            count2++;
                        }
                    }
                    hbt = new Entidad.Old.Habitacion(int.Parse(tmp[0]), int.Parse(tmp[1]), bool.Parse(tmp[2]), int.Parse(tmp[3]), int.Parse(tmp[4]), tipHbt, new List<Entidad.Old.Reserva>());
                }
                else
                {
                    count++;
                }
            }

            return hbt;
        }

        public static bool Delete(int id)
        {
            List<string[]> habitaciones = BBDD.ArrayHabitacion();
            List<string[]> rlcHbtXTipHbt = BBDD.ArrayTipoHabitacionHabitacion();

            int count = -1;
            string[] tmp;
            do
            {
                count++;
                tmp = habitaciones[count];
            } while (id != int.Parse(tmp[0]) && count+1 < habitaciones.Count());

            if (id == int.Parse(tmp[0]))
            {
                habitaciones.RemoveAt(count);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Entidad.Old.Habitacion Create(Entidad.Old.Habitacion hbt)
        {
            List<string[]> habitaciones = BBDD.ArrayHabitacion();
            List<string[]> rlcHbtXTipHbt = BBDD.ArrayTipoHabitacionHabitacion();

            int id = int.Parse(habitaciones.Last()[0]) + 1;
            string[] tmp = new string[] { id.ToString(), hbt.numeroCamas.ToString(), "true", hbt.numeroHabitacion.ToString(), hbt.pisoHabitacion.ToString() };
            habitaciones.Add(tmp);

            rlcHbtXTipHbt.Add(new string[] { tmp[0], hbt.tipoHabitacion.id.ToString() });

            hbt.id = id;
            return hbt;
        }

        public static bool Update(Entidad.Old.Habitacion hbt)
        {
            List<string[]> habitaciones = BBDD.ArrayHabitacion();
            List<string[]> rlcHbtXTipHbt = BBDD.ArrayTipoHabitacionHabitacion();

            string[] tmp = new string[] { hbt.id.ToString(), hbt.numeroCamas.ToString(), hbt.estado.ToString(), hbt.numeroHabitacion.ToString(), hbt.pisoHabitacion.ToString() };
            int index = habitaciones.FindIndex(delegate (string[] hbt) { return hbt[0] == tmp[0]; });
            if (index == -1)
            {
                return false;
            }
            else
            {
                habitaciones[index] = tmp;
                return true;
            }
        }
    }

    public class TipoHabitacion
    {
        public static List<Entidad.Old.TipoHabitacion> getAll()
        {
            List<string[]> tiposHabitaciones = BBDD.ArrayTipoHabitacion();
            List<string[]> rlcTipHbtXTipHbt_Prc = BBDD.ArrayTipoHabitacionTipHab_Precio();

            List<Entidad.Old.TipoHabitacion> lstTipoHabitacion = new List<Entidad.Old.TipoHabitacion>();
            foreach (string[] tipHbt in tiposHabitaciones)
            {
                Entidad.Old.TipoHabitacion tipoHabitacion = new Entidad.Old.TipoHabitacion(int.Parse(tipHbt[0]), tipHbt[1], new List<Entidad.Old.TipHab_Precio>());
                foreach (string[] rlcTipHbt_prc in rlcTipHbtXTipHbt_Prc)
                {
                    if (tipoHabitacion.id == int.Parse(rlcTipHbt_prc[0]))
                    {
                        Entidad.Old.TipHab_Precio tmp = Datos.Old.TipHab_Precio.getOne(int.Parse(rlcTipHbt_prc[1]));
                        tipoHabitacion.lstTipHab_Precio.Add(tmp);
                    }
                }
                lstTipoHabitacion.Add(tipoHabitacion);
            }
            
            return lstTipoHabitacion;
        }
        
        public static Entidad.Old.TipoHabitacion getOne(int id)
        {
            List<string[]> tiposHabitaciones = BBDD.ArrayTipoHabitacion();
            List<string[]> rlcTipHbtXTipHbt_Prc = BBDD.ArrayTipoHabitacionTipHab_Precio();

            Entidad.Old.TipoHabitacion? tipoHabitacion = null;
            int count = 0;
            while (tipoHabitacion == null && count < tiposHabitaciones.Count())
            {
                string[] tipHbt = (string[])tiposHabitaciones[count];
                if (id == int.Parse(tipHbt[0]))
                {
                    tipoHabitacion = new Entidad.Old.TipoHabitacion(int.Parse(tipHbt[0]), tipHbt[1], new List<Entidad.Old.TipHab_Precio>());
                    foreach (string[] rlcTipHbt_prc in rlcTipHbtXTipHbt_Prc)
                    {
                        if (tipoHabitacion.id == int.Parse(rlcTipHbt_prc[0]))
                        {
                            Entidad.Old.TipHab_Precio tmp = Datos.Old.TipHab_Precio.getOne(int.Parse(rlcTipHbt_prc[1]));
                            tipoHabitacion.lstTipHab_Precio.Add(tmp);
                        }
                    }
                }
                else { count++; }
            }

            return tipoHabitacion;
        }
    }
}
