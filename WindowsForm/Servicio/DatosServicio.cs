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
    public partial class DatosServicio : Form
    {
        int? op;
        int? _id;
        bool controlPrecio = false;
        Entidad.Models.Servicio? serv;
        Task<List<Entidad.Models.Servicio>> getlstServ = Negocio.Servicio.GetAll();
        Hashtable _tmpServ = new Hashtable();
        public DatosServicio()
        {
            InitializeComponent();
        }

        public DatosServicio(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        public DatosServicio(int opcion, int id)
        {
            _id = id;
            op = opcion;
            InitializeComponent();
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
                            serv = new Entidad.Models.Servicio();
                            serv.Descripcion = txtDescipcion.Text;
                            Entidad.Models.PrecioServicio prcServ = new Entidad.Models.PrecioServicio();
                            prcServ.PrecioServicio1 = double.Parse(txtPrecio.Text);
                            prcServ.FechaPrecio = DateTime.Now;
                            serv.PrecioServicios.Add(prcServ);

                            Negocio.Servicio.Create(serv);
                            MessageBox.Show("Servicio ID: " + serv.IdServicio + " cargado con exito.");
                        }
                        catch
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al cargar el Servicio. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //throw ex;
                        }

                        break;

                    case 2:
                        try
                        {
                            List<Entidad.Models.Servicio> _lstServ = await getlstServ; 
                            serv = _lstServ.Find(delegate (Entidad.Models.Servicio serv) { return serv.IdServicio == _id; })!;
                            serv.Descripcion = txtDescipcion.Text;
                            if (controlPrecio && double.Parse(txtPrecio.Text) != serv.Precio.PrecioServicio1)
                            {
                                Entidad.Models.PrecioServicio prcServ = new Entidad.Models.PrecioServicio();
                                serv.IdServicio = serv.IdServicio;
                                prcServ.IdServicioNavigation = serv;
                                prcServ.FechaPrecio = DateTime.Now;
                                prcServ.PrecioServicio1 = double.Parse(txtPrecio.Text);
                                serv.PrecioServicios.Add(prcServ);

                            }

                            Negocio.Servicio.Update(serv);
                            MessageBox.Show("Servicio ID: " + serv.IdServicio + " editado con exito.");
                        }
                        catch
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al editar el Servicio. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //throw ex;
                        }

                        break;

                   
                }
            }
            else
            {
                stop = true;
                MessageBox.Show("Hay errores en los datos del servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!stop)
            {
                this.Close();
            }
        }

        private async void DatosServicio_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    this.Text = "Agregar Servicio";
                    idLabel.Text = "Nuevo";
                    mskCmbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    break;

                case 2:
                    this.Text = "Editar Servicio";
                    List<Entidad.Models.Servicio> _lstServ = await getlstServ;
                    if (_lstServ.Count <= 0)
                    {
                        MessageBox.Show("No hay servicios registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        idLabel.Text = _id.ToString();
                        txtPrecio.Enabled = false;
                        Id_SelectionChangeCommitted(sender, e);
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void  Id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Entidad.Models.Servicio> _lstServ = await getlstServ;
            serv = _lstServ.Find(delegate (Entidad.Models.Servicio serv) { return serv.IdServicio == _id; })!;
            txtDescipcion.Text = serv.Descripcion;
            txtPrecio.Text = serv.PrecioServicios.Last().PrecioServicio1.ToString();
            mskCmbFecha.Text = serv.PrecioServicios.Last().FechaPrecio.ToString("dd/MM/yyyy");
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

        private bool validate()
        {
            if (txtDescipcion.Text.Length == 0 || txtDescipcion.Text[0].ToString() == " ") { return false; }
            if (txtPrecio.Text.Length == 0 || double.Parse(txtPrecio.Text) == 0) { return false; }
            return true;
        }

        private void btnEditarPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true;
            btnEditarPrecio.Enabled = false;
            controlPrecio = true;
            mskCmbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
