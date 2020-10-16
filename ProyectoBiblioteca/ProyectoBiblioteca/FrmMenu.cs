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
            FrmPrestamosExternos prestamosli = new FrmPrestamosExternos();
            prestamosli.Show();
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
            FrmPrestamosExternos prestamos = new FrmPrestamosExternos();
            prestamos.Show();
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
            FrmPrestamosInternos prestamos = new FrmPrestamosInternos();
            prestamos.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            reportes.Show();
        }
    }
}
