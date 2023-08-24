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
        Habitacion hbt;
        List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
        List<Habitacion> _lstHbt = Negocio.Habitacion.GetAll();
        Hashtable _tmpHbt = new Hashtable();
        Hashtable _tmpTpHbt = new Hashtable();

        public DatosHabitacion()
        {
            InitializeComponent();
        }

        public DatosHabitacion(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    try
                    {
                        TipoHabitacion tmpTpHbt = (TipoHabitacion)_tmpTpHbt[cmbTipoHabitacion.SelectedItem];
                        hbt.Estado = true;
                        hbt.IdTipoHabitacion = tmpTpHbt.IdTipoHabitacion;
                        hbt.IdTipoHabitacionNavigation = tmpTpHbt;
                        hbt.NumeroHabitacion = (int)this.nroNumero.Value;
                        hbt.PisoHabitacion = (int)this.nroPiso.Value;
                        Negocio.Habitacion.Create(hbt);
                        MessageBox.Show("Habitacion ID: " + hbt.IdHabitacion + " cargada con exito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un problema al cargar la habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;

                case 2:
                    try
                    {
                        Habitacion tmpHbt = (Habitacion)_tmpHbt[cmbIdHabitacion.SelectedItem];
                        hbt = _lstHbt.Find(delegate (Habitacion hbt) { return hbt == tmpHbt; });
                        TipoHabitacion tmpTpHbt = (TipoHabitacion)_tmpTpHbt[cmbTipoHabitacion.SelectedItem];
                        hbt.Estado = true;
                        hbt.IdTipoHabitacion = tmpTpHbt.IdTipoHabitacion;
                        hbt.IdTipoHabitacionNavigation = tmpTpHbt;
                        hbt.NumeroHabitacion = (int)this.nroNumero.Value;
                        hbt.PisoHabitacion = (int)this.nroPiso.Value;

                        Negocio.Habitacion.Update(hbt);
                        MessageBox.Show("Habitacion ID: " + hbt.IdHabitacion + " editada con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al editar la habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;
            }

            this.Close();
        }

        private void DatosHabitacion_Load(object sender, EventArgs e)
        {
            if (_lstTpHbt.Count <= 0)
            {
                MessageBox.Show("No hay tipos de habitaciones registradas\nAgrege un Tipo de habitacion, antes de cargar una habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbIdHabitacion.Items.Add("Nuevo");
                    cmbIdHabitacion.SelectedIndex = 0;
                    cmbIdHabitacion.Enabled = false;
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
                        foreach (Habitacion _hbt in _lstHbt)
                        {
                            string tmp = "Nro: " + _hbt.NumeroHabitacion + " -  Piso: " + _hbt.PisoHabitacion;
                            _tmpHbt[tmp] = _hbt;
                            cmbIdHabitacion.Items.Add(tmp);
                        }
                        cmbIdHabitacion.SelectedIndex = 0;
                        cmbIdHabitacion_SelectionChangeCommitted(sender, e);
                    }
                    break;
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

        private void nroNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbIdHabitacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hbt = (Habitacion)_tmpHbt[cmbIdHabitacion.SelectedItem];
            nroNumero.Value = hbt.NumeroHabitacion;
            nroPiso.Value = hbt.PisoHabitacion;
            cmbTipoHabitacion.SelectedItem = hbt.IdTipoHabitacionNavigation.IdTipoHabitacion + " - " + hbt.IdTipoHabitacionNavigation.Descripcion;
        }
    }
}
