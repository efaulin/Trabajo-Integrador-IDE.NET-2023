using Entidad.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class DatosReserva : Form
    {
#warning Se podria discriminar con los propios tipos Habitacion y Huesped, pero para no cambiar lo que tenemos hasta ahora agrego un booleano para discriminar entre tipos.
        bool _controlHbt;
        Reserva? _rsv;
        Habitacion? _hbt;
        Huesped? _hpd;
        List<Habitacion> _lstHbt = Negocio.Habitacion.GetAll();
        List<Huesped> _lstHpd = Negocio.Huesped.GetAll();
        List<Reserva> _lstRsv = Negocio.Reserva.GetAll();
        Hashtable _hashHbt = new Hashtable();
        Hashtable _hashHpd = new Hashtable();
        Hashtable _hashRsv = new Hashtable();

        public DatosReserva()
        {
            InitializeComponent();
        }

        //constructor con parametro del listado
        public DatosReserva(int id, bool esUnaHabitacion)
        {
            if (esUnaHabitacion)
            {
                try
                {
                    _hbt = Negocio.Habitacion.GetOne(id)!;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡La habitacion no existe!\n" + ex);
                    this.Close();
                }
            }
            else
            {
                try
                {
                    _hpd = Negocio.Huesped.GetOne(id)!;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡El huesped no existe!\n" + ex);
                    this.Close();
                }
            }

            InitializeComponent();
        }
#warning Pasar el objeto por parametro, nos ahorramos la busqueda con el id y podemos discriminarlo en el constructor ¯\_(ツ)_/¯
        public DatosReserva(int id, string a)
        {
            try
            {
                _rsv = Negocio.Reserva.GetOne(id)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡La reserva no existe!\n" + ex);
                this.Close();
            }
            InitializeComponent();
        }

        private void DatosHabitacion_Load(object sender, EventArgs e)
        {
            foreach (Habitacion _tmpHbt in _lstHbt)
            {
                string tmp = _tmpHbt.IdHabitacion + " - Piso: " + _tmpHbt.PisoHabitacion + " Nro: " + _tmpHbt.NumeroHabitacion;
                _hashHbt[tmp] = _tmpHbt;
                cmbHabitacion.Items.Add(tmp);
            }

            foreach (Huesped _tmpHpd in _lstHpd)
            {
                string tmp = _tmpHpd.NumeroDocumento + " - " + _tmpHpd.Nombre + " " + _tmpHpd.Apellido;
                _hashHpd[tmp] = _tmpHpd;
                cmbHuesped.Items.Add(tmp);
            }

            foreach (Reserva _tmpRsv in _lstRsv)
            {
                string tmp = _tmpRsv.FechaInscripcion.ToString("dd/MM/yyyy") + " - Habitacion " + _tmpRsv.IdHabitacionNavigation.NumeroHabitacion + " piso " + _tmpRsv.IdHabitacionNavigation.PisoHabitacion;
                _hashRsv[tmp] = _tmpRsv;
                cmbIdReserva.Items.Add(tmp);
            }

            if (_rsv != null)
            {
                this.Text = "Editar reserva";
                cmbIdReserva.SelectedItem = _rsv.FechaInscripcion.ToString("dd/MM/yyyy") + " - Habitacion " + _rsv.IdHabitacionNavigation.NumeroHabitacion + " piso " + _rsv.IdHabitacionNavigation.PisoHabitacion;
                cmbIdReserva_SelectionChangeCommitted(sender, e);
            }
            else
            {
                this.Text = "Agregar nueva reserva";
                cmbIdReserva.Items.Add("Nuevo");
                cmbIdReserva.SelectedItem = "Nuevo";
                cmbIdReserva.Enabled = false;
            }

            if (_hbt != null)
            {
                cmbHabitacion.SelectedItem = _hbt.IdHabitacion + " - Piso: " + _hbt.PisoHabitacion + " Nro: " + _hbt.NumeroHabitacion;
            }

            if (_hpd != null)
            {
                cmbHuesped.SelectedItem = _hpd.NumeroDocumento + " - " + _hpd.Nombre + " " + _hpd.Apellido;
            }
        }

        private void cmbIdReserva_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _rsv = (Reserva)_hashRsv[cmbIdReserva.SelectedItem]!;
            mskCmbFechaInicio.Text = _rsv.FechaInicioReserva.ToString("dd/MM/yyyy");
            mskCmbFechaFin.Text = _rsv.FechaFinReserva.ToString("dd/MM/yyyy");
            mskCmbCantPersonas.Text = _rsv.CantidadPersonas.ToString();
            cmbHabitacion.SelectedItem = _rsv.IdHabitacionNavigation.IdHabitacion + " - Piso: " + _rsv.IdHabitacionNavigation.PisoHabitacion + " Nro: " + _rsv.IdHabitacionNavigation.NumeroHabitacion;
            cmbHuesped.SelectedItem = _rsv.IdHuespedNavigation.NumeroDocumento + " - " + _rsv.IdHuespedNavigation.Nombre + " " + _rsv.IdHuespedNavigation.Apellido;
            lblEstado.Text = _rsv.EstadoReserva;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_rsv != null)
            {
                _rsv.FechaInicioReserva = DateTime.Parse(mskCmbFechaInicio.Text);
                _rsv.FechaFinReserva = DateTime.Parse(mskCmbFechaFin.Text);
                _rsv.CantidadPersonas = int.Parse(mskCmbCantPersonas.Text);
                _rsv.IdHabitacionNavigation = (Habitacion)_hashHbt[cmbHabitacion.SelectedItem]!;
                _rsv.IdHuespedNavigation = (Huesped)_hashHpd[cmbHuesped.SelectedItem]!;
                _rsv.IdHabitacion = _rsv.IdHabitacionNavigation.IdHabitacion;
                _rsv.IdHuesped = _rsv.IdHuespedNavigation.IdHuesped;
                #warning Falta modificar estado de reserva
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region A borrar
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
