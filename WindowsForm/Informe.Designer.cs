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
            dtpHasta = new DateTimePicker();
            label3 = new Label();
            dtpDesde = new DateTimePicker();
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
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(957, 75);
            panel3.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(957, 75);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Informe de recaudación";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Location = new Point(0, 54);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1534, 8);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(37, 92);
            label1.Name = "label1";
            label1.Size = new Size(404, 82);
            label1.TabIndex = 5;
            label1.Text = "Ingrese el rango de fechas sobre el cual desea emitir el informe:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnEmitir);
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(446, 92);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 82);
            panel1.TabIndex = 7;
            // 
            // btnEmitir
            // 
            btnEmitir.BackColor = Color.LightSeaGreen;
            btnEmitir.Location = new Point(368, 11);
            btnEmitir.Margin = new Padding(3, 2, 3, 2);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new Size(100, 46);
            btnEmitir.TabIndex = 4;
            btnEmitir.Text = "Emitir";
            btnEmitir.UseVisualStyleBackColor = false;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(66, 46);
            dtpHasta.Margin = new Padding(3, 2, 3, 2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(274, 23);
            dtpHasta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 50);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Hasta";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(66, 8);
            dtpDesde.Margin = new Padding(3, 2, 3, 2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(274, 23);
            dtpDesde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Desde";
            // 
            // dgvInforme
            // 
            dgvInforme.AllowUserToAddRows = false;
            dgvInforme.AllowUserToDeleteRows = false;
            dgvInforme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(37, 199);
            dgvInforme.Margin = new Padding(3, 2, 3, 2);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.ReadOnly = true;
            dgvInforme.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvInforme.RowTemplate.Height = 29;
            dgvInforme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInforme.Size = new Size(896, 248);
            dgvInforme.TabIndex = 8;
            // 
            // Informe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 491);
            Controls.Add(dgvInforme);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dtpHasta;
        private Label label3;
        private DateTimePicker dtpDesde;
        private Label label2;
        private Button btnEmitir;
        private DataGridView dgvInforme;
    }
}