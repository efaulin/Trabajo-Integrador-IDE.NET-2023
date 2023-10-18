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
    public partial class EliminarHabitacion : Form
    {
        int? op;
        Habitacion? hbt;
        List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
        List<Habitacion> _lstHbt = Negocio.Habitacion.GetAll();
        Hashtable _tmpHbt = new Hashtable();
        Hashtable _tmpTpHbt = new Hashtable();

        public EliminarHabitacion()
        {
            InitializeComponent();
        }

        public EliminarHabitacion(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Habitacion tmpHbt = (Habitacion)_tmpHbt[cmbIdHabitacion.SelectedItem]!;
            int tmpId = tmpHbt.IdHabitacion;
            try
            {
                if (MessageBox.Show("¿Seguro que quiere borrar la habitacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Negocio.Habitacion.Delete(hbt!))
                    {
                        MessageBox.Show("Habitacion ID: " + hbt!.IdHabitacion + " eliminada con exito.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al borrar la habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                if (tmpHbt.Reservas.Count() != 0)
                {
                    MessageBox.Show("//TEMPORAL//\nCondicion DELETE para reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Hubo un problema al borrar la habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
            this.Close();
        }

        private void DatosHabitacion_Load(object sender, EventArgs e)
        {
            if (_lstHbt.Count <= 0)
            {
                MessageBox.Show("No hay Habitaciones registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            hbt = (Habitacion)_tmpHbt[cmbIdHabitacion.SelectedItem]!;
            lblNumero.Text = hbt.NumeroHabitacion.ToString();
            lblPiso.Text = hbt.PisoHabitacion.ToString();
            if (hbt.Estado)
            {
                lblEstado.Text = "ALTA";
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                lblEstado.Text = "BAJA";
                lblEstado.ForeColor = Color.DarkGray;
            }
            lblTipoHabitacion.Text = hbt.IdTipoHabitacionNavigation.IdTipoHabitacion + " - " + hbt.IdTipoHabitacionNavigation.Descripcion;
            lblNroReservas.Text = hbt.Reservas.Count().ToString();
        }
    }
}
