namespace WindowsForm.Huespedes
{
    partial class DatosHuesped
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
            txtApellido = new TextBox();
            panel1 = new Panel();
            cmbId = new ComboBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            cmbTipoDoc = new ComboBox();
            txtDNI = new TextBox();
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
            // txtApellido
            // 
            txtApellido.Location = new Point(152, 100);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(191, 23);
            txtApellido.TabIndex = 28;
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
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
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
            label2.Location = new Point(86, 74);
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
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 32;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new Point(152, 163);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(191, 23);
            cmbTipoDoc.TabIndex = 33;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(152, 132);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(191, 23);
            txtDNI.TabIndex = 34;
            // 
            // DatosHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 301);
            Controls.Add(txtDNI);
            Controls.Add(cmbTipoDoc);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(panel1);
            Controls.Add(cmbId);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosHuesped";
            Text = "DatosHuesped";
            Load += DatosHuesped_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCmbFecha;
        private Label label5;
        private TextBox txtApellido;
        private Panel panel1;
        private ComboBox cmbId;
        private Label label4;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private ComboBox cmbTipoDoc;
        private TextBox txtDNI;
    }
}