using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas
{
    public abstract class Estudiante : Persona
    {
        private int _registro;

        public Estudiante(int Registro, string Nombre, string Apellido) : base(Nombre, Apellido)
        {
            _registro = Registro;
        }

        public Estudiante(int Registro, string Nombre, string Apellido, string Email) : base(Nombre, Apellido, Email)
        {
            _registro = Registro;
        }

        internal override string Mostrar()
        {
            return String.Format("{0} ({1})", this._nombre, this._email);
        }

        public int Registro
        {
            get
            {
                return _registro;
            }
        }
    }
}
