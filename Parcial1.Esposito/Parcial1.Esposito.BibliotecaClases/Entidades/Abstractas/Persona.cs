using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _email;

        public Persona(string Nombre, string Apellido)
        {
            _nombre = Nombre;
            _apellido = Apellido;
        }

        public Persona(string Nombre, string Apellido, string Email)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _email = Email;
        }

        public override string ToString()
        {
            return Mostrar();
        }

        internal abstract string Mostrar();
    }
}
