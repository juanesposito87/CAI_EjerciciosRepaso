using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPresentismo.BibliotecaClases.Excepciones;

namespace EjercicioPresentismo.BibliotecaClases.Entidades
{
    public class Presentismo
    {
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;

        public Presentismo()
        {
            _preceptores = new List<Preceptor>();
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _fechas = new List<string>();

            //datos de inicialización
            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }

        private bool AsistenciaRegistrada(string Fecha)
        {
            return this._fechas.Contains(Fecha);
        }

        private int GetCantidadAlumnosRegulares()
        {
            int Cantidad = 0;
            foreach (Alumno a in this._alumnos)
                {
                    if (a is AlumnoRegular)
                    {
                    Cantidad++;
                    }
                }
            return Cantidad++;
        }

        public Preceptor GetPreceptorActivo()
        {
            return _preceptores.Last();
        }

        public List<Alumno> GetListaAlumnos(string Fecha)
        {
            List<Alumno> Devolver = new List<Alumno>();
            foreach (Asistencia a in this._asistencias)
            {
                if (a.FechaReferencia == Fecha)
                {
                    Devolver.Add(a.Alumno);
                }
            }

            return Devolver;
        }

        public void AgregarAsistencia(List<Asistencia> Asistencias, string Fecha)
        {
            if (this.GetCantidadAlumnosRegulares() == Asistencias.Count)
            {
                if (!this.AsistenciaRegistrada(Fecha))
                {
                    foreach (Asistencia a in Asistencias)
                    {
                        _asistencias.Add(a);
                    }
                }
                else
                {
                throw new AsistenciaExistenteEseDiaException(Fecha);
                }
            }
            else
            {
                throw new AsistenciaInconsistenteException();
            }
        }

        public List<Asistencia> GetAsistenciasPorFecha(string Fecha)
        {
            if (_fechas.Contains(Fecha))
            {
                return _asistencias.FindAll(a => a.FechaReferencia == Fecha);
            }
            else
            {
                throw new SinAlumnosRegistradosException(Fecha);
            }
        }

        public List<Alumno> GetListaAlumnos()
        {
            return this._alumnos;
        }
       
    }
}
