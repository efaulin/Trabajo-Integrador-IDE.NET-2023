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
    public partial class DatosHabitacion : Form
    {
        Habitacion? _hbt;
        Habitacion hbt;
        List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
        Hashtable _tmpTpHbt = new Hashtable();

        public DatosHabitacion()
        {
            InitializeComponent();
        }

        public DatosHabitacion(Habitacion exHbt)
        {
            _hbt = exHbt;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TipoHabitacion tmpTpHbt = (TipoHabitacion)_tmpTpHbt[cmbTipoHabitacion.SelectedItem];
            hbt.Estado = true;
            hbt.IdTipoHabitacion = tmpTpHbt.IdTipoHabitacion;
            hbt.IdTipoHabitacionNavigation = tmpTpHbt;
            hbt.NumeroHabitacion = (int)this.nroNumero.Value;
            hbt.PisoHabitacion = (int)this.nroPiso.Value;

            if (_hbt == null)
            {
                Negocio.Habitacion.Create(hbt);
            }
            else
            {
                Negocio.Habitacion.Update(hbt); //¿Cambiar las funciones CRUD de negocio para devolver un boolean? ¿Como?
            }

            if (hbt.IdHabitacion != 0)
            {
                MessageBox.Show("Habitacion ID: " + hbt.IdHabitacion + " cargada con exito.");
            }
            else
            {
                MessageBox.Show("Hubo un problema al cargar la habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void DatosHabitacion_Load(object sender, EventArgs e)
        {
            this.Text = "Agregar habitacion";
            if (_lstTpHbt.Count <= 0)
            {
                MessageBox.Show("No hay tipos de habitaciones registradas\nAgrege un Tipo de habitacion, antes de cargar una habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            foreach (TipoHabitacion tpHbt in _lstTpHbt)
            {
                string tmp = tpHbt.IdTipoHabitacion + " - " + tpHbt.Descripcion;
                _tmpTpHbt[tmp] = tpHbt;
                cmbTipoHabitacion.Items.Add(tmp);
            }
            cmbTipoHabitacion.SelectedIndex = 0;

            if (_hbt == null)
            {
                hbt = new Habitacion();
            }
            else
            {
                hbt = _hbt;
                this.txtId.Text = hbt.IdHabitacion.ToString();
                this.nroNumero.Value = hbt.NumeroHabitacion;
                this.nroPiso.Value = hbt.PisoHabitacion;
                cmbTipoHabitacion.SelectedItem = hbt.IdTipoHabitacion + " - " + hbt.IdTipoHabitacionNavigation.Descripcion;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
