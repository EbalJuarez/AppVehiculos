using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppVehiculos
{
    internal class ProcesosGuardado
    {
        public void GuardarC(string archivo, List<Clientes> asistencias)
        {
            string json = JsonConvert.SerializeObject(asistencias);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Clientes> LeerC(string archivo)
        {
            List<Clientes> lista = new List<Clientes>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Clientes>>(json);
            return lista;
        }
        public void GuardarV(string archivo, List<Vehiculos> asistencias)
        {
            string json = JsonConvert.SerializeObject(asistencias);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Vehiculos> LeerV(string archivo)
        {
            List<Vehiculos> lista = new List<Vehiculos>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Vehiculos>>(json);
            return lista;
        }

        public void GuardarAl(string archivo, List<Alquileres> asistencias)
        {
            string json = JsonConvert.SerializeObject(asistencias);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Alquileres> LeerAl(string archivo)
        {
            List<Alquileres> lista = new List<Alquileres>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Alquileres>>(json);
            return lista;
        }
    }
}
