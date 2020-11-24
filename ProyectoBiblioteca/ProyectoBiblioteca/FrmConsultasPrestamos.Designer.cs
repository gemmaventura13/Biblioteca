namespace ProyectoBiblioteca
{
    partial class FrmConsultasPrestamos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionesLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(40, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(512, 27);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "ESCRIBE EL FOLIO DEL PRÉSTAMO O NOMBRE DEL CLIENTE";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(587, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrestamo.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.NombreCliente,
            this.NombreLibro,
            this.FechaRetiro,
            this.FechaDevolucion,
            this.CondicionesLibro});
            this.dgvPrestamo.EnableHeadersVisualStyles = false;
            this.dgvPrestamo.Location = new System.Drawing.Point(40, 105);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.RowHeadersVisible = false;
            this.dgvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamo.Size = new System.Drawing.Size(651, 432);
            this.dgvPrestamo.TabIndex = 3;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "FOLIO";
            this.Folio.Name = "Folio";
            this.Folio.Width = 63;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "NOMBRE DEL CLIENTE";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 96;
            // 
            // NombreLibro
            // 
            this.NombreLibro.HeaderText = "NOMBRE DEL LIBRO";
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Width = 96;
            // 
            // FechaRetiro
            // 
            this.FechaRetiro.HeaderText = "FECHA DE RETIRO";
            this.FechaRetiro.Name = "FechaRetiro";
            this.FechaRetiro.Width = 114;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.HeaderText = "FECHA DE DEVOLUCIÓN";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Width = 143;
            // 
            // CondicionesLibro
            // 
            this.CondicionesLibro.HeaderText = "CONDICIONES DEL LIBRO";
            this.CondicionesLibro.Name = "CondicionesLibro";
            this.CondicionesLibro.Width = 122;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(734, 149);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 38);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(734, 105);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 38);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "RECARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmConsultasPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(878, 574);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmConsultasPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAS PRÉSTAMOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionesLibro;
        private System.Windows.Forms.Button btnCargar;
    }
}

