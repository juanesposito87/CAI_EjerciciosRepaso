using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;

namespace Parcial1.Esposito.BibliotecaClases.Entidades
{
    public class EstudianteNuevo : Estudiante
    {
        public EstudianteNuevo(int R, string N, string A, string E) : base(R, N, A, E)
        {

        }

        public EstudianteNuevo(int R, string N, string A) : base(R, N, A)
        {

        }
    }
}
