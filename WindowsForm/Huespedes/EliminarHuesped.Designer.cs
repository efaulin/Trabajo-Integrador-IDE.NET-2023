namespace WindowsForm.Huespedes
{
    partial class EliminarHuesped
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
            panel1 = new Panel();
            cmbId = new ComboBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblNumero = new Label();
            lblDocumento = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(108, 138);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 29;
            label5.Text = "DNI:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 11);
            panel1.TabIndex = 27;
            // 
            // cmbId
            // 
            cmbId.BackColor = Color.DarkSlateGray;
            cmbId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbId.ForeColor = Color.White;
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(152, 39);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(191, 23);
            cmbId.TabIndex = 26;
            cmbId.SelectedIndexChanged += cmbId_SelectedIndexChanged;
            cmbId.SelectionChangeCommitted += cmbId_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(32, 169);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 25;
            label4.Text = "Tipo documento:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Crimson;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Eliminar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(81, 106);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 21;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(82, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 20;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(119, 45);
            label1.Name = "label1";
            label1.Size = new Size(27, 17);
            label1.TabIndex = 19;
            label1.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(152, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 17);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "lblNombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(152, 106);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 17);
            lblApellido.TabIndex = 31;
            lblApellido.Text = "lblApellido";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumero.Location = new Point(152, 138);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(70, 17);
            lblNumero.TabIndex = 32;
            lblNumero.Text = "lblNumero";
            lblNumero.Click += lblNumero_Click;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento.Location = new Point(152, 169);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(89, 17);
            lblDocumento.TabIndex = 33;
            lblDocumento.Text = "lblDocumento";
            // 
            // EliminarHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 301);
            Controls.Add(lblDocumento);
            Controls.Add(lblNumero);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
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
            Name = "EliminarHuesped";
            Text = "Eliminar Huesped";
            Load += DatosHuesped_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCmbFecha;
        private Label label5;
        private Panel panel1;
        private ComboBox cmbId;
        private Label label4;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNumero;
        private Label lblDocumento;
    }
}