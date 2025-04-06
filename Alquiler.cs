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
        ProcesosGuardado ProcesosGuardado = new ProcesosGuardado();
        List<Alquileres> Lista_Alquileres = new List<Alquileres>();
        List<Clientes> Lista_Clientes = new List<Clientes>();
        List<Vehiculos> Lista_Vehiculos = new List<Vehiculos>(); 
        List<Reporte> Lista_Reporte = new List<Reporte>(); 
        Alquileres alquileres = new Alquileres();
        public Alquiler()
        {
            InitializeComponent();
        }

        private void RellenarCombos()
        {
            Lista_Clientes = ProcesosGuardado.LeerC("../../Registro_Clientes");
            Lista_Vehiculos = ProcesosGuardado.LeerV("../../Registro_Vehiculos");
            foreach(var Clientes in Lista_Clientes)
            {
                comboBoxNit.Items.Add(Clientes.Nit);
            }
            foreach(var Vehiculos in Lista_Vehiculos)
            {
                comboBoxPlaca.Items.Add(Vehiculos.Placa);
            }
        }

        private void Clear()
        {
            textBoxKmRecorrido.Text = string.Empty;
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

        private void crear_Reporte()
        {
            Lista_Reporte = ProcesosGuardado.LeerRep("../../Reportes");
            foreach (var alquileres in Lista_Alquileres)
            {
                foreach (var clientes in Lista_Clientes)
                {
                    foreach (var vehiculso in Lista_Vehiculos)
                    {
                        if (clientes.Nit == alquileres.Nit_al && alquileres.Placa_al == vehiculso.Placa)
                        {
                            Reporte Reporte = new Reporte();
                            Reporte.Name = clientes.Nombre;
                            Reporte.Placa = alquileres.Placa_al;
                            Reporte.Pre_km = vehiculso.P_km;
                            Reporte.Color = vehiculso.color;
                            Reporte.Modelo = vehiculso.Modelo;
                            Reporte.Marca = vehiculso.Marca;
                            Reporte.Fec_Reg = alquileres.Fecha_dev;
                            Reporte.total = alquileres.Km_rec * vehiculso.P_km;
                            Lista_Reporte.Add(Reporte);
                        }

                    }
                }
            }
            ProcesosGuardado.GuardarRep("../../Reportes", Lista_Reporte);

        }

        private void buttonRegAl_Click(object sender, EventArgs e)
        {
            alquileres.Placa_al = comboBoxPlaca.SelectedItem.ToString();
            alquileres.Nit_al = int.Parse(comboBoxNit.SelectedItem.ToString());
            alquileres.Fecha_dev = monthCalendarDevolucion.SelectionStart;
            alquileres.Fecha_al = monthCalendarAlquiler.SelectionStart;
            alquileres.Km_rec = int.Parse(textBoxKmRecorrido.Text);
            Clear();
            Lista_Alquileres.Add(alquileres);
            ProcesosGuardado.GuardarAl("../../Registro_Alquileres", Lista_Alquileres);
            crear_Reporte();
        }

        private void Alquiler_Load(object sender, EventArgs e)
        {
            RellenarCombos();
        }
    }
}
