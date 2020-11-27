namespace ProyectoBiblioteca
{
    partial class FrmPrestamos
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
            this.TxtNombreLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Labelxd = new System.Windows.Forms.Label();
            this.FechaSelector = new System.Windows.Forms.DateTimePicker();
            this.IdUsuario = new System.Windows.Forms.Label();
            this.TxtIdLibro = new System.Windows.Forms.TextBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.Labelxd2 = new System.Windows.Forms.Label();
            this.TxtNumPrestamo = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombreLibro
            // 
            this.TxtNombreLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreLibro.Location = new System.Drawing.Point(306, 227);
            this.TxtNombreLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreLibro.Name = "TxtNombreLibro";
            this.TxtNombreLibro.Size = new System.Drawing.Size(344, 36);
            this.TxtNombreLibro.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 40);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre del Libro:";
            // 
            // TxtNomCli
            // 
            this.TxtNomCli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomCli.Location = new System.Drawing.Point(388, 79);
            this.TxtNomCli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNomCli.Name = "TxtNomCli";
            this.TxtNomCli.Size = new System.Drawing.Size(468, 36);
            this.TxtNomCli.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // Labelxd
            // 
            this.Labelxd.AutoSize = true;
            this.Labelxd.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd.ForeColor = System.Drawing.Color.White;
            this.Labelxd.Location = new System.Drawing.Point(34, 184);
            this.Labelxd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelxd.Name = "Labelxd";
            this.Labelxd.Size = new System.Drawing.Size(241, 40);
            this.Labelxd.TabIndex = 31;
            this.Labelxd.Text = "Num. Prestamo:";
            // 
            // FechaSelector
            // 
            this.FechaSelector.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSelector.Location = new System.Drawing.Point(953, 79);
            this.FechaSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaSelector.Name = "FechaSelector";
            this.FechaSelector.Size = new System.Drawing.Size(298, 36);
            this.FechaSelector.TabIndex = 39;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSize = true;
            this.IdUsuario.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario.ForeColor = System.Drawing.Color.White;
            this.IdUsuario.Location = new System.Drawing.Point(34, 36);
            this.IdUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(158, 40);
            this.IdUsuario.TabIndex = 32;
            this.IdUsuario.Text = "Id Cliente:";
            this.IdUsuario.Click += new System.EventHandler(this.IdUsuario_Click);
            // 
            // TxtIdLibro
            // 
            this.TxtIdLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdLibro.Location = new System.Drawing.Point(708, 227);
            this.TxtIdLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdLibro.Name = "TxtIdLibro";
            this.TxtIdLibro.Size = new System.Drawing.Size(148, 36);
            this.TxtIdLibro.TabIndex = 38;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCliente.Location = new System.Drawing.Point(42, 79);
            this.TxtIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(268, 36);
            this.TxtIdCliente.TabIndex = 37;
            // 
            // Labelxd2
            // 
            this.Labelxd2.AutoSize = true;
            this.Labelxd2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd2.ForeColor = System.Drawing.Color.White;
            this.Labelxd2.Location = new System.Drawing.Point(700, 184);
            this.Labelxd2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelxd2.Name = "Labelxd2";
            this.Labelxd2.Size = new System.Drawing.Size(140, 40);
            this.Labelxd2.TabIndex = 33;
            this.Labelxd2.Text = "Id. Libro:";
            // 
            // TxtNumPrestamo
            // 
            this.TxtNumPrestamo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumPrestamo.Location = new System.Drawing.Point(40, 227);
            this.TxtNumPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNumPrestamo.Name = "TxtNumPrestamo";
            this.TxtNumPrestamo.Size = new System.Drawing.Size(146, 36);
            this.TxtNumPrestamo.TabIndex = 36;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(951, 36);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(241, 40);
            this.Fecha.TabIndex = 34;
            this.Fecha.Text = "Fecha de Retiro:";
            // 
            // TxtHora
            // 
            this.TxtHora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHora.Location = new System.Drawing.Point(953, 227);
            this.TxtHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(148, 36);
            this.TxtHora.TabIndex = 58;
            this.TxtHora.TextChanged += new System.EventHandler(this.TxtHora_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(946, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 40);
            this.label3.TabIndex = 57;
            this.label3.Text = "Hora del Prestamo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1151, 521);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 58);
            this.btnSalir.TabIndex = 84;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1151, 440);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 58);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1151, 355);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 58);
            this.btnGuardar.TabIndex = 82;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NombreCliente,
            this.NumeroPrestamo,
            this.NombreLibro,
            this.IdLibro,
            this.HoraPrestamo,
            this.FechaRetiro});
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(42, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1023, 268);
            this.dataGridView1.TabIndex = 85;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id del Cliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // NumeroPrestamo
            // 
            this.NumeroPrestamo.HeaderText = "Numero del Prestamo";
            this.NumeroPrestamo.Name = "NumeroPrestamo";
            // 
            // NombreLibro
            // 
            this.NombreLibro.HeaderText = "Nombre del Libro";
            this.NombreLibro.Name = "NombreLibro";
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "Id del Libro";
            this.IdLibro.Name = "IdLibro";
            // 
            // HoraPrestamo
            // 
            this.HoraPrestamo.HeaderText = "Hora del Prestamo";
            this.HoraPrestamo.Name = "HoraPrestamo";
            // 
            // FechaRetiro
            // 
            this.FechaRetiro.HeaderText = "Fecha de Retiro";
            this.FechaRetiro.Name = "FechaRetiro";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1151, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 58);
            this.button1.TabIndex = 86;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1397, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Labelxd);
            this.Controls.Add(this.FechaSelector);
            this.Controls.Add(this.IdUsuario);
            this.Controls.Add(this.TxtIdLibro);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.Labelxd2);
            this.Controls.Add(this.TxtNumPrestamo);
            this.Controls.Add(this.Fecha);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRÉSTAMOS INTERNOS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombreLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelxd;
        private System.Windows.Forms.DateTimePicker FechaSelector;
        private System.Windows.Forms.Label IdUsuario;
        private System.Windows.Forms.TextBox TxtIdLibro;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label Labelxd2;
        private System.Windows.Forms.TextBox TxtNumPrestamo;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRetiro;
        private System.Windows.Forms.Button button1;
    }
}