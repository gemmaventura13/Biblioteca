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
            cargarPrestamos();
        }

        private void cargarPrestamos()
        {
            string peticion; //Variable para peticion SQL

            peticion = "SELECT NombreCliente as 'NOMBRE DEL CLIENTE', TituloLibro as 'TÍTULO DEL LIBRO', FechaPrestamo as 'FECHA' FROM historialprestamos ORDER BY FechaPrestamo";

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

        private void formateoDgvPrestamos()
        {
            this.dgvConsulta.EnableHeadersVisualStyles = false;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
        }

        private void FrmConsultasPrestamos_Load(object sender, EventArgs e)
        {
            cargarPrestamos();
            formateoDgvPrestamos();
        }

        private void buscarPrestamo()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                string peticion;
                string fecha = Convert.ToDateTime(txtFecha.Text).ToString("yyyy/MM/dd");

                peticion = "SELECT NombreCliente as 'NOMBRE DEL CLIENTE', TituloLibro as 'TÍTULO DEL LIBRO', FechaPrestamo as 'FECHA' FROM historialprestamos WHERE NombreCliente LIKE ('%" + Convert.ToString(txtBuscar.Text.Trim()) + "%') OR TituloLibro LIKE ('%" + txtBuscar.Text.Trim() + "%') OR FechaPrestamo = '" + fecha + "' ; ";

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
            buscarPrestamo();
        }
    }
}
