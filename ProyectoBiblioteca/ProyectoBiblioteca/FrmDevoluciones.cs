using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBiblioteca
{
    public partial class FrmDevoluciones : Form
    {
        string connstring = "Server=localhost;User id=root;Database=biblioteca;password=;Convert Zero Datetime=True";

        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void cargarMovPrestamos()
        {
            string peticion; //Variable para peticion SQL

            peticion = "SELECT IdMovPrestamo as 'NÚMERO DEL MOVIMIENTO', FolioPrestamo as 'FOLIO', IdLibro as 'CLAVE DEL LIBRO', TituloLibro as 'TÍTULO DEL LIBRO', IdCliente as 'CLAVE DEL CLIENTE', NombreCliente as 'NOMBRE DEL CLIENTE' FROM movprestamos ORDER BY IdMovPrestamo";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(FrmRegistroLibro.connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                DataTable dt = new DataTable();
                comando.Fill(dt);
                dgvMovPrestamos.DataSource = dt;

                conexion.Close();
            }
            catch
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarFolioSiguiente()
        {
            int cve = 0; //Variable para buscar Clave
            int May = 0;
            string peticion; //Variable para peticion SQL
            DataTable tabla = new DataTable();
            peticion = "SELECT Folio FROM devoluciones order by Folio";
            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);
                comando.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    try
                    {
                        //Ciclo para encontrar el siguiente
                        May = Convert.ToInt32(tabla.Rows[0][0].ToString()); ;
                        //Recorrer la Tabla
                        int kr = tabla.Rows.Count;
                        for (int j = 0; j < kr; j++)
                        {
                            cve = Convert.ToInt32(tabla.Rows[j][0].ToString());
                            if (cve > May)
                            {
                                May = cve;
                            }
                        }



                        May = May + 1;
                        txtFolio.Text = Convert.ToString(May);

                        conexion.Close();
                    }
                    catch
                    {
                        // textBox2.Text = "0000000001";
                    }
                }
                else
                {
                    txtFolio.Text = "1";
                }
            }
            catch
            {

            }
            //final Buscar Clave Articulo Siguiente
        }​​​​

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            cargarMovPrestamos();
            timerHora.Enabled = true;
            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            buscarFolioSiguiente();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarMovPrestamos();
        }

        private void buscarPrestamo()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()) == false)
            {
                string peticion;

                peticion = "SELECT IdPMovPrestamo as 'NÚMERO DEL MOVIMIENTO', FolioPrestamo as 'FOLIO', IdLibro as 'CLAVE DEL LIBRO', TituloLibro as 'TÍTULO DEL LIBRO', IdCliente as 'CLAVE DEL CLIENTE', NombreCliente as 'NOMBRE DEL CLIENTE' FROM movprestamos WHERE NombreCliente LIKE ('%" + Convert.ToString(txtBuscar.Text.Trim()) + "%') OR IdPrestamo LIKE ('%" + txtBuscar.Text.Trim() + "%') ";

                try
                {
                    MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(FrmRegistroLibro.connstring);
                    conexion.Open();
                    MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                    DataTable dt = new DataTable();
                    comando.Fill(dt);
                    dgvMovPrestamos.DataSource = dt;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtClaveCliente.Text = dgvMovPrestamos.Rows[dgvMovPrestamos.CurrentRow.Index].Cells[4].Value.ToString();
            txtNombreCliente.Text = dgvMovPrestamos.Rows[dgvMovPrestamos.CurrentRow.Index].Cells[5].Value.ToString();
            txtClaveLibro.Text = dgvMovPrestamos.Rows[dgvMovPrestamos.CurrentRow.Index].Cells[2].Value.ToString();
            txtNombreLibro.Text = dgvMovPrestamos.Rows[dgvMovPrestamos.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void registrarDevolucion()
        {
            dgvDevoluciones.Rows.Add(txtFolio.Text, txtClaveLibro.Text, txtNombreLibro.Text, txtClaveCliente.Text, txtNombreCliente.Text);
        }

        public void eliminarMovPrestamo()
        {
            string peticion;

            peticion = "DELETE FROM movprestamos WHERE IdLibro='" + txtClaveLibro.Text.Trim() + "';";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(peticion, conexion);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {

            }
        }

        public void limpiarCampos()
        {
            txtClaveCliente.Text = "";
            txtNombreCliente.Text = "";
            txtClaveLibro.Text = "";
            txtNombreLibro.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea devolver este libro?";
            string tituloboton = "DEVOLVER LIBRO";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtClaveCliente.Text) || string.IsNullOrEmpty(txtNombreCliente.Text) || string.IsNullOrEmpty(txtClaveLibro.Text) || string.IsNullOrEmpty(txtNombreLibro.Text))
                {
                    MessageBox.Show("Te hace falta capturar algunos datos");
                }
                else
                {
                    dgvMovPrestamos.Rows.RemoveAt(dgvMovPrestamos.CurrentRow.Index);
                    registrarDevolucion();
                    limpiarCampos();
                    txtClaveCliente.Focus();
                }

            } 
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void guardarMovDevoluciones()
        {
            //Proceso de Guardar
            int filas = dgvDevoluciones.RowCount - 1;
            for (int i = 0; i <= filas; i++)
            {
                //inicia Guardar

                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO devoluciones(Folio, IdLibro, TituloLibro, IdCLiente, NombreCliente, FechaDevolucion) " +
                "VALUES (@Folio,@IdLibro,@Titulo,@IdCliente,@Nombre,@Fecha)", conn))
                {
                    //var avisos = Convert.ToInt32(TxtAvisos.Text);
                    cmd.Parameters.Add("@Folio", MySqlDbType.VarChar).Value = txtFolio.Text;
                    cmd.Parameters.Add("@Fecha", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@IdLibro", MySqlDbType.VarChar).Value = dgvDevoluciones[1, i].Value.ToString();
                    cmd.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = dgvDevoluciones[2, i].Value.ToString();
                    cmd.Parameters.Add("@IdCliente", MySqlDbType.Int64).Value = Convert.ToInt64(dgvDevoluciones[3, i].Value.ToString());
                    cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = dgvDevoluciones[4, i].Value.ToString();

                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            // MessageBox.Show("Dado de Alta el Movimiento");
                        }
                    }
                    catch (MySqlException sqlEx)
                    {
                        if (sqlEx.Number == 1062)
                        {
                            MessageBox.Show(sqlEx.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Error: " + sqlEx.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //Termina Guardar
            }
        }

        public void limpiaDgvDevoluciones()
        {
            dgvDevoluciones.Rows.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int filas = dgvDevoluciones.RowCount;
            string mensaje = "¿Quieres guardar los datos capturados?";
            string tituloboton = "GUARDAR DATOS";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (filas == 0)
                {
                    MessageBox.Show("Te hace falta capturar algunos datos");
                }
                else
                {
                    int conFilas = dgvDevoluciones.RowCount - 1;
                    for (int i = 0; i <= conFilas; i++)
                    {
                        string peticion;
                        peticion = "UPDATE libros set Disponibilidad ='" + 1 + "' where IdLibro='" + dgvDevoluciones[1, i].Value.ToString() + "';";

                        try
                        {
                            MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                            conexion.Open();
                            MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(peticion, conexion);

                            comando.ExecuteNonQuery();
                            conexion.Close();
                        }
                        catch
                        {

                        }
                    }
                    guardarMovDevoluciones();
                    eliminarMovPrestamo();
                    limpiarCampos();
                    limpiaDgvDevoluciones();
                    txtClaveCliente.Focus();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            limpiaDgvDevoluciones();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
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
    }
}
