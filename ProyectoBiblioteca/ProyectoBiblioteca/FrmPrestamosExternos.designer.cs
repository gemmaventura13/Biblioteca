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
            this.button1 = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1033, 617);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 80;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(911, 617);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(112, 35);
            this.Cancelar.TabIndex = 79;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(789, 617);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(112, 35);
            this.Eliminar.TabIndex = 78;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(668, 617);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(112, 35);
            this.Editar.TabIndex = 77;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(547, 617);
            this.Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(112, 35);
            this.Guardar.TabIndex = 76;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 35);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nombre del Alumno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 35);
            this.label6.TabIndex = 74;
            this.label6.Text = "Codigo de control del Alumno:";
            // 
            // CondicionLibro
            // 
            this.CondicionLibro.FormattingEnabled = true;
            this.CondicionLibro.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.CondicionLibro.Location = new System.Drawing.Point(883, 190);
            this.CondicionLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CondicionLibro.Name = "CondicionLibro";
            this.CondicionLibro.Size = new System.Drawing.Size(180, 28);
            this.CondicionLibro.TabIndex = 73;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Location = new System.Drawing.Point(13, 334);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(516, 318);
            this.TxtObservaciones.TabIndex = 72;
            this.TxtObservaciones.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 35);
            this.label4.TabIndex = 71;
            this.label4.Text = "Observaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(877, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 35);
            this.label3.TabIndex = 70;
            this.label3.Text = "Condiciones del Libro:";
            // 
            // TxtNombreLibro
            // 
            this.TxtNombreLibro.Location = new System.Drawing.Point(250, 193);
            this.TxtNombreLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreLibro.Name = "TxtNombreLibro";
            this.TxtNombreLibro.Size = new System.Drawing.Size(344, 26);
            this.TxtNombreLibro.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 35);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre del Libro:";
            // 
            // TxtNombreAlumno
            // 
            this.TxtNombreAlumno.Location = new System.Drawing.Point(337, 67);
            this.TxtNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreAlumno.Name = "TxtNombreAlumno";
            this.TxtNombreAlumno.Size = new System.Drawing.Size(292, 26);
            this.TxtNombreAlumno.TabIndex = 67;
            // 
            // Devolucion
            // 
            this.Devolucion.AutoSize = true;
            this.Devolucion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devolucion.Location = new System.Drawing.Point(937, 268);
            this.Devolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.Size = new System.Drawing.Size(148, 35);
            this.Devolucion.TabIndex = 60;
            this.Devolucion.Text = "¿Se Devolvio?:";
            // 
            // NoDevolucion
            // 
            this.NoDevolucion.AutoSize = true;
            this.NoDevolucion.Location = new System.Drawing.Point(943, 363);
            this.NoDevolucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoDevolucion.Name = "NoDevolucion";
            this.NoDevolucion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoDevolucion.Size = new System.Drawing.Size(54, 24);
            this.NoDevolucion.TabIndex = 66;
            this.NoDevolucion.TabStop = true;
            this.NoDevolucion.Text = "No";
            this.NoDevolucion.UseVisualStyleBackColor = true;
            // 
            // SiDevolucion
            // 
            this.SiDevolucion.AutoSize = true;
            this.SiDevolucion.Location = new System.Drawing.Point(943, 326);
            this.SiDevolucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SiDevolucion.Name = "SiDevolucion";
            this.SiDevolucion.Size = new System.Drawing.Size(48, 24);
            this.SiDevolucion.TabIndex = 65;
            this.SiDevolucion.TabStop = true;
            this.SiDevolucion.Text = "Si";
            this.SiDevolucion.UseVisualStyleBackColor = true;
            // 
            // Labelxd
            // 
            this.Labelxd.AutoSize = true;
            this.Labelxd.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd.Location = new System.Drawing.Point(4, 143);
            this.Labelxd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelxd.Name = "Labelxd";
            this.Labelxd.Size = new System.Drawing.Size(160, 35);
            this.Labelxd.TabIndex = 57;
            this.Labelxd.Text = "Num. Prestamo:";
            // 
            // FechaSelector
            // 
            this.FechaSelector.Location = new System.Drawing.Point(603, 329);
            this.FechaSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaSelector.Name = "FechaSelector";
            this.FechaSelector.Size = new System.Drawing.Size(298, 26);
            this.FechaSelector.TabIndex = 64;
            // 
            // TxtIdLibro
            // 
            this.TxtIdLibro.Location = new System.Drawing.Point(656, 192);
            this.TxtIdLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIdLibro.Name = "TxtIdLibro";
            this.TxtIdLibro.Size = new System.Drawing.Size(148, 26);
            this.TxtIdLibro.TabIndex = 63;
            // 
            // TxtCodigoControlAlumno
            // 
            this.TxtCodigoControlAlumno.Location = new System.Drawing.Point(13, 67);
            this.TxtCodigoControlAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigoControlAlumno.Name = "TxtCodigoControlAlumno";
            this.TxtCodigoControlAlumno.Size = new System.Drawing.Size(268, 26);
            this.TxtCodigoControlAlumno.TabIndex = 0;
            this.TxtCodigoControlAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoControlAlumno_KeyPress);
            // 
            // Labelxd2
            // 
            this.Labelxd2.AutoSize = true;
            this.Labelxd2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelxd2.Location = new System.Drawing.Point(650, 143);
            this.Labelxd2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labelxd2.Name = "Labelxd2";
            this.Labelxd2.Size = new System.Drawing.Size(92, 35);
            this.Labelxd2.TabIndex = 58;
            this.Labelxd2.Text = "Id. Libro:";
            // 
            // TxtNumPrestamo
            // 
            this.TxtNumPrestamo.Location = new System.Drawing.Point(10, 193);
            this.TxtNumPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNumPrestamo.Name = "TxtNumPrestamo";
            this.TxtNumPrestamo.Size = new System.Drawing.Size(146, 26);
            this.TxtNumPrestamo.TabIndex = 61;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(597, 268);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(161, 35);
            this.Fecha.TabIndex = 59;
            this.Fecha.Text = "Fecha de Retiro:";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1151, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CondicionLibro);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreAlumno);
            this.Controls.Add(this.Devolucion);
            this.Controls.Add(this.NoDevolucion);
            this.Controls.Add(this.SiDevolucion);
            this.Controls.Add(this.Labelxd);
            this.Controls.Add(this.FechaSelector);
            this.Controls.Add(this.TxtIdLibro);
            this.Controls.Add(this.TxtCodigoControlAlumno);
            this.Controls.Add(this.Labelxd2);
            this.Controls.Add(this.TxtNumPrestamo);
            this.Controls.Add(this.Fecha);
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Guardar;
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

    }
}