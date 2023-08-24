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
            listar();
        }

        public void listar()
        {
            switch (opcion)
            {
                case 0:
                    //List<Habitacion> _lstHbt = Negocio.Habitacion.GetAll();
                    dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_Hbt_TpHbt();
                    //dgvHabitaciones.Columns.RemoveAt(6);
                    //dgvHabitaciones.Columns.RemoveAt(5);
                    break;
                case 1:
                    //List<TipoHabitacion> _lstTpHbt = Negocio.TipoHabitacion.GetAll();
                    dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_TpHbt_PrcTpHbt();
                    //dgvHabitaciones.Columns.RemoveAt(3);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
