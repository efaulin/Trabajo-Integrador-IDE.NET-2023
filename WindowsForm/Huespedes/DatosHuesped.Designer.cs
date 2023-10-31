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
            label4 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            cmbTipoDoc = new ComboBox();
            txtDNI = new TextBox();
            idLabel = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            txtApellido.TabIndex = 3;
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
            btnAceptar.Location = new Point(12, 233);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
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
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 2;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Location = new Point(152, 163);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(191, 23);
            cmbTipoDoc.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(152, 132);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(191, 23);
            txtDNI.TabIndex = 4;
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
            panel1.Size = new Size(373, 37);
            panel1.TabIndex = 30;
            // 
            // DatosHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 301);
            Controls.Add(panel1);
            Controls.Add(txtDNI);
            Controls.Add(cmbTipoDoc);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosHuesped";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosHuesped";
            Load += DatosHuesped_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskCmbFecha;
        private Label label5;
        private TextBox txtApellido;
        private Label label4;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private ComboBox cmbTipoDoc;
        private TextBox txtDNI;
        private Label idLabel;
        private Label label6;
        private Panel panel1;
    }
}