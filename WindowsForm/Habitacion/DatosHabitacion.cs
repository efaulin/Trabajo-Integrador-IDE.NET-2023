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
        int? op;
        int? _id;
        Habitacion? hbt;
        List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
        List<Habitacion> _lstHbt = Negocio.Habitacion.GetAll();
        Hashtable _tmpHbt = new Hashtable();
        Hashtable _tmpTpHbt = new Hashtable();

        public DatosHabitacion(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        //constructor con parametro del listado
        public DatosHabitacion(int opcion, int id)
        {
            op = opcion;
            _id = id;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                TipoHabitacion tmpTpHbt;
                bool stop = false;
                switch (op)
                {
                    case 1:
                        tmpTpHbt = (TipoHabitacion)_tmpTpHbt[cmbTipoHabitacion.SelectedItem]!;
                        hbt!.Estado = true;
                        hbt.IdTipoHabitacion = tmpTpHbt.IdTipoHabitacion;
                        hbt.IdTipoHabitacionNavigation = tmpTpHbt;
                        hbt.NumeroHabitacion = int.Parse(txtNumero.Text);
                        hbt.PisoHabitacion = int.Parse(txtPiso.Text);
                        if (Negocio.Habitacion.Create(hbt))
                        {
                            MessageBox.Show("Habitacion ID: " + hbt.IdHabitacion + " cargada con exito.");
                        }
                        else
                        {
                            stop = true;
                        }
                        break;

                    case 2:
                        hbt = _lstHbt.Find(delegate (Habitacion hbt) { return hbt.IdHabitacion == _id; })!;
                        tmpTpHbt = (TipoHabitacion)_tmpTpHbt[cmbTipoHabitacion.SelectedItem]!;
                        hbt.Estado = true;
                        hbt.IdTipoHabitacion = tmpTpHbt.IdTipoHabitacion;
                        hbt.IdTipoHabitacionNavigation = tmpTpHbt;
                        hbt.NumeroHabitacion = int.Parse(txtNumero.Text);
                        hbt.PisoHabitacion = int.Parse(txtPiso.Text);
                        if (Negocio.Habitacion.Update(hbt))
                        {
                            MessageBox.Show("Habitacion ID: " + hbt.IdHabitacion + " editada con exito.");
                        }
                        else
                        {
                            stop = true;
                        }
                        break;
                }
                if (!stop) { this.Close(); }
                else
                {
                    MessageBox.Show("Hubo un problema al cargar la habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hay errores en los datos de la habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void DatosHabitacion_Load(object sender, EventArgs e)
        {
            if (_lstTpHbt.Count <= 0)
            {
                MessageBox.Show("¡No hay tipos de habitaciones registradas!\nAgrege un Tipo de habitacion, antes de cargar una habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                foreach (TipoHabitacion tpHbt in _lstTpHbt)
                {
                    string tmp = tpHbt.IdTipoHabitacion + " - " + tpHbt.Descripcion;
                    _tmpTpHbt[tmp] = tpHbt;
                    cmbTipoHabitacion.Items.Add(tmp);
                }
                cmbTipoHabitacion.SelectedIndex = 0;
            }

            switch (op)
            {
                case 1:
                    this.Text = "Agregar habitacion";
                    idLabel.Text = "Nuevo";
                    hbt = new Habitacion();
                    break;

                case 2:
                    this.Text = "Editar habitacion";
                    if (_lstHbt.Count <= 0)
                    {
                        MessageBox.Show("No hay Habitaciones registradas\nAgrege una Habitacion, antes de editar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        idLabel.Text = _id.ToString();
                        foreach (Habitacion _hbt in _lstHbt)
                        {
                            string tmp = "Nro: " + _hbt.NumeroHabitacion + " -  Piso: " + _hbt.PisoHabitacion;
                            _tmpHbt[tmp] = _hbt;
                        }
                        cmbIdHabitacion_SelectionChangeCommitted(sender, e);

                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIdHabitacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hbt = _lstHbt.Find(delegate (Habitacion hbt) { return hbt.IdHabitacion == _id; })!;
            txtNumero.Text = hbt.NumeroHabitacion.ToString();
            txtPiso.Text = hbt.PisoHabitacion.ToString();
            cmbTipoHabitacion.SelectedItem = hbt.IdTipoHabitacionNavigation.IdTipoHabitacion + " - " + hbt.IdTipoHabitacionNavigation.Descripcion;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool validate()
        {
            if (txtNumero.Text.Length == 0 || txtNumero.Text == "0") { return false; }
            if (txtPiso.Text.Length == 0 || txtPiso.Text == "0") { return false; }
            return true;
        }
    }
}
