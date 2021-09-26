using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public class Bedel : Empleado
    {
        private string _apodo;
        public Bedel(DateTime FechaNac, DateTime FechaIng, string Ape, string Nomb) : base(FechaNac, FechaIng, Ape, Nomb)
        {

        }
        public Bedel(DateTime FechaNac, DateTime FechaIng, string Ape, string Nomb, string Apodo) : base(FechaNac, FechaIng, Ape, Nomb)
        {
            _apodo = Apodo;
        }

        public override string GetNombreCompleto()
        {
            return String.Format("Bedel {0}", this._apodo);
        }

        public string Apodo
        {
            get
            {
                return _apodo;
            }
            set
            {
                _apodo = value;
            }
        }
    }
}
