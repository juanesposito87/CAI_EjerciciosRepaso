using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public abstract class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;
    
        public Persona(DateTime FechaNac)
        {
            _fechaNac = FechaNac;
        }

        public Persona(DateTime FechaNac, string Apellido, string Nombre)
        {
            _fechaNac = FechaNac;
            _apellido = Apellido;
            _nombre = Nombre;
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

        public int Edad
        {
            get
            {
                if((DateTime.Now.Month >= _fechaNac.Month) && (DateTime.Now.Day >= _fechaNac.Day))
                {
                    return (DateTime.Now.Year - _fechaNac.Year);

                }
                else
                { 
                    return (DateTime.Now.Year - _fechaNac.Year - 1);
                }
            }
        }

        public virtual string GetCredencial()
        {
            return ("Nombre: " + this._nombre + System.Environment.NewLine + "Apellido: " + this._apellido + System.Environment.NewLine + "Edad: " + Convert.ToString(this.Edad));
        }

        public virtual string GetNombreCompleto()
        {
            return String.Format("{0}, {1}", this.Nombre, this.Apellido);
        }

    }

}
