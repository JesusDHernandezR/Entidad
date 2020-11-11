using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class ContratoRepository
    {
        private readonly string FileName = "Persona.txt";
        public void Guardar(Contrato persona)
        {
            FileStream origen = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(origen);
            writer.WriteLine(persona.Id + ";" + persona.Nombre + ";" +
            persona.FechaNacimiento.ToString("dd/MM/yyyy") + ";" + persona.Direccion+";"+persona.TipoDeContrato+";"+
            persona.ValorDeContrato);
            writer.Close();
            origen.Close();
        }

        public List<Contrato> Consultar()
        {
            List<Contrato> personas = new List<Contrato>();
            FileStream origen = new FileStream(FileName, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Contrato persona = Mapear(linea);
                personas.Add(persona);
            }
            reader.Close();
            origen.Close();
            return personas;
        }
        private Contrato Mapear(string linea)
        {
            string[] datos = linea.Split(';');
            Contrato persona = new Contrato();
            persona.Id = datos[0];
            persona.Nombre = datos[1];
            persona.FechaNacimiento = DateTime.Parse(datos[2]);
            persona.Direccion = datos[3];
            persona.TipoDeContrato = datos[4];
            persona.ValorDeContrato = decimal.Parse(datos[5]);
            return persona;
        }
    }
}
