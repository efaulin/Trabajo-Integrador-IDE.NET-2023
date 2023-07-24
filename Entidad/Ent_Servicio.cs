using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Servicio
    {
        int _id;
        string _descripcion;
        List<Reserva> _lstReserva = new List<Reserva>();
        List<Ser_Precio> _lstSer_Precio = new List<Ser_Precio>();

        public int id { get { return _id; } }
        public string descripcion { get {  return _descripcion; } set { _descripcion = value; } }
        public float precio { get { return _lstSer_Precio[_lstSer_Precio.Count() - 1].precio; } }
        public List<Reserva> lstReserva { get { return _lstReserva; } set { _lstReserva = value; } }
        public List<Ser_Precio> lstSer_Precio { get { return _lstSer_Precio; } set { _lstSer_Precio = value; } }

        public Servicio(int _id, string _desc, List<Reserva> _lstReserva, List<Ser_Precio> _lstSer_Precio)
        {
            this._id = _id;
            _descripcion = _desc;
            this._lstReserva = _lstReserva;
            this._lstSer_Precio = _lstSer_Precio;
        }
    }
}
