using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentismo.BibliotecaClases.Entidades
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public Persona( string Nombre, string Apellido)
        {
            _nombre = Nombre;
            _apellido = Apellido;
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }



    }
}
