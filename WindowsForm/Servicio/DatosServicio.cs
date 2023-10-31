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
        Entidad.Models.Servicio? serv;
        List<Entidad.Models.Servicio> _lstServ = Negocio.Servicio.GetAll();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    try
                    {
                        serv = new Entidad.Models.Servicio();
                        serv.Descripcion = txtDescipcion.Text;
                        Entidad.Models.PrecioServicio prcServ = new Entidad.Models.PrecioServicio();
                        prcServ.PrecioServicio1 = (double)nroPrecio.Value;
                        prcServ.FechaPrecio = DateTime.Now;
                        serv.PrecioServicios.Add(prcServ);

                        Negocio.Servicio.Create(serv);
                        MessageBox.Show("Servicio ID: " + serv.IdServicio + " cargado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al cargar el Servicio. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;

                case 2:
                    try
                    {
                        serv = _lstServ.Find(delegate (Entidad.Models.Servicio serv) { return serv.IdServicio == _id; })!;
                        serv.Descripcion = txtDescipcion.Text;

                        Negocio.Servicio.Update(serv);
                        MessageBox.Show("Servicio ID: " + serv.IdServicio + " editado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al editar el Servicio. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }

                    break;

                case 3:
                    try
                    {
                        serv = _lstServ.Find(delegate (Entidad.Models.Servicio serv) { return serv.IdServicio == _id; })!;
                        Entidad.Models.PrecioServicio prcServ = new Entidad.Models.PrecioServicio();
                        serv.IdServicio = serv.IdServicio;
                        prcServ.IdServicioNavigation = serv;
                        prcServ.FechaPrecio = DateTime.Now;
                        prcServ.PrecioServicio1 = (double)nroPrecio.Value;
                        serv.PrecioServicios.Add(prcServ);

                        Negocio.Servicio.Update(serv);
                        MessageBox.Show("Precio del Servicio ID: " + prcServ.IdPrecioServicio + " actualizado con exito.");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al actualizar el precio del Servicio. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //throw ex;
                    }
                    break;
            }

            this.Close();
        }

        private void DatosServicio_Load(object sender, EventArgs e)
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
                    if (_lstServ.Count <= 0)
                    {
                        MessageBox.Show("No hay servicios registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        idLabel.Text = _id.ToString();
                        nroPrecio.Enabled = false;
                        Id_SelectionChangeCommitted(sender, e);
                    }
                    break;

                case 3:
                    this.Text = "Actualizar precio";
                    txtDescipcion.Enabled = false;
                    if (_lstServ.Count <= 0)
                    {
                        MessageBox.Show("No hay servicios registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            serv = _lstServ.Find(delegate (Entidad.Models.Servicio serv) { return serv.IdServicio == _id; })!;
            txtDescipcion.Text = serv.Descripcion;
            nroPrecio.Value = (decimal)serv.PrecioServicios.Last().PrecioServicio1;
            mskCmbFecha.Text = serv.PrecioServicios.Last().FechaPrecio.ToString("dd/MM/yyyy");
        }
    }
}
