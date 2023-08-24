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
            btnActualizar = new Button();
            btnSalir = new Button();
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
            toolStripContainer1.Size = new Size(950, 600);
            toolStripContainer1.TabIndex = 7;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // tlHabitaciones
            // 
            tlHabitaciones.ColumnCount = 2;
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlHabitaciones.ColumnStyles.Add(new ColumnStyle());
            tlHabitaciones.Controls.Add(dgvHabitaciones, 0, 0);
            tlHabitaciones.Controls.Add(btnActualizar, 0, 1);
            tlHabitaciones.Controls.Add(btnSalir, 1, 1);
            tlHabitaciones.Dock = DockStyle.Fill;
            tlHabitaciones.Location = new Point(0, 0);
            tlHabitaciones.Name = "tlHabitaciones";
            tlHabitaciones.RowCount = 2;
            tlHabitaciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlHabitaciones.RowStyles.Add(new RowStyle());
            tlHabitaciones.Size = new Size(950, 575);
            tlHabitaciones.TabIndex = 0;
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.AllowUserToResizeColumns = false;
            dgvHabitaciones.AllowUserToResizeRows = false;
            dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabitaciones.BackgroundColor = Color.White;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlHabitaciones.SetColumnSpan(dgvHabitaciones, 2);
            dgvHabitaciones.Dock = DockStyle.Fill;
            dgvHabitaciones.Location = new Point(3, 3);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.ReadOnly = true;
            dgvHabitaciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHabitaciones.RowTemplate.Height = 25;
            dgvHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabitaciones.Size = new Size(944, 540);
            dgvHabitaciones.TabIndex = 0;
            dgvHabitaciones.CellContentClick += dgvHabitaciones_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = Color.DarkCyan;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(744, 549);
            btnActualizar.Margin = new Padding(3, 3, 10, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(89, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(846, 549);
            btnSalir.Margin = new Padding(3, 3, 15, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
    }
}