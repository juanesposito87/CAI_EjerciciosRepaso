using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPresentismo.BibliotecaClases.Entidades.Abstractas;

namespace EjercicioPresentismo.BibliotecaClases.Entidades
{
    public class AlumnoOyente : Alumno
    {

        public AlumnoOyente(int Reg, string N, string A) : base(Reg, N, A)
        {
        }

        public AlumnoOyente(string N, string A) : base(N, A)
        {
        }
    }
}
