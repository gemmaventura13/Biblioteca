namespace ProyectoBiblioteca
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamoInternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamoExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosInternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosExternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHora = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matenimientoToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.devolucionesToolStripMenuItem2,
            this.consultasToolStripMenuItem1,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem1,
            this.salirToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(911, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matenimientoToolStripMenuItem
            // 
            this.matenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem1,
            this.clientesToolStripMenuItem2});
            this.matenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.matenimientoToolStripMenuItem.Name = "matenimientoToolStripMenuItem";
            this.matenimientoToolStripMenuItem.Size = new System.Drawing.Size(129, 25);
            this.matenimientoToolStripMenuItem.Text = "Matenimiento";
            // 
            // librosToolStripMenuItem1
            // 
            this.librosToolStripMenuItem1.Name = "librosToolStripMenuItem1";
            this.librosToolStripMenuItem1.Size = new System.Drawing.Size(139, 26);
            this.librosToolStripMenuItem1.Text = "Libros";
            this.librosToolStripMenuItem1.Click += new System.EventHandler(this.librosToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(139, 26);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            this.clientesToolStripMenuItem2.Click += new System.EventHandler(this.clientesToolStripMenuItem2_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préstamoInternoToolStripMenuItem,
            this.préstamoExternoToolStripMenuItem});
            this.préstamosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // préstamoInternoToolStripMenuItem
            // 
            this.préstamoInternoToolStripMenuItem.Name = "préstamoInternoToolStripMenuItem";
            this.préstamoInternoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.préstamoInternoToolStripMenuItem.Text = "Préstamo Interno";
            this.préstamoInternoToolStripMenuItem.Click += new System.EventHandler(this.préstamoInternoToolStripMenuItem_Click);
            // 
            // préstamoExternoToolStripMenuItem
            // 
            this.préstamoExternoToolStripMenuItem.Name = "préstamoExternoToolStripMenuItem";
            this.préstamoExternoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.préstamoExternoToolStripMenuItem.Text = "Préstamo Externo";
            this.préstamoExternoToolStripMenuItem.Click += new System.EventHandler(this.préstamoExternoToolStripMenuItem_Click);
            // 
            // devolucionesToolStripMenuItem2
            // 
            this.devolucionesToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.devolucionesToolStripMenuItem2.Name = "devolucionesToolStripMenuItem2";
            this.devolucionesToolStripMenuItem2.Size = new System.Drawing.Size(124, 25);
            this.devolucionesToolStripMenuItem2.Text = "Devoluciones";
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préstamosToolStripMenuItem1,
            this.devolucionesToolStripMenuItem3});
            this.consultasToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(95, 25);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(100, 25);
            this.acercaDeToolStripMenuItem1.Text = "Acerca De";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem3
            // 
            this.salirToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem3.Name = "salirToolStripMenuItem3";
            this.salirToolStripMenuItem3.Size = new System.Drawing.Size(54, 25);
            this.salirToolStripMenuItem3.Text = "Salir";
            this.salirToolStripMenuItem3.Click += new System.EventHandler(this.salirToolStripMenuItem3_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosInternosToolStripMenuItem,
            this.prestamosExternosToolStripMenuItem});
            this.prestamosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // prestamosInternosToolStripMenuItem
            // 
            this.prestamosInternosToolStripMenuItem.Name = "prestamosInternosToolStripMenuItem";
            this.prestamosInternosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.prestamosInternosToolStripMenuItem.Text = "Prestamos Internos";
            this.prestamosInternosToolStripMenuItem.Click += new System.EventHandler(this.prestamosInternosToolStripMenuItem_Click);
            // 
            // prestamosExternosToolStripMenuItem
            // 
            this.prestamosExternosToolStripMenuItem.Name = "prestamosExternosToolStripMenuItem";
            this.prestamosExternosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.prestamosExternosToolStripMenuItem.Text = "Prestamos Externos";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem1,
            this.devolucionesToolStripMenuItem1,
            this.clientesToolStripMenuItem1});
            this.devolucionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.devolucionesToolStripMenuItem.Text = "Consultas";
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            // 
            // devolucionesToolStripMenuItem1
            // 
            this.devolucionesToolStripMenuItem1.Name = "devolucionesToolStripMenuItem1";
            this.devolucionesToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.devolucionesToolStripMenuItem1.Text = "Devoluciones";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeDevolucionesToolStripMenuItem});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.consultasToolStripMenuItem.Text = "Devoluciones";
            // 
            // registroDeDevolucionesToolStripMenuItem
            // 
            this.registroDeDevolucionesToolStripMenuItem.Name = "registroDeDevolucionesToolStripMenuItem";
            this.registroDeDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registroDeDevolucionesToolStripMenuItem.Text = "Registro de Devoluciones";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Consolas", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(236, 355);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(182, 79);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // préstamosToolStripMenuItem1
            // 
            this.préstamosToolStripMenuItem1.Name = "préstamosToolStripMenuItem1";
            this.préstamosToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.préstamosToolStripMenuItem1.Text = "Préstamos";
            this.préstamosToolStripMenuItem1.Click += new System.EventHandler(this.préstamosToolStripMenuItem1_Click);
            // 
            // devolucionesToolStripMenuItem3
            // 
            this.devolucionesToolStripMenuItem3.Name = "devolucionesToolStripMenuItem3";
            this.devolucionesToolStripMenuItem3.Size = new System.Drawing.Size(182, 26);
            this.devolucionesToolStripMenuItem3.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem3.Click += new System.EventHandler(this.devolucionesToolStripMenuItem3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::ProyectoBiblioteca.Properties.Resources.libros3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(298, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(911, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosInternosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosExternosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeDevolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamoInternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamoExternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}