using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVehiculos
{
    internal class Reporte
    {
        public string Name { get; set; }
        public string Placa { get; set; }
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public float Pre_km { get; set; }
        public DateTime Fec_Reg { get; set; }
        public float total {  get; set; }
    }
}
