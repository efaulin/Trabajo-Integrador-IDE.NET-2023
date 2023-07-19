using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TipoHabitacion
    {
        int _id;
        string _descripcion;
        List<Habitacion> _lstHabitacion;
        List<TipHab_Precio> _lstTipHab_Precio;

        public int id { get { return _id; } }
        public string descripcion { get { return _descripcion.ToString(); } set { _descripcion = value; } }
        public float precio => _lstTipHab_Precio[_lstTipHab_Precio.Count() - 1].precio;
        public List<Habitacion> lstHabitacion { get { return _lstHabitacion; } set { _lstHabitacion = value; } }
        public List<TipHab_Precio> lstTipHab_Precio { get { return _lstTipHab_Precio; } set { _lstTipHab_Precio = value; } }

        public TipoHabitacion(int _id, string _desc, List<Habitacion> _lstHabitacion, List<TipHab_Precio> _lstTipHab_Precio)
        {
            this._id = _id;
            _descripcion = _desc;
            this._lstHabitacion = _lstHabitacion;
            this._lstTipHab_Precio = _lstTipHab_Precio;
        }
    }

    public class Habitacion
    {
        int _id;
        int _numeroCamas;
        bool _estado;
        int _numeroHabitacion;
        int _pisoHabitacion;
        TipoHabitacion _tipoHabitacion;
        List<Reserva> _lstReserva;

        public int id { get { return _id; }}
        public int numeroCamas { get {  return _numeroCamas; } set { _numeroCamas = value; } }
        public bool estado { get { return _estado; } set { _estado = value; } }
        public int numeroHabitacion { get {  return _numeroHabitacion; } set { _numeroHabitacion = value; } }
        public int pisoHabitacion { get { return _pisoHabitacion; } set { _pisoHabitacion = value; } }
        public TipoHabitacion tipoHabitacion { get { return _tipoHabitacion; } set { _tipoHabitacion = value; } }
        public List<Reserva> lstReserva { get { return _lstReserva; } set { _lstReserva = value; } }

        public Habitacion(int _id, int _nroCma, bool _est, int _nroHab, int _psoHab, TipoHabitacion _tpHab, List<Reserva> _lstReserva)
        {
            this._id = _id;
            _numeroCamas = _nroCma;
            _estado = _est;
            _numeroHabitacion = _nroHab;
            _pisoHabitacion = _psoHab;
            _tipoHabitacion = _tpHab;
            this._lstReserva = _lstReserva;
        }
    }
}
