using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPresentismo.BibliotecaClases.Entidades.Abstractas
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

        public override string ToString()
        {
            if (this is Preceptor)
            {
                return String.Format("{0} - {1}", _apellido, ((Preceptor)this).Legajo);
            }
            else if (this is Alumno)
            {
                return String.Format("{0} ({1})", _nombre, ((Alumno)this).Registro);
            }
            else
            {
                return "Error inesperado";
            }
        }

        internal abstract string Display();

    }
}
