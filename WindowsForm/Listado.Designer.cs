namespace WindowsForm
{
    partial class Listado
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
            toolStripContainer1 = new ToolStripContainer();
            tlHabitaciones = new TableLayoutPanel();
            dgvHabitaciones = new DataGridView();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnEditPrecio = new Button();
            btnAltaBaja = new Button();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tlHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(337, 86);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 4;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tlHabitaciones);
            toolStripContainer1.ContentPanel.Size = new Size(950, 575);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            toolStripContainer1.RightToolStripPanel.Click += toolStripContainer1_RightToolStripPanel_Click;
            toolStripContainer1.Size = new Size(950, 600);
            toolStripContainer1.TabIndex = 7;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tlHabitaciones
            // 
            tlHabitaciones.ColumnCount = 7;
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.Controls.Add(dgvHabitaciones, 0, 0);
            tlHabitaciones.Controls.Add(btnSalir, 6, 1);
            tlHabitaciones.Controls.Add(btnActualizar, 5, 1);
            tlHabitaciones.Controls.Add(btnAgregar, 0, 1);
            tlHabitaciones.Controls.Add(btnEditar, 1, 1);
            tlHabitaciones.Controls.Add(btnEliminar, 2, 1);
            tlHabitaciones.Controls.Add(btnEditPrecio, 4, 1);
            tlHabitaciones.Controls.Add(btnAltaBaja, 3, 1);
            tlHabitaciones.Dock = DockStyle.Fill;
            tlHabitaciones.Location = new Point(0, 0);
            tlHabitaciones.Margin = new Padding(15, 3, 3, 3);
            tlHabitaciones.Name = "tlHabitaciones";
            tlHabitaciones.RowCount = 3;
            tlHabitaciones.RowStyles.Add(new RowStyle(SizeType.Percent, 84.17391F));
            tlHabitaciones.RowStyles.Add(new RowStyle(SizeType.Percent, 15.82609F));
            tlHabitaciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlHabitaciones.Size = new Size(950, 575);
            tlHabitaciones.TabIndex = 0;

            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.AllowUserToAddRows = false;
            dgvHabitaciones.AllowUserToDeleteRows = false;
            dgvHabitaciones.AllowUserToResizeColumns = false;
            dgvHabitaciones.AllowUserToResizeRows = false;
            dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabitaciones.BackgroundColor = Color.White;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlHabitaciones.SetColumnSpan(dgvHabitaciones, 7);
            dgvHabitaciones.Dock = DockStyle.Fill;
            dgvHabitaciones.Location = new Point(3, 3);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.ReadOnly = true;
            dgvHabitaciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHabitaciones.RowTemplate.Height = 25;
            dgvHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabitaciones.Size = new Size(944, 461);
            dgvHabitaciones.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Right;
            btnSalir.BackColor = SystemColors.ButtonFace;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(807, 492);
            btnSalir.Margin = new Padding(3, 3, 40, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 37);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Right;
            btnActualizar.BackColor = Color.DarkCyan;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(691, 492);
            btnActualizar.Margin = new Padding(3, 3, 10, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 37);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.BackColor = Color.DarkCyan;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(40, 492);
            btnAgregar.Margin = new Padding(40, 3, 3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(103, 37);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Left;
            btnEditar.BackColor = SystemColors.ButtonFace;
            btnEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(161, 492);
            btnEditar.Margin = new Padding(15, 3, 3, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.No;
            btnEditar.Size = new Size(103, 37);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left;
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(282, 492);
            btnEliminar.Margin = new Padding(15, 3, 3, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 37);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditPrecio
            // 
            btnEditPrecio.Anchor = AnchorStyles.Left;
            btnEditPrecio.BackColor = SystemColors.ButtonFace;
            btnEditPrecio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditPrecio.ForeColor = Color.Black;
            btnEditPrecio.Location = new Point(509, 492);
            btnEditPrecio.Margin = new Padding(0, 3, 3, 3);
            btnEditPrecio.Name = "btnEditPrecio";
            btnEditPrecio.RightToLeft = RightToLeft.No;
            btnEditPrecio.Size = new Size(121, 37);
            btnEditPrecio.TabIndex = 5;
            btnEditPrecio.Text = "Editar Precio";
            btnEditPrecio.UseVisualStyleBackColor = false;
            btnEditPrecio.Click += btnEditPrecio_Click;
            // 
            // btnAltaBaja
            // 
            btnAltaBaja.Anchor = AnchorStyles.Left;
            btnAltaBaja.BackColor = SystemColors.ButtonFace;
            btnAltaBaja.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaBaja.ForeColor = Color.Black;
            btnAltaBaja.Location = new Point(403, 492);
            btnAltaBaja.Margin = new Padding(15, 3, 3, 3);
            btnAltaBaja.Name = "btnAltaBaja";
            btnAltaBaja.RightToLeft = RightToLeft.No;
            btnAltaBaja.Size = new Size(103, 37);
            btnAltaBaja.TabIndex = 7;
            btnAltaBaja.Text = "Alta/Baja";
            btnAltaBaja.UseVisualStyleBackColor = false;
            btnAltaBaja.Click += btnAltaBaja_Click;
            // 
            // Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 600);
            Controls.Add(toolStripContainer1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 600);
            Name = "Listado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Habitaciones";
            Load += ListarHbt_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tlHabitaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tlHabitaciones;
        private DataGridView dgvHabitaciones;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnEditPrecio;
        private Button btnAltaBaja;
        private Button btnAgregar;
    }
}