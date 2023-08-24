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
    public partial class EliminarHuesped : Form
    {
        Huesped hspd;
        List<Huesped> _lstHspd = Negocio.Huesped.GetAll();
        Hashtable _tmpHspd = new Hashtable();
        public EliminarHuesped()
        {
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
            hspd = (Huesped)_tmpHspd[cmbId.SelectedItem];
            string tmp = hspd.Nombre + " " + hspd.Apellido;
            try
            {
                if (MessageBox.Show("¿Seguro que quiere borrar el huesped?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Negocio.Huesped.Delete(hspd))
                    {
                        MessageBox.Show("Huesped " + tmp + " eliminado con exito.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al eliminar el huesped. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                //Revisar DELETE para Reservas
                MessageBox.Show("Hubo un problema al eliminar el huesped. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void DatosHuesped_Load(object sender, EventArgs e)
        {
            if (_lstHspd.Count <= 0)
            {
                MessageBox.Show("No hay Huespedes registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmbId_SelectionChangeCommitted(sender, e);
            }

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void cmbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hspd = (Huesped)_tmpHspd[cmbId.SelectedItem];
            lblNombre.Text = hspd.Nombre;
            lblApellido.Text = hspd.Apellido;
            lblNumero.Text = hspd.NumeroDocumento.ToString();
            lblDocumento.Text = hspd.TipoDocumento;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
