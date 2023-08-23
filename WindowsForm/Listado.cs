using Entidad.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Listado : Form
    {
        int opcion;
        public Listado(int op)
        {
            opcion = op;
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

        public void listar()
        {
            switch (opcion)
            {
                case 0:
                    List<Habitacion> _lstHbt = Negocio.Habitacion.GetAll();
                    dgvHabitaciones.DataSource = _lstHbt;
                    dgvHabitaciones.Columns.RemoveAt(6);
                    dgvHabitaciones.Columns.RemoveAt(5);
                    break;
                case 1:
                    List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
                    dgvHabitaciones.DataSource = _lstTpHbt;
                    dgvHabitaciones.Columns.RemoveAt(3);
                    break;
                case 2:
                    List<Huesped> _lstHspd = Negocio.Huesped.GetAll();
                    dgvHabitaciones.DataSource = _lstHspd;
                    dgvHabitaciones.Columns.RemoveAt(5);
                    break;
            }

        }

        private void ListarHbt_Load(object sender, EventArgs e)
        {
            listar();
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
            Form form = new Listado(1);
            form.ShowDialog();
            ocultarSubmenu();
        }

        private void addTpHbt_Click(object sender, EventArgs e)
        {
            //..
            ocultarSubmenu();
        }

        private void editarTpHbt_Click(object sender, EventArgs e)
        {
            //..
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
            Form form = new Listado(2);
            form.ShowDialog();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
