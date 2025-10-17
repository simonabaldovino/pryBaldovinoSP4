namespace pryBaldovinoSP4
{
    partial class frmBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBar));
            dgvVentas = new DataGridView();
            colMozo = new DataGridViewTextBoxColumn();
            colComida = new DataGridViewTextBoxColumn();
            colBebidaSinAlcohol = new DataGridViewTextBoxColumn();
            colBebidaConAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colMozo, colComida, colBebidaSinAlcohol, colBebidaConAlcohol, colPostres });
            dgvVentas.Location = new Point(32, 30);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(544, 348);
            dgvVentas.TabIndex = 0;
            // 
            // colMozo
            // 
            colMozo.HeaderText = "Mozo";
            colMozo.Name = "colMozo";
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebidaSinAlcohol
            // 
            colBebidaSinAlcohol.HeaderText = "Bebida sin alcohol";
            colBebidaSinAlcohol.Name = "colBebidaSinAlcohol";
            // 
            // colBebidaConAlcohol
            // 
            colBebidaConAlcohol.HeaderText = "Bebida con Alcohol";
            colBebidaConAlcohol.Name = "colBebidaConAlcohol";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // frmBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(dgvVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBar";
            Text = "Bar La Milanga -Registro de ventas diarias";
            Load += frmBar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colMozo;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebidaSinAlcohol;
        private DataGridViewTextBoxColumn colBebidaConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
    }
}