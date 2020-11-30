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
using Microsoft.Reporting.WinForms;


namespace ProyectoBiblioteca
{
    public partial class FrmReportePrestamos : Form
    {
        string connstring = "Server=localhost;User id=root;Database=biblioteca;password=;Convert Zero Datetime=True";

        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string peticion = "SELECT IdPrestamo, Fecha, CantidadLibro, IdCliente FROM prestamos ORDER BY IdPrestamo";
                MySqlConnection cn = new MySqlConnection(connstring);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(peticion, cn);
                da.Fill(dt);

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rp = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rp);
                reportViewer1.RefreshReport();
            }
            catch 
            {
                MessageBox.Show("No hay datos capturados");
            }

        }
        
    }
}
