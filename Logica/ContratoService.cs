using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Logica
{
    public class ContratoService
    {
        ContratoRepository personaRepository;
        public ContratoService()
        {
            personaRepository = new ContratoRepository();
        }
        public string Guardar(Contrato persona)
        {
            try
            {
                if (persona.Equals(null))
                {
                    return $"Lo sentimos no se pudo guardar";
                }
                else
                {
                    personaRepository.Guardar(persona);
                    return $"se han guardado Satisfactoriamente los datos de: {persona.Nombre} ";                   
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }
        public List<Contrato> Consultar()
        {
            try
            {
                List<Contrato> listaContrato = personaRepository.Consultar();
                return listaContrato;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
