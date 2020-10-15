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
    public partial class FrmPrestamosExternos : Form
    {
        public FrmPrestamosExternos()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            TxtCodigoControlAlumno.Text = "";
            TxtIdLibro.Text = "";
            TxtNombreAlumno.Text = "";
            TxtNombreLibro.Text = "";
            TxtNumPrestamo.Text = "";
            TxtObservaciones.Text = "";
            FechaSelector.Text = "";
            SiDevolucion.Checked = false;
            NoDevolucion.Checked = false;
            CondicionLibro.Text = "";
            TxtCodigoControlAlumno.Focus();


            TxtCodigoControlAlumno.Focus();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Se han Guardado Los datos exitosamente!");
            LimpiarCampos();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            string mensaje = "Usted esta apunto de editar los datos ¿Esta seguro de que quiere continuar?";
            string tituloventana = "Editar Datos";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloventana, botones, MessageBoxIcon.Question);
            MessageBox.Show("¡Se han Actualizado los datos!");
            LimpiarCampos();
        }

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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCodigoControlAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                TxtIdLibro.Focus();
            }
        }
    }
}
