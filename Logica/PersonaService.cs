using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Logica
{
    public class PersonaService
    {
        PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public string Guardar(Persona persona)
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
    }
}
