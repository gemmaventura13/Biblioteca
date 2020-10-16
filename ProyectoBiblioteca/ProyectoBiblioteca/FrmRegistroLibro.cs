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
    public partial class FrmRegistroLibro : Form
    {
        public FrmRegistroLibro()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres cerrar esta ventana?";
            string tituloboton = "CERRAR VENTANA";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            } 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres guardar los datos capturados?";
            string tituloboton = "GUARDAR DATOS";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtClaveLibro.Text) | string.IsNullOrEmpty(txtTitulo.Text) | string.IsNullOrEmpty(txtAutor.Text) | string.IsNullOrEmpty(txtEditorial.Text)
                    | string.IsNullOrEmpty(txtAñoPub.Text) | string.IsNullOrEmpty(txtPaisPub.Text) | string.IsNullOrEmpty(txtEdicion.Text) | string.IsNullOrEmpty(txtGenero.Text)
                    | string.IsNullOrEmpty(txtPaginas.Text) | string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Te hace falta capturar algunos datos");
                }
                else
                {
                    MessageBox.Show("Se guardaron los datos capturados");
                    btnSalir.Focus();
                }
            } 
        }

        private void limpiarCampos()
        {
            string mensaje = "¿Quieres limpiar los campos de captura?";
            string tituloboton = "LIMPIAR CAMPOS DE CAPTURA";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtClaveLibro.Text = "";
                txtTitulo.Text = "";
                txtAutor.Text = "";
                txtEditorial.Text = "";
                txtAñoPub.Text = "";
                txtPaisPub.Text = "";
                txtEdicion.Text = "";
                txtGenero.Text = "";
                txtPaginas.Text = "";
                txtPrecio.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtClaveLibro.Focus();
        }

        private void txtClaveLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTitulo.Focus();
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAutor.Focus();
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEditorial.Focus();
            }
        }

        private void txtEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAñoPub.Focus();
            }
        }

        private void txtAñoPub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPaisPub.Focus();
            }
        }

        private void txtPaisPub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEdicion.Focus();
            }
        }

        private void txtEdicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGenero.Focus();
            }
        }

        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPaginas.Focus();
            }
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPrecio.Focus();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGuardar.Focus();
            }
        }

        private void FrmAñadirLibro_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToLongDateString();
            txtHora.Text = DateTime.Now.ToString("hh:mm tt");
        }

    }
}
