using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;

namespace Parcial1.Esposito.BibliotecaClases.Entidades
{
    public class EstudianteRecursante : Estudiante
    {
        private int _cantidadCursosTomados;

        public EstudianteRecursante (int R, string N, string A, int Q) : base(R, N, A)
        {
            _cantidadCursosTomados = Q;
        }

        public EstudianteRecursante(int R, string N, string A, string E, int Q) : base(R, N, A, E)
        {
            _cantidadCursosTomados = Q;
        }

        public int CantidadCursosTomados
        {
            get
            {
                return _cantidadCursosTomados;
            }
        }
    }
}
