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
        int? _id;
        Huesped? hspd;
        List<Huesped> _lstHspd = Negocio.Huesped.GetAll();
        Hashtable _tmpHspd = new Hashtable();
        public DatosHuesped(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        public DatosHuesped(int opcion, int id)
        {
            op = opcion;
            _id = id;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool stop = false;
            if (validate())
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
                            stop = true;
                            MessageBox.Show("Hubo un problema al crear el huesped. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //throw ex;
                        }

                        break;

                    case 2:
                        try
                        {
                            hspd = _lstHspd.Find(delegate (Huesped hspd) { return hspd.IdHuesped == _id; })!;
                            hspd.Nombre = txtNombre.Text;
                            hspd.Apellido = txtApellido.Text;
                            hspd.NumeroDocumento = txtDNI.Text;
                            hspd.TipoDocumento = cmbTipoDoc.Text;

                            Negocio.Huesped.Update(hspd);
                            MessageBox.Show("Huesped ID: " + hspd.IdHuesped + " editado con exito.");
                        }
                        catch
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al editar el huesped. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //throw ex;
                        }

                        break;
                }
            }
            else
            {
                stop = true;
                MessageBox.Show("Hay errores en los datos del huesped", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (!stop)
            {
                this.Close();
            }
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
                    idLabel.Text = "Nuevo";
                    break;

                case 2:
                    this.Text = "Editar huesped";
                    if (_lstHspd.Count <= 0)
                    {
                        MessageBox.Show("No hay Huespedes registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hspd = _lstHspd.Find(delegate (Huesped hspd) { return hspd.IdHuesped == _id; })!;
            txtNombre.Text = hspd.Nombre;
            txtApellido.Text = hspd.Apellido;
            txtDNI.Text = hspd.NumeroDocumento.ToString();
            cmbTipoDoc.SelectedItem = hspd.TipoDocumento;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validate()
        {
            if (txtNombre.Text.Length == 0 || txtNombre.Text[0].ToString() == " ") { return false; }
            if (txtApellido.Text.Length == 0 || txtApellido.Text[0].ToString() == " ") { return false; }
            if (txtDNI.Text.Length == 0 || txtDNI.Text[0].ToString() == " ") { return false; }
            return true;
        }
    }
}
