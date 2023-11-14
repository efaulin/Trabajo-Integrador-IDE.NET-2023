using Entidad.Models;
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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.GrayText;
            btnIngresar.Enabled = false;
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;

            Empleado? emp = await Negocio.Empleado.GetByUsuario_Contraseña(txtUsuario.Text, txtContraseña.Text);

            if (emp == null)
            {
                MessageBox.Show("Usuario o contraseña incorectos\nIntente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Hide();
                Form form = new Menu(emp);
                form.ShowDialog();
                /*txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
                this.Show();*/
                this.Close();
            }
            btnIngresar.BackColor = Color.DarkCyan;
            btnIngresar.Enabled = true;
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
        }

        private void iniciarSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
