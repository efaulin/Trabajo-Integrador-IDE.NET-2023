using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TipHab_Precio
    {
        int _id;
        DateTime _fecha;
        float _precio;
        TipoHabitacion _tipoHabitacion;

        public int id { get { return _id; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        public float precio { get { return _precio; } set { _precio = value; } }
        public TipoHabitacion tipoHabitacion { get { return _tipoHabitacion; } set { _tipoHabitacion = value; } }
    }

    public class TipoHabitacion
    {
        int _id;
        string _descripcion;
        List<TipHab_Precio> _lstTipHab_Precio { get; set; }

        public int id { get { return _id; } }
        public string descripcion { get { return _descripcion.ToString(); } set { _descripcion = value; } }
        public float precio => _lstTipHab_Precio[_lstTipHab_Precio.Count() - 1].precio;
    }

    public class Habitacion
    {
    }
}
