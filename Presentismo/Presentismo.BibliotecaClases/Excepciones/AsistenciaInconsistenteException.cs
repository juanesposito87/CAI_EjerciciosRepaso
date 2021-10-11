using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPresentismo.BibliotecaClases.Excepciones
{
    public class AsistenciaInconsistenteException : Exception
    {
        public AsistenciaInconsistenteException() : base ("Error. La cantidad de alumnos registrados en la lista de asistencia no coincide con la cantidad de alumnos regulares.")
        {

        }
    }
}
