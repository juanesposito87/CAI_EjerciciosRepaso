using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;
using Parcial1.Esposito.BibliotecaClases.Entidades;

namespace Parcial1.Esposito.BibliotecaClases.Excepciones
{
    public class EstudianteInhabilitadoException : Exception
    {
        public EstudianteInhabilitadoException(Estudiante e) : base(String.Format("El estudiante {0} se encuentra inhabilitado para la inscripción, por haber tomado {1} cursos.", e.ToString(), ((EstudianteRecursante)e).CantidadCursosTomados))
        {

        }
    }
}
