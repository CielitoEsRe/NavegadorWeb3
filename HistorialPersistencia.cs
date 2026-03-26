using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NavegadorWeb
{
    internal class HistorialPersistencia
    {
        private string archivo = "historial.json";

        public List<Direccion> Leer()
        {
            if (!File.Exists(archivo))
                return new List<Direccion>();

            string json = File.ReadAllText(archivo);

            return JsonConvert.DeserializeObject<List<Direccion>>(json)
                   ?? new List<Direccion>();
        }

        public void Guardar(List<Direccion> direcciones)
        {
            string json = JsonConvert.SerializeObject(direcciones, Formatting.Indented);
            File.WriteAllText(archivo, json);
        }
    }
}