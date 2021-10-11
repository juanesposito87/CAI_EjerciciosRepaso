using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPresentismo.BibliotecaClases.Entidades.Abstractas;


namespace EjercicioPresentismo.BibliotecaClases.Entidades
{
    public class AlumnoRegular : Alumno
    {
        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public AlumnoRegular(int R, string N, string A, string E) : base(R, N, A)
        {
            _email = Email;

        }

        public AlumnoRegular(string N, string A, string E) : base(N, A)
        {
            _email = Email;
        }
    }
}
