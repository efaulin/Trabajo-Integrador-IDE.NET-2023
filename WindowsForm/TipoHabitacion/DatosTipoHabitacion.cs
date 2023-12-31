﻿using Entidad.Models;
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
        int? _id;
        bool controlPrecio = false;
        TipoHabitacion? tpHbt;
        Task<List<TipoHabitacion>> getlstTpHbt = Negocio.TipoHabitacion.GetAll();
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

        public DatosTipoHabitacion(int opcion, int id)
        {
            op = opcion;
            _id = id;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            bool stop = false;
            if (validate())
            {
                switch (op)
                {
                    case 1:
                        try
                        {
                            TipoHabitacion tpHbt = new TipoHabitacion();
                            tpHbt.NumeroCamas = int.Parse(txtNumero.Text);
                            tpHbt.Descripcion = txtDescipcion.Text;
                            tpHbt = await Negocio.TipoHabitacion.Create(tpHbt);
                            if(tpHbt != null)
                            {
                                PrecioTipoHabitacion prcTpHbt = new PrecioTipoHabitacion();
                                prcTpHbt.PrecioHabitacion = double.Parse(txtPrecio.Text);
                                prcTpHbt.FechaPrecio = DateTime.Now;
                                prcTpHbt.IdTipoHabitacion = tpHbt.IdTipoHabitacion;
                                prcTpHbt = await Negocio.PrecioTipoHabitacion.Create(prcTpHbt);
                                tpHbt = await Negocio.TipoHabitacion.GetOne(tpHbt.IdTipoHabitacion);
                                if(tpHbt != null) {
                                    MessageBox.Show("Tipo habitacion ID: " + tpHbt.IdTipoHabitacion + " cargado con exito.");
                                }
                            }

                            
                        }
                        catch
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al crear el tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //throw ex;
                        }

                        break;

                    case 2:
                        try
                        {
                            List<Entidad.Models.TipoHabitacion> _lstTpHbt = await getlstTpHbt;
                            tpHbt = _lstTpHbt.Find(delegate (TipoHabitacion tpHbt) { return tpHbt.IdTipoHabitacion == _id; })!;
                            tpHbt.NumeroCamas = int.Parse(txtNumero.Text);
                            tpHbt.Descripcion = txtDescipcion.Text;
                            if (controlPrecio && double.Parse(txtPrecio.Text) != tpHbt.Precio.PrecioHabitacion)
                            {
                                PrecioTipoHabitacion prc = new PrecioTipoHabitacion();
                                prc.IdTipoHabitacion = tpHbt.IdTipoHabitacion;
                                prc.IdTipoHabitacionNavigation = tpHbt;
                                prc.FechaPrecio = DateTime.Now;
                                prc.PrecioHabitacion = double.Parse(txtPrecio.Text);
                                prc = await Negocio.PrecioTipoHabitacion.Create(prc);
                            }
                            if (await Negocio.TipoHabitacion.Update(tpHbt))
                            {
                                MessageBox.Show("Tipo habitacion ID: " + tpHbt.IdTipoHabitacion + " editado con exito.");
                            }
                        }
                        catch (Exception ex)
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al editar el tipo de habitacion. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show(ex.Message);
                        }

                        break;

                }
                if (!stop)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hay errores en los datos del tipo de habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void DatosTipoHabitacion_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    this.Text = "Agregar tipo de habitacion";
                    idLabel.Text = "Nuevo";
                    mskCmbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    btnEditarPrecio.Enabled = false;
                    break;

                case 2:
                    this.Text = "Editar tipo de habitacion";
                    List<Entidad.Models.TipoHabitacion> _lstTpHbt = await getlstTpHbt;
                    if (_lstTpHbt.Count <= 0)
                    {
                        MessageBox.Show("No hay Tipos de Habitaciones registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        idLabel.Text = _id.ToString();
                        Id_SelectionChangeCommitted(sender, e);
                    }
                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nroNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void Id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //nroCamas, descripcion, precio, fecha
            List<Entidad.Models.TipoHabitacion> _lstTpHbt = await getlstTpHbt;
            tpHbt = _lstTpHbt.Find(delegate (TipoHabitacion tpHbt) { return tpHbt.IdTipoHabitacion == _id; })!;
            txtNumero.Text = tpHbt.NumeroCamas.ToString();
            txtDescipcion.Text = tpHbt.Descripcion;
            txtPrecio.Text = tpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString();
            mskCmbFecha.Text = tpHbt.PrecioTipoHabitacions.Last().FechaPrecio.ToString("dd/MM/yyyy");
            txtPrecio.Enabled = false;
            btnEditarPrecio.Enabled = true;
            controlPrecio = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox)!.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDescipcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true;
            btnEditarPrecio.Enabled = false;
            controlPrecio = true;
            mskCmbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool validate()
        {
            if (txtNumero.Text.Length == 0 || int.Parse(txtNumero.Text) == 0) { return false; }
            if (txtDescipcion.Text.Length == 0 || txtDescipcion.Text[0].ToString() == " ") { return false; }
            if (txtPrecio.Text.Length == 0 || int.Parse(txtNumero.Text) == 0) { return false; }
            return true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
