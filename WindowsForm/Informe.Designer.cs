namespace WindowsForm
{
    partial class Informe
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
            panel3 = new Panel();
            lblTitulo = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnEmitir = new Button();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dgvInforme = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(lblTitulo);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 100);
            panel3.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1094, 100);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Informe de recaudación";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Location = new Point(0, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(1753, 10);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(42, 123);
            label1.Name = "label1";
            label1.Size = new Size(462, 110);
            label1.TabIndex = 5;
            label1.Text = "Ingrese el rango de fechas sobre el cual desea emitir el informe:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnEmitir);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(510, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 110);
            panel1.TabIndex = 7;
            // 
            // btnEmitir
            // 
            btnEmitir.BackColor = Color.LightSeaGreen;
            btnEmitir.Location = new Point(420, 15);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(114, 61);
            btnEmitir.TabIndex = 4;
            btnEmitir.Text = "Emitir";
            btnEmitir.UseVisualStyleBackColor = false;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(75, 62);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(312, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 67);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "Desde";
            // 
            // dgvInforme
            // 
            dgvInforme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(42, 265);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.RowHeadersWidth = 51;
            dgvInforme.RowTemplate.Height = 29;
            dgvInforme.Size = new Size(1024, 331);
            dgvInforme.TabIndex = 8;
            // 
            // Informe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 655);
            Controls.Add(dgvInforme);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Name = "Informe";
            Text = "Informe";
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private Label lblTitulo;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button btnEmitir;
        private DataGridView dgvInforme;
    }
}