namespace WindowsForm
{
    partial class EliminarTipoHabitacion
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
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            cmbId = new ComboBox();
            panel1 = new Panel();
            label5 = new Label();
            lblCamas = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblFecha = new Label();
            label6 = new Label();
            lblHabitaciones = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(119, 39);
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
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 2;
            label2.Text = "Numero de camas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(61, 100);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 4;
            label3.Text = "Descripcion:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Crimson;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 223);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Eliminar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(43, 163);
            label4.Name = "label4";
            label4.Size = new Size(194, 17);
            label4.TabIndex = 11;
            label4.Text = "Fecha modificacion de precio:";
            label4.Click += label4_Click;
            // 
            // cmbId
            // 
            cmbId.BackColor = Color.DarkSlateGray;
            cmbId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbId.ForeColor = Color.White;
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(152, 33);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(191, 23);
            cmbId.TabIndex = 13;
            cmbId.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbId.SelectionChangeCommitted += cmbId_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 11);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(94, 132);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 16;
            label5.Text = "Precio:";
            // 
            // lblCamas
            // 
            lblCamas.AutoSize = true;
            lblCamas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCamas.Location = new Point(152, 68);
            lblCamas.Name = "lblCamas";
            lblCamas.Size = new Size(61, 17);
            lblCamas.TabIndex = 17;
            lblCamas.Text = "lblCamas";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(152, 100);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 17);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "lblDescripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(152, 132);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(58, 17);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "lblPrecio";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(243, 163);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(55, 17);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "lblFecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(12, 192);
            label6.Name = "label6";
            label6.Size = new Size(168, 17);
            label6.TabIndex = 21;
            label6.Text = "Cantidad de habitaciones:";
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHabitaciones.Location = new Point(186, 192);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(97, 17);
            lblHabitaciones.TabIndex = 22;
            lblHabitaciones.Text = "lblHabitaciones";
            // 
            // EliminarTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 294);
            Controls.Add(lblHabitaciones);
            Controls.Add(label6);
            Controls.Add(lblFecha);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCamas);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(cmbId);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EliminarTipoHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Tipo de Habitacion";
            Load += DatosTipoHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label4;
        private ComboBox cmbId;
        private Panel panel1;
        private Label label5;
        private Label lblCamas;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblFecha;
        private Label label6;
        private Label lblHabitaciones;
    }
}