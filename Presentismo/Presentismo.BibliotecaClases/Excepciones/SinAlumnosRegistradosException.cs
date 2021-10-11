using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPresentismo.BibliotecaClases.Excepciones
{
    public class SinAlumnosRegistradosException : Exception
    {
        public SinAlumnosRegistradosException(string F) : base (String.Format("No hay registros para la fecha {0}", F))
        {

        }
    }
}
