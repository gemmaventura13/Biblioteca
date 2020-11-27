using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoBiblioteca
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void prestamosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistroLibro libro = new FrmRegistroLibro();
            libro.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente registro = new FrmRegistroCliente();
            registro.Show();
        }

        private void salirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void préstamoExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void préstamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultasPrestamos prestamo = new FrmConsultasPrestamos();
            prestamo.Show();
        }

        private void devolucionesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmConsultasDevoluciones devolucion = new FrmConsultasDevoluciones();
            devolucion.Show();
        }

        private void préstamoInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamos prestamos = new FrmPrestamos();
            prestamos.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FrmReportes reportes = new FrmReportes();
            reportes.Show();*/
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acerca = new FrmAcercaDe();
            acerca.Show();
        }

        private void devolucionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDevoluciones devoluciones = new FrmDevoluciones();
            devoluciones.Show();
        }

        private void librosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultasLibros libro = new FrmConsultasLibros();
            libro.Show();
        }

        private void clientesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmConsultasClientes cliente = new FrmConsultasClientes();
            cliente.Show();
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamos Prestamos = new FrmPrestamos();
            Prestamos.Show();
        }

        private void préstamoInternoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportePrestamos reporte = new FrmReportePrestamos();
            reporte.Show();
        }

        private void reporteDeLecturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFormularioLectura lectura = new FrmFormularioLectura();
            lectura.Show();

        }

       
    }
}
