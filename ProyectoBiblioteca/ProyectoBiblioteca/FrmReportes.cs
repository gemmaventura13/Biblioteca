﻿using System;
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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha registrado nada aun");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha registrado un prestamo interno aun");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha registrado un prestamo externo aun");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
