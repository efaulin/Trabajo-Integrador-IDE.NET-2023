using Entidad.Models;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        List<Habitacion> lstHbt = Negocio.Habitacion.GetAll();
        List<TipoHabitacion> lstTpHbt = Negocio.TipoHabitacion.GetAll();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region tlSc_Habitaciones
        private void tlSc_hbtVer_Click(object sender, EventArgs e)
        {

        }

        private void tlSc_hbtAgregar_Click(object sender, EventArgs e)
        {
            Form form = new DatosHabitacion();
            form.ShowDialog();
        }

        private void tlSc_hbtEditar_Click(object sender, EventArgs e)
        {
            //Elegir habitacion...
            Habitacion hbt = Negocio.Habitacion.GetOne(1004);
            Form form = new DatosHabitacion(hbt);
            form.ShowDialog();
        }

        private void tlSc_hbtBaja_Click(object sender, EventArgs e)
        {

        }

        private void tlSc_hbtAlta_Click(object sender, EventArgs e)
        {

        }

        private void tlSc_hbtEliminar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}