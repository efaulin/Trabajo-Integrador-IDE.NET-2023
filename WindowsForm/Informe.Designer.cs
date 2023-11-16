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
            label1 = new Label();
            panel1 = new Panel();
            btnEmitir = new Button();
            dtpHasta = new DateTimePicker();
            label3 = new Label();
            dtpDesde = new DateTimePicker();
            label2 = new Label();
            dgvInforme = new DataGridView();
            btnPdf = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 51);
            label1.Name = "label1";
            label1.Size = new Size(592, 21);
            label1.TabIndex = 5;
            label1.Text = "Ingrese el rango de fechas sobre el cual desea emitir el informe de recaudacion:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnEmitir);
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(37, 84);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 82);
            panel1.TabIndex = 7;
            // 
            // btnEmitir
            // 
            btnEmitir.BackColor = Color.LightSeaGreen;
            btnEmitir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
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
            dgvInforme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Location = new Point(37, 199);
            dgvInforme.Margin = new Padding(3, 2, 3, 2);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.ReadOnly = true;
            dgvInforme.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvInforme.RowTemplate.Height = 29;
            dgvInforme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInforme.Size = new Size(896, 275);
            dgvInforme.TabIndex = 8;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.LightSeaGreen;
            btnPdf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.Location = new Point(809, 485);
            btnPdf.Margin = new Padding(3, 2, 3, 2);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(122, 32);
            btnPdf.TabIndex = 9;
            btnPdf.Text = "Descargar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // Informe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(957, 526);
            Controls.Add(btnPdf);
            Controls.Add(dgvInforme);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Informe";
            Text = "Informe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtpHasta;
        private Label label3;
        private DateTimePicker dtpDesde;
        private Label label2;
        private Button btnEmitir;
        private DataGridView dgvInforme;
        private Button btnPdf;
    }
}