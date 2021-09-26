using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public class Directivo : Empleado
    {
        public Directivo(DateTime FechaNac, DateTime FechaIng, string Ape, string Nomb) : base(FechaNac, FechaIng, Ape, Nomb)
        {

        }

        public override string GetNombreCompleto()
        {
            return String.Format("Sr. Director {0}", this._apellido);
        }
    }
}
