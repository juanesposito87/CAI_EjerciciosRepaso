using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public class Alumno : Persona
    {
        private int _codigo;
        public Alumno(DateTime FechaNac) : base(FechaNac)
        {

        }
        public Alumno(DateTime FechaNac, int Codigo) : base(FechaNac)
        {
            Codigo = _codigo;
        }

        public override string GetCredencial()
        {
            return String.Format("Código {0} {1}, {2}", this._codigo, this._apellido, this._nombre);
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public override string ToString()
        {
            return this.GetCredencial();
        }
    }
}
