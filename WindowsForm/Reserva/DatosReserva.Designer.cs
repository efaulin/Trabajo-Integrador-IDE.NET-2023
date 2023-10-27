namespace WindowsForm
{
    partial class DatosReserva
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
            label1 = new Label();
            label2 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cmbIdReserva = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbHuesped = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            dtFechaInicio = new DateTimePicker();
            dtFechaFin = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnBuscar = new Button();
            label8 = new Label();
            panel2 = new Panel();
            dtGrHabitacion = new DataGridView();
            txtNro = new TextBox();
            label10 = new Label();
            txtPiso = new TextBox();
            txtCantidadPersonas = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrHabitacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(86, 39);
            label1.Name = "label1";
            label1.Size = new Size(27, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(53, 68);
            label2.Name = "label2";
            label2.Size = new Size(151, 17);
            label2.TabIndex = 2;
            label2.Text = "Fecha inico de reserva:";
            label2.Click += label2_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 586);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 622);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbIdReserva
            // 
            cmbIdReserva.BackColor = Color.DarkSlateGray;
            cmbIdReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdReserva.ForeColor = Color.White;
            cmbIdReserva.FormattingEnabled = true;
            cmbIdReserva.Location = new Point(119, 33);
            cmbIdReserva.Name = "cmbIdReserva";
            cmbIdReserva.Size = new Size(191, 23);
            cmbIdReserva.TabIndex = 1;
            cmbIdReserva.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbIdReserva.SelectionChangeCommitted += cmbIdReserva_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 11);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(65, 97);
            label3.Name = "label3";
            label3.Size = new Size(139, 17);
            label3.TabIndex = 16;
            label3.Text = "Fecha fin de reserva:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(58, 126);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 18;
            label4.Text = "Cantidad de personas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(34, 154);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 20;
            label5.Text = "Habitacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(47, 393);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 21;
            label6.Text = "Huesped:";
            // 
            // cmbHuesped
            // 
            cmbHuesped.DropDownStyle = ComboBoxStyle.Simple;
            cmbHuesped.FormattingEnabled = true;
            cmbHuesped.Location = new Point(119, 387);
            cmbHuesped.Name = "cmbHuesped";
            cmbHuesped.Size = new Size(191, 83);
            cmbHuesped.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(130, 482);
            label7.Name = "label7";
            label7.Size = new Size(53, 17);
            label7.TabIndex = 24;
            label7.Text = "Estado:";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(143, 532);
            label9.Name = "label9";
            label9.Size = new Size(76, 17);
            label9.TabIndex = 26;
            label9.Text = "Servicios...";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Checked = false;
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(210, 62);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(100, 23);
            dtFechaInicio.TabIndex = 27;
            // 
            // dtFechaFin
            // 
            dtFechaFin.Format = DateTimePickerFormat.Short;
            dtFechaFin.Location = new Point(210, 91);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(100, 23);
            dtFechaFin.TabIndex = 28;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "En espera", "En curso", "Finalizada", "Cancelada" });
            cmbEstado.Location = new Point(189, 476);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 29;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(243, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(8, 9);
            label8.Name = "label8";
            label8.Size = new Size(39, 17);
            label8.TabIndex = 32;
            label8.Text = "Piso:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dtGrHabitacion);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtNro);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPiso);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(119, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 190);
            panel2.TabIndex = 33;
            // 
            // dtGrHabitacion
            // 
            dtGrHabitacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrHabitacion.Location = new Point(-2, 32);
            dtGrHabitacion.Name = "dtGrHabitacion";
            dtGrHabitacion.RowTemplate.Height = 25;
            dtGrHabitacion.Size = new Size(334, 156);
            dtGrHabitacion.TabIndex = 36;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(160, 3);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(58, 23);
            txtNro.TabIndex = 35;
            txtNro.KeyPress += textBox_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(117, 9);
            label10.Name = "label10";
            label10.Size = new Size(37, 17);
            label10.TabIndex = 34;
            label10.Text = "Nro:";
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(53, 3);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(58, 23);
            txtPiso.TabIndex = 33;
            txtPiso.KeyPress += textBox_KeyPress;
            // 
            // txtCantidadPersonas
            // 
            txtCantidadPersonas.Location = new Point(210, 120);
            txtCantidadPersonas.Name = "txtCantidadPersonas";
            txtCantidadPersonas.Size = new Size(100, 23);
            txtCantidadPersonas.TabIndex = 34;
            txtCantidadPersonas.KeyPress += textBox_KeyPress;
            // 
            // DatosReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(649, 663);
            Controls.Add(txtCantidadPersonas);
            Controls.Add(panel2);
            Controls.Add(cmbEstado);
            Controls.Add(dtFechaFin);
            Controls.Add(dtFechaInicio);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cmbHuesped);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(cmbIdReserva);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosReserva";
            Load += DatosHabitacion_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrHabitacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cmbIdReserva;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbHuesped;
        private Label label7;
        private Label label9;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFin;
        private ComboBox cmbEstado;
        private Button btnBuscar;
        private Label label8;
        private Panel panel2;
        private DataGridView dtGrHabitacion;
        private TextBox txtNro;
        private Label label10;
        private TextBox txtPiso;
        private TextBox txtCantidadPersonas;
    }
}