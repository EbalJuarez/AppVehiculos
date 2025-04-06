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
        
        ProcesosGuardado guardado = new ProcesosGuardado();
        public Reg_Vehi()
        {
            InitializeComponent();
        }

        private void clear()
        {
            textBoxColor.Text = string.Empty;
            textBoxMarca.Text = string.Empty;
            textBoxModelo.Text = string.Empty;
            textBoxPlaca.Text = string.Empty;
            textBoxPre_Km.Text = string.Empty;
        }
        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.Placa = textBoxPlaca.Text;
            vehiculo.Modelo = textBoxModelo.Text;
            vehiculo.P_km = float.Parse(textBoxPre_Km.Text);
            vehiculo.color = textBoxColor.Text;
            vehiculo.Marca = textBoxMarca.Text;
            Listas_Ve.Add(vehiculo);
            guardado.GuardarV("../../Registro_Vehiculos", Listas_Ve);
            clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Registros registros = new Registros();
            registros.Show();
        }

        private void Reg_Vehi_Load(object sender, EventArgs e)
        {
            Listas_Ve = guardado.LeerV("../../Registro_Vehiculos");
        }
    }
}
