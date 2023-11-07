namespace WindowsForm
{
    partial class DatosTipoHabitacion
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
            lblFecha = new Label();
            panel1 = new Panel();
            idLabel = new Label();
            txtDescipcion = new TextBox();
            label5 = new Label();
            mskCmbFecha = new MaskedTextBox();
            btnEditarPrecio = new Button();
            txtNumero = new TextBox();
            txtPrecio = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(121, 11);
            label1.Name = "label1";
            label1.Size = new Size(25, 17);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(21, 59);
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
            label3.Location = new Point(61, 92);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 4;
            label3.Text = "Descripcion:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkCyan;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 227);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.DarkCyan;
            lblFecha.Location = new Point(43, 161);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(194, 17);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "Fecha modificacion de precio:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(idLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 35);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
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
            // txtDescipcion
            // 
            txtDescipcion.Location = new Point(152, 91);
            txtDescipcion.Name = "txtDescipcion";
            txtDescipcion.Size = new Size(191, 23);
            txtDescipcion.TabIndex = 3;
            txtDescipcion.TextChanged += txtDescipcion_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(94, 127);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 16;
            label5.Text = "Precio:";
            // 
            // mskCmbFecha
            // 
            mskCmbFecha.Enabled = false;
            mskCmbFecha.Location = new Point(243, 160);
            mskCmbFecha.Mask = "00/00/0000";
            mskCmbFecha.Name = "mskCmbFecha";
            mskCmbFecha.Size = new Size(100, 23);
            mskCmbFecha.TabIndex = 5;
            mskCmbFecha.TextAlign = HorizontalAlignment.Center;
            mskCmbFecha.ValidatingType = typeof(DateTime);
            // 
            // btnEditarPrecio
            // 
            btnEditarPrecio.Location = new Point(261, 125);
            btnEditarPrecio.Name = "btnEditarPrecio";
            btnEditarPrecio.Size = new Size(82, 23);
            btnEditarPrecio.TabIndex = 17;
            btnEditarPrecio.Text = "🔑🔒";
            btnEditarPrecio.UseVisualStyleBackColor = true;
            btnEditarPrecio.Click += btnEditarPrecio_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(152, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(103, 23);
            txtNumero.TabIndex = 18;
            txtNumero.KeyPress += textBox_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(152, 126);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(103, 23);
            txtPrecio.TabIndex = 19;
            txtPrecio.KeyPress += textBoxPrecio_KeyPress;
            // 
            // DatosTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 301);
            Controls.Add(txtPrecio);
            Controls.Add(txtNumero);
            Controls.Add(btnEditarPrecio);
            Controls.Add(mskCmbFecha);
            Controls.Add(label5);
            Controls.Add(txtDescipcion);
            Controls.Add(lblFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosTipoHabitacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosTipoHabitacion";
            Load += DatosTipoHabitacion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblFecha;
        private Panel panel1;
        private TextBox txtDescipcion;
        private Label label5;
        private MaskedTextBox mskCmbFecha;
        private Button btnEditarPrecio;
        private Label idLabel;
        private TextBox txtNumero;
        private TextBox txtPrecio;
    }
}