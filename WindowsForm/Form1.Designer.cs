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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panelSrvSubmenu = new Panel();
            deleteSrv = new Button();
            editarSrv = new Button();
            addSrv = new Button();
            mostrarSrv = new Button();
            btnServicio = new Button();
            panelRsvSubmenu = new Panel();
            deleteRsv = new Button();
            editarRsv = new Button();
            addRsv = new Button();
            mostrarRsv = new Button();
            btnReserva = new Button();
            panelHspdSubmenu = new Panel();
            deleteHspd = new Button();
            editarHspd = new Button();
            addHspd = new Button();
            mostrarHspd = new Button();
            btnHuesped = new Button();
            panelTpHbtSubmenu = new Panel();
            deleteTpHbt = new Button();
            editarPrecioTpHbt = new Button();
            editarTpHbt = new Button();
            addTpHbt = new Button();
            mostrarTpHbt = new Button();
            btnTpHbt = new Button();
            panelHbtSubmenu = new Panel();
            deleteHbt = new Button();
            altaHbt = new Button();
            editHbt = new Button();
            addHbt = new Button();
            mostrarHbt = new Button();
            btnHabitacion = new Button();
            panel5 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            panelSrvSubmenu.SuspendLayout();
            panelRsvSubmenu.SuspendLayout();
            panelHspdSubmenu.SuspendLayout();
            panelTpHbtSubmenu.SuspendLayout();
            panelHbtSubmenu.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(panelSrvSubmenu);
            panel1.Controls.Add(btnServicio);
            panel1.Controls.Add(panelRsvSubmenu);
            panel1.Controls.Add(btnReserva);
            panel1.Controls.Add(panelHspdSubmenu);
            panel1.Controls.Add(btnHuesped);
            panel1.Controls.Add(panelTpHbtSubmenu);
            panel1.Controls.Add(btnTpHbt);
            panel1.Controls.Add(panelHbtSubmenu);
            panel1.Controls.Add(btnHabitacion);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 720);
            panel1.TabIndex = 2;
            // 
            // panelSrvSubmenu
            // 
            panelSrvSubmenu.BackColor = Color.MediumTurquoise;
            panelSrvSubmenu.Controls.Add(deleteSrv);
            panelSrvSubmenu.Controls.Add(editarSrv);
            panelSrvSubmenu.Controls.Add(addSrv);
            panelSrvSubmenu.Controls.Add(mostrarSrv);
            panelSrvSubmenu.Dock = DockStyle.Top;
            panelSrvSubmenu.Location = new Point(0, 832);
            panelSrvSubmenu.Name = "panelSrvSubmenu";
            panelSrvSubmenu.Size = new Size(234, 111);
            panelSrvSubmenu.TabIndex = 24;
            // 
            // deleteSrv
            // 
            deleteSrv.Dock = DockStyle.Top;
            deleteSrv.FlatAppearance.BorderSize = 0;
            deleteSrv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            deleteSrv.FlatStyle = FlatStyle.Flat;
            deleteSrv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSrv.ForeColor = Color.Firebrick;
            deleteSrv.Location = new Point(0, 75);
            deleteSrv.Name = "deleteSrv";
            deleteSrv.Padding = new Padding(8, 0, 0, 0);
            deleteSrv.Size = new Size(234, 25);
            deleteSrv.TabIndex = 23;
            deleteSrv.Text = "Eliminar";
            deleteSrv.TextAlign = ContentAlignment.MiddleLeft;
            deleteSrv.UseVisualStyleBackColor = true;
            // 
            // editarSrv
            // 
            editarSrv.Dock = DockStyle.Top;
            editarSrv.FlatAppearance.BorderSize = 0;
            editarSrv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            editarSrv.FlatStyle = FlatStyle.Flat;
            editarSrv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarSrv.Location = new Point(0, 50);
            editarSrv.Name = "editarSrv";
            editarSrv.Padding = new Padding(8, 0, 0, 0);
            editarSrv.Size = new Size(234, 25);
            editarSrv.TabIndex = 22;
            editarSrv.Text = "Editar";
            editarSrv.TextAlign = ContentAlignment.MiddleLeft;
            editarSrv.UseVisualStyleBackColor = true;
            // 
            // addSrv
            // 
            addSrv.Dock = DockStyle.Top;
            addSrv.FlatAppearance.BorderSize = 0;
            addSrv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            addSrv.FlatStyle = FlatStyle.Flat;
            addSrv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addSrv.Location = new Point(0, 25);
            addSrv.Name = "addSrv";
            addSrv.Padding = new Padding(8, 0, 0, 0);
            addSrv.Size = new Size(234, 25);
            addSrv.TabIndex = 21;
            addSrv.Text = "Agregar ";
            addSrv.TextAlign = ContentAlignment.MiddleLeft;
            addSrv.UseVisualStyleBackColor = true;
            // 
            // mostrarSrv
            // 
            mostrarSrv.Dock = DockStyle.Top;
            mostrarSrv.FlatAppearance.BorderSize = 0;
            mostrarSrv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            mostrarSrv.FlatStyle = FlatStyle.Flat;
            mostrarSrv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mostrarSrv.Location = new Point(0, 0);
            mostrarSrv.Name = "mostrarSrv";
            mostrarSrv.Padding = new Padding(8, 0, 0, 0);
            mostrarSrv.Size = new Size(234, 25);
            mostrarSrv.TabIndex = 20;
            mostrarSrv.Text = "Listar";
            mostrarSrv.TextAlign = ContentAlignment.MiddleLeft;
            mostrarSrv.UseVisualStyleBackColor = true;
            mostrarSrv.Click += mostrarSrv_Click;
            // 
            // btnServicio
            // 
            btnServicio.BackColor = Color.LightSeaGreen;
            btnServicio.Dock = DockStyle.Top;
            btnServicio.FlatAppearance.BorderColor = Color.DarkCyan;
            btnServicio.FlatAppearance.BorderSize = 2;
            btnServicio.FlatStyle = FlatStyle.Flat;
            btnServicio.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnServicio.ForeColor = Color.White;
            btnServicio.Location = new Point(0, 797);
            btnServicio.Name = "btnServicio";
            btnServicio.Size = new Size(234, 35);
            btnServicio.TabIndex = 23;
            btnServicio.Text = "Servicio";
            btnServicio.UseVisualStyleBackColor = false;
            btnServicio.Click += btnServicio_Click;
            // 
            // panelRsvSubmenu
            // 
            panelRsvSubmenu.BackColor = Color.MediumTurquoise;
            panelRsvSubmenu.Controls.Add(deleteRsv);
            panelRsvSubmenu.Controls.Add(editarRsv);
            panelRsvSubmenu.Controls.Add(addRsv);
            panelRsvSubmenu.Controls.Add(mostrarRsv);
            panelRsvSubmenu.Dock = DockStyle.Top;
            panelRsvSubmenu.Location = new Point(0, 686);
            panelRsvSubmenu.Name = "panelRsvSubmenu";
            panelRsvSubmenu.Size = new Size(234, 111);
            panelRsvSubmenu.TabIndex = 22;
            // 
            // deleteRsv
            // 
            deleteRsv.Dock = DockStyle.Top;
            deleteRsv.FlatAppearance.BorderSize = 0;
            deleteRsv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            deleteRsv.FlatStyle = FlatStyle.Flat;
            deleteRsv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteRsv.ForeColor = Color.Firebrick;
            deleteRsv.Location = new Point(0, 75);
            deleteRsv.Name = "deleteRsv";
            deleteRsv.Padding = new Padding(8, 0, 0, 0);
            deleteRsv.Size = new Size(234, 25);
            deleteRsv.TabIndex = 23;
            deleteRsv.Text = "Eliminar";
            deleteRsv.TextAlign = ContentAlignment.MiddleLeft;
            deleteRsv.UseVisualStyleBackColor = true;
            deleteRsv.Click += deleteRsv_Click;
            // 
            // editarRsv
            // 
            editarRsv.Dock = DockStyle.Top;
            editarRsv.FlatAppearance.BorderSize = 0;
            editarRsv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            editarRsv.FlatStyle = FlatStyle.Flat;
            editarRsv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarRsv.Location = new Point(0, 50);
            editarRsv.Name = "editarRsv";
            editarRsv.Padding = new Padding(8, 0, 0, 0);
            editarRsv.Size = new Size(234, 25);
            editarRsv.TabIndex = 22;
            editarRsv.Text = "Editar";
            editarRsv.TextAlign = ContentAlignment.MiddleLeft;
            editarRsv.UseVisualStyleBackColor = true;
            editarRsv.Click += editarRsv_Click;
            // 
            // addRsv
            // 
            addRsv.Dock = DockStyle.Top;
            addRsv.FlatAppearance.BorderSize = 0;
            addRsv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            addRsv.FlatStyle = FlatStyle.Flat;
            addRsv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addRsv.Location = new Point(0, 25);
            addRsv.Name = "addRsv";
            addRsv.Padding = new Padding(8, 0, 0, 0);
            addRsv.Size = new Size(234, 25);
            addRsv.TabIndex = 21;
            addRsv.Text = "Agregar ";
            addRsv.TextAlign = ContentAlignment.MiddleLeft;
            addRsv.UseVisualStyleBackColor = true;
            addRsv.Click += addRsv_Click;
            // 
            // mostrarRsv
            // 
            mostrarRsv.Dock = DockStyle.Top;
            mostrarRsv.FlatAppearance.BorderSize = 0;
            mostrarRsv.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            mostrarRsv.FlatStyle = FlatStyle.Flat;
            mostrarRsv.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mostrarRsv.Location = new Point(0, 0);
            mostrarRsv.Name = "mostrarRsv";
            mostrarRsv.Padding = new Padding(8, 0, 0, 0);
            mostrarRsv.Size = new Size(234, 25);
            mostrarRsv.TabIndex = 20;
            mostrarRsv.Text = "Listar";
            mostrarRsv.TextAlign = ContentAlignment.MiddleLeft;
            mostrarRsv.UseVisualStyleBackColor = true;
            mostrarRsv.Click += mostrarRsv_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.LightSeaGreen;
            btnReserva.Dock = DockStyle.Top;
            btnReserva.FlatAppearance.BorderColor = Color.DarkCyan;
            btnReserva.FlatAppearance.BorderSize = 2;
            btnReserva.FlatStyle = FlatStyle.Flat;
            btnReserva.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReserva.ForeColor = Color.White;
            btnReserva.Location = new Point(0, 651);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(234, 35);
            btnReserva.TabIndex = 21;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // panelHspdSubmenu
            // 
            panelHspdSubmenu.BackColor = Color.MediumTurquoise;
            panelHspdSubmenu.Controls.Add(deleteHspd);
            panelHspdSubmenu.Controls.Add(editarHspd);
            panelHspdSubmenu.Controls.Add(addHspd);
            panelHspdSubmenu.Controls.Add(mostrarHspd);
            panelHspdSubmenu.Dock = DockStyle.Top;
            panelHspdSubmenu.Location = new Point(0, 540);
            panelHspdSubmenu.Name = "panelHspdSubmenu";
            panelHspdSubmenu.Size = new Size(234, 111);
            panelHspdSubmenu.TabIndex = 20;
            // 
            // deleteHspd
            // 
            deleteHspd.Dock = DockStyle.Top;
            deleteHspd.FlatAppearance.BorderSize = 0;
            deleteHspd.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            deleteHspd.FlatStyle = FlatStyle.Flat;
            deleteHspd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteHspd.ForeColor = Color.Firebrick;
            deleteHspd.Location = new Point(0, 75);
            deleteHspd.Name = "deleteHspd";
            deleteHspd.Padding = new Padding(8, 0, 0, 0);
            deleteHspd.Size = new Size(234, 25);
            deleteHspd.TabIndex = 23;
            deleteHspd.Text = "Eliminar";
            deleteHspd.TextAlign = ContentAlignment.MiddleLeft;
            deleteHspd.UseVisualStyleBackColor = true;
            deleteHspd.Click += deleteHspd_Click;
            // 
            // editarHspd
            // 
            editarHspd.Dock = DockStyle.Top;
            editarHspd.FlatAppearance.BorderSize = 0;
            editarHspd.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            editarHspd.FlatStyle = FlatStyle.Flat;
            editarHspd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarHspd.Location = new Point(0, 50);
            editarHspd.Name = "editarHspd";
            editarHspd.Padding = new Padding(8, 0, 0, 0);
            editarHspd.Size = new Size(234, 25);
            editarHspd.TabIndex = 22;
            editarHspd.Text = "Editar";
            editarHspd.TextAlign = ContentAlignment.MiddleLeft;
            editarHspd.UseVisualStyleBackColor = true;
            editarHspd.Click += editarHspd_Click;
            // 
            // addHspd
            // 
            addHspd.Dock = DockStyle.Top;
            addHspd.FlatAppearance.BorderSize = 0;
            addHspd.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            addHspd.FlatStyle = FlatStyle.Flat;
            addHspd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addHspd.Location = new Point(0, 25);
            addHspd.Name = "addHspd";
            addHspd.Padding = new Padding(8, 0, 0, 0);
            addHspd.Size = new Size(234, 25);
            addHspd.TabIndex = 21;
            addHspd.Text = "Agregar ";
            addHspd.TextAlign = ContentAlignment.MiddleLeft;
            addHspd.UseVisualStyleBackColor = true;
            addHspd.Click += addHspd_Click;
            // 
            // mostrarHspd
            // 
            mostrarHspd.Dock = DockStyle.Top;
            mostrarHspd.FlatAppearance.BorderSize = 0;
            mostrarHspd.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            mostrarHspd.FlatStyle = FlatStyle.Flat;
            mostrarHspd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mostrarHspd.Location = new Point(0, 0);
            mostrarHspd.Name = "mostrarHspd";
            mostrarHspd.Padding = new Padding(8, 0, 0, 0);
            mostrarHspd.Size = new Size(234, 25);
            mostrarHspd.TabIndex = 20;
            mostrarHspd.Text = "Listar";
            mostrarHspd.TextAlign = ContentAlignment.MiddleLeft;
            mostrarHspd.UseVisualStyleBackColor = true;
            mostrarHspd.Click += mostrarHspd_Click;
            // 
            // btnHuesped
            // 
            btnHuesped.BackColor = Color.LightSeaGreen;
            btnHuesped.Dock = DockStyle.Top;
            btnHuesped.FlatAppearance.BorderColor = Color.DarkCyan;
            btnHuesped.FlatAppearance.BorderSize = 2;
            btnHuesped.FlatStyle = FlatStyle.Flat;
            btnHuesped.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuesped.ForeColor = Color.White;
            btnHuesped.Location = new Point(0, 505);
            btnHuesped.Name = "btnHuesped";
            btnHuesped.Size = new Size(234, 35);
            btnHuesped.TabIndex = 19;
            btnHuesped.Text = "Huesped";
            btnHuesped.UseVisualStyleBackColor = false;
            btnHuesped.Click += btnHuesped_Click;
            // 
            // panelTpHbtSubmenu
            // 
            panelTpHbtSubmenu.BackColor = Color.MediumTurquoise;
            panelTpHbtSubmenu.Controls.Add(deleteTpHbt);
            panelTpHbtSubmenu.Controls.Add(editarPrecioTpHbt);
            panelTpHbtSubmenu.Controls.Add(editarTpHbt);
            panelTpHbtSubmenu.Controls.Add(addTpHbt);
            panelTpHbtSubmenu.Controls.Add(mostrarTpHbt);
            panelTpHbtSubmenu.Dock = DockStyle.Top;
            panelTpHbtSubmenu.Location = new Point(0, 370);
            panelTpHbtSubmenu.Name = "panelTpHbtSubmenu";
            panelTpHbtSubmenu.Size = new Size(234, 135);
            panelTpHbtSubmenu.TabIndex = 18;
            // 
            // deleteTpHbt
            // 
            deleteTpHbt.Dock = DockStyle.Top;
            deleteTpHbt.FlatAppearance.BorderSize = 0;
            deleteTpHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            deleteTpHbt.FlatStyle = FlatStyle.Flat;
            deleteTpHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteTpHbt.ForeColor = Color.Firebrick;
            deleteTpHbt.Location = new Point(0, 100);
            deleteTpHbt.Name = "deleteTpHbt";
            deleteTpHbt.Padding = new Padding(8, 0, 0, 0);
            deleteTpHbt.Size = new Size(234, 25);
            deleteTpHbt.TabIndex = 23;
            deleteTpHbt.Text = "Elminar";
            deleteTpHbt.TextAlign = ContentAlignment.MiddleLeft;
            deleteTpHbt.UseVisualStyleBackColor = true;
            deleteTpHbt.Click += deleteTpHbt_Click;
            // 
            // editarPrecioTpHbt
            // 
            editarPrecioTpHbt.Dock = DockStyle.Top;
            editarPrecioTpHbt.FlatAppearance.BorderSize = 0;
            editarPrecioTpHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            editarPrecioTpHbt.FlatStyle = FlatStyle.Flat;
            editarPrecioTpHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarPrecioTpHbt.Location = new Point(0, 75);
            editarPrecioTpHbt.Name = "editarPrecioTpHbt";
            editarPrecioTpHbt.Padding = new Padding(8, 0, 0, 0);
            editarPrecioTpHbt.Size = new Size(234, 25);
            editarPrecioTpHbt.TabIndex = 22;
            editarPrecioTpHbt.Text = "Actualizar precio";
            editarPrecioTpHbt.TextAlign = ContentAlignment.MiddleLeft;
            editarPrecioTpHbt.UseVisualStyleBackColor = true;
            editarPrecioTpHbt.Click += editarPrecioTpHbt_Click;
            // 
            // editarTpHbt
            // 
            editarTpHbt.Dock = DockStyle.Top;
            editarTpHbt.FlatAppearance.BorderSize = 0;
            editarTpHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            editarTpHbt.FlatStyle = FlatStyle.Flat;
            editarTpHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            editarTpHbt.Location = new Point(0, 50);
            editarTpHbt.Name = "editarTpHbt";
            editarTpHbt.Padding = new Padding(8, 0, 0, 0);
            editarTpHbt.Size = new Size(234, 25);
            editarTpHbt.TabIndex = 21;
            editarTpHbt.Text = "Editar";
            editarTpHbt.TextAlign = ContentAlignment.MiddleLeft;
            editarTpHbt.UseVisualStyleBackColor = true;
            editarTpHbt.Click += editarTpHbt_Click;
            // 
            // addTpHbt
            // 
            addTpHbt.Dock = DockStyle.Top;
            addTpHbt.FlatAppearance.BorderSize = 0;
            addTpHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            addTpHbt.FlatStyle = FlatStyle.Flat;
            addTpHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTpHbt.Location = new Point(0, 25);
            addTpHbt.Name = "addTpHbt";
            addTpHbt.Padding = new Padding(8, 0, 0, 0);
            addTpHbt.Size = new Size(234, 25);
            addTpHbt.TabIndex = 20;
            addTpHbt.Text = "Agregar";
            addTpHbt.TextAlign = ContentAlignment.MiddleLeft;
            addTpHbt.UseVisualStyleBackColor = true;
            addTpHbt.Click += addTpHbt_Click;
            // 
            // mostrarTpHbt
            // 
            mostrarTpHbt.Dock = DockStyle.Top;
            mostrarTpHbt.FlatAppearance.BorderSize = 0;
            mostrarTpHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            mostrarTpHbt.FlatStyle = FlatStyle.Flat;
            mostrarTpHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mostrarTpHbt.Location = new Point(0, 0);
            mostrarTpHbt.Name = "mostrarTpHbt";
            mostrarTpHbt.Padding = new Padding(8, 0, 0, 0);
            mostrarTpHbt.Size = new Size(234, 25);
            mostrarTpHbt.TabIndex = 19;
            mostrarTpHbt.Text = "Listar";
            mostrarTpHbt.TextAlign = ContentAlignment.MiddleLeft;
            mostrarTpHbt.UseVisualStyleBackColor = true;
            mostrarTpHbt.Click += mostrarTpHbt_Click;
            // 
            // btnTpHbt
            // 
            btnTpHbt.BackColor = Color.LightSeaGreen;
            btnTpHbt.Dock = DockStyle.Top;
            btnTpHbt.FlatAppearance.BorderColor = Color.DarkCyan;
            btnTpHbt.FlatAppearance.BorderSize = 2;
            btnTpHbt.FlatStyle = FlatStyle.Flat;
            btnTpHbt.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTpHbt.ForeColor = Color.White;
            btnTpHbt.Location = new Point(0, 335);
            btnTpHbt.Name = "btnTpHbt";
            btnTpHbt.Size = new Size(234, 35);
            btnTpHbt.TabIndex = 17;
            btnTpHbt.Text = "Tipo de Habitacion";
            btnTpHbt.UseVisualStyleBackColor = false;
            btnTpHbt.Click += btnTpHbt_Click;
            // 
            // panelHbtSubmenu
            // 
            panelHbtSubmenu.BackColor = Color.MediumTurquoise;
            panelHbtSubmenu.Controls.Add(deleteHbt);
            panelHbtSubmenu.Controls.Add(altaHbt);
            panelHbtSubmenu.Controls.Add(editHbt);
            panelHbtSubmenu.Controls.Add(addHbt);
            panelHbtSubmenu.Controls.Add(mostrarHbt);
            panelHbtSubmenu.Dock = DockStyle.Top;
            panelHbtSubmenu.Location = new Point(0, 200);
            panelHbtSubmenu.Name = "panelHbtSubmenu";
            panelHbtSubmenu.Size = new Size(234, 135);
            panelHbtSubmenu.TabIndex = 16;
            // 
            // deleteHbt
            // 
            deleteHbt.Dock = DockStyle.Top;
            deleteHbt.FlatAppearance.BorderSize = 0;
            deleteHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            deleteHbt.FlatStyle = FlatStyle.Flat;
            deleteHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteHbt.ForeColor = Color.Firebrick;
            deleteHbt.Location = new Point(0, 100);
            deleteHbt.Name = "deleteHbt";
            deleteHbt.Padding = new Padding(8, 0, 0, 0);
            deleteHbt.Size = new Size(234, 25);
            deleteHbt.TabIndex = 23;
            deleteHbt.Text = "Eliminar";
            deleteHbt.TextAlign = ContentAlignment.MiddleLeft;
            deleteHbt.UseVisualStyleBackColor = true;
            deleteHbt.Click += deleteHbt_Click;
            // 
            // altaHbt
            // 
            altaHbt.Dock = DockStyle.Top;
            altaHbt.FlatAppearance.BorderSize = 0;
            altaHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            altaHbt.FlatStyle = FlatStyle.Flat;
            altaHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            altaHbt.Location = new Point(0, 75);
            altaHbt.Name = "altaHbt";
            altaHbt.Padding = new Padding(8, 0, 0, 0);
            altaHbt.Size = new Size(234, 25);
            altaHbt.TabIndex = 22;
            altaHbt.Text = "Dar de alta o baja";
            altaHbt.TextAlign = ContentAlignment.MiddleLeft;
            altaHbt.UseVisualStyleBackColor = true;
            altaHbt.Click += altaHbt_Click;
            // 
            // editHbt
            // 
            editHbt.Dock = DockStyle.Top;
            editHbt.FlatAppearance.BorderSize = 0;
            editHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            editHbt.FlatStyle = FlatStyle.Flat;
            editHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            editHbt.Location = new Point(0, 50);
            editHbt.Name = "editHbt";
            editHbt.Padding = new Padding(8, 0, 0, 0);
            editHbt.Size = new Size(234, 25);
            editHbt.TabIndex = 20;
            editHbt.Text = "Editar ";
            editHbt.TextAlign = ContentAlignment.MiddleLeft;
            editHbt.UseVisualStyleBackColor = true;
            editHbt.Click += editHbt_Click;
            // 
            // addHbt
            // 
            addHbt.Dock = DockStyle.Top;
            addHbt.FlatAppearance.BorderSize = 0;
            addHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            addHbt.FlatStyle = FlatStyle.Flat;
            addHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addHbt.Location = new Point(0, 25);
            addHbt.Name = "addHbt";
            addHbt.Padding = new Padding(8, 0, 0, 0);
            addHbt.Size = new Size(234, 25);
            addHbt.TabIndex = 19;
            addHbt.Text = "Agregar";
            addHbt.TextAlign = ContentAlignment.MiddleLeft;
            addHbt.UseVisualStyleBackColor = true;
            addHbt.Click += addHbt_Click;
            // 
            // mostrarHbt
            // 
            mostrarHbt.Dock = DockStyle.Top;
            mostrarHbt.FlatAppearance.BorderSize = 0;
            mostrarHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            mostrarHbt.FlatStyle = FlatStyle.Flat;
            mostrarHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mostrarHbt.Location = new Point(0, 0);
            mostrarHbt.Name = "mostrarHbt";
            mostrarHbt.Padding = new Padding(8, 0, 0, 0);
            mostrarHbt.Size = new Size(234, 25);
            mostrarHbt.TabIndex = 18;
            mostrarHbt.Text = "Listar";
            mostrarHbt.TextAlign = ContentAlignment.MiddleLeft;
            mostrarHbt.UseVisualStyleBackColor = true;
            mostrarHbt.Click += mostrarHbt_Click;
            // 
            // btnHabitacion
            // 
            btnHabitacion.BackColor = Color.LightSeaGreen;
            btnHabitacion.Dock = DockStyle.Top;
            btnHabitacion.FlatAppearance.BorderColor = Color.DarkCyan;
            btnHabitacion.FlatAppearance.BorderSize = 2;
            btnHabitacion.FlatStyle = FlatStyle.Flat;
            btnHabitacion.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHabitacion.ForeColor = Color.White;
            btnHabitacion.Location = new Point(0, 165);
            btnHabitacion.Name = "btnHabitacion";
            btnHabitacion.Size = new Size(234, 35);
            btnHabitacion.TabIndex = 15;
            btnHabitacion.Text = "Habitacion";
            btnHabitacion.UseVisualStyleBackColor = false;
            btnHabitacion.Click += btnHabitacion_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 68);
            panel5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(132, 35);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 9;
            label6.Text = "CRUD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 35);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 8;
            label3.Text = "Opciones";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 97);
            panel2.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSeaGreen;
            panel7.Location = new Point(-2, 72);
            panel7.Name = "panel7";
            panel7.Size = new Size(253, 10);
            panel7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 32);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 5;
            label4.Text = "Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 12);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Bienvenido";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(251, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 100);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(0, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(859, 10);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(375, 213);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(135, 128);
            label1.TabIndex = 0;
            label1.Text = "ⵥ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.White;
            panelChildForm.Controls.Add(label1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(251, 100);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(859, 620);
            panelChildForm.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1110, 720);
            Controls.Add(panelChildForm);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelSrvSubmenu.ResumeLayout(false);
            panelRsvSubmenu.ResumeLayout(false);
            panelHspdSubmenu.ResumeLayout(false);
            panelTpHbtSubmenu.ResumeLayout(false);
            panelHbtSubmenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Panel panel5;
        private Panel panelHbtSubmenu;
        private Button btnHabitacion;
        private Label label6;
        private Label label3;
        private Button mostrarHbt;
        private Panel panelHspdSubmenu;
        private Button deleteHspd;
        private Button editarHspd;
        private Button addHspd;
        private Button mostrarHspd;
        private Button btnHuesped;
        private Panel panelTpHbtSubmenu;
        private Button deleteTpHbt;
        private Button editarPrecioTpHbt;
        private Button editarTpHbt;
        private Button addTpHbt;
        private Button mostrarTpHbt;
        private Button btnTpHbt;
        private Button deleteHbt;
        private Button altaHbt;
        private Button editHbt;
        private Button addHbt;
        private Label label1;
        private Panel panelChildForm;
        private Panel panel4;
        private Panel panelRsvSubmenu;
        private Button deleteRsv;
        private Button editarRsv;
        private Button addRsv;
        private Button mostrarRsv;
        private Button btnReserva;
        private Panel panelSrvSubmenu;
        private Button deleteSrv;
        private Button editarSrv;
        private Button addSrv;
        private Button mostrarSrv;
        private Button btnServicio;
        private Panel panel7;
    }
}