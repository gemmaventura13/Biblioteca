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
    public partial class frmPrestamosLibros : Form
    {
        public static string connstring = "Server=localhost;User id=root;Database=biblioteca;password=;Convert Zero Datetime=True";
        int bandera;

        public frmPrestamosLibros()
        {
            InitializeComponent();
        }

        private void buscarFolioSiguiente()
        {
            int cve = 0; //Variable para buscar Clave
            int May = 0;
            string peticion; //Variable para peticion SQL
            DataTable tabla = new DataTable();
            peticion = "SELECT IdPrestamo FROM prestamos order by IdPrestamo";
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

        private void frmPrestamosLibros_Load(object sender, EventArgs e)
        {
            timerHora.Enabled = true;
            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            buscarFolioSiguiente();
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

        private void timerHora_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void buscarCliente()
        {
            bandera = 0;
            string peticion; //Variable para peticion SQL
            DataTable tabla = new DataTable();
            peticion = "SELECT IdUsuario, Nombre, Apellidos FROM usuarios WHERE (IdUsuario ='" + txtClaveCliente.Text + "' )";
            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                comando.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    txtNombreCliente.Text = tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][2].ToString();
                    bandera = 1;
                    txtClaveLibro.Focus();
                }
                else 
                {
                    MessageBox.Show("El cliente no existe", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveCliente.Focus();
                }

                conexion.Close();
            }
            catch (MySqlException error)
            {
                
            }
        }

        private void txtClaveCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buscarCliente();                
            }
        }

        private void registrarPrestamo()
        {
            dgvPrestamo.Rows.Add(txtFolio.Text, txtClaveLibro.Text, txtNombreLibro.Text, txtClaveCliente.Text, txtNombreCliente.Text);
        }

        public void limpiarCampos()
        {
            txtClaveCliente.Text = "";
            txtNombreCliente.Text = "";
            txtClaveLibro.Text = "";
            txtNombreLibro.Text = "";
        }

        public void noDisponible() 
        {
            string peticion;
            peticion = "UPDATE libros set Disponibilidad ='" + 0 + "' where IdLibro='" + txtClaveLibro.Text + "';";

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            registrarPrestamo();
            noDisponible();
            txtClaveLibro.Text = "";
            txtNombreLibro.Text = "";
            txtClaveLibro.Focus();

        }

        public void buscarLibro()
        {
            bandera = 0;
            string peticion; //Variable para peticion SQL
            DataTable tabla = new DataTable();
            peticion = "SELECT IdLibro, Titulo FROM libros WHERE (IdLibro ='" + txtClaveLibro.Text + "' ) AND (Disponibilidad ='" + 1 + "' )";
            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                comando.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    txtNombreLibro.Text = tabla.Rows[0][1].ToString();
                    bandera = 1;
                    btnAceptar.Focus();
                }
                else
                {
                    MessageBox.Show("El libro no existe o ya ha sido prestado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveLibro.Focus();
                }

                conexion.Close();
            }
            catch (MySqlException error)
            {

            }
        }

        private void txtClaveLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buscarLibro();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres limpiar todos los campos?";
            string tituloboton = "LIMPIAR CAMPOS Y TABLA";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                int filas = dgvPrestamo.RowCount - 1;
                for (int i = 0; i <= filas; i++)
                {
                    string peticion;
                    peticion = "UPDATE libros set Disponibilidad ='" + 1 + "' where IdLibro='" + dgvPrestamo[1, i].Value.ToString() +"';";

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
                limpiarCampos();
                limpiaDgvPrestamo();
                txtClaveCliente.Focus();
            }
        }

        public void guardarMovPrestamos()
        {
            //Proceso de Guardar
            int filas = dgvPrestamo.RowCount - 1;
            for (int i = 0; i <= filas; i++)
            {
                //inicia Guardar

                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO movprestamos(FolioPrestamo, IdLibro, TituloLibro, IdCLiente, NombreCliente, FechaPrestamo) " +
                "VALUES (@Folio,@IdLibro,@Titulo,@IdCliente,@Nombre,@Fecha)", conn))
                {
                    //var avisos = Convert.ToInt32(TxtAvisos.Text);
                    cmd.Parameters.Add("@Folio", MySqlDbType.VarChar).Value = txtFolio.Text;
                    cmd.Parameters.Add("@Fecha", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@IdLibro", MySqlDbType.VarChar).Value = dgvPrestamo[1, i].Value.ToString();
                    cmd.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = dgvPrestamo[2, i].Value.ToString();
                    cmd.Parameters.Add("@IdCliente", MySqlDbType.Int64).Value = Convert.ToInt64(dgvPrestamo[3, i].Value.ToString());
                    cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = dgvPrestamo[4, i].Value.ToString();

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

        public void limpiaDgvPrestamo()
        {
            dgvPrestamo.Rows.Clear();
            //txtFolio.Text = Convert.ToString(Convert.ToInt64(txtFolio.Text) + 1);
        }

        public bool guardarPrestamo()
        {
            // using (conn)
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO prestamos(IdPrestamo, Fecha, CantidadLibro, IdCliente) " +
                "VALUES (@Id, @Fecha, @Cantidad, @IdCliente)", conn))
                {
                    cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = txtFolio.Text;
                    cmd.Parameters.Add("@Fecha", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@Cantidad", MySqlDbType.Int64).Value = dgvPrestamo.RowCount;
                    cmd.Parameters.Add("@IdCliente", MySqlDbType.Int64).Value = Convert.ToInt64(txtClaveCliente.Text);

                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            return true;
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
            }
            return false;
        }

        public void guardarHistorial()
        {
            //Proceso de Guardar
            int filas = dgvPrestamo.RowCount - 1;
            for (int i = 0; i <= filas; i++)
            {
                //inicia Guardar

                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO historialprestamos(FolioPrestamo, IdLibro, TituloLibro, IdCLiente, NombreCliente, FechaPrestamo) " +
                "VALUES (@Folio,@IdLibro,@Titulo,@IdCliente,@Nombre,@Fecha)", conn))
                {
                    //var avisos = Convert.ToInt32(TxtAvisos.Text);
                    cmd.Parameters.Add("@Folio", MySqlDbType.VarChar).Value = txtFolio.Text;
                    cmd.Parameters.Add("@Fecha", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@IdLibro", MySqlDbType.VarChar).Value = dgvPrestamo[1, i].Value.ToString();
                    cmd.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = dgvPrestamo[2, i].Value.ToString();
                    cmd.Parameters.Add("@IdCliente", MySqlDbType.Int64).Value = Convert.ToInt64(dgvPrestamo[3, i].Value.ToString());
                    cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = dgvPrestamo[4, i].Value.ToString();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int filas = dgvPrestamo.RowCount;
            string mensaje = "¿Quieres guardar los datos capturados?";
            string tituloboton = "GUARDAR DATOS";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtClaveCliente.Text) || string.IsNullOrEmpty(txtNombreCliente.Text) || filas == 0)
                {
                    MessageBox.Show("Te hace falta capturar algunos datos");
                }
                else
                {
                    guardarHistorial();
                    guardarMovPrestamos();
                    guardarPrestamo();
                    limpiarCampos();
                    limpiaDgvPrestamo();
                    txtClaveCliente.Focus();
                }
            }

        }

        public void Disponible()
        {
            string peticion;
            peticion = "UPDATE libros set Disponibilidad ='" + 1 + "' where IdLibro='" + dgvPrestamo[1, dgvPrestamo.CurrentRow.Index].Value.ToString() + "';";

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro del libro?";
            string tituloboton = "ELIMINAR REGISTRO";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Disponible();
                dgvPrestamo.Rows.RemoveAt(dgvPrestamo.CurrentRow.Index);
            }            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
