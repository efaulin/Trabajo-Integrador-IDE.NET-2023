namespace WindowsForm
{
    partial class DatosHabitacion
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
            nroNumero = new NumericUpDown();
            nroPiso = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            cmbTipoHabitacion = new ComboBox();
            panel1 = new Panel();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)nroNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nroPiso).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(25, 17);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(82, 56);
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
            label3.Location = new Point(107, 88);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Piso:";
            // 
            // nroNumero
            // 
            nroNumero.Location = new Point(152, 56);
            nroNumero.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nroNumero.Name = "nroNumero";
            nroNumero.Size = new Size(103, 23);
            nroNumero.TabIndex = 2;
            // 
            // nroPiso
            // 
            nroPiso.Location = new Point(152, 88);
            nroPiso.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nroPiso.Name = "nroPiso";
            nroPiso.Size = new Size(103, 23);
            nroPiso.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 184);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(18, 124);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 11;
            label4.Text = "Tipo de habitacion:";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.BackColor = Color.DarkSlateGray;
            cmbTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHabitacion.ForeColor = Color.White;
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(152, 123);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(191, 23);
            cmbTipoHabitacion.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 35);
            panel1.TabIndex = 14;

            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = Color.DarkCyan;
            idLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.ForeColor = Color.White;
            idLabel.Location = new Point(152, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(20, 17);
            idLabel.TabIndex = 15;
            idLabel.Text = "id";

            // 
            // DatosHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 258);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nroPiso);
            Controls.Add(nroNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosHabitacion";
            Load += DatosHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)nroNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)nroPiso).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nroNumero;
        private NumericUpDown nroPiso;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label4;
        private ComboBox cmbTipoHabitacion;
        private Panel panel1;
        private Label idLabel;
    }
}