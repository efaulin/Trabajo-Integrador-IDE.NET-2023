namespace WindowsForm
{
    partial class EliminarHabitacion
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
            cmbIdHabitacion = new ComboBox();
            panel1 = new Panel();
            lblNumero = new Label();
            lblPiso = new Label();
            lblTipoHabitacion = new Label();
            label5 = new Label();
            lblNroReservas = new Label();
            label6 = new Label();
            lblEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(129, 39);
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
            label2.Location = new Point(92, 67);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(117, 97);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Piso:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Crimson;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 274);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Eliminar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(28, 157);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 11;
            label4.Text = "Tipo de habitacion:";
            label4.Click += label4_Click;
            // 
            // cmbIdHabitacion
            // 
            cmbIdHabitacion.BackColor = Color.DarkSlateGray;
            cmbIdHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdHabitacion.ForeColor = Color.White;
            cmbIdHabitacion.FormattingEnabled = true;
            cmbIdHabitacion.Location = new Point(162, 33);
            cmbIdHabitacion.Name = "cmbIdHabitacion";
            cmbIdHabitacion.Size = new Size(191, 23);
            cmbIdHabitacion.TabIndex = 1;
            cmbIdHabitacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbIdHabitacion.SelectionChangeCommitted += cmbIdHabitacion_SelectionChangeCommitted;
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
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(162, 67);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(70, 17);
            lblNumero.TabIndex = 15;
            lblNumero.Text = "lblNumero";
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPiso.Location = new Point(162, 97);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(46, 17);
            lblPiso.TabIndex = 16;
            lblPiso.Text = "lblPiso";
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoHabitacion.Location = new Point(162, 157);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(110, 17);
            lblTipoHabitacion.TabIndex = 17;
            lblTipoHabitacion.Text = "lblTipoHabitacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(16, 187);
            label5.Name = "label5";
            label5.Size = new Size(140, 17);
            label5.TabIndex = 18;
            label5.Text = "Numero de reservas:";
            // 
            // lblNroReservas
            // 
            lblNroReservas.AutoSize = true;
            lblNroReservas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroReservas.Location = new Point(162, 187);
            lblNroReservas.Name = "lblNroReservas";
            lblNroReservas.Size = new Size(97, 17);
            lblNroReservas.TabIndex = 19;
            lblNroReservas.Text = "lblNroReservas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(103, 126);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 20;
            label6.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(162, 126);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 17);
            lblEstado.TabIndex = 21;
            lblEstado.Text = "lblEstado";
            // 
            // EliminarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 348);
            Controls.Add(lblEstado);
            Controls.Add(label6);
            Controls.Add(lblNroReservas);
            Controls.Add(label5);
            Controls.Add(lblTipoHabitacion);
            Controls.Add(lblPiso);
            Controls.Add(lblNumero);
            Controls.Add(panel1);
            Controls.Add(cmbIdHabitacion);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EliminarHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Habitacion";
            Load += DatosHabitacion_Load;
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
        private ComboBox cmbIdHabitacion;
        private Panel panel1;
        private Label lblNumero;
        private Label lblPiso;
        private Label lblTipoHabitacion;
        private Label label5;
        private Label lblNroReservas;
        private Label label6;
        private Label lblEstado;
    }
}