namespace Entidad
{
    public abstract class Persona
    {
        int _id;
        string _nombre;
        string _apellido;
        string _tipoDocumento;
        string _nroDocumento;

        public int id { get { return _id; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public string tipoDocumento { get { return _tipoDocumento; } set { _tipoDocumento = value; } }
        public string nroDocumento { get { return _nroDocumento; } set { _nroDocumento = value; } }

        public Persona(int _id, string _nom, string _ape, string _tipDoc, string _nroDoc)
        {
            this._id = _id;
            this._nombre = _nom;
            this._apellido = _ape;
            this._tipoDocumento = _tipDoc;
            this._nroDocumento = _nroDoc;
        }
    }

    public class Cliente : Persona
    {
        List<Reserva> _lstReserva;

        public List<Reserva> lstReserva { get { return _lstReserva; } set { _lstReserva = value; } }

        public Cliente(int _id, string _nom, string _ape, string _tipDoc, string _nroDoc, List<Reserva> _lstReserva) : base(_id, _nom, _ape, _tipDoc, _nroDoc)
        {
            this._lstReserva = _lstReserva;
        }
    }

    public class Recepcionista : Persona
    {
        string _usuario;
        string _contraseña;

        public string usuario { get { return _usuario; } set { _usuario = value; } }
        public string contraseña { get { return _contraseña; } set { _contraseña = value; } }

        public Recepcionista(int _id, string _nom, string _ape, string _tipDoc, string _nroDoc, string _usr, string _cts) : base(_id, _nom, _ape, _tipDoc, _nroDoc)
        {
            this.usuario = _usr;
            this.contraseña = _cts;
        }
    }

    public class Gerente : Persona
    {
        string _usuario;
        string _contraseña;

        public string usuario { get { return _usuario; } set { _usuario = value; } }
        public string contraseña { get { return _contraseña; } set { _contraseña = value; } }

        public Gerente(int _id, string _nom, string _ape, string _tipDoc, string _nroDoc, string _usr, string _cts) : base(_id, _nom, _ape, _tipDoc, _nroDoc)
        {
            this.usuario = _usr;
            this.contraseña = _cts;
        }
    }
}