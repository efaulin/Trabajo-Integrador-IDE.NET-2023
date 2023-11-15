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
using WindowsForm.Empleados;
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
                { "Servicio", 4 },
                { "Empleado", 5 }
            };
            opcion = (int)ht[op]!;
            InitializeComponent();
        }

        public async void listar()
        {
            switch (opcion)
            {
                case 0:
                    Task<List<Habitacion>> getAll = Negocio.Habitacion.GetAll();
                    DataTable dtHbt = new DataTable();
                    DataColumn[] dcHbt = new DataColumn[]
                    {
                        new DataColumn("IdHabitacion", typeof(int)),
                        new DataColumn("Estado", typeof(string)),
                        new DataColumn("Nro. habitacion", typeof(int)),
                        new DataColumn("Piso de habitacion", typeof(int)),
                        new DataColumn("Descripcion", typeof(string)),
                        new DataColumn("Cant. de camas", typeof(int)),
                        new DataColumn("Precio", typeof(int))
                    };
                    dtHbt.Columns.AddRange(dcHbt);
                    List<Habitacion> _lstHbt = await getAll;
                    foreach (Habitacion hbt in _lstHbt)
                    {
                        string estado;
                        if (hbt.Estado)
                        { estado = "Alta"; }
                        else
                        { estado = "Baja"; }

                        dtHbt.Rows.Add(
                            hbt.IdHabitacion,
                            estado,
                            hbt.NumeroHabitacion,
                            hbt.PisoHabitacion,
                            hbt.IdTipoHabitacionNavigation.Descripcion,
                            hbt.IdTipoHabitacionNavigation.NumeroCamas,
                            hbt.IdTipoHabitacionNavigation.Precio.PrecioHabitacion
                            );
                    }
                    dgvHabitaciones.DataSource = dtHbt;
                    break;
                case 1:
                    //dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_TpHbt_PrcTpHbt();
                    Task<List<TipoHabitacion>> getAllTipo = Negocio.TipoHabitacion.GetAll();
                    DataTable dtTpHbt = new DataTable();
                    DataColumn[] dcTpHbt = new DataColumn[]
                    {
                        new DataColumn("IdTipoHabitacion", typeof(int)),
                        new DataColumn("Nro. Cama", typeof(int)),
                        new DataColumn("Descripcion", typeof(string)),
                        new DataColumn("Precio", typeof(double)),
                        new DataColumn("Fecha Modificacion", typeof(DateTime)),

                    };
                    dtTpHbt.Columns.AddRange(dcTpHbt);
                    List<TipoHabitacion> _lstTpHbt = await getAllTipo;
                    foreach (TipoHabitacion tpHbt in _lstTpHbt)
                    {
                        dtTpHbt.Rows.Add(
                            tpHbt.IdTipoHabitacion,
                            tpHbt.NumeroCamas,
                            tpHbt.Descripcion,
                            tpHbt.Precio.PrecioHabitacion,
                            tpHbt.Precio.FechaPrecio
                            );
                    }
                    dgvHabitaciones.DataSource = dtTpHbt;
                    break;
                case 2:
                    List<Huesped> _lstHspd = await Negocio.Huesped.GetAll();
                    dgvHabitaciones.DataSource = _lstHspd;
                    //Se remueve la columna de reserva debido a la falta de ABM
                    dgvHabitaciones.Columns.RemoveAt(5);
                    break;
                case 3:
                    Task<List<Reserva>> getlstRsv = Negocio.Reserva.GetAll();
                    DataTable dtRsv = new DataTable();
                    DataColumn[] dcRsv = new DataColumn[]
                    {
                        new DataColumn("idReserva", typeof(int)),
                        new DataColumn("Fecha de Inscripcion", typeof(DateTime)),
                        new DataColumn("Estado", typeof(string)),
                        new DataColumn("Fecha de Inicio Reserva", typeof(DateTime)),
                        new DataColumn("Fecha de Fin Reserva", typeof(DateTime)),
                        new DataColumn("Cantidad de Personas", typeof(int)),
                        new DataColumn("Huesped", typeof(string)),
                        new DataColumn("Nro de habitacion", typeof(int)),
                        new DataColumn("Piso de habitacion", typeof(int)),
                        new DataColumn("Tipo de habitacion", typeof(string)),
                        new DataColumn("Precio", typeof(string))
                    };
                    dtRsv.Columns.AddRange(dcRsv);
                    List<Reserva> _lstRsv = await getlstRsv;
                    foreach (Reserva rsv in _lstRsv)
                    {
                        PrecioTipoHabitacion tmp = Negocio.TipoHabitacion.DevPrecioFecha(rsv.FechaFinReserva, rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation)!;
                        double precio = tmp.PrecioHabitacion;
                        Task<List<Servicio>> getlstRsvSrv = Negocio.Servicio.GetAllOfReserva(rsv.IdReserva);
                        List<Servicio> lstRsvSrv = await getlstRsvSrv;
                        lstRsvSrv.ForEach(e => precio += Negocio.Servicio.DevPrecioFecha(rsv.FechaFinReserva, e)!.PrecioServicio1);

                        dtRsv.Rows.Add(
                            rsv.IdReserva,
                            rsv.FechaInscripcion,
                            rsv.EstadoReserva,
                            rsv.FechaInicioReserva,
                            rsv.FechaFinReserva,
                            rsv.CantidadPersonas,
                            rsv.IdHuespedNavigation.nombreCompleto(),
                            rsv.IdHabitacionNavigation.NumeroHabitacion,
                            rsv.IdHabitacionNavigation.PisoHabitacion,
                            rsv.IdHabitacionNavigation.IdTipoHabitacionNavigation.Descripcion,
                            "$" + precio.ToString("0.00")
                            );
                    }
                    dgvHabitaciones.DataSource = dtRsv;
                    break;
                case 4:
#warning No se muestra el precio del servicio en la tabla (Ver si hay que hacer como con hbt y tpHbt con los innerJoins)
                    Task<List<Servicio>> getlstSrv = Negocio.Servicio.GetAll();
                    DataTable dtSrv = new DataTable();
                    DataColumn[] dcSrv = new DataColumn[]
                    {
                        new DataColumn("idServicio", typeof(int)),
                        new DataColumn("Descripcion", typeof(string)),
                        new DataColumn("Precio", typeof(double)),
                        new DataColumn("Fecha de precio", typeof(DateTime))
                    };
                    dtSrv.Columns.AddRange(dcSrv);
                    List<Servicio> _lstSrv = await getlstSrv;
                    foreach (Servicio srv in _lstSrv)
                    {
                        dtSrv.Rows.Add(srv.IdServicio, srv.Descripcion, srv.Precio.PrecioServicio1, srv.Precio.FechaPrecio);
                    }
                    dgvHabitaciones.DataSource = dtSrv;
                    break;
                case 5:
                    dgvHabitaciones.DataSource = await Negocio.Empleado.GetAll();
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
                case 0:
                    form = new DatosHabitacion(1);
                    form.ShowDialog();
                    break;
                case 1:
                    form = new DatosTipoHabitacion(1);
                    form.ShowDialog();
                    break;
                case 2:
                    form = new DatosHuesped(1);
                    form.ShowDialog();
                    break;
                case 3:
                    form = new DatosReserva();
                    form.ShowDialog();
                    break;
                case 4:
                    form = new DatosServicio(1);
                    form.ShowDialog();
                    break;
                case 5:
                    form = new DatosEmpleado(1);
                    form.ShowDialog();
                    break;
            }
            listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.Rows.Count > 0)
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
                        break;
                    case 1:
                        tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                        form = new DatosTipoHabitacion(2, tmp);
                        form.ShowDialog();
                        break;
                    case 2:
                        tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                        form = new DatosHuesped(2, tmp);
                        form.ShowDialog();
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
                        break;
                    case 5:
                        tmp = (int)dgvHabitaciones.SelectedCells[0].Value;
                        form = new DatosEmpleado(2, tmp);
                        form.ShowDialog();
                        break;
                }
                listar();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.Rows.Count > 0)
            {
                int tmpId;
                if (MessageBox.Show("¿Seguro que desea borrar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    switch (opcion)
                    {
#warning Falta implementacion boton "Eliminar"
                        case 0:
                            tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                            Habitacion hbt = (await Negocio.Habitacion.GetOne(tmpId))!;
                            if (await Negocio.Habitacion.Delete(hbt))
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
                            TipoHabitacion tpHbt = await Negocio.TipoHabitacion.GetOne(tmpId)!;
                            if (await Negocio.TipoHabitacion.Delete(tpHbt))
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
                            Huesped hspd = (await Negocio.Huesped.GetOne(tmpId))!;
                            if (await Negocio.Huesped.Delete(hspd))
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
                            Reserva rsv = (await Negocio.Reserva.GetOne(tmpId))!;
                            if (await Negocio.Reserva.Delete(rsv))
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
                            Task<Servicio> getserv = Negocio.Servicio.GetOne(tmpId)!;
                            Servicio serv = await getserv;
                            if (await Negocio.Servicio.Delete(serv))
                            {
                                MessageBox.Show("Servicio ID:" + tmpId + " borrada con exito");
                                listar();
                            }
                            else
                            {
                                MessageBox.Show("Error, intente nuevamente");
                            }
                            break;
                        case 5:
                            tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                            Empleado emp = (await Negocio.Empleado.GetOne(tmpId))!;
                            if (await Negocio.Empleado.Delete(emp))
                            {
                                MessageBox.Show("Empleado ID:" + tmpId + " borrado con exito");
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
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        /*private void btnEditPrecio_Click(object sender, EventArgs e)
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

        }*/

        private async void btnAltaBaja_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.Rows.Count > 0)
            {
                int tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                Habitacion hbt = (await Negocio.Habitacion.GetOne(tmpId))!;
                hbt.Estado = !hbt.Estado;
                if (!(await Negocio.Habitacion.Update(hbt)))
                {
                    //Si falla
                    MessageBox.Show("No se pudo actualizar el estado de la habitacion\nVuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listar();
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
