namespace ProyectoBiblioteca
{
    partial class FrmLibrosDevolucion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.DataSetDevolucionLibros = new ProyectoBiblioteca.DataSetDevolucionLibros();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDevolucionLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Teal;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoBiblioteca.ReportDevolucionLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1163, 583);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.White;
            this.btnCargarDatos.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(465, 14);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(246, 60);
            this.btnCargarDatos.TabIndex = 1;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // DataSetDevolucionLibros
            // 
            this.DataSetDevolucionLibros.DataSetName = "DataSetDevolucionLibros";
            this.DataSetDevolucionLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmLibrosDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1189, 695);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmLibrosDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DEVOLUCIONES";
            this.Load += new System.EventHandler(this.FrmLibrosDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDevolucionLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
      //  private DataSetDevolucionLibrosxsd DataSetDevolucionLibrosxsd;
        private DataSetDevolucionLibros DataSetDevolucionLibros;
    }
}