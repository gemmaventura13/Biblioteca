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
    public partial class FrmConsultasLibros : Form
    {
        public FrmConsultasLibros()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha eliminado la información del libro");
        }

        private void buscarLibro()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                string peticion;

                peticion = "SELECT IdLibro as 'CLAVE', Titulo as 'TITULO', Autor as 'AUTOR', Editorial as 'EDITORIAL', AñoPub as 'AÑO DE PUBLICACIÓN', Edicion as 'EDICIÓN', Genero as 'GÉNERO', NumPag as 'PÁGINAS', PrecioLibro as 'PRECIO' FROM libros WHERE Titulo LIKE ('%" + Convert.ToString(txtBuscar.Text.Trim()) + "%') OR IdLibro LIKE ('%" + txtBuscar.Text.Trim() + "%') "; 

                try
                {
                    MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(FrmRegistroLibro.connstring);
                    conexion.Open();
                    MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                    DataTable dt = new DataTable();
                    comando.Fill(dt);
                    dgvConsulta.DataSource = dt;

                    conexion.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarLibro();
        }

        private void cargarLibros()
        {
            string peticion; //Variable para peticion SQL

            peticion = "SELECT IdLibro as 'CLAVE', Titulo as 'TITULO', Autor as 'AUTOR', Editorial as 'EDITORIAL', AñoPub as 'AÑO DE PUBLICACIÓN', Edicion as 'EDICIÓN', Genero as 'GÉNERO', NumPag as 'PÁGINAS', PrecioLibro as 'PRECIO' FROM libros ORDER BY IdLibro";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(FrmRegistroLibro.connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                DataTable dt = new DataTable();
                comando.Fill(dt);
                dgvConsulta.DataSource = dt;

                conexion.Close();
            }
            catch
            {

            }
        }

        private void FrmConsultasLibros_Load(object sender, EventArgs e)
        {
            cargarLibros();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarLibros();
        }
    }
}
