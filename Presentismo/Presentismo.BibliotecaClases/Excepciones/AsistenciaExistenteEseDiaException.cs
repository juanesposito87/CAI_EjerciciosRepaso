using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPresentismo.BibliotecaClases.Excepciones
{
    public class AsistenciaExistenteEseDiaException : Exception
    {
        public AsistenciaExistenteEseDiaException(string Fecha) : base(String.Format("Error: ya existen asistencias registradas para el día {0}", Fecha))
        {

        }
    }
}
