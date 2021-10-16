using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;

namespace Parcial1.Esposito.BibliotecaClases.Entidades
{
    public class Inscripcion
    {
        private DateTime _fechaInscripcion;
        private Profesor _profesor;
        private Estudiante _estudiante;
        private Materia _materia;

        public Inscripcion (Profesor p, Estudiante e, Materia m)
        {
            _fechaInscripcion = DateTime.Now;
            _profesor = p;
            _estudiante = e;
            _materia = m;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} inscripto a {2}", this._fechaInscripcion.ToString("yyyy-MM-dd"), this._estudiante.Mostrar(), this._materia.ToString());         
        }

        public DateTime FechaInscripcion
        {
            get
            {
                return _fechaInscripcion;
            }
        }

        public Estudiante Estudiante
        {
            get
            {
                return _estudiante;
            }
        }

        public Materia Materia
        {
            get
            {
                return _materia;
            }
        }

    }
}
