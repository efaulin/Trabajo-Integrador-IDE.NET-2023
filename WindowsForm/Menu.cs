using Entidad.Models;
using WindowsForm.Huespedes;

namespace WindowsForm
{
    public partial class Menu : Form
    {
        Empleado emp;
        List<Habitacion> lstHbt = Negocio.Habitacion.GetAll();
        List<TipoHabitacion> lstTpHbt = Negocio.TipoHabitacion.GetAll();
        private Listado? activeForm = null;
        public Menu(Empleado tmp)
        {
            emp = tmp;
            InitializeComponent();
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

        private void btnHabitacion_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Listado("Habitacion"));
        }
        private void btnTpHbt_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("TipoHabitacion"));
        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Huesped"));
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Reserva"));
        }

        private void editarRsv_Click(object sender, EventArgs e)
        {
            if (Negocio.Reserva.GetAll().Count != 0)
            {
                Form form = new DatosReserva(Negocio.Reserva.GetAll().First());
                form.ShowDialog();
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


        private void btnServicio_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Servicio"));
        }

#warning Falta create, update y delete (CRUD Servicio)

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNombre.Text = emp.NombreUsuario.ToString();
        }

        private void addSrv_Click(object sender, EventArgs e)
        {

        }
    }
}