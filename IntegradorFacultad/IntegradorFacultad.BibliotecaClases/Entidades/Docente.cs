using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public class Docente : Empleado
    {
        public Docente(DateTime FechaNac, DateTime FechaIng, string Ape, string Nomb) : base(FechaNac, FechaIng, Ape, Nomb)
        {

        }
        
        public override string GetNombreCompleto()
        {
            return String.Format("Docente {0}", this._nombre);
        }

    }
}
