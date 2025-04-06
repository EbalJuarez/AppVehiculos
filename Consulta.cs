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
    public partial class Consulta : Form
    {
       
        List<Reporte> Lista_Reporte = new List<Reporte>();
        List<Vehiculos> Lista_Vehiculos = new List<Vehiculos>();
        List<Clientes> Lista_Clientes = new List<Clientes>();
        List<Alquileres> Lista_Alquileres = new List<Alquileres>();
        ProcesosGuardado ProcesosGuardado = new ProcesosGuardado();
        public Consulta()
        {
            InitializeComponent();
        }

        private void Cargar_Clientes()
        {
            Lista_Clientes = ProcesosGuardado.LeerC("../../Registro_Clientes");
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = Lista_Clientes;
            dataGridViewClientes.Refresh();
        }

        private void Cargar_Vehiculos()
        {
            Lista_Vehiculos = ProcesosGuardado.LeerV("../../Registro_Vehiculos");
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource= Lista_Vehiculos;
            dataGridViewVehiculos.Refresh();
        }

        private void Cargar_Reporte()
        {
            Lista_Reporte = ProcesosGuardado.LeerRep("../../Reportes");
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = Lista_Reporte;
            dataGridViewReporte.Refresh();
        }
        private void Consulta_Load(object sender, EventArgs e)
        {
            Cargar_Clientes();
            Cargar_Vehiculos();
            Cargar_Reporte();
        }

        private void dataGridViewVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Mostrar todos")
            {
                Cargar_Reporte();
            }
            if (comboBox1.SelectedItem.ToString() == "De mayor a menor (Total a pagar)")
            {
                Lista_Reporte = ProcesosGuardado.LeerRep("../../Reportes");
                Lista_Reporte = Lista_Reporte.OrderByDescending(x => x.total).ToList();
                dataGridViewReporte.DataSource = null;
                dataGridViewReporte.DataSource = Lista_Reporte;
                dataGridViewReporte.Refresh();
            }
        }
    }
}
