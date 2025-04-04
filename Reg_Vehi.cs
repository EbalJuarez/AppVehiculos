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
    public partial class Reg_Vehi : Form
    {
        List<Vehiculos> Listas_Ve = new List<Vehiculos>();
        Vehiculos vehiculo = new Vehiculos();
        ProcesosGuardado guardado = new ProcesosGuardado();
        public Reg_Vehi()
        {
            InitializeComponent();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            vehiculo.Placa = textBoxPlaca.Text;
            vehiculo.Modelo = textBoxModelo.Text;
            vehiculo.P_km = float.Parse(textBoxPre_Km.Text);
            vehiculo.color = textBoxColor.Text;
            vehiculo.Marca = textBoxMarca.Text;
            Listas_Ve.Add(vehiculo);
            guardado.GuardarV("../../Registro_Vehiculos", Listas_Ve);
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Registros registros = new Registros();
            registros.Show();
        }
    }
}
