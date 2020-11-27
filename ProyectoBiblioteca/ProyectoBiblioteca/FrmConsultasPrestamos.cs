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
    public partial class FrmConsultasPrestamos : Form
    {
        public FrmConsultasPrestamos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void cargarPrestamos()
        {
            string peticion; //Variable para peticion SQL

            peticion = "SELECT IdPrestamo as 'FOLIO', Fecha as 'FECHA', CAntidadLibro as 'LIBROS PRÉSTADOS', IdCliente as 'CLIENTE' FROM prestamos ORDER BY IdPrestamo";

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

        private void FrmConsultasPrestamos_Load(object sender, EventArgs e)
        {
            cargarPrestamos();
        }
    }
}
