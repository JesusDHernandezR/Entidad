using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Contrato
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string TipoDeContrato { get; set; }
        public decimal ValorDeContrato { get; set; }

        public void CalcularPago()
        {

        }
    }
}
