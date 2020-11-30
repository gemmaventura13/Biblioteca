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
    public partial class FrmRegistroLibro : Form
    {
        public static string connstring = "Server=localhost;User id=root;Database=biblioteca;password=;Convert Zero Datetime=True";
        int bandera = 0;

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
            if (bandera == 0)
            {
                string mensaje = "¿Quieres guardar los datos capturados?";
                string tituloboton = "GUARDAR DATOS";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtClaveLibro.Text) | string.IsNullOrEmpty(txtTitulo.Text) | string.IsNullOrEmpty(txtAutor.Text)
                        | string.IsNullOrEmpty(txtAñoPub.Text) | string.IsNullOrEmpty(txtGenero.Text) | string.IsNullOrEmpty(txtPrecio.Text))
                    {
                        MessageBox.Show("Te hace falta capturar algunos datos");
                    }
                    else
                    {
                        guardarLibro();
                        limpiarCampos();
                        btnSalir.Focus();
                        txtClaveLibro.Focus();
                    }
                }
            }
            else
            {
                string mensaje = "¿Quieres modificar los datos del registro?";
                string tituloboton = "MODIFICAR DATOS";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtClaveLibro.Text) | string.IsNullOrEmpty(txtTitulo.Text) | string.IsNullOrEmpty(txtAutor.Text)
                        | string.IsNullOrEmpty(txtAñoPub.Text) | string.IsNullOrEmpty(txtGenero.Text) | string.IsNullOrEmpty(txtPrecio.Text))
                    {
                        MessageBox.Show("Te hace falta capturar algunos datos");
                    }
                    else
                    {
                        editarLibro();
                        MessageBox.Show("Se modificaron los datos del libro");
                        limpiarCampos();
                        btnSalir.Focus();
                        txtClaveLibro.Focus();
                    }
                }
            }
        }

        private void limpiarCampos()
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres limpiar los campos de captura?";
            string tituloboton = "LIMPIAR CAMPOS DE CAPTURA";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloboton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                limpiarCampos();
                txtClaveLibro.Focus();
            }            
        }

        private void buscarLibro()
        {
            bandera = 0;
            string peticion; //Variable para peticion SQL
            DataTable tabla = new DataTable();
            peticion = "SELECT IdLibro, Titulo, Autor, Editorial, AñoPub, PaisPub, Edicion, Genero, NumPag, PrecioLibro FROM libros WHERE (IdLibro ='" + txtClaveLibro.Text + "' )";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);

                comando.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    txtTitulo.Text = tabla.Rows[0][1].ToString();
                    txtAutor.Text = tabla.Rows[0][2].ToString();
                    txtEditorial.Text = tabla.Rows[0][3].ToString();
                    txtAñoPub.Text = tabla.Rows[0][4].ToString();
                    txtPaisPub.Text = tabla.Rows[0][5].ToString();
                    txtEdicion.Text = tabla.Rows[0][6].ToString();
                    txtGenero.Text = tabla.Rows[0][7].ToString();
                    txtPaginas.Text = tabla.Rows[0][8].ToString();
                    txtPrecio.Text = tabla.Rows[0][9].ToString();
                    bandera = 1;
                }

                conexion.Close();

            }
            catch
            {

            }
        }

        private void txtClaveLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buscarLibro();
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

        public bool guardarLibro()
        {
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO libros(IdLibro, Titulo, Autor, Editorial, AñoPub, PaisPub, Edicion, Genero, NumPag, PrecioLibro, Disponibilidad) " +
                "VALUES (@Id, @Titulo, @Autor, @Editorial, @Año, @Pais, @Edicion, @Genero, @Pag, @Precio, @Disponibilidad)", conn))
                {
                    //var avisos = Convert.ToInt32(TxtAvisos.Text);
                    cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = txtClaveLibro.Text.Trim();
                    cmd.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = txtTitulo.Text.Trim();
                    cmd.Parameters.Add("@Autor", MySqlDbType.VarChar).Value = txtAutor.Text.Trim();

                    if (string.IsNullOrEmpty(txtEditorial.Text))
                    {
                        cmd.Parameters.Add("@Editorial", MySqlDbType.VarChar).Value = "-";
                    }
                    else
                    {
                        cmd.Parameters.Add("@Editorial", MySqlDbType.VarChar).Value = txtEditorial.Text.Trim();
                    }

                    cmd.Parameters.Add("@Año", MySqlDbType.VarChar).Value = txtAñoPub.Text.Trim();

                    if (string.IsNullOrEmpty(txtPaisPub.Text))
                    {
                        cmd.Parameters.Add("@Pais", MySqlDbType.VarChar).Value = "-";
                    }
                    else
                    {
                        cmd.Parameters.Add("@Pais", MySqlDbType.VarChar).Value = txtPaisPub.Text.Trim();
                    }

                    if (string.IsNullOrEmpty(txtEdicion.Text))
                    {
                        cmd.Parameters.Add("@Edicion", MySqlDbType.VarChar).Value = "-";
                    }
                    else
                    {
                        cmd.Parameters.Add("@Edicion", MySqlDbType.VarChar).Value = txtEdicion.Text.Trim();
                    }

                    cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = txtGenero.Text.Trim();

                    if (string.IsNullOrEmpty(txtPaginas.Text))
                    {
                        cmd.Parameters.Add("@Pag", MySqlDbType.VarChar).Value = "-";
                    }
                    else
                    {
                        cmd.Parameters.Add("@Pag", MySqlDbType.VarChar).Value = txtPaginas.Text.Trim();
                    }

                    cmd.Parameters.Add("@Precio", MySqlDbType.Double).Value = Convert.ToDouble(txtPrecio.Text.Trim());
                    cmd.Parameters.Add("@Disponibilidad", MySqlDbType.Int16).Value = 1;

                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se guardaron los datos capturados");
                            return true;
                        }
                    }
                    catch (MySqlException sqlEx)
                    {
                        if (sqlEx.Number == 1062)
                        {
                            MessageBox.Show("El registro de este libro ya existe. \nIntente registrar otro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            /*MessageBox.Show("El libro ya ha sido llamado antes. Intente con otro cliente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido guardar los datos del libro.\nError: " + sqlEx.Message, "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            } 
            return false;            
        }

        public void editarLibro()
        {
            string peticion;

            peticion = "UPDATE libros SET Titulo ='" + txtTitulo.Text + "', Autor ='" + txtAutor.Text + "', Editorial ='" + txtEditorial.Text + "', AñoPub ='" 
                + txtAñoPub.Text + "', PaisPub ='" + txtPaisPub.Text + "', Edicion ='" + txtEdicion.Text + "', Genero ='" + txtGenero.Text + "', NumPag ='" 
                + txtPaginas.Text + "', PrecioLibro ='" + txtPrecio.Text + "' where IdLibro='" + txtClaveLibro.Text + "';";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);//Principal.connstring);
                conexion.Open();
                MySql.Data.MySqlClient.MySqlCommand comando = new MySql.Data.MySqlClient.MySqlCommand(peticion, conexion);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {

            }
        }​​​​

        public void eliminarLibro()
        {
            string peticion;

            peticion = "DELETE FROM libros WHERE IdLibro='" + txtClaveLibro.Text.Trim() + "';";

            try
            {
                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);//Principal.connstring);
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
                eliminarLibro();
                MessageBox.Show("Se eliminó el registro del libro");
                txtClaveLibro.Focus();
            } 
        }


    }
}
