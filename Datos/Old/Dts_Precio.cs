using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Old
{
    public class TipHab_Precio
    {
        public static Entidad.Old.TipHab_Precio getOne(int id)
        {

            List<string[]> tipHab_Precios = BBDD.ArrayTipHab_Precio();

            Entidad.Old.TipHab_Precio? tipHab_Precio = null;
            int count = 0;
            while (tipHab_Precio == null && count < tipHab_Precios.Count())
            {
                string[] tipHbt_Prc = tipHab_Precios[count];
                if (id == int.Parse(tipHbt_Prc[0]))
                {
                    tipHab_Precio = new Entidad.Old.TipHab_Precio(int.Parse(tipHbt_Prc[0]), DateTime.Parse(tipHbt_Prc[1]), float.Parse(tipHbt_Prc[2]));
                }
                else { count++; }
            }

            return tipHab_Precio;
        }
    }
}
