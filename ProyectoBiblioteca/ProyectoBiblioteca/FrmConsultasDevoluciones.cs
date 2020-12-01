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
    public partial class FrmConsultasDevoluciones : Form
    {
        public FrmConsultasDevoluciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarDevoluciones();
        }

        private void cargarDevoluciones()
        {
            string peticion; //Variable para peticion SQL

            peticion = "SELECT TituloLibro as 'TITULO LIBRO', NombreCliente as 'NOMBRE CLIENTE', FechaDevolucion as 'FECHA' FROM devoluciones ORDER BY IdMovDevolucion";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(FrmRegistroLibro.connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                DataTable dt = new DataTable();
                comando.Fill(dt);
                dgvDevolucion.DataSource = dt;

                conexion.Close();
            }
            catch
            {

            }
        }

        private void formateoDgvDevoluciones()
        {
            this.dgvDevolucion.EnableHeadersVisualStyles = false;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
        }

        private void FrmConsultasDevoluciones_Load(object sender, EventArgs e)
        {
            cargarDevoluciones();
            formateoDgvDevoluciones();
        }

        private void buscarDevolucion()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                string peticion;
                string fecha = Convert.ToDateTime(txtFecha.Text).ToString("yyyy/MM/dd");

                peticion = "SELECT TituloLibro as 'TITULO LIBRO', NombreCliente as 'NOMBRE CLIENTE', FechaDevolucion as 'FECHA' FROM devoluciones WHERE NombreCliente LIKE ('%" + Convert.ToString(txtBuscar.Text.Trim()) + "%') OR IdMovDevolucion LIKE ('%" + txtBuscar.Text.Trim() + "%') OR FechaDevolucion = '" + fecha + "' ; ";

                try
                {
                    MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(FrmRegistroLibro.connstring);
                    conexion.Open();
                    MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                    DataTable dt = new DataTable();
                    comando.Fill(dt);
                    dgvDevolucion.DataSource = dt;

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
            buscarDevolucion();
        }


    }
}
