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

        public async void listar()
        {
            switch (opcion)
            {
                case 0:
                    dgvHabitaciones.DataSource = await Negocio.Habitacion.GetAll();
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
                    DataTable dtRsv = new DataTable();
                    DataColumn[] dcRsv = new DataColumn[]
                    {
                        new DataColumn("idReserva", typeof(int)),
                        new DataColumn("Fecha de Inscripcion", typeof(DateTime)),
                        new DataColumn("Fecha de Inicio Reserva", typeof(DateTime)),
                        new DataColumn("Fecha de Fin Reserva", typeof(DateTime)),
                        new DataColumn("Estado", typeof(string)),
                        new DataColumn("Cantidad de Personas", typeof(int)),
                        new DataColumn("Huesped", typeof(string)),
                        new DataColumn("Precio", typeof(double)),
                        new DataColumn("Nro de habitacion", typeof(int)),
                        new DataColumn("Piso de habitacion", typeof(int)),
                        new DataColumn("Tipo de habitacion", typeof(string))
                    };
                    dtRsv.Columns.AddRange(dcRsv);
                    foreach (Reserva rsv in _lstRsv)
                    {
                        double precio = rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation.Precio.PrecioHabitacion;
                        List<Servicio> lstRsvSrv = Negocio.Servicio.GetAllOfReserva(rsv.IdReserva);
                        lstRsvSrv.ForEach(e => precio += e.Precio.PrecioServicio1);
                        dtRsv.Rows.Add(rsv.IdReserva, rsv.FechaInscripcion, rsv.FechaInicioReserva, rsv.FechaFinReserva, rsv.EstadoReserva, rsv.CantidadPersonas, rsv.IdHuespedNavigation.nombreCompleto(), precio, rsv.IdHabitacionNavigation.NumeroHabitacion, rsv.IdHabitacionNavigation.PisoHabitacion, rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation.Descripcion);
                    }
                    dgvHabitaciones.DataSource = dtRsv;
                    break;
                case 4:
#warning No se muestra el precio del servicio en la tabla (Ver si hay que hacer como con hbt y tpHbt con los innerJoins)
                    List<Servicio> _lstSrv = Negocio.Servicio.GetAll();
                    DataTable dtSrv = new DataTable();
                    DataColumn[] dcSrv = new DataColumn[]
                    {
                        new DataColumn("idServicio", typeof(int)),
                        new DataColumn("Descripcion", typeof(string)),
                        new DataColumn("Precio", typeof(double)),
                        new DataColumn("Fecha de precio", typeof(DateTime))
                    };
                    dtSrv.Columns.AddRange(dcSrv);
                    foreach (Servicio srv in _lstSrv)
                    {
                        dtSrv.Rows.Add(srv.IdServicio, srv.Descripcion, srv.Precio.PrecioServicio1, srv.Precio.FechaPrecio);
                    }
                    dgvHabitaciones.DataSource = dtSrv;
                    break;
            }

        }

        private void ListarHbt_Load(object sender, EventArgs e)
        {
            listar();
            btnAltaBaja.Width = 0;
            if (opcion == 0)
            {
                btnAltaBaja.Visible = true;
                btnAltaBaja.Width = 107;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listar();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    form = new DatosServicio(1);
                    form.ShowDialog();
                    listar();
                    break;
            }
            listar();
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
                    tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                    form = new DatosServicio(2, tmp);
                    form.ShowDialog();
                    listar();
                    break;
            }
            listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int tmpId;
            if (MessageBox.Show("¿Seguro que desea borrar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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
                    case 3:
                        tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                        Reserva rsv = Negocio.Reserva.GetOne(tmpId)!;
                        if (Negocio.Reserva.Delete(rsv))
                        {
                            MessageBox.Show("Reserva ID:" + tmpId + " borrado con exito");
                            listar();
                        }
                        else
                        {
                            MessageBox.Show("Error, intente nuevamente");
                        }
                        break;
                    case 4:
                        tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                        Servicio serv = Negocio.Servicio.GetOne(tmpId)!;
                        if (Negocio.Servicio.Delete(serv))
                        {
                            MessageBox.Show("Servicio ID:" + tmpId + " borrada con exito");
                            listar();
                        }
                        else
                        {
                            MessageBox.Show("Error, intente nuevamente");
                        }
                        break;
                }
            }

            listar();
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPrecio_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                int tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                Form form = new DatosTipoHabitacion(3, tmp);
                form.ShowDialog();
                listar();
            }
            else
            {
                int tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                Form form = new DatosServicio(3, tmp);
                form.ShowDialog();
                listar();
            }

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
