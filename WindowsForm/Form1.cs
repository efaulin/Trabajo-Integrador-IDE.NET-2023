using Entidad.Models;
using WindowsForm.Huespedes;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        List<Habitacion> lstHbt = Negocio.Habitacion.GetAll();
        List<TipoHabitacion> lstTpHbt = Negocio.TipoHabitacion.GetAll();
        private Form activeForm = null;
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

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHbtSubmenu);
        }

        private void mostrarHbt_Click(object sender, EventArgs e)
        {
            //..          
            openChildForm(new Listado(0));
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

        private void bajaHbt_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void altaHbt_Click(object sender, EventArgs e)
        {
            Form form = new AltaBajaHabitacion();
            form.ShowDialog();
            ocultarSubmenu();
        }

        private void deleteHbt_Click(object sender, EventArgs e)
        {
            Form form = new EliminarHabitacion();
            form.ShowDialog();
            ocultarSubmenu();
        }

        private void mostrarTpHbt_Click(object sender, EventArgs e)
        {
            //..
            openChildForm(new Listado(1));
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

        private void editarPrecioTpHbt_Click(object sender, EventArgs e)
        {
            Form form = new DatosTipoHabitacion(3);
            form.ShowDialog();
            ocultarSubmenu();
        }

        private void deleteTpHbt_Click(object sender, EventArgs e)
        {
            Form form = new EliminarTipoHabitacion();
            form.ShowDialog();
            ocultarSubmenu();
        }

        private void mostrarHspd_Click(object sender, EventArgs e)
        {
            //..
            openChildForm(new Listado(2));
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

        private void btnHabitacion_Click_1(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHbtSubmenu);
        }

        private void btnTpHbt_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelTpHbtSubmenu);
        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHspdSubmenu);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void actualizarListado()
        {
            //..
        }

        private void openChildForm(Form childForm)
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
    }
}