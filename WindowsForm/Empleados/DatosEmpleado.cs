using Entidad.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.Empleados
{
    public partial class DatosEmpleado : Form
    {
        int? op;
        int? _id;
        Empleado? emp;
        Task<List<Empleado>> getAll = Negocio.Empleado.GetAll();
        List<Empleado> _lstEmp;
        Hashtable _tmpEmp = new Hashtable();
        public DatosEmpleado(int opcion)
        {
            op = opcion;
            InitializeComponent();
        }

        public DatosEmpleado(int opcion, int id)
        {
            op = opcion;
            _id = id;
            InitializeComponent();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            bool stop = false;
            if (validate())
            {
                switch (op)
                {
                    case 1:
                        emp = new Empleado();
                        emp.NombreUsuario = txtNombre.Text;
                        emp.Password = txtPassword.Text;
                        emp.TipoUsuario = cmbTipoUsuario.Text;

                        emp = await Negocio.Empleado.Create(emp);
                        if (emp != null)
                        {
                            MessageBox.Show("Empleado ID: " + emp.IdEmpleado + " cargado con exito.");
                        }
                        else
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al crear el empleado. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;

                    case 2:
                        emp = _lstEmp.Find(delegate (Empleado emp) { return emp.IdEmpleado == _id; })!;
                        emp.NombreUsuario = txtNombre.Text;
                        emp.TipoUsuario = cmbTipoUsuario.Text;
                        emp.Password = txtPassword.Text;

                        if (await Negocio.Empleado.Update(emp))
                        {
                            MessageBox.Show("Empleado ID: " + emp.IdEmpleado + " editado con exito.");
                        }
                        else
                        {
                            stop = true;
                            MessageBox.Show("Hubo un problema al editar el empleado. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                }
            }
            else
            {
                stop = true;
                MessageBox.Show("Hay errores en los datos del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!stop)
            {
                this.Close();
            }
        }

        private async void DatosHuesped_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 1:
                    this.Text = "Agregar Empleado";
                    idLabel.Text = "Nuevo";
                    cmbTipoUsuario.SelectedIndex = 0;
                    break;

                case 2:
                    this.Text = "Editar Empleado";
                    _lstEmp = await getAll;
                    if (_lstEmp.Count <= 0)
                    {
                        MessageBox.Show("No hay empleados registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        idLabel.Text = _id.ToString();
                        Id_SelectionChangeCommitted(sender, e);
                    }
                    break;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            emp = _lstEmp.Find(delegate (Empleado emp) { return emp.IdEmpleado == _id; })!;
            txtNombre.Text = emp.NombreUsuario;
            cmbTipoUsuario.SelectedItem = emp.TipoUsuario;
            txtPassword.Text = emp.Password;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validate()
        {
            if (txtNombre.Text.Length == 0 || txtNombre.Text[0].ToString() == " ") { return false; }
            if (txtPassword.Text.Length == 0 || txtPassword.Text[0].ToString() == " ") { return false; }
            return true;
        }
    }
}
