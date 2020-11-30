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
    public partial class FrmConsultasClientes : Form
    {
        public FrmConsultasClientes()
        {
            InitializeComponent();
        }

        private void cargarClientes()
        {
            string peticion; //Variable para peticion SQL
            //DataTable tabla = new DataTable();

            peticion = "SELECT IdUsuario as 'CLAVE', Nombre as 'NOMBRE', Apellidos as 'APELLIDOS', Edad as 'EDAD', Sexo as 'SEXO' FROM usuarios ORDER BY IdUsuario";

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

        private void FrmConsultasClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha eliminado la información del cliente");
        }

        private void buscarCliente()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                string peticion;

                peticion = "SELECT IdUsuario as 'CLAVE', Nombre as 'NOMBRE', Apellidos as 'APELLIDOS', Edad as 'EDAD', Sexo as 'SEXO' FROM usuarios WHERE Nombre LIKE ('%" + Convert.ToString(txtBuscar.Text.Trim()) + "%') OR Apellidos LIKE ('%" + txtBuscar.Text.Trim() + "%') OR IdUsuario LIKE ('%" + txtBuscar.Text.Trim() + "%')";

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
            buscarCliente();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }
    }
}
