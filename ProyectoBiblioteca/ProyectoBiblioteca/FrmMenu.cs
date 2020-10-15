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
    }
}
