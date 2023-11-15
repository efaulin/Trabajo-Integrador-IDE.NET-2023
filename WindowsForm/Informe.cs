using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Informe : Form
    {
        DataTable dtInforme = new DataTable();
        DataColumn[] dcInforme = new DataColumn[]
        {
            new DataColumn("Fecha", typeof(DateTime)),
            new DataColumn("Recaudado", typeof(string))
        };

        public Informe()
        {
            dtInforme.Columns.AddRange(dcInforme);
            InitializeComponent();
        }

        private async void btnEmitir_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.CompareTo(dtpHasta.Value) < 0)
            {
                dtInforme.Rows.Clear();

                Negocio.Informe inf = new Negocio.Informe(dtpDesde.Value, dtpHasta.Value);

                var tmp = await inf.EmitirInforme();
                tmp.ForEach(e =>
                {
                    dtInforme.Rows.Add(
                        e.Fecha,
                        "$" + e.Recaudacion.ToString("0.00")
                        );
                });

                dgvInforme.DataSource = dtInforme;
            }
            else
            {
                MessageBox.Show("Ingrese un intervalo de fechas valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
