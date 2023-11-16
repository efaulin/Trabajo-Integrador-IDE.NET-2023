using Entidad.Models;
using WindowsForm.Huespedes;

namespace WindowsForm
{
    public partial class Menu : Form
    {
        Empleado emp;
        //Task<List<Habitacion>> lstHbt = Negocio.Habitacion.GetAll();
        //Task<List<TipoHabitacion>> lstTpHbt = Negocio.TipoHabitacion.GetAll();
        private Form? activeForm = null;
        public Menu(Empleado tmp)
        {
            emp = tmp;
            InitializeComponent();

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

        private void btnHabitacion_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Listado("Habitacion"));
            Titulo.Visible = true;
            Titulo.Text = "Habitaciones";
        }
        private void btnTpHbt_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("TipoHabitacion"));
            Titulo.Visible = true;
            Titulo.Text = "Tipo de Habitaciones";
        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Huesped"));
            Titulo.Visible = true;
            Titulo.Text = "Huespedes";
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Reserva"));
            Titulo.Visible = true;
            Titulo.Text = "Reservas";
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Servicio"));
            Titulo.Visible = true;
            Titulo.Text = "Servicios";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNombre.Text = emp.NombreUsuario.ToString().ToUpper();
            if (emp.TipoUsuario != "Gerente")
            {
                btnEmpleados.Visible = false;
            }
            Titulo.Visible = false;
        }
 
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new Listado("Empleado"));
            Titulo.Visible = true;
            Titulo.Text = "Empleados";
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            openChildForm(new Informe());
            Titulo.Visible = true;
            Titulo.Text = "Generar Informe";
        }

 
    }
}