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
    public partial class EliminarTipoHabitacion : Form
    {
        int? op;
        TipoHabitacion tpHbt;
        List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
        Hashtable _tmpTpHbt = new Hashtable();

        public EliminarTipoHabitacion()
        {
            InitializeComponent();
        }

        public EliminarTipoHabitacion(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            tpHbt = (TipoHabitacion)_tmpTpHbt[cmbId.SelectedItem];
            int tmpId = tpHbt.IdTipoHabitacion;
            try
            {
                if (MessageBox.Show("¿Seguro que quiere borrar la habitacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Negocio.TipoHabitacion.Delete(tpHbt))
                    {
                        MessageBox.Show("Tipo habitacion ID: " + tmpId + " eliminado con exito.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al eliminar el tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                if (tpHbt.Habitacions.Count() != 0)
                {
                    MessageBox.Show("¡No se puede borrar un tipo de habitacion con habitaciones cargadas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Hubo un problema al eliminar el tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw ex;
            }
            this.Close();
        }

        private void DatosTipoHabitacion_Load(object sender, EventArgs e)
        {
            if (_lstTpHbt.Count <= 0)
            {
                MessageBox.Show("No hay Tipos de Habitaciones registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                foreach (TipoHabitacion _tpHbt in _lstTpHbt)
                {
                    string tmp = _tpHbt.IdTipoHabitacion + "  -  Desc: " + _tpHbt.Descripcion;
                    _tmpTpHbt[tmp] = _tpHbt;
                    cmbId.Items.Add(tmp);
                }
                cmbId.SelectedIndex = 0;
                cmbId_SelectionChangeCommitted(sender, e);
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //nroCamas, descripcion, precio, fecha
            tpHbt = (TipoHabitacion)_tmpTpHbt[cmbId.SelectedItem];
            lblCamas.Text = tpHbt.NumeroCamas.ToString();
            lblDescripcion.Text = tpHbt.Descripcion;
            lblPrecio.Text = tpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString();
            lblFecha.Text = tpHbt.PrecioTipoHabitacions.Last().FechaPrecio.ToShortDateString();
            lblHabitaciones.Text = tpHbt.Habitacions.Count().ToString();
        }
    }
}
