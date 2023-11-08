namespace WindowsForm
{
    partial class IniciarSesion
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(46, 58);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 21;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 19);
            label1.TabIndex = 22;
            label1.Text = "Ingrese sus credenciales para entrar al sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 23;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(113, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(175, 23);
            txtUsuario.TabIndex = 24;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(113, 81);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(175, 23);
            txtContraseña.TabIndex = 25;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.KeyPress += iniciarSesion_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkCyan;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(12, 135);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(332, 30);
            btnIngresar.TabIndex = 26;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 183);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "IniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IniciarSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
    }
}