using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Excepciones
{
    public class AlumnoNoEncontradoExc : Exception
    {
        public AlumnoNoEncontradoExc()
        {

        }

        public AlumnoNoEncontradoExc(string Parametro) : base(Parametro)
        {

        }

        //lo declarado en el constructor base es lo que se guarda en la excepcion.Message
    }
}

/* Uso de excepciones:
Frente a un escenario donde puede darse una excepción:
try
{
Se llama al método involucrado, y se implementa el camino feliz.
}
catch (ClaseExcepcion nombre)
{
    Acá va lo que se muestra si el try falló.
    En general va a ser un console writeline con el mensaje de la excepción (nombre.Message).
}


En la implementación del método involucrado, tiene que estar definido el escenario que arroja la custom excepcion, con la declaración throw new ClaseExcepción(parametro);
*/