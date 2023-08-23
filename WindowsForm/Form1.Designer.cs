namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            tlScHbtVer = new ToolStripMenuItem();
            tlScHbtAgregar = new ToolStripMenuItem();
            tlScHbtEditar = new ToolStripMenuItem();
            tlScHbtBaja = new ToolStripMenuItem();
            tlScHbtAlta = new ToolStripMenuItem();
            tlScHbtEliminar = new ToolStripMenuItem();
            tiposDeHabitacionesToolStripMenuItem = new ToolStripMenuItem();
            tlScTpHbtVer = new ToolStripMenuItem();
            tlScTpHbtAgregar = new ToolStripMenuItem();
            tlScTpHbtEditar = new ToolStripMenuItem();
            tlScTpHbtEditarDatos = new ToolStripMenuItem();
            tlScTpHbtEditarPrecio = new ToolStripMenuItem();
            tlScTpHbtEliminar = new ToolStripMenuItem();
            huespedesToolStripMenuItem = new ToolStripMenuItem();
            tlScHpdVer = new ToolStripMenuItem();
            tlScHpdAgregar = new ToolStripMenuItem();
            tlScHpdEditar = new ToolStripMenuItem();
            tlScHpdEliminar = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { habitacionesToolStripMenuItem, tiposDeHabitacionesToolStripMenuItem, huespedesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tlScHbtVer, tlScHbtAgregar, tlScHbtEditar, tlScHbtBaja, tlScHbtAlta, tlScHbtEliminar });
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(88, 20);
            habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // tlScHbtVer
            // 
            tlScHbtVer.Name = "tlScHbtVer";
            tlScHbtVer.Size = new Size(133, 22);
            tlScHbtVer.Text = "Ver";
            tlScHbtVer.Click += tlSc_hbtVer_Click;
            // 
            // tlScHbtAgregar
            // 
            tlScHbtAgregar.Name = "tlScHbtAgregar";
            tlScHbtAgregar.Size = new Size(133, 22);
            tlScHbtAgregar.Text = "Agregar";
            tlScHbtAgregar.Click += tlSc_hbtAgregar_Click;
            // 
            // tlScHbtEditar
            // 
            tlScHbtEditar.Name = "tlScHbtEditar";
            tlScHbtEditar.Size = new Size(133, 22);
            tlScHbtEditar.Text = "Editar";
            tlScHbtEditar.Click += tlSc_hbtEditar_Click;
            // 
            // tlScHbtBaja
            // 
            tlScHbtBaja.Name = "tlScHbtBaja";
            tlScHbtBaja.Size = new Size(133, 22);
            tlScHbtBaja.Text = "Dar de baja";
            tlScHbtBaja.Click += tlSc_hbtBaja_Click;
            // 
            // tlScHbtAlta
            // 
            tlScHbtAlta.Name = "tlScHbtAlta";
            tlScHbtAlta.Size = new Size(133, 22);
            tlScHbtAlta.Text = "Dar de alta";
            tlScHbtAlta.Click += tlSc_hbtAlta_Click;
            // 
            // tlScHbtEliminar
            // 
            tlScHbtEliminar.ForeColor = Color.Red;
            tlScHbtEliminar.Name = "tlScHbtEliminar";
            tlScHbtEliminar.Size = new Size(133, 22);
            tlScHbtEliminar.Text = "Eliminar";
            tlScHbtEliminar.Click += tlSc_hbtEliminar_Click;
            // 
            // tiposDeHabitacionesToolStripMenuItem
            // 
            tiposDeHabitacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tlScTpHbtVer, tlScTpHbtAgregar, tlScTpHbtEditar, tlScTpHbtEliminar });
            tiposDeHabitacionesToolStripMenuItem.Name = "tiposDeHabitacionesToolStripMenuItem";
            tiposDeHabitacionesToolStripMenuItem.Size = new Size(133, 20);
            tiposDeHabitacionesToolStripMenuItem.Text = "Tipos de habitaciones";
            // 
            // tlScTpHbtVer
            // 
            tlScTpHbtVer.Name = "tlScTpHbtVer";
            tlScTpHbtVer.Size = new Size(117, 22);
            tlScTpHbtVer.Text = "Ver";
            // 
            // tlScTpHbtAgregar
            // 
            tlScTpHbtAgregar.Name = "tlScTpHbtAgregar";
            tlScTpHbtAgregar.Size = new Size(117, 22);
            tlScTpHbtAgregar.Text = "Agregar";
            // 
            // tlScTpHbtEditar
            // 
            tlScTpHbtEditar.DropDownItems.AddRange(new ToolStripItem[] { tlScTpHbtEditarDatos, tlScTpHbtEditarPrecio });
            tlScTpHbtEditar.Name = "tlScTpHbtEditar";
            tlScTpHbtEditar.Size = new Size(117, 22);
            tlScTpHbtEditar.Text = "Editar";
            // 
            // tlScTpHbtEditarDatos
            // 
            tlScTpHbtEditarDatos.Name = "tlScTpHbtEditarDatos";
            tlScTpHbtEditarDatos.Size = new Size(275, 22);
            tlScTpHbtEditarDatos.Text = "Editar descripcion y numero de camas";
            // 
            // tlScTpHbtEditarPrecio
            // 
            tlScTpHbtEditarPrecio.Name = "tlScTpHbtEditarPrecio";
            tlScTpHbtEditarPrecio.Size = new Size(275, 22);
            tlScTpHbtEditarPrecio.Text = "Actualizar precio";
            // 
            // tlScTpHbtEliminar
            // 
            tlScTpHbtEliminar.ForeColor = Color.Red;
            tlScTpHbtEliminar.Name = "tlScTpHbtEliminar";
            tlScTpHbtEliminar.Size = new Size(117, 22);
            tlScTpHbtEliminar.Text = "Eliminar";
            // 
            // huespedesToolStripMenuItem
            // 
            huespedesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tlScHpdVer, tlScHpdAgregar, tlScHpdEditar, tlScHpdEliminar });
            huespedesToolStripMenuItem.Name = "huespedesToolStripMenuItem";
            huespedesToolStripMenuItem.Size = new Size(77, 20);
            huespedesToolStripMenuItem.Text = "Huespedes";
            // 
            // tlScHpdVer
            // 
            tlScHpdVer.Name = "tlScHpdVer";
            tlScHpdVer.Size = new Size(180, 22);
            tlScHpdVer.Text = "Ver";
            // 
            // tlScHpdAgregar
            // 
            tlScHpdAgregar.Name = "tlScHpdAgregar";
            tlScHpdAgregar.Size = new Size(180, 22);
            tlScHpdAgregar.Text = "Agregar";
            // 
            // tlScHpdEditar
            // 
            tlScHpdEditar.Name = "tlScHpdEditar";
            tlScHpdEditar.Size = new Size(180, 22);
            tlScHpdEditar.Text = "Editar";
            // 
            // tlScHpdEliminar
            // 
            tlScHpdEliminar.ForeColor = Color.Red;
            tlScHpdEliminar.Name = "tlScHpdEliminar";
            tlScHpdEliminar.Size = new Size(180, 22);
            tlScHpdEliminar.Text = "Eliminar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(235, 200);
            label1.Name = "label1";
            label1.Size = new Size(313, 25);
            label1.TabIndex = 1;
            label1.Text = "¡Bienvenido [usuario administrador]!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Menu Principal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem tlScHbtVer;
        private ToolStripMenuItem tlScHbtAgregar;
        private ToolStripMenuItem tlScHbtEditar;
        private ToolStripMenuItem tlScHbtBaja;
        private ToolStripMenuItem tlScHbtAlta;
        private ToolStripMenuItem tlScHbtEliminar;
        private ToolStripMenuItem tiposDeHabitacionesToolStripMenuItem;
        private ToolStripMenuItem tlScTpHbtVer;
        private ToolStripMenuItem tlScTpHbtAgregar;
        private ToolStripMenuItem tlScTpHbtEditar;
        private ToolStripMenuItem tlScTpHbtEditarDatos;
        private ToolStripMenuItem tlScTpHbtEditarPrecio;
        private ToolStripMenuItem tlScTpHbtEliminar;
        private ToolStripMenuItem huespedesToolStripMenuItem;
        private ToolStripMenuItem tlScHpdVer;
        private ToolStripMenuItem tlScHpdAgregar;
        private ToolStripMenuItem tlScHpdEditar;
        private ToolStripMenuItem tlScHpdEliminar;
        private Label label1;
    }
}