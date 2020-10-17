namespace ProyectoBiblioteca
{
    partial class FrmPrestamosInternos
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
            this.groupDevolucion = new System.Windows.Forms.GroupBox();
            this.Devolucion = new System.Windows.Forms.Label();
            this.NoDevolucion = new System.Windows.Forms.RadioButton();
            this.SiDevolucion = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombreLibro
            // 
            this.TxtNombreLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreLibro.Location = new System.Drawing.Point(228, 146);
            this.TxtNombreLibro.Name = "TxtNombreLibro";
            this.TxtNombreLibro.Size = new System.Drawing.Size(231, 27);
            this.TxtNombreLibro.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre del Libro:";
            // 
            // TxtNomCli
            // 
            this.TxtNomCli.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomCli.Location = new System.Drawing.Point(283, 50);
            this.TxtNomCli.Name = "TxtNomCli";
            this.TxtNomCli.Size = new System.Drawing.Size(313, 27);
            this.TxtNomCli.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // Labelxd
            // 
            this.Labelxd.AutoSize = true;
            this.Labelxd.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd.ForeColor = System.Drawing.Color.White;
            this.Labelxd.Location = new System.Drawing.Point(47, 118);
            this.Labelxd.Name = "Labelxd";
            this.Labelxd.Size = new System.Drawing.Size(159, 25);
            this.Labelxd.TabIndex = 31;
            this.Labelxd.Text = "Num. Prestamo:";
            // 
            // FechaSelector
            // 
            this.FechaSelector.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSelector.Location = new System.Drawing.Point(51, 249);
            this.FechaSelector.Name = "FechaSelector";
            this.FechaSelector.Size = new System.Drawing.Size(200, 27);
            this.FechaSelector.TabIndex = 39;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSize = true;
            this.IdUsuario.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUsuario.ForeColor = System.Drawing.Color.White;
            this.IdUsuario.Location = new System.Drawing.Point(47, 22);
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Size = new System.Drawing.Size(103, 25);
            this.IdUsuario.TabIndex = 32;
            this.IdUsuario.Text = "Id Cliente:";
            this.IdUsuario.Click += new System.EventHandler(this.IdUsuario_Click);
            // 
            // TxtIdLibro
            // 
            this.TxtIdLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdLibro.Location = new System.Drawing.Point(496, 146);
            this.TxtIdLibro.Name = "TxtIdLibro";
            this.TxtIdLibro.Size = new System.Drawing.Size(100, 27);
            this.TxtIdLibro.TabIndex = 38;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdCliente.Location = new System.Drawing.Point(52, 50);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(180, 27);
            this.TxtIdCliente.TabIndex = 37;
            // 
            // Labelxd2
            // 
            this.Labelxd2.AutoSize = true;
            this.Labelxd2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd2.ForeColor = System.Drawing.Color.White;
            this.Labelxd2.Location = new System.Drawing.Point(491, 118);
            this.Labelxd2.Name = "Labelxd2";
            this.Labelxd2.Size = new System.Drawing.Size(93, 25);
            this.Labelxd2.TabIndex = 33;
            this.Labelxd2.Text = "Id. Libro:";
            // 
            // TxtNumPrestamo
            // 
            this.TxtNumPrestamo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumPrestamo.Location = new System.Drawing.Point(51, 146);
            this.TxtNumPrestamo.Name = "TxtNumPrestamo";
            this.TxtNumPrestamo.Size = new System.Drawing.Size(99, 27);
            this.TxtNumPrestamo.TabIndex = 36;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(49, 221);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(157, 25);
            this.Fecha.TabIndex = 34;
            this.Fecha.Text = "Fecha de Retiro:";
            // 
            // TxtHora
            // 
            this.TxtHora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHora.Location = new System.Drawing.Point(294, 249);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(100, 27);
            this.TxtHora.TabIndex = 58;
            this.TxtHora.TextChanged += new System.EventHandler(this.TxtHora_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Hora del Prestamo";
            // 
            // groupDevolucion
            // 
            this.groupDevolucion.Controls.Add(this.Devolucion);
            this.groupDevolucion.Controls.Add(this.NoDevolucion);
            this.groupDevolucion.Controls.Add(this.SiDevolucion);
            this.groupDevolucion.Location = new System.Drawing.Point(51, 298);
            this.groupDevolucion.Name = "groupDevolucion";
            this.groupDevolucion.Size = new System.Drawing.Size(180, 112);
            this.groupDevolucion.TabIndex = 85;
            this.groupDevolucion.TabStop = false;
            // 
            // Devolucion
            // 
            this.Devolucion.AutoSize = true;
            this.Devolucion.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devolucion.ForeColor = System.Drawing.Color.White;
            this.Devolucion.Location = new System.Drawing.Point(18, 19);
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.Size = new System.Drawing.Size(139, 25);
            this.Devolucion.TabIndex = 60;
            this.Devolucion.Text = "¿Se devolvió?:";
            // 
            // NoDevolucion
            // 
            this.NoDevolucion.AutoSize = true;
            this.NoDevolucion.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDevolucion.ForeColor = System.Drawing.Color.White;
            this.NoDevolucion.Location = new System.Drawing.Point(23, 74);
            this.NoDevolucion.Name = "NoDevolucion";
            this.NoDevolucion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoDevolucion.Size = new System.Drawing.Size(51, 25);
            this.NoDevolucion.TabIndex = 66;
            this.NoDevolucion.TabStop = true;
            this.NoDevolucion.Text = "No";
            this.NoDevolucion.UseVisualStyleBackColor = true;
            // 
            // SiDevolucion
            // 
            this.SiDevolucion.AutoSize = true;
            this.SiDevolucion.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiDevolucion.ForeColor = System.Drawing.Color.White;
            this.SiDevolucion.Location = new System.Drawing.Point(23, 45);
            this.SiDevolucion.Name = "SiDevolucion";
            this.SiDevolucion.Size = new System.Drawing.Size(41, 25);
            this.SiDevolucion.TabIndex = 65;
            this.SiDevolucion.TabStop = true;
            this.SiDevolucion.Text = "Sí";
            this.SiDevolucion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(405, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 38);
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
            this.btnCancelar.Location = new System.Drawing.Point(258, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 38);
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
            this.btnGuardar.Location = new System.Drawing.Point(111, 439);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 38);
            this.btnGuardar.TabIndex = 82;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPrestamosInternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(642, 499);
            this.Controls.Add(this.groupDevolucion);
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
            this.MaximizeBox = false;
            this.Name = "FrmPrestamosInternos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRÉSTAMOS INTERNOS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupDevolucion.ResumeLayout(false);
            this.groupDevolucion.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupDevolucion;
        private System.Windows.Forms.Label Devolucion;
        private System.Windows.Forms.RadioButton NoDevolucion;
        private System.Windows.Forms.RadioButton SiDevolucion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}