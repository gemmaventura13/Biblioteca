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
    public partial class RegistroCli : Form
    {
        public RegistroCli()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToShortTimeString();
            txtFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApellidos.Focus();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFechaNacimiento.Focus();
            }
        }

        private void txtFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEdad.Focus();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbSexo.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SE HAN GUARDADO LOS DATOS CORRECTAMENTE");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres eliminar los datos?";
            string tituloBoton = "Ventana Eliminar";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloBoton, botones, MessageBoxIcon.Question);
            if (result== DialogResult.Yes)
            {
                txtIdUsuario.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtFechaNacimiento.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
                txtEdad.Text = "";
                cmbSexo.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtFechaNacimiento.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            cmbSexo.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       
    }
}
