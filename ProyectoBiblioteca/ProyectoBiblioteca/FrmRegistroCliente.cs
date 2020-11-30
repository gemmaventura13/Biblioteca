﻿using System;
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
    public partial class FrmRegistroCliente : Form
    {
        public static string connstring = "Server=localhost;User id=root;Database=biblioteca;password=;Convert Zero Datetime=True";

        Validacion v = new Validacion();

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToShortTimeString();
            txtFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
            if (e.KeyChar == 13)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApellidos.Focus();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtFechaNacimiento.Focus();
            }
        }

        private void txtFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEdad.Focus();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbSexo.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            GuardarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quieres eliminar los datos?";
            string tituloBoton = "Ventana Eliminar";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloBoton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EliminarCliente();
            }
            MessageBox.Show("SE HAN ELIMINADO LOS DATOS CORRECTAMENTE");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Esta seguro de cancelar los Datos?";
            string tituloBoton = "Ventana Cancelar";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, tituloBoton, botones, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtIdUsuario.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
                txtEdad.Text = "";
                cmbSexo.Text = "";
            }

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

        public bool GuardarCliente()
        {
            int bandera = 0;
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connstring);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO usuarios(IdUsuario, Nombre, Apellidos, Edad, Sexo, Direccion, Email, FechaNac, Telefono ) " +
                "VALUES (@IdUsuario, @Nombre, @Apellidos, @Edad, @Sexo, @Direccion, @Email, @FechaNac, @Telefono )", conn))
                {
                    // cmd.Parameters.Add("@IdUsuario", MySqlDbType.VarChar).Value = txtIdUsuario.Text;
                    cmd.Parameters.Add("@IdUsuario", MySqlDbType.Int32).Value = Convert.ToInt64(txtIdUsuario.Text);
                    cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@Apellidos", MySqlDbType.VarChar).Value = txtApellidos.Text;
                    cmd.Parameters.Add("@Edad", MySqlDbType.VarChar).Value = txtEdad.Text;
                    cmd.Parameters.Add("@Sexo", MySqlDbType.VarChar).Value = cmbSexo.Text;
                    cmd.Parameters.Add("@Direccion", MySqlDbType.VarChar).Value = txtDireccion.Text;
                    cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@FechaNac", MySqlDbType.VarChar).Value = Convert.ToDateTime(txtFechaNacimiento.Text).ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@Telefono", MySqlDbType.VarChar).Value = txtTelefono.Text;
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
                                MessageBox.Show("El cliente ya existe. Intente con otro cliente.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido guardar el cliente llamado.\nError: " + sqlEx.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                return false;
            }
        }

        private void EliminarCliente()
        {
            string peticion;

            peticion = "DELETE FROM usuarios WHERE IdUsuario ='" + txtIdUsuario.Text + "';";

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

      


    }
}

