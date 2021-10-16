using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;

namespace Parcial1.Esposito.BibliotecaClases.Entidades
{
    public class Profesor : Persona
    {
        private int _legajo;

        public Profesor (int L, string N, string A, string E) : base(N, A, E)
        {
            _legajo = L;
        }

        public Profesor(int L, string N, string A) : base(N, A)
        {
            _legajo = L;
        }

        internal override string Mostrar()
        {
            return String.Format("{0} - {1}",this._apellido, this._legajo);
        }

        public int Legajo
        {
            get
            {
                return _legajo;
            }
        }

            

    }
}
