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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region tlSc_Habitaciones
        private void tlSc_hbtVer_Click(object sender, EventArgs e)
        {

        }

        private void tlSc_hbtAgregar_Click(object sender, EventArgs e)
        {
            Form form = new DatosHabitacion(1);
            form.ShowDialog();
        }

        private void tlSc_hbtEditar_Click(object sender, EventArgs e)
        {
            //Elegir habitacion...
            //Habitacion hbt = Negocio.Habitacion.GetOne(1004);
            Form form = new DatosHabitacion(2);
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

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tlScTpHbtAgregar_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelHabitacionSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHbtSubmenu);
        }

        private void mostrarHbt_Click(object sender, EventArgs e)
        {
            //..
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
            //..
            ocultarSubmenu();
        }

        private void deleteHbt_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void mostrarTpHbt_Click(object sender, EventArgs e)
        {
            //..
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
            //..
            ocultarSubmenu();
        }

        private void deleteTpHbt_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void mostrarHspd_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void addHspd_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void editarHspd_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void deleteHspd_Click(object sender, EventArgs e)
        {
            //..
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

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}