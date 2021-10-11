using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPresentismo.BibliotecaClases.Entidades
{
    public class Asistencia
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        public string FechaReferencia
        {
            get
            {
                return _fechaReferencia;
            }
        }
        
        public Asistencia (string FechaRef, Preceptor p, Alumno a, bool Presente)
        {
            _fechaReferencia = FechaRef;
            _fechaHoraReal = DateTime.Now;
            _preceptor = p;
            _alumno = a;
            _estaPresente = Presente;
        }

        public override string ToString()
        {
            return String.Format("{0}{1} está presente {2} por {3} registrado el {4}", _fechaReferencia, _alumno.ToString(), EstaPresenteSiNO, _preceptor.ToString(), _fechaHoraReal.ToString());
        }

        private string EstaPresenteSiNO
        {
            get
            {
                if(_estaPresente)
                {
                    return "SI";
                }
                else
                {
                    return "NO";
                }
            }
        }

        public Alumno Alumno
        {
            get
            {
                return _alumno;
            }
        }

        public Preceptor Preceptor
        {
            get
            {
                return _preceptor;
            }
        }
    }
}
