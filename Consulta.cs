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
        Reporte Reporte = new Reporte();
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

        private void Cargar_Alquileres()
        {
            Lista_Alquileres = ProcesosGuardado.LeerAl("../../Registro_Alquileres"); 
            foreach(var alquileres in Lista_Alquileres)
            {
                foreach(var clientes in Lista_Clientes)
                {
                    foreach (var vehiculso in Lista_Vehiculos)
                    {
                        if (alquileres.Nit_al == clientes.Nit && alquileres.Placa_al == vehiculso.Placa)
                        {
                            Reporte.Name = clientes.Nombre;
                            Reporte.Placa = alquileres.Placa_al;
                            Reporte.Pre_km = vehiculso.P_km;
                            Reporte.Color = vehiculso.color;
                            Reporte.Modelo = vehiculso.Modelo;
                            Reporte.Marca = vehiculso.Marca;
                            Reporte.total = alquileres.Km_rec * vehiculso.P_km;
                        }
                        Lista_Reporte.Add(Reporte);
                    } 
                }
            }
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = Lista_Reporte;
            dataGridViewReporte.Refresh();
        }
        private void Consulta_Load(object sender, EventArgs e)
        {
            Cargar_Clientes();
            Cargar_Vehiculos();
            Cargar_Alquileres();
        }
    }
}
