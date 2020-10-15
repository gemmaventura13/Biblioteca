using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCli registro = new RegistroCli();
            registro.Show();
        }

        private void prestamosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos prestamosli = new Prestamos();
            prestamosli.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
