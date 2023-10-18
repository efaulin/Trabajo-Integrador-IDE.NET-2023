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
            mskCmbFechaInicio = new MaskedTextBox();
            label3 = new Label();
            mskCmbFechaFin = new MaskedTextBox();
            label4 = new Label();
            mskCmbCantPersonas = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            cmbHabitacion = new ComboBox();
            cmbHuesped = new ComboBox();
            label7 = new Label();
            lblEstado = new Label();
            label9 = new Label();
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
            btnAceptar.Location = new Point(12, 279);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 315);
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
            panel1.Size = new Size(377, 11);
            panel1.TabIndex = 14;
            // 
            // mskCmbFechaInicio
            // 
            mskCmbFechaInicio.Enabled = false;
            mskCmbFechaInicio.Location = new Point(210, 62);
            mskCmbFechaInicio.Mask = "00/00/0000";
            mskCmbFechaInicio.Name = "mskCmbFechaInicio";
            mskCmbFechaInicio.Size = new Size(100, 23);
            mskCmbFechaInicio.TabIndex = 15;
            mskCmbFechaInicio.TextAlign = HorizontalAlignment.Center;
            mskCmbFechaInicio.ValidatingType = typeof(DateTime);
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
            // mskCmbFechaFin
            // 
            mskCmbFechaFin.Enabled = false;
            mskCmbFechaFin.Location = new Point(210, 91);
            mskCmbFechaFin.Mask = "00/00/0000";
            mskCmbFechaFin.Name = "mskCmbFechaFin";
            mskCmbFechaFin.Size = new Size(100, 23);
            mskCmbFechaFin.TabIndex = 17;
            mskCmbFechaFin.TextAlign = HorizontalAlignment.Center;
            mskCmbFechaFin.ValidatingType = typeof(DateTime);
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
            // mskCmbCantPersonas
            // 
            mskCmbCantPersonas.Location = new Point(210, 120);
            mskCmbCantPersonas.Mask = "99";
            mskCmbCantPersonas.Name = "mskCmbCantPersonas";
            mskCmbCantPersonas.Size = new Size(100, 23);
            mskCmbCantPersonas.TabIndex = 19;
            mskCmbCantPersonas.TextAlign = HorizontalAlignment.Center;
            mskCmbCantPersonas.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(34, 156);
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
            label6.Location = new Point(47, 185);
            label6.Name = "label6";
            label6.Size = new Size(66, 17);
            label6.TabIndex = 21;
            label6.Text = "Huesped:";
            // 
            // cmbHabitacion
            // 
            cmbHabitacion.FormattingEnabled = true;
            cmbHabitacion.Location = new Point(119, 150);
            cmbHabitacion.Name = "cmbHabitacion";
            cmbHabitacion.Size = new Size(191, 23);
            cmbHabitacion.TabIndex = 22;
            // 
            // cmbHuesped
            // 
            cmbHuesped.FormattingEnabled = true;
            cmbHuesped.Location = new Point(119, 179);
            cmbHuesped.Name = "cmbHuesped";
            cmbHuesped.Size = new Size(191, 23);
            cmbHuesped.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(151, 214);
            label7.Name = "label7";
            label7.Size = new Size(53, 17);
            label7.TabIndex = 24;
            label7.Text = "Estado:";
            label7.Click += label7_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.ControlText;
            lblEstado.Location = new Point(210, 214);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 17);
            lblEstado.TabIndex = 25;
            lblEstado.Text = "lblEstado";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(143, 244);
            label9.Name = "label9";
            label9.Size = new Size(76, 17);
            label9.TabIndex = 26;
            label9.Text = "Servicios...";
            // 
            // DatosReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(377, 355);
            Controls.Add(label9);
            Controls.Add(lblEstado);
            Controls.Add(label7);
            Controls.Add(cmbHuesped);
            Controls.Add(cmbHabitacion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mskCmbCantPersonas);
            Controls.Add(label4);
            Controls.Add(mskCmbFechaFin);
            Controls.Add(label3);
            Controls.Add(mskCmbFechaInicio);
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
        private MaskedTextBox mskCmbFechaInicio;
        private Label label3;
        private MaskedTextBox mskCmbFechaFin;
        private Label label4;
        private MaskedTextBox mskCmbCantPersonas;
        private Label label5;
        private Label label6;
        private ComboBox cmbHabitacion;
        private ComboBox cmbHuesped;
        private Label label7;
        private Label lblEstado;
        private Label label9;
    }
}