using Entidad.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections;
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
        public Listado(string op)
        {
            Hashtable ht = new Hashtable()
            {
                { "Habitacion", 0 },
                { "TipoHabitacion", 1 },
                { "Huesped", 2 },
                { "Reserva", 3 }
            };
            opcion = (int)ht[op]!;
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            switch (opcion)
            {
                case 0:
                    dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_Hbt_TpHbt();
                    break;
                case 1:
                    dgvHabitaciones.DataSource = Datos.Old.BBDD.InnerJoin_TpHbt_PrcTpHbt();
                    break;
                case 2:
                    List<Huesped> _lstHspd = Negocio.Huesped.GetAll();
                    dgvHabitaciones.DataSource = _lstHspd;
                    //Se remueve la columna de reserva debido a la falta de ABM
                    dgvHabitaciones.Columns.RemoveAt(5);
                    break;
                case 3:
                    List<Reserva> _lstRsv = Negocio.Reserva.GetAll();
                    dgvHabitaciones.DataSource = _lstRsv;
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

        private void tlHabitaciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 0:
                    var tmp = dgvHabitaciones.SelectedCells[0].Value;
                    MessageBox.Show("tmp: " + tmp);
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 0:
                    try
                    {
                        int tmpId = (int)dgvHabitaciones.SelectedCells[0].Value;
                        Habitacion hbt = Negocio.Habitacion.GetOne(tmpId)!;
                        if (Negocio.Habitacion.Delete(hbt))
                        {
                            MessageBox.Show("Habitacion ID:" + tmpId + " borrada con exito");
                            listar();
                        }
                        else
                        {
                            MessageBox.Show("Error, intente nuevamente");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}
