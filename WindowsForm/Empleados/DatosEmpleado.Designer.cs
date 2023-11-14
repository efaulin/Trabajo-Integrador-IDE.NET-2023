namespace WindowsForm.Empleados
{
    partial class DatosEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            idLabel = new Label();
            label6 = new Label();
            panel1 = new Panel();
            txtPassword = new TextBox();
            cmbTipoUsuario = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(90, 122);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 29;
            label5.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(13, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(370, 25);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(13, 174);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(370, 30);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(62, 93);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 21;
            label3.Text = "Tipo de usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(38, 64);
            label2.Name = "label2";
            label2.Size = new Size(134, 17);
            label2.TabIndex = 20;
            label2.Text = "Nombre de usuario:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = Color.DarkCyan;
            idLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.ForeColor = Color.White;
            idLabel.Location = new Point(152, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 17);
            idLabel.TabIndex = 18;
            idLabel.Text = "id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkCyan;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(121, 11);
            label6.Name = "label6";
            label6.Size = new Size(25, 17);
            label6.TabIndex = 0;
            label6.Text = "Id:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 37);
            panel1.TabIndex = 30;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(178, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 23);
            txtPassword.TabIndex = 4;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Recepcionista", "Gerente" });
            cmbTipoUsuario.Location = new Point(178, 87);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(191, 23);
            cmbTipoUsuario.TabIndex = 31;
            // 
            // DatosEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(416, 251);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(txtPassword);
            Controls.Add(panel1);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleado";
            Load += DatosHuesped_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCmbFecha;
        private Label label5;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private Label idLabel;
        private Label label6;
        private Panel panel1;
        private TextBox txtPassword;
        private ComboBox cmbTipoUsuario;
    }
}