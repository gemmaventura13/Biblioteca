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
    public partial class FrmPrestamosInternos : Form
    {
        public FrmPrestamosInternos()
        {
            InitializeComponent();
        }

        public void LimpiarCampos() 
        {
            
            TxtIdCliente.Text = "";
            TxtIdLibro.Text = "";
            TxtNomCli.Text = "";
            TxtNombreLibro.Text = "";
            TxtNumPrestamo.Text = "";
            TxtHora.Text = "";
            FechaSelector.Text = "";
            SiDevolucion.Checked = false;
            NoDevolucion.Checked = false;
            
            TxtIdCliente.Focus();
        }

        private void IdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TxtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /*private void Editar_Click(object sender, EventArgs e)
        {
            string mensaje = "Usted esta apunto de editar los datos ¿Esta seguro de que quiere continuar?";
            string tituloventana = "Editar Datos";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloventana, botones, MessageBoxIcon.Question);
            MessageBox.Show("¡Se han Actualizado los datos!");
            LimpiarCampos();
        }*/

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta seguro de que quiere eliminar los datos?";
            string tituloventana = "Eliminar Datos";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloventana, botones, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LimpiarCampos();

            }

            else
            {
                MessageBox.Show("¡Se han conservado los datos!");
            }
        }

        private void TxtHora_TextChanged(object sender, EventArgs e)
        {
            TxtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se han guardado Los datos exitosamente!");
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
