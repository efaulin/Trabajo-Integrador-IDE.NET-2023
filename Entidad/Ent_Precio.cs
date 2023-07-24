using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Precio
    {
        int _id;
        DateTime _fecha;
        float _precio;

        public int id { get { return _id; } }
        public DateTime fecha { get { return _fecha; } set { _fecha = value; } }
        public float precio { get { return _precio; } set { _precio = value; } }

        public Precio(int _id, DateTime _fec, float _prc)
        {
            this._id = _id;
            _fecha = _fec;
            _precio = _prc;
        }
    }

    public class TipHab_Precio : Precio
    {
        //TipoHabitacion _tipoHabitacion;

        //public TipoHabitacion tipoHabitacion { get { return _tipoHabitacion; } set { _tipoHabitacion = value; } }

        public TipHab_Precio(int _id, DateTime _fec, float _prc/*, TipoHabitacion _tphab*/) : base(_id, _fec, _prc)
        {
            //_tipoHabitacion = _tphab;
        }
    }

    public class Ser_Precio : Precio
    {
        Servicio _servicio;

        public Servicio servicio { get { return _servicio; } set { _servicio = value; } }

        public Ser_Precio(int _id, DateTime _fec, float _prc, Servicio _ser) : base(_id, _fec, _prc)
        {
            _servicio = _ser;
        }
    }
}
