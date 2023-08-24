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
    public partial class DatosTipoHabitacion : Form
    {
        int? op;
        TipoHabitacion tpHbt;
        List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
        Hashtable _tmpTpHbt = new Hashtable();

        public DatosTipoHabitacion()
        {
            InitializeComponent();
        }

        public DatosTipoHabitacion(int opcion)
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
                        tpHbt = new TipoHabitacion();
                        tpHbt.NumeroCamas = (int)nroNumero.Value;
                        tpHbt.Descripcion = txtDescipcion.Text;
                        PrecioTipoHabitacion prcTpHbt = new PrecioTipoHabitacion();
                        prcTpHbt.PrecioHabitacion = (double)nroPrecio.Value;
                        prcTpHbt.FechaPrecio = DateTime.Now;
                        tpHbt.PrecioTipoHabitacions.Add(prcTpHbt);

                        Negocio.TipoHabitacion.Create(tpHbt);
                        MessageBox.Show("Tipo habitacion ID: " + tpHbt.IdTipoHabitacion + " cargado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al editar el tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;

                case 2:
                    try
                    {
                        tpHbt = (TipoHabitacion)_tmpTpHbt[cmbId.SelectedItem];
                        tpHbt.NumeroCamas = (int)nroNumero.Value;
                        tpHbt.Descripcion = txtDescipcion.Text;

                        Negocio.TipoHabitacion.Update(tpHbt);
                        MessageBox.Show("Tipo habitacion ID: " + tpHbt.IdTipoHabitacion + " editado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al editar el tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;

                case 3:
                    try
                    {
                        tpHbt = (TipoHabitacion)_tmpTpHbt[cmbId.SelectedItem];
                        PrecioTipoHabitacion prc = new PrecioTipoHabitacion();
                        prc.IdTipoHabitacion = tpHbt.IdTipoHabitacion;
                        prc.IdTipoHabitacionNavigation = tpHbt;
                        prc.FechaPrecio = DateTime.Now;
                        prc.PrecioHabitacion = (double)nroPrecio.Value;
                        tpHbt.PrecioTipoHabitacions.Add(prc);

                        Negocio.TipoHabitacion.Update(tpHbt);
                        MessageBox.Show("Precio del Tipo habitacion ID: " + tpHbt.IdTipoHabitacion + " actualizado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al actualizar el precio del tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }
                    break;
            }

            this.Close();
        }

        private void DatosTipoHabitacion_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    this.Text = "Agregar tipo de habitacion";
                    cmbId.Items.Add("Nuevo");
                    cmbId.SelectedIndex = 0;
                    cmbId.Enabled = false;
                    mskCmbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    break;

                case 2:
                    this.Text = "Editar tipo de habitacion";
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
                        nroPrecio.Enabled = false;
                        cmbId_SelectionChangeCommitted(sender, e);
                    }
                    break;

                case 3:
                    this.Text = "Actualizar precio";
                    nroNumero.Enabled = false;
                    txtDescipcion.Enabled = false;
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //nroCamas, descripcion, precio, fecha
            tpHbt = (TipoHabitacion)_tmpTpHbt[cmbId.SelectedItem];
            nroNumero.Value = tpHbt.NumeroCamas;
            txtDescipcion.Text = tpHbt.Descripcion;
            nroPrecio.Value = (decimal)tpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion;
            mskCmbFecha.Text = tpHbt.PrecioTipoHabitacions.Last().FechaPrecio.ToString("dd/MM/yyyy");
        }

        private void txtDescipcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
