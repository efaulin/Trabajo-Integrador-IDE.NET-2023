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
            cmbIdHabitacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nroNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nroPiso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 36);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 65);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 94);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Piso:";
            // 
            // nroNumero
            // 
            nroNumero.Location = new Point(126, 62);
            nroNumero.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nroNumero.Name = "nroNumero";
            nroNumero.Size = new Size(103, 23);
            nroNumero.TabIndex = 6;
            nroNumero.ValueChanged += nroNumero_ValueChanged;
            // 
            // nroPiso
            // 
            nroPiso.Location = new Point(126, 94);
            nroPiso.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nroPiso.Name = "nroPiso";
            nroPiso.Size = new Size(103, 23);
            nroPiso.TabIndex = 7;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 184);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 123);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 11;
            label4.Text = "Tipo de habitacion:";
            label4.Click += label4_Click;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Location = new Point(126, 123);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(191, 23);
            cmbTipoHabitacion.TabIndex = 12;
            // 
            // cmbIdHabitacion
            // 
            cmbIdHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdHabitacion.FormattingEnabled = true;
            cmbIdHabitacion.Location = new Point(126, 33);
            cmbIdHabitacion.Name = "cmbIdHabitacion";
            cmbIdHabitacion.Size = new Size(191, 23);
            cmbIdHabitacion.TabIndex = 13;
            cmbIdHabitacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DatosHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 258);
            Controls.Add(cmbIdHabitacion);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nroPiso);
            Controls.Add(nroNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosHabitacion";
            Text = "DatosHabitacion";
            Load += DatosHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)nroNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)nroPiso).EndInit();
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
        private ComboBox cmbIdHabitacion;
    }
}