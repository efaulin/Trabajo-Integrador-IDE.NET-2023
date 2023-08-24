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

namespace WindowsForm.Huespedes
{
    public partial class DatosHuesped : Form
    {
        int? op;
        Huesped hspd;
        List<Huesped> _lstHspd = Negocio.Huesped.GetAll();
        Hashtable _tmpHspd = new Hashtable();
        public DatosHuesped(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nroPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    try
                    {
                        hspd = new Huesped();
                        hspd.Nombre = txtNombre.Text;
                        hspd.Apellido = txtApellido.Text;
                        hspd.NumeroDocumento = txtDNI.Text;
                        hspd.TipoDocumento = cmbTipoDoc.Text;

                        Negocio.Huesped.Create(hspd);
                        MessageBox.Show("Huesped ID: " + hspd.IdHuesped + " cargado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al crear el huesped. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;

                case 2:
                    try
                    {
                        hspd = (Huesped)_tmpHspd[cmbId.SelectedItem];
                        hspd.Nombre = txtNombre.Text;
                        hspd.Apellido = txtApellido.Text;
                        hspd.NumeroDocumento = txtDNI.Text;
                        hspd.TipoDocumento = cmbTipoDoc.SelectedIndex.ToString();

                        Negocio.Huesped.Update(hspd);
                        MessageBox.Show("Hueñsped ID: " + hspd.IdHuesped + " editado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al editar el huesped. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;
            }

            this.Close();
        }

        private void DatosHuesped_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.Items.Add("DNI");
            cmbTipoDoc.Items.Add("LC");
            cmbTipoDoc.Items.Add("LE");
            cmbTipoDoc.SelectedIndex = 0;
            switch (op)
            {
                case 1:
                    this.Text = "Agregar huesped";
                    cmbId.Items.Add("Nuevo");
                    cmbId.SelectedIndex = 0;
                    cmbId.Enabled = false;
                    break;

                case 2:
                    this.Text = "Editar tipo de habitacion";
                    if (_lstHspd.Count <= 0)
                    {
                        MessageBox.Show("No hay Tipos de Huespedes registradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        foreach (Huesped _Hspd in _lstHspd)
                        {
                            string tmp = _Hspd.Nombre + " " + _Hspd.Apellido;
                            _tmpHspd[tmp] = _Hspd;
                            cmbId.Items.Add(tmp);
                        }
                        cmbId.SelectedIndex = 0;
                    }
                    break;
            }

        }
    }
}
