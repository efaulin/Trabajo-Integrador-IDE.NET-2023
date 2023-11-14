using Accessibility;
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
using System.Windows.Forms.VisualStyles;

namespace WindowsForm
{
    public partial class DatosReserva : Form
    {
        int? idRsv;
        Reserva? _rsv;
        Habitacion? _hbt;
        Huesped? _hpd;
        Task<List<Habitacion>> getlstHbt = Negocio.Habitacion.GetAll();
        Task<List<Servicio>> getLstSrv = Negocio.Servicio.GetAll();
        List<Servicio> originlstSrv;
        List<Habitacion> _lstHbt;
        List<Servicio> _lstSrv;
        List<Huesped> _lstHpd;
        List<Reserva> _lstRsv;
        List<ReservaServicio> lstSrvTemporal = new List<ReservaServicio>();
        Hashtable _hashHbt = new Hashtable();
        Hashtable _hashHpd = new Hashtable();
        Hashtable _hashRsv = new Hashtable();

        public DatosReserva()
        {
            InitializeComponent();
        }

        public DatosReserva(Habitacion hbt)
        {
            _hbt = hbt;
            InitializeComponent();
        }

        public DatosReserva(Huesped hpd)
        {
            _hpd = hpd;
            InitializeComponent();
        }

        public DatosReserva(Reserva rsv)
        {
            _rsv = rsv;
            InitializeComponent();
        }

        public DatosReserva(int id)
        {
            idRsv = id;
            InitializeComponent();
        }

        private async void DatosHabitacion_Load(object sender, EventArgs e)
        {
            if (idRsv != null)
            {
                _rsv = await Negocio.Reserva.GetOne(idRsv ?? 0);
                if (_rsv == null)
                {
                    MessageBox.Show("¡La reserva no existe!");
                    this.Close();
                }
            }

            _lstHbt = await getlstHbt;
            _lstHpd = await Negocio.Huesped.GetAll();
            if (_lstHbt.Count <= 0)
            {
                MessageBox.Show("¡No hay habitaciones registradas!\nAgrege una habitacion, antes de cargar una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (_lstHpd.Count <= 0)
            {
                MessageBox.Show("¡No hay huespedes registrados!\nAgrege un huesped, antes de cargar una reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            _lstRsv = await Negocio.Reserva.GetAll();
            foreach (Reserva _tmpRsv in _lstRsv)
            {
                string tmp = _tmpRsv.FechaInscripcion.ToString("dd/MM/yyyy") + " - Habitacion " + _tmpRsv.IdHabitacionNavigation.NumeroHabitacion + " piso " + _tmpRsv.IdHabitacionNavigation.PisoHabitacion;
                _hashRsv[tmp] = _tmpRsv;
                cmbIdReserva.Items.Add(tmp);
            }
            originlstSrv = await getLstSrv;
            if (_rsv != null)
            {
                this.Text = "Editar reserva";
                cmbIdReserva.SelectedItem = _rsv.FechaInscripcion.ToString("dd/MM/yyyy") + " - Habitacion " + _rsv.IdHabitacionNavigation.NumeroHabitacion + " piso " + _rsv.IdHabitacionNavigation.PisoHabitacion;
                cmbIdReserva_SelectionChangeCommitted(sender, e);
            }
            else
            {
                this.Text = "Agregar nueva reserva";
                cmbIdReserva.Items.Add("Nuevo");
                cmbIdReserva.SelectedItem = "Nuevo";
                cmbIdReserva.Enabled = false;
                cmbEstado.SelectedIndex = 0;
                dtFechaInicio.Value = DateTime.Now;
                dtFechaInicio.MinDate = DateTime.Now;
                dtFechaFin.Value = dtFechaInicio.Value.AddDays(1);
                dtFechaFin.MinDate = DateTime.Now.AddDays(1);
                _lstSrv = originlstSrv;
                foreach (Servicio _tmpSrv in _lstSrv)
                {
                    chkBoxListServicio.Items.Add(_tmpSrv.Descripcion);
                }
            }

            if (_hbt != null)
            {
                SetDataGridHabitacion(_hbt);
            }

            if (_hpd != null)
            {
                SetDataGridHuesped(_hpd);
            }
        }

        private async void cmbIdReserva_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task<List<Servicio>> getSrvOfRsv = Negocio.Servicio.GetAllOfReserva(_rsv.IdReserva);
            _rsv = (Reserva)_hashRsv[cmbIdReserva.SelectedItem]!;
            dtFechaInicio.MinDate = _rsv.FechaInicioReserva;
            dtFechaFin.MinDate = _rsv.FechaFinReserva;
            dtFechaInicio.Value = _rsv.FechaInicioReserva;
            dtFechaFin.Value = _rsv.FechaFinReserva;
            txtCantidadPersonas.Text = _rsv.CantidadPersonas.ToString();
            txtNro.Text = _rsv.IdHabitacionNavigation.NumeroHabitacion.ToString();
            txtPiso.Text = _rsv.IdHabitacionNavigation.PisoHabitacion.ToString();
            txtNroDocumento.Text = _rsv.IdHuespedNavigation.NumeroDocumento;
            cmbEstado.SelectedItem = _rsv.EstadoReserva;
            SetDataGridsEditando(_rsv.IdHabitacionNavigation, _rsv.IdHuespedNavigation);
            chkBoxListServicio.Items.Clear();
            _lstSrv = originlstSrv;
            List<Servicio> lstSrvGuardados = await getSrvOfRsv;
            foreach (Servicio _tmpSrv in _lstSrv)
            {
                bool chck = false;
                if (lstSrvGuardados.FirstOrDefault(e => e.IdServicio == _tmpSrv.IdServicio) != null)
                {
                    chck = true;
                }
                chkBoxListServicio.Items.Add(_tmpSrv.Descripcion, chck);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                bool stop = false;
                //¿Reserva existente o nueva?
                if (_rsv != null)
                {
                    //Se modifica una reserva existente
                    await asignarValores();
                    if (Negocio.Reserva.Validate(_rsv))
                    {
                        if (!(await Negocio.Reserva.Update(_rsv)))
                        {
                            stop = true;
                            MessageBox.Show("Hubo un error al guardar la reserva\nVuelva a intentar mas tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            GroupServicios();
                            bool serviciosControl = await Negocio.ReservaServicio.SaveServicios(_rsv.IdReserva, lstSrvTemporal);
                            if (!serviciosControl)
                            {
                                stop = true;
                                MessageBox.Show("Hubo un error al guardar los servicios\nVuelva a intentar mas tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        stop = true;
                        MessageBox.Show("Hay un error en los datos de la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Se crea una nueva reserva
                    _rsv = new Reserva();
                    _rsv.FechaInscripcion = DateTime.Now.Date;
                    _rsv.EstadoReserva = (string)cmbEstado.SelectedItem;
                    await asignarValores();
                    _rsv = await Negocio.Reserva.Create(_rsv);
                    if (_rsv == null)
                    {
                        stop = true;
                        MessageBox.Show("Hubo un error al guardar la reserva\nVuelva a intentar mas tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        GroupServicios();
                        bool serviciosControl = await Negocio.ReservaServicio.SaveServicios(_rsv.IdReserva, lstSrvTemporal);
                        if (!serviciosControl)
                        {
                            stop = true;
                            MessageBox.Show("Hubo un error al guardar los servicios\nVuelva a intentar mas tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (!stop)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hay un error en los datos de la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task asignarValores()
        {
            int idHbt = (int)dtGrHabitacion.SelectedRows[0].Cells[0].Value;
            int idHpd = (int)dtGrHuesped.SelectedRows[0].Cells[0].Value;
            Task<Habitacion> getHbt = Negocio.Habitacion.GetOne(idHbt)!;
            //Task<Huesped> getHpd = Negocio.Huesped.GetOne(idHpd)!;
            _rsv!.FechaInicioReserva = dtFechaInicio.Value.Date;
            _rsv.FechaFinReserva = dtFechaFin.Value.Date;
            _rsv.CantidadPersonas = int.Parse(txtCantidadPersonas.Text);
            _rsv.IdHabitacion = (int)dtGrHabitacion.SelectedRows[0].Cells[0].Value;
            _rsv.IdHuesped = (int)dtGrHuesped.SelectedRows[0].Cells[0].Value;
            _rsv.IdHabitacionNavigation = await getHbt;
            _rsv.IdHuespedNavigation = (await Negocio.Huesped.GetOne(idHpd))!;
            //_rsv.IdHuespedNavigation = await getHpd;
        }

        private void GroupServicios()
        {
            //Guardo las relaciones de la reserva con los servicios
            _lstSrv = originlstSrv;
            for (int i = 0; i < _lstSrv.Count; i++)
            {
                if (chkBoxListServicio.GetItemChecked(i))
                {
                    ReservaServicio tmp = new ReservaServicio();
                    tmp.IdReserva = _rsv.IdReserva;
                    tmp.IdServicio = _lstSrv[i].IdServicio;
                    lstSrvTemporal.Add(tmp);
                }
            }
        }

        #region A borrar
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Esta funcion controla que solo se puedan ingresar numeros enteros en los textBoxs
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnBuscarHabitacion_Click(object sender, EventArgs e)
        {
            List<Habitacion> lstHbt;
            DataTable? dt = null;
            DateTime start = dtFechaInicio.Value;
            DateTime end = dtFechaFin.Value;

            if (txtCantidadPersonas.Text.Length > 0 && start.CompareTo(end) < 0)
            {
                lstHbt = Negocio.Habitacion.TakeAvailable(await Negocio.Habitacion.GetForAmountOfPeople(int.Parse(txtCantidadPersonas.Text)), start, end);

                if (txtPiso.Text.Length > 0)
                {
                    int piso = int.Parse(txtPiso.Text);
                    if (txtNro.Text.Length > 0)
                    {
                        lstHbt = lstHbt.FindAll(hbt => hbt.PisoHabitacion == piso && hbt.NumeroHabitacion == int.Parse(txtNro.Text));
                    }
                    else
                    {
                        lstHbt = lstHbt.FindAll(hbt => hbt.PisoHabitacion == piso);
                    }
                }
                else if (txtNro.Text.Length > 0)
                {
                    lstHbt = lstHbt.FindAll(hbt => hbt.NumeroHabitacion == int.Parse(txtNro.Text));
                }

                dt = new DataTable();
                DataColumn[] dcArray = new DataColumn[]
                {
                    new DataColumn("id", typeof(int)),
                    new DataColumn("Nro", typeof(int)),
                    new DataColumn("Piso", typeof(int)),
                    new DataColumn("Numero de camas", typeof(int)),
                    new DataColumn("Descripcion", typeof(string)),
                    new DataColumn("Precio", typeof(double))
                };
                dt.Columns.AddRange(dcArray);

                foreach (Habitacion tmp in lstHbt)
                {
                    dt.Rows.Add(tmp.IdHabitacion, tmp.NumeroHabitacion, tmp.PisoHabitacion, tmp.IdTipoHabitacionNavigation.NumeroCamas, tmp.IdTipoHabitacionNavigation.Descripcion, tmp.IdTipoHabitacionNavigation.Precio.PrecioHabitacion);
                }

                if (_rsv != null)
                {
                    Habitacion tmpHbt = _rsv!.IdHabitacionNavigation;
                    dt.Rows.Add(tmpHbt.IdHabitacion, tmpHbt.NumeroHabitacion, tmpHbt.PisoHabitacion, tmpHbt.IdTipoHabitacionNavigation.NumeroCamas, tmpHbt.IdTipoHabitacionNavigation.Descripcion, tmpHbt.IdTipoHabitacionNavigation.Precio.PrecioHabitacion);
                }
            }
            else
            {
                MessageBox.Show("Antes de buscar, ingrese cantidad de personas y un rango de fechas valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dtGrHabitacion.DataSource = dt;

            if (dtGrHabitacion.DataSource != null)
            {
                dtGrHabitacion.Columns["id"].Visible = false;
            }

            dtGrHabitacion.Select();
        }

        private async void btnBuscarHuesped_Click(object sender, EventArgs e)
        {
            List<Huesped>? lstHpd = null;

            if (txtNroDocumento.Text.Length > 0)
            {
                lstHpd = await Negocio.Huesped.GetByNroDocumento(txtNroDocumento.Text);
            }
            else
            {
                lstHpd = await Negocio.Huesped.GetAll();
            }

            dtGrHuesped.DataSource = lstHpd;

            if (dtGrHuesped.DataSource != null)
            {
                dtGrHuesped.Columns[0].Visible = false;
                dtGrHuesped.Columns[5].Visible = false;
            }

            dtGrHuesped.Select();
        }

        private void SetDataGridHabitacion(Habitacion hbt)
        {
            DataTable dtHbt = new DataTable();
            DataColumn[] dcArrayHbt = new DataColumn[]
            {
                new DataColumn("id", typeof(int)),
                new DataColumn("Nro", typeof(int)),
                new DataColumn("Piso", typeof(int)),
                new DataColumn("Numero de camas", typeof(int)),
                new DataColumn("Descripcion", typeof(string)),
                new DataColumn("Precio", typeof(double))
            };
            dtHbt.Columns.AddRange(dcArrayHbt);
            dtHbt.Rows.Add(hbt.IdHabitacion, hbt.NumeroHabitacion, hbt.PisoHabitacion, hbt.IdTipoHabitacionNavigation.NumeroCamas, hbt.IdTipoHabitacionNavigation.Descripcion, hbt.IdTipoHabitacionNavigation.Precio.PrecioHabitacion);

            dtGrHabitacion.DataSource = dtHbt;

            if (dtGrHabitacion.DataSource != null)
            {
                dtGrHabitacion.Columns["id"].Visible = false;
            }

            dtGrHabitacion.Select();
        }

        private void SetDataGridHuesped(Huesped hpd)
        {
            dtGrHuesped.DataSource = new List<Huesped> { hpd };

            if (dtGrHuesped.DataSource != null)
            {
                dtGrHuesped.Columns[0].Visible = false;
                dtGrHuesped.Columns[5].Visible = false;
            }

            dtGrHuesped.Select();
        }

        private void SetDataGridsEditando(Habitacion hbt, Huesped hpd)
        {
            SetDataGridHabitacion(hbt);
            SetDataGridHuesped(hpd);
        }

        private bool validate()
        {
            if (txtCantidadPersonas.Text.Length == 0) { return false; }
            if (dtFechaInicio.Value.CompareTo(dtFechaFin.Value) >= 0) { return false; }
            if (dtGrHabitacion.SelectedRows.Count == 0) { return false; }
            if (dtGrHuesped.SelectedRows.Count == 0) { return false; }
            return true;
        }
    }
}
