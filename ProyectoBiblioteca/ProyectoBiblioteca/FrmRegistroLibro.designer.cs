namespace ProyectoBiblioteca
{
    partial class FrmRegistroLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroLibro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveLibro = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaisPub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAñoPub = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            this.txtPaginas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del libro";
            // 
            // txtClaveLibro
            // 
            this.txtClaveLibro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveLibro.Location = new System.Drawing.Point(33, 99);
            this.txtClaveLibro.Name = "txtClaveLibro";
            this.txtClaveLibro.Size = new System.Drawing.Size(278, 27);
            this.txtClaveLibro.TabIndex = 1;
            this.txtClaveLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveLibro_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(33, 171);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(469, 27);
            this.txtTitulo.TabIndex = 4;
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título del libro";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(33, 243);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(469, 27);
            this.txtAutor.TabIndex = 6;
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor del libro";
            // 
            // txtPaisPub
            // 
            this.txtPaisPub.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaisPub.Location = new System.Drawing.Point(250, 387);
            this.txtPaisPub.Name = "txtPaisPub";
            this.txtPaisPub.Size = new System.Drawing.Size(183, 27);
            this.txtPaisPub.TabIndex = 12;
            this.txtPaisPub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaisPub_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(245, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "País de publicación";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(33, 315);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(469, 27);
            this.txtEditorial.TabIndex = 8;
            this.txtEditorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditorial_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Editorial";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.Location = new System.Drawing.Point(467, 387);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(93, 27);
            this.txtEdicion.TabIndex = 14;
            this.txtEdicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdicion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(462, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edición";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año de publicación";
            // 
            // txtAñoPub
            // 
            this.txtAñoPub.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAñoPub.Location = new System.Drawing.Point(33, 387);
            this.txtAñoPub.Name = "txtAñoPub";
            this.txtAñoPub.Size = new System.Drawing.Size(183, 27);
            this.txtAñoPub.TabIndex = 10;
            this.txtAñoPub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAñoPub_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(28, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Género";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(245, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Páginas";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(374, 459);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(98, 27);
            this.txtPrecio.TabIndex = 20;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(369, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Precio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(43, 518);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 42);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(234, 518);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 42);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(425, 518);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 42);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Items.AddRange(new object[] {
            "Horror",
            "Misterio",
            "Policialico",
            "Romance",
            "Fantasía",
            "Acción",
            "Aventura",
            "Infantil",
            "Drama",
            "Ciencia ficción",
            "Cuento",
            "Suspenso",
            "Comedia",
            "Erótica",
            "Filosofía",
            "Poesía",
            "No ficción",
            "Piscológico",
            "Juvenil",
            "Científico",
            "Novela gráfica",
            "Biográfico",
            "Recetario",
            "Político",
            "Teatral",
            "Didáctico",
            "Histórico",
            "Distópico"});
            this.txtGenero.Location = new System.Drawing.Point(33, 459);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(183, 27);
            this.txtGenero.TabIndex = 24;
            this.txtGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenero_KeyPress);
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.FormattingEnabled = true;
            this.txtPaginas.Items.AddRange(new object[] {
            "1-200",
            "201-400",
            "401-600",
            "601-800",
            "801-1000",
            "1000+"});
            this.txtPaginas.Location = new System.Drawing.Point(250, 459);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(93, 27);
            this.txtPaginas.TabIndex = 25;
            this.txtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaginas_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(256, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.DarkCyan;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtFecha.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFecha.Location = new System.Drawing.Point(260, 33);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(223, 21);
            this.txtFecha.TabIndex = 28;
            this.txtFecha.Text = "\r\n";
            this.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.DarkCyan;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtHora.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHora.Location = new System.Drawing.Point(489, 33);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(89, 21);
            this.txtHora.TabIndex = 29;
            this.txtHora.Text = "\r\n";
            this.txtHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(485, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "Hora";
            // 
            // FrmRegistroLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(593, 585);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPaisPub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAñoPub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveLibro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRegistroLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO LIBRO";
            this.Load += new System.EventHandler(this.FrmAñadirLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveLibro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaisPub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAñoPub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox txtGenero;
        private System.Windows.Forms.ComboBox txtPaginas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtHora;
        private System.Windows.Forms.Label label12;
    }
}

