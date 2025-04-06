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
    public partial class Reg_Per : Form
    {
        List<Clientes> Lista_Clientes = new List<Clientes>();
        Clientes cliente= new Clientes();
        ProcesosGuardado Guardado = new ProcesosGuardado();
        public Reg_Per()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Per_Load(object sender, EventArgs e)
        {
            Lista_Clientes = Guardado.LeerC("../../Registro_Clientes");
        }
        private void clear()
        {
            textBoxDireccion.Text = string.Empty;
            textBoxNit.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = textBoxNombre.Text;
            cliente.Direccion = textBoxDireccion.Text;
            cliente.Nit = int.Parse(textBoxNit.Text);
            Lista_Clientes.Add(cliente);
            Guardado.GuardarC("../../Registro_Clientes",Lista_Clientes);
            clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Registros registros = new Registros();
            registros.Show();
        }
    }
}
