using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Reserva
    {
        int _id;
        DateTime _fechaInscripcion = DateTime.Now;
        DateTime _fechaInicioReserva;
        DateTime _fechaFinReserva;
        string _estado = "En espera";
        List<Cliente> _lstCliente = new List<Cliente>();
        List<Habitacion> _lstHabitacion = new List<Habitacion>();
        List<Servicio> _lstServicio = new List<Servicio>();

        public int id { get { return _id; } }
        public DateTime fechaInscripcion { get { return _fechaInscripcion; } set { _fechaInscripcion = value; } }
        public DateTime fechaInicioReserva { get { return _fechaInicioReserva; } set { _fechaInicioReserva = value; } }
        public DateTime fechaFinReserva { get {  return _fechaFinReserva; } set { _fechaFinReserva = value; } }
        public string estado { get { return _estado; } set { _estado = value; } }
        public List<Cliente> lstCliente { get {  return _lstCliente; } set { _lstCliente = value; } }
        public List<Habitacion> lstHabitacion { get { return _lstHabitacion; } set { _lstHabitacion = value; } }
        public List<Servicio> lstServicio { get { return _lstServicio; } set { _lstServicio = value; } }

        public Reserva(int _id, DateTime _fchIns, DateTime _fchIniRsr, DateTime _fchFinRsr, string _est, List<Cliente> _lstCliente, List<Habitacion> _lstHabitacion, List<Servicio> _lstServicio)
        {
            this._id = _id;
            _fechaInscripcion = _fchIns;
            _fechaInicioReserva = _fchIniRsr;
            _fechaFinReserva = _fchFinRsr;
            _estado = _est;
            this._lstCliente = _lstCliente;
            this._lstHabitacion = _lstHabitacion;
            this._lstServicio = _lstServicio;
        }
    }
}
