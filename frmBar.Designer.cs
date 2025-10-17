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
            btnValidar = new Button();
            btnMozo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colMozo, colComida, colBebidaSinAlcohol, colBebidaConAlcohol, colPostres });
            dgvVentas.Location = new Point(32, 30);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(503, 171);
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
            // btnValidar
            // 
            btnValidar.Location = new Point(413, 224);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(122, 28);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozo
            // 
            btnMozo.Location = new Point(32, 313);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(122, 28);
            btnMozo.TabIndex = 2;
            btnMozo.Text = "Mozo del día";
            btnMozo.UseVisualStyleBackColor = true;
            // 
            // frmBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 434);
            Controls.Add(btnMozo);
            Controls.Add(btnValidar);
            Controls.Add(dgvVentas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBar";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnValidar;
        private Button btnMozo;
    }
}