namespace WindowsForm
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btnServicio = new Button();
            btnReserva = new Button();
            btnHuesped = new Button();
            btnTpHbt = new Button();
            btnHabitacion = new Button();
            panel5 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(btnServicio);
            panel1.Controls.Add(btnReserva);
            panel1.Controls.Add(btnHuesped);
            panel1.Controls.Add(btnTpHbt);
            panel1.Controls.Add(btnHabitacion);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 720);
            panel1.TabIndex = 2;
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
            btnServicio.Location = new Point(0, 305);
            btnServicio.Name = "btnServicio";
            btnServicio.Size = new Size(251, 35);
            btnServicio.TabIndex = 23;
            btnServicio.Text = "Servicio";
            btnServicio.UseVisualStyleBackColor = false;
            btnServicio.Click += btnServicio_Click;
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
            btnReserva.Location = new Point(0, 270);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(251, 35);
            btnReserva.TabIndex = 21;
            btnReserva.Text = "Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
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
            btnHuesped.Location = new Point(0, 235);
            btnHuesped.Name = "btnHuesped";
            btnHuesped.Size = new Size(251, 35);
            btnHuesped.TabIndex = 19;
            btnHuesped.Text = "Huesped";
            btnHuesped.UseVisualStyleBackColor = false;
            btnHuesped.Click += btnHuesped_Click;
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
            btnTpHbt.Location = new Point(0, 200);
            btnTpHbt.Name = "btnTpHbt";
            btnTpHbt.Size = new Size(251, 35);
            btnTpHbt.TabIndex = 17;
            btnTpHbt.Text = "Tipo de Habitacion";
            btnTpHbt.UseVisualStyleBackColor = false;
            btnTpHbt.Click += btnTpHbt_Click;
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
            btnHabitacion.Click += btnHabitacion_Click_1;
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
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 97);
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
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.DarkCyan;
            lblNombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(96, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 21);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Administrador";
            lblNombre.Click += lblNombre_Click;
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
            // Menu
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
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
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

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblNombre;
        private Label label2;
        private Panel panel5;
        private Button btnHabitacion;
        private Label label6;
        private Label label3;
        private Button btnHuesped;
        private Button btnTpHbt;
        private Label label1;
        private Panel panelChildForm;
        private Panel panel4;
        private Button btnReserva;
        private Button btnServicio;
        private Panel panel7;
    }
}