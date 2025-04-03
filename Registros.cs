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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void buttonPersonas_Click(object sender, EventArgs e)
        {
            Reg_Per reg_Per = new Reg_Per();
            this.Close();
            reg_Per.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonVehiculos_Click(object sender, EventArgs e)
        {
            this.Close();
            Reg_Vehi reg_Vehi = new Reg_Vehi();
            reg_Vehi.Show();    
        }
    }
}
