using Entidad.Models;
using WindowsForm.Huespedes;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        List<Habitacion> lstHbt = Negocio.Habitacion.GetAll();
        List<TipoHabitacion> lstTpHbt = Negocio.TipoHabitacion.GetAll();
        private Listado? activeForm = null;
        public Form1()
        {
            InitializeComponent();
            personalizarDesign();
        }

        private void personalizarDesign()
        {
            panelHbtSubmenu.Visible = false;
            panelTpHbtSubmenu.Visible = false;
            panelHspdSubmenu.Visible = false;
            panelRsvSubmenu.Visible = false;
            panelSrvSubmenu.Visible = false;
        }

        private void ocultarSubmenu()
        {
            if (panelHbtSubmenu.Visible == true)
            {
                panelHbtSubmenu.Visible = false;
            }
            if (panelTpHbtSubmenu.Visible == true)
            {
                panelTpHbtSubmenu.Visible = false;
            }
            if (panelHspdSubmenu.Visible == true)
            {
                panelHspdSubmenu.Visible = false;
            }
            if (panelRsvSubmenu.Visible == true)
            {
                panelRsvSubmenu.Visible = false;
            }
            if (panelSrvSubmenu.Visible == true)
            {
                panelSrvSubmenu.Visible = false;
            }
            actualizarListado();
        }

        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void actualizarListado()
        {
            if (activeForm != null)
            {
                activeForm.listar();
            }
        }

        private void openChildForm(Listado childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Habitacion
        private void btnHabitacion_Click_1(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHbtSubmenu);
        }
        private void mostrarHbt_Click(object sender, EventArgs e)
        {
            //..          
            openChildForm(new Listado("Habitacion"));
            ocultarSubmenu();
        }
        private void addHbt_Click(object sender, EventArgs e)
        {
            Form form = new DatosHabitacion(1);
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void editHbt_Click(object sender, EventArgs e)
        {
            Form form = new DatosHabitacion(2);
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void deleteHbt_Click(object sender, EventArgs e)
        {
            Form form = new EliminarHabitacion();
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void altaHbt_Click(object sender, EventArgs e)
        {
            Form form = new AltaBajaHabitacion();
            form.ShowDialog();
            ocultarSubmenu();
        }
        #endregion

        #region Tipo Habitacion
        private void mostrarTpHbt_Click(object sender, EventArgs e)
        {
            //..
            openChildForm(new Listado("TipoHabitacion"));
            ocultarSubmenu();
        }
        private void addTpHbt_Click(object sender, EventArgs e)
        {
            Form form = new DatosTipoHabitacion(1);
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void editarTpHbt_Click(object sender, EventArgs e)
        {
            Form form = new DatosTipoHabitacion(2);
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void deleteTpHbt_Click(object sender, EventArgs e)
        {
            Form form = new EliminarTipoHabitacion();
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void editarPrecioTpHbt_Click(object sender, EventArgs e)
        {
            Form form = new DatosTipoHabitacion(3);
            form.ShowDialog();
            ocultarSubmenu();
        }
        #endregion

        #region Huesped
        private void btnHuesped_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHspdSubmenu);
        }
        private void btnTpHbt_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelTpHbtSubmenu);
        }
        private void mostrarHspd_Click(object sender, EventArgs e)
        {
            //..
            openChildForm(new Listado("Huesped"));
            ocultarSubmenu();
        }
        private void addHspd_Click(object sender, EventArgs e)
        {
            //..
            Form form = new DatosHuesped(1);
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void editarHspd_Click(object sender, EventArgs e)
        {
            //..
            Form form = new DatosHuesped(2);
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void deleteHspd_Click(object sender, EventArgs e)
        {
            Form form = new EliminarHuesped();
            form.ShowDialog();
            ocultarSubmenu();
        }
        #endregion

        #region Reserva
        private void btnReserva_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelRsvSubmenu);
        }
        private void mostrarRsv_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Reserva"));
            ocultarSubmenu();
        }
        private void addRsv_Click(object sender, EventArgs e)
        {
            Form form = new DatosReserva();
            form.ShowDialog();
            ocultarSubmenu();
        }
        private void editarRsv_Click(object sender, EventArgs e)
        {
            if (Negocio.Reserva.GetAll().Count != 0)
            {
                Form form = new DatosReserva(Negocio.Reserva.GetAll().First());
                form.ShowDialog();
                ocultarSubmenu();
            }
            else
            {
                MessageBox.Show("�No hay reservas registradas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deleteRsv_Click(object sender, EventArgs e)
        {

        }
#warning Falta delete (CRUD Reserva), mejorar filtrado de husped y habitacion
        #endregion

        #region Servicio
        private void btnServicio_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSrvSubmenu);
        }
        private void mostrarSrv_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Servicio"));
            ocultarSubmenu();
        }
#warning Falta create, update y delete (CRUD Servicio)
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}