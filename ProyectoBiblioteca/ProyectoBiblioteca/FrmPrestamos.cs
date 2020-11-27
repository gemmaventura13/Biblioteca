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
    public partial class FrmPrestamos : Form
    {
        public static string connstring = "Server=localhost;User id=root;Database=biblioteca;password=;Convert Zero Datetime=True";

        public FrmPrestamos()
        {
            InitializeComponent();
        }

        public void LimpiarCampos() 
        {
            
            TxtIdCliente.Text = "";
            TxtIdLibro.Text = "";
            TxtNomCli.Text = "";
            TxtNombreLibro.Text = "";
            TxtNumPrestamo.Text = "";
            TxtHora.Text = "";
            FechaSelector.Text = "";
            
            
            TxtIdCliente.Focus();
        }

        private void IdUsuario_Click(object sender, EventArgs e)
        {

        }


        private void GuardaDgvPrestamo()
        {

            //String FPrecio = string.Format("{0:#,##0.00;-#,##0.00}", XPrecio);

            //String FImporte = string.Format("{0:#,##0.00;-#,##0.00}", XImporte);

            //String FIva = string.Format("{0:#,##0.00;-#,##0.00}", XIva);

            //TxtImporte.Text = string.Format("{0:#,##0.00;-#,##0.00}", decimal.Parse(TxtImporte.Text));

            dataGridView1.Rows.Add(TxtIdCliente.Text, TxtNomCli.Text, TxtNumPrestamo.Text, TxtNombreLibro.Text, TxtIdLibro.Text, TxtHora.Text, FechaSelector.Text);

        }
        
        public void CargarLibros()
        {
            string peticion; //Variable para peticion SQL

            DataTable tabla = new DataTable();


            peticion = "SELECT IdCliente, NombreCli, NumPrestamo ,NombreLibro ,IdLibro ,FechaRetiro ,HoraPrestamo FROM prestamosinternos";

            try
            {

                MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(connstring);

                conexion.Open();

                MySql.Data.MySqlClient.MySqlDataAdapter comando = new MySql.Data.MySqlClient.MySqlDataAdapter(peticion, conexion);



                DataTable dt = new DataTable();

                comando.Fill(dt);


                dataGridView1.DataSource = dt;


                conexion.Close();

            }

            catch { }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TxtHora.Text = DateTime.Now.ToString("HH:mm:ss");
            

        }
                
        
        private void TxtHora_TextChanged(object sender, EventArgs e)
        {
            TxtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            GuardarPrestamoInterno();
            GuardaDgvPrestamo();
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public bool GuardarPrestamoInterno()
        {
            int bandera = 0;
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO prestamosinternos(IdCliente, NombreCli, NumPrestamo, NombreLibro, IdLibro, FechaRetiro, HoraPrestamo ) " +
                "VALUES (@IdCliente, @NombreCli, @NumPrestamo, @NombreLibro, @IdLibro, @FechaRetiro, @HoraPrestamo )", conn))
                {
                    // cmd.Parameters.Add("@IdUsuario", MySqlDbType.VarChar).Value = txtIdUsuario.Text;
                    cmd.Parameters.Add("@IdCliente", MySqlDbType.Int32).Value = Convert.ToInt64(TxtIdCliente.Text);
                    cmd.Parameters.Add("@NombreCli", MySqlDbType.VarChar).Value = TxtNomCli.Text;
                    cmd.Parameters.Add("@NumPrestamo", MySqlDbType.VarChar).Value = TxtNumPrestamo.Text;
                    cmd.Parameters.Add("@NombreLibro", MySqlDbType.VarChar).Value = TxtNombreLibro.Text;
                    cmd.Parameters.Add("@IdLibro", MySqlDbType.Int32).Value = Convert.ToInt64(TxtIdLibro.Text);
                    cmd.Parameters.Add("@FechaRetiro", MySqlDbType.VarChar).Value = FechaSelector.Text;
                    cmd.Parameters.Add("@HoraPrestamo", MySqlDbType.VarChar).Value = TxtHora.Text;

                    bandera = 1;

                    if (bandera == 1)
                    {
                        try
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("SE HAN GUARDADO LOS DATOS CORRECTAMENTE");
                                return true;
                            }



                        }
                        catch (MySqlException sqlEx)
                        {
                            if (sqlEx.Number == 1062)
                            {
                                MessageBox.Show("El numero de prestamo ya existe. Intente con otro ", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido guardar el prestamo llamado.\nError: " + sqlEx.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                        }
                    }
                }
                return false;
            }
        }​​

    }
}
