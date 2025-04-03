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
    public partial class Alquiler : Form
    {
        List<Alquileres> Lista_Alquileres = new List<Alquileres>();
        Alquileres alquileres = new Alquileres();
        public Alquiler()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonRegAl_Click(object sender, EventArgs e)
        {
            alquileres.Placa_al = comboBoxPlaca.SelectedItem.ToString();
            alquileres.Nit_al = int.Parse(comboBoxNit.SelectedItem.ToString());
            alquileres.Fecha_dev = monthCalendarDevolucion.SelectionStart;
            alquileres.Fecha_al = monthCalendarAlquiler.SelectionStart;
            alquileres.Km_rec = int.Parse(textBoxKmRecorrido.Text);
            Lista_Alquileres.Add(alquileres);
        }
    }
}
