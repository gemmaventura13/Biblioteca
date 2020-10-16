namespace ProyectoBiblioteca
{
    partial class FrmPrestamosExternos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CondicionLibro = new System.Windows.Forms.ComboBox();
            this.TxtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreAlumno = new System.Windows.Forms.TextBox();
            this.Devolucion = new System.Windows.Forms.Label();
            this.NoDevolucion = new System.Windows.Forms.RadioButton();
            this.SiDevolucion = new System.Windows.Forms.RadioButton();
            this.Labelxd = new System.Windows.Forms.Label();
            this.FechaSelector = new System.Windows.Forms.DateTimePicker();
            this.TxtIdLibro = new System.Windows.Forms.TextBox();
            this.TxtCodigoControlAlumno = new System.Windows.Forms.TextBox();
            this.Labelxd2 = new System.Windows.Forms.Label();
            this.TxtNumPrestamo = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupDevolucion = new System.Windows.Forms.GroupBox();
            this.groupDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nombre del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "Codigo de control del cliente";
            // 
            // CondicionLibro
            // 
            this.CondicionLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondicionLibro.FormattingEnabled = true;
            this.CondicionLibro.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.CondicionLibro.Location = new System.Drawing.Point(608, 154);
            this.CondicionLibro.Name = "CondicionLibro";
            this.CondicionLibro.Size = new System.Drawing.Size(165, 27);
            this.CondicionLibro.TabIndex = 73;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(27, 241);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(345, 273);
            this.TxtObservaciones.TabIndex = 72;
            this.TxtObservaciones.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Observaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(603, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Condiciones del Libro:";
            // 
            // TxtNombreLibro
            // 
            this.TxtNombreLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreLibro.Location = new System.Drawing.Point(205, 154);
            this.TxtNombreLibro.Name = "TxtNombreLibro";
            this.TxtNombreLibro.Size = new System.Drawing.Size(231, 27);
            this.TxtNombreLibro.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre del Libro:";
            // 
            // TxtNombreAlumno
            // 
            this.TxtNombreAlumno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreAlumno.Location = new System.Drawing.Point(362, 65);
            this.TxtNombreAlumno.Name = "TxtNombreAlumno";
            this.TxtNombreAlumno.Size = new System.Drawing.Size(411, 27);
            this.TxtNombreAlumno.TabIndex = 67;
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
            // Labelxd
            // 
            this.Labelxd.AutoSize = true;
            this.Labelxd.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd.ForeColor = System.Drawing.Color.White;
            this.Labelxd.Location = new System.Drawing.Point(28, 126);
            this.Labelxd.Name = "Labelxd";
            this.Labelxd.Size = new System.Drawing.Size(159, 25);
            this.Labelxd.TabIndex = 57;
            this.Labelxd.Text = "Num. Prestamo:";
            // 
            // FechaSelector
            // 
            this.FechaSelector.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSelector.Location = new System.Drawing.Point(408, 241);
            this.FechaSelector.Name = "FechaSelector";
            this.FechaSelector.Size = new System.Drawing.Size(287, 27);
            this.FechaSelector.TabIndex = 64;
            // 
            // TxtIdLibro
            // 
            this.TxtIdLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdLibro.Location = new System.Drawing.Point(473, 154);
            this.TxtIdLibro.Name = "TxtIdLibro";
            this.TxtIdLibro.Size = new System.Drawing.Size(100, 27);
            this.TxtIdLibro.TabIndex = 63;
            // 
            // TxtCodigoControlAlumno
            // 
            this.TxtCodigoControlAlumno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoControlAlumno.Location = new System.Drawing.Point(34, 65);
            this.TxtCodigoControlAlumno.Name = "TxtCodigoControlAlumno";
            this.TxtCodigoControlAlumno.Size = new System.Drawing.Size(180, 27);
            this.TxtCodigoControlAlumno.TabIndex = 0;
            this.TxtCodigoControlAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoControlAlumno_KeyPress);
            // 
            // Labelxd2
            // 
            this.Labelxd2.AutoSize = true;
            this.Labelxd2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd2.ForeColor = System.Drawing.Color.White;
            this.Labelxd2.Location = new System.Drawing.Point(468, 126);
            this.Labelxd2.Name = "Labelxd2";
            this.Labelxd2.Size = new System.Drawing.Size(93, 25);
            this.Labelxd2.TabIndex = 58;
            this.Labelxd2.Text = "Id. Libro:";
            // 
            // TxtNumPrestamo
            // 
            this.TxtNumPrestamo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumPrestamo.Location = new System.Drawing.Point(33, 154);
            this.TxtNumPrestamo.Name = "TxtNumPrestamo";
            this.TxtNumPrestamo.Size = new System.Drawing.Size(99, 27);
            this.TxtNumPrestamo.TabIndex = 61;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(404, 213);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(157, 25);
            this.Fecha.TabIndex = 59;
            this.Fecha.Text = "Fecha de Retiro:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(396, 476);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 38);
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(543, 476);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 38);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(690, 476);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 38);
            this.btnSalir.TabIndex = 80;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupDevolucion
            // 
            this.groupDevolucion.Controls.Add(this.Devolucion);
            this.groupDevolucion.Controls.Add(this.NoDevolucion);
            this.groupDevolucion.Controls.Add(this.SiDevolucion);
            this.groupDevolucion.Location = new System.Drawing.Point(409, 309);
            this.groupDevolucion.Name = "groupDevolucion";
            this.groupDevolucion.Size = new System.Drawing.Size(180, 112);
            this.groupDevolucion.TabIndex = 81;
            this.groupDevolucion.TabStop = false;
            // 
            // FrmPrestamosExternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 550);
            this.Controls.Add(this.groupDevolucion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CondicionLibro);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreAlumno);
            this.Controls.Add(this.Labelxd);
            this.Controls.Add(this.FechaSelector);
            this.Controls.Add(this.TxtIdLibro);
            this.Controls.Add(this.TxtCodigoControlAlumno);
            this.Controls.Add(this.Labelxd2);
            this.Controls.Add(this.TxtNumPrestamo);
            this.Controls.Add(this.Fecha);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPrestamosExternos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRÉSTAMOS EXTERNOS";
            this.groupDevolucion.ResumeLayout(false);
            this.groupDevolucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CondicionLibro;
        private System.Windows.Forms.RichTextBox TxtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombreLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreAlumno;
        private System.Windows.Forms.Label Devolucion;
        private System.Windows.Forms.RadioButton NoDevolucion;
        private System.Windows.Forms.RadioButton SiDevolucion;
        private System.Windows.Forms.Label Labelxd;
        private System.Windows.Forms.DateTimePicker FechaSelector;
        private System.Windows.Forms.TextBox TxtIdLibro;
        private System.Windows.Forms.TextBox TxtCodigoControlAlumno;
        private System.Windows.Forms.Label Labelxd2;
        private System.Windows.Forms.TextBox TxtNumPrestamo;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupDevolucion;

    }
}