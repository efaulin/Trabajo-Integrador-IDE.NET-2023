using Entidad.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Huespedes;

namespace WindowsForm
{
    public partial class Listado : Form
    {
        int opcion;
        public Listado(string op)
        {
            Hashtable ht = new Hashtable()
            {
                { "Habitacion", 0 },
                { "TipoHabitacion", 1 },
                { "Huesped", 2 },
                { "Reserva", 3 },
                { "Servicio", 4 }
            };
            opcion = (int)ht[op]!;
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            switch (opcion)
            {
                case 0:
                    dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_Hbt_TpHbt();
                    break;
                case 1:
                    dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_TpHbt_PrcTpHbt();
                    break;
                case 2:
                    List<Huesped> _lstHspd = Negocio.Huesped.GetAll();
                    dgvHabitaciones.DataSource = _lstHspd;
                    //Se remueve la columna de reserva debido a la falta de ABM
                    dgvHabitaciones.Columns.RemoveAt(5);
                    break;
                case 3:
                    List<Reserva> _lstRsv = Negocio.Reserva.GetAll();
                    dgvHabitaciones.DataSource = _lstRsv;
                    break;
                case 4:
                    List<Servicio> _lstSrv = Negocio.Servicio.GetAll();
                    dgvHabitaciones.DataSource = _lstSrv;
                    break;
            }

        }

        private void ListarHbt_Load(object sender, EventArgs e)
        {
            listar();
            btnEditPrecio.Visible = false;
            btnAltaBaja.Width = 0;
            if (opcion == 1)
            {
                btnEditPrecio.Visible = true;
            }
            else if (opcion == 0)
            {
                btnAltaBaja.Visible = true;
                btnAltaBaja.Width = 107;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlHabitaciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form form;
            switch (opcion)
            {
#warning Falta implementacion boton "Agregar" en todas las opciones
                case 0:
                    form = new DatosHabitacion(1);
                    form.ShowDialog();
                    listar();
                    break;
                case 1:
                    form = new DatosTipoHabitacion(1);
                    form.ShowDialog();
                    listar();
                    break;
                case 2:
                    form = new DatosHuesped(1);
                    form.ShowDialog();
                    listar();
                    break;
                case 3:
                    form = new DatosReserva(4);
                    form.ShowDialog();
                    break;
                case 4:

                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int tmp;
            Form form;
            switch (opcion)
            {
#warning Falta implementacion boton "Editar"
                case 0:
                    tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                    form = new DatosHabitacion(2, tmp);
                    form.ShowDialog();
                    listar();
                    break;
                case 1:
                    tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                    form = new DatosTipoHabitacion(2, tmp);
                    form.ShowDialog();
                    listar();
                    break;
                case 2:
                    tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                    form = new DatosHuesped(2, tmp);
                    form.ShowDialog();
                    listar();
                    break;
                case 3:
                    tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                    form = new DatosReserva(tmp);
                    form.ShowDialog();
                    break;
                case 4:
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int tmpId;
            switch (opcion)
            {
#warning Falta implementacion boton "Eliminar"
                case 0:
                    tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                    Habitacion hbt = Negocio.Habitacion.GetOne(tmpId)!;
                    if (Negocio.Habitacion.Delete(hbt))
                    {
                        MessageBox.Show("Habitacion ID:" + tmpId + " borrada con exito");
                        listar();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente");
                    }
                    break;
                case 1:
                    tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                    TipoHabitacion tpHbt = Negocio.TipoHabitacion.GetOne(tmpId)!;
                    if (Negocio.TipoHabitacion.Delete(tpHbt))
                    {
                        MessageBox.Show("TipoHabitacion ID:" + tmpId + " borrada con exito");
                        listar();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente");
                    }
                    break;
                case 2:
                    tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                    Huesped hspd = Negocio.Huesped.GetOne(tmpId)!;
                    if (Negocio.Huesped.Delete(hspd))
                    {
                        MessageBox.Show("Huesped ID:" + tmpId + " borrada con exito");
                        listar();
                    }
                    else
                    {
                        MessageBox.Show("Error, intente nuevamente");
                    }
                    break;
            }
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPrecio_Click(object sender, EventArgs e)
        {
            int tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
            Form form = new DatosTipoHabitacion(3, tmp);
            form.ShowDialog();
            listar();
        }

        private void btnAltaBaja_Click(object sender, EventArgs e)
        {
            int tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
            Habitacion hbt = Negocio.Habitacion.GetOne(tmpId)!;
            hbt.Estado = !hbt.Estado;
            Negocio.Habitacion.Update(hbt);
            listar();
        }
    }
}
