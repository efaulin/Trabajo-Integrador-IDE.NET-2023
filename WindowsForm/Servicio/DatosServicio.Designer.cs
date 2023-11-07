namespace WindowsForm
{
    partial class DatosServicio
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
            btnEditarPrecio = new Button();
            mskCmbFecha = new MaskedTextBox();
            label5 = new Label();
            txtDescipcion = new TextBox();
            lblFecha = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label3 = new Label();
            panel1 = new Panel();
            idLabel = new Label();
            label1 = new Label();
            txtPrecio = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditarPrecio
            // 
            btnEditarPrecio.Location = new Point(261, 95);
            btnEditarPrecio.Name = "btnEditarPrecio";
            btnEditarPrecio.Size = new Size(82, 23);
            btnEditarPrecio.TabIndex = 29;
            btnEditarPrecio.Text = "🔑🔒";
            btnEditarPrecio.UseVisualStyleBackColor = true;
            btnEditarPrecio.Click += btnEditarPrecio_Click;
            // 
            // mskCmbFecha
            // 
            mskCmbFecha.Enabled = false;
            mskCmbFecha.Location = new Point(243, 130);
            mskCmbFecha.Mask = "00/00/0000";
            mskCmbFecha.Name = "mskCmbFecha";
            mskCmbFecha.Size = new Size(100, 23);
            mskCmbFecha.TabIndex = 23;
            mskCmbFecha.TextAlign = HorizontalAlignment.Center;
            mskCmbFecha.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(94, 97);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 28;
            label5.Text = "Precio:";
            // 
            // txtDescipcion
            // 
            txtDescipcion.Location = new Point(152, 61);
            txtDescipcion.Name = "txtDescipcion";
            txtDescipcion.Size = new Size(191, 23);
            txtDescipcion.TabIndex = 20;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.DarkCyan;
            lblFecha.Location = new Point(43, 131);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(194, 17);
            lblFecha.TabIndex = 26;
            lblFecha.Text = "Fecha modificacion de precio:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(349, 25);
            btnCancelar.TabIndex = 25;
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
            btnAceptar.Location = new Point(12, 186);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(349, 30);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(61, 62);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 22;
            label3.Text = "Descripcion:";
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
            panel1.TabIndex = 27;
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
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(152, 95);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(103, 23);
            txtPrecio.TabIndex = 30;
            txtPrecio.KeyPress += textBoxPrecio_KeyPress;
            // 
            // DatosServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(373, 258);
            Controls.Add(txtPrecio);
            Controls.Add(btnEditarPrecio);
            Controls.Add(mskCmbFecha);
            Controls.Add(label5);
            Controls.Add(txtDescipcion);
            Controls.Add(lblFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DatosServicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosServicio";
            Load += DatosServicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditarPrecio;
        private MaskedTextBox mskCmbFecha;
        private Label label5;
        private TextBox txtDescipcion;
        private Label lblFecha;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label3;
        private Panel panel1;
        private Label idLabel;
        private Label label1;
        private TextBox txtPrecio;
    }
}