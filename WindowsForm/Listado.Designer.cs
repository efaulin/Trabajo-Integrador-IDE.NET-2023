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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panelHspdSubmenu = new Panel();
            deleteHspd = new Button();
            editarHspd = new Button();
            addHspd = new Button();
            mostrarHspd = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            mostrarHbt = new Button();
            btnHuesped = new Button();
            panelTpHbtSubmenu = new Panel();
            deleteTpHbt = new Button();
            editarPrecioTpHbt = new Button();
            editarTpHbt = new Button();
            addTpHbt = new Button();
            mostrarTpHbt = new Button();
            deleteHbt = new Button();
            altaHbt = new Button();
            bajaHbt = new Button();
            editHbt = new Button();
            addHbt = new Button();
            btnTpHbt = new Button();
            panelHbtSubmenu = new Panel();
            btnHabitacion = new Button();
            panel5 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            toolStripContainer1 = new ToolStripContainer();
            tlHabitaciones = new TableLayoutPanel();
            dgvHabitaciones = new DataGridView();
            btnActualizar = new Button();
            btnSalir = new Button();
            panel3.SuspendLayout();
            panelHspdSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTpHbtSubmenu.SuspendLayout();
            panelHbtSubmenu.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tlHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(251, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(808, 97);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(294, 43);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 0;
            label5.Text = "Listado Habitaciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 47);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 5;
            label4.Text = "Administrador";
            // 
            // panelHspdSubmenu
            // 
            panelHspdSubmenu.BackColor = Color.MediumTurquoise;
            panelHspdSubmenu.Controls.Add(deleteHspd);
            panelHspdSubmenu.Controls.Add(editarHspd);
            panelHspdSubmenu.Controls.Add(addHspd);
            panelHspdSubmenu.Controls.Add(mostrarHspd);
            panelHspdSubmenu.Dock = DockStyle.Top;
            panelHspdSubmenu.Location = new Point(0, 566);
            panelHspdSubmenu.Name = "panelHspdSubmenu";
            panelHspdSubmenu.Size = new Size(251, 111);
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
            deleteHspd.Size = new Size(251, 25);
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
            editarHspd.Size = new Size(251, 25);
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
            addHspd.Size = new Size(251, 25);
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
            mostrarHspd.Size = new Size(251, 25);
            mostrarHspd.TabIndex = 20;
            mostrarHspd.Text = "Listar";
            mostrarHspd.TextAlign = ContentAlignment.MiddleLeft;
            mostrarHspd.UseVisualStyleBackColor = true;
            mostrarHspd.Click += mostrarHspd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(82, 23);
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
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 8;
            label3.Text = "Opciones";
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
            mostrarHbt.Size = new Size(251, 25);
            mostrarHbt.TabIndex = 18;
            mostrarHbt.Text = "Listar";
            mostrarHbt.TextAlign = ContentAlignment.MiddleLeft;
            mostrarHbt.UseVisualStyleBackColor = true;
            mostrarHbt.Click += mostrarHbt_Click;
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
            btnHuesped.Location = new Point(0, 531);
            btnHuesped.Name = "btnHuesped";
            btnHuesped.Size = new Size(251, 35);
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
            panelTpHbtSubmenu.Location = new Point(0, 396);
            panelTpHbtSubmenu.Name = "panelTpHbtSubmenu";
            panelTpHbtSubmenu.Size = new Size(251, 135);
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
            deleteTpHbt.Size = new Size(251, 25);
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
            editarPrecioTpHbt.Size = new Size(251, 25);
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
            editarTpHbt.Size = new Size(251, 25);
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
            addTpHbt.Size = new Size(251, 25);
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
            mostrarTpHbt.Size = new Size(251, 25);
            mostrarTpHbt.TabIndex = 19;
            mostrarTpHbt.Text = "Listar";
            mostrarTpHbt.TextAlign = ContentAlignment.MiddleLeft;
            mostrarTpHbt.UseVisualStyleBackColor = true;
            mostrarTpHbt.Click += mostrarTpHbt_Click;
            // 
            // deleteHbt
            // 
            deleteHbt.Dock = DockStyle.Top;
            deleteHbt.FlatAppearance.BorderSize = 0;
            deleteHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            deleteHbt.FlatStyle = FlatStyle.Flat;
            deleteHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteHbt.ForeColor = Color.Firebrick;
            deleteHbt.Location = new Point(0, 125);
            deleteHbt.Name = "deleteHbt";
            deleteHbt.Padding = new Padding(8, 0, 0, 0);
            deleteHbt.Size = new Size(251, 25);
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
            altaHbt.Location = new Point(0, 100);
            altaHbt.Name = "altaHbt";
            altaHbt.Padding = new Padding(8, 0, 0, 0);
            altaHbt.Size = new Size(251, 25);
            altaHbt.TabIndex = 22;
            altaHbt.Text = "Dar de alta";
            altaHbt.TextAlign = ContentAlignment.MiddleLeft;
            altaHbt.UseVisualStyleBackColor = true;
            altaHbt.Click += altaHbt_Click;
            // 
            // bajaHbt
            // 
            bajaHbt.Dock = DockStyle.Top;
            bajaHbt.FlatAppearance.BorderSize = 0;
            bajaHbt.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            bajaHbt.FlatStyle = FlatStyle.Flat;
            bajaHbt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bajaHbt.Location = new Point(0, 75);
            bajaHbt.Name = "bajaHbt";
            bajaHbt.Padding = new Padding(8, 0, 0, 0);
            bajaHbt.Size = new Size(251, 25);
            bajaHbt.TabIndex = 21;
            bajaHbt.Text = "Dar de baja";
            bajaHbt.TextAlign = ContentAlignment.MiddleLeft;
            bajaHbt.UseVisualStyleBackColor = true;
            bajaHbt.Click += bajaHbt_Click;
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
            editHbt.Size = new Size(251, 25);
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
            addHbt.Size = new Size(251, 25);
            addHbt.TabIndex = 19;
            addHbt.Text = "Agregar";
            addHbt.TextAlign = ContentAlignment.MiddleLeft;
            addHbt.UseVisualStyleBackColor = true;
            addHbt.Click += addHbt_Click;
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
            btnTpHbt.Location = new Point(0, 361);
            btnTpHbt.Name = "btnTpHbt";
            btnTpHbt.Size = new Size(251, 35);
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
            panelHbtSubmenu.Controls.Add(bajaHbt);
            panelHbtSubmenu.Controls.Add(editHbt);
            panelHbtSubmenu.Controls.Add(addHbt);
            panelHbtSubmenu.Controls.Add(mostrarHbt);
            panelHbtSubmenu.Dock = DockStyle.Top;
            panelHbtSubmenu.Location = new Point(0, 200);
            panelHbtSubmenu.Name = "panelHbtSubmenu";
            panelHbtSubmenu.Size = new Size(251, 161);
            panelHbtSubmenu.TabIndex = 16;
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
            btnHabitacion.Size = new Size(251, 35);
            btnHabitacion.TabIndex = 15;
            btnHabitacion.Text = "Habitacion";
            btnHabitacion.UseVisualStyleBackColor = false;
            btnHabitacion.Click += btnHabitacion_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 68);
            panel5.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 97);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 27);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Bienvenido";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.DarkCyan;
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
            panel1.Size = new Size(251, 717);
            panel1.TabIndex = 5;
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
            toolStripContainer1.ContentPanel.Size = new Size(808, 595);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(251, 97);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(808, 620);
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
            tlHabitaciones.Size = new Size(808, 595);
            tlHabitaciones.TabIndex = 0;
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.AllowUserToResizeColumns = false;
            dgvHabitaciones.AllowUserToResizeRows = false;
            dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlHabitaciones.SetColumnSpan(dgvHabitaciones, 2);
            dgvHabitaciones.Dock = DockStyle.Fill;
            dgvHabitaciones.Location = new Point(3, 3);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.ReadOnly = true;
            dgvHabitaciones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHabitaciones.RowTemplate.Height = 25;
            dgvHabitaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHabitaciones.Size = new Size(802, 560);
            dgvHabitaciones.TabIndex = 0;
            dgvHabitaciones.CellContentClick += dgvHabitaciones_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(649, 569);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(730, 569);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1059, 717);
            Controls.Add(toolStripContainer1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            MinimumSize = new Size(950, 600);
            Name = "Listado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Habitaciones";
            Load += ListarHbt_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelHspdSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTpHbtSubmenu.ResumeLayout(false);
            panelHbtSubmenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tlHabitaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label4;
        private Panel panelHspdSubmenu;
        private Button deleteHspd;
        private Button editarHspd;
        private Button addHspd;
        private Button mostrarHspd;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label3;
        private Button mostrarHbt;
        private Button btnHuesped;
        private Panel panelTpHbtSubmenu;
        private Button deleteTpHbt;
        private Button editarPrecioTpHbt;
        private Button editarTpHbt;
        private Button addTpHbt;
        private Button mostrarTpHbt;
        private Button deleteHbt;
        private Button altaHbt;
        private Button bajaHbt;
        private Button editHbt;
        private Button addHbt;
        private Button btnTpHbt;
        private Panel panelHbtSubmenu;
        private Button btnHabitacion;
        private Panel panel5;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tlHabitaciones;
        private DataGridView dgvHabitaciones;
        private Button btnActualizar;
        private Button btnSalir;
    }
}