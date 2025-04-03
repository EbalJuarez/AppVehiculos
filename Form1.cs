using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            this.Hide();
            registros.Show();
        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler(); 
            this.Hide(); 
            alquiler.Show();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
            this.Hide();
        }
    }
}
