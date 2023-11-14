using Entidad.Models;
using WindowsForm.Huespedes;

namespace WindowsForm
{
    public partial class Menu : Form
    {
        Empleado emp;
        //Task<List<Habitacion>> lstHbt = Negocio.Habitacion.GetAll();
        //Task<List<TipoHabitacion>> lstTpHbt = Negocio.TipoHabitacion.GetAll();
        private Listado? activeForm = null;
        public Menu(Empleado tmp)
        {
            emp = tmp;
            InitializeComponent();
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

        private void btnServicio_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Servicio"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNombre.Text = emp.NombreUsuario.ToString().ToUpper();
            if (emp.TipoUsuario != "Gerente")
            {
                btnEmpleados.Visible = false;
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Empleado"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}