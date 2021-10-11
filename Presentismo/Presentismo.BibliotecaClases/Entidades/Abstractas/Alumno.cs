using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPresentismo.BibliotecaClases.Entidades.Abstractas;

namespace EjercicioPresentismo.BibliotecaClases.Entidades
{
    public abstract class Alumno : Persona
    {
        private int _registro;
        private static int RegistroActual = 1;

        public Alumno(string N, string A) : base(N, A)
        {
            _registro = RegistroActual;
            RegistroActual++;
        }

        public Alumno(int R, string N, string A) : base(N, A)
        {
            _registro = R;
            RegistroActual = R;
        }

        public int Registro
        {
            get
            {
                return _registro;
            }

            set
            {
                _registro = value;
            }
        }

        internal override string Display()
        {
            if (this is AlumnoRegular)
            {
                return this.ToString();
            }
            if (this is AlumnoOyente)
            {
                return String.Format("El alumno {0} es oyente.", this.ToString());
            }
            else
            {
                return "Error inesperado.";
            }
        }
    }
}
