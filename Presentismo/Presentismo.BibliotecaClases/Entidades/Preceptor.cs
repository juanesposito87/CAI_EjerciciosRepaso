using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPresentismo.BibliotecaClases.Entidades.Abstractas;

namespace EjercicioPresentismo.BibliotecaClases.Entidades
{
    public class Preceptor : Persona
    {
        private int _legajo;
        private static int LegajoActual = 1;

        public Preceptor(string N, string A) : base(N, A)
        {
            _legajo = LegajoActual;
            LegajoActual++;
        }

        public Preceptor(int L, string N, string A) : base(N, A)
        {
            _legajo = L;
            LegajoActual = L;
        }
        public int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }

        internal override string Display()
        {
            return this.ToString();
        }
    }
}
