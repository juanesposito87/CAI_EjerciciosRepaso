using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;
using Parcial1.Esposito.BibliotecaClases.Entidades;

namespace Parcial1.Esposito.BibliotecaClases.Excepciones
{
    public class EstudianteInscriptoException : Exception
    {
        public EstudianteInscriptoException(Estudiante e, Materia m) : base(String.Format("El estudiante {0} ya se encuentra inscripto a la materia {1}", e.ToString(), m.ToString()))
        {

        }
    }
}
