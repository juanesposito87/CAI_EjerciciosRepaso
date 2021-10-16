using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Esposito.BibliotecaClases.Entidades.Abstractas;
using Parcial1.Esposito.BibliotecaClases.Excepciones;

namespace Parcial1.Esposito.BibliotecaClases.Entidades
{
    public class Instituto
    {
        private string _nombre;
        private List<Profesor> _profesores;
        private List<Estudiante> _estudiantes;
        private List<Inscripcion> _inscripciones;
        private List<Materia> _materias;

        public Instituto (string Nombre)
        {
            _nombre = Nombre;
            _profesores = new List<Profesor>();
            _estudiantes = new List<Estudiante>();
            _inscripciones = new List<Inscripcion>();
            _materias = new List<Materia>();

            _estudiantes.Add(new EstudianteRecursante(123, "Carlos", "Juarez", "cjua@gmail.com", 2));
            _estudiantes.Add(new EstudianteRecursante(124, "Carla", "Jaime", "cjai@gmail.com", 3));
            _estudiantes.Add(new EstudianteNuevo(320, "Ramona", "Vals", "vals@gmail.com"));
            _estudiantes.Add(new EstudianteNuevo(321, "Alejandro", "Medina", "medi@gmail.com"));

            _profesores.Add(new Profesor(5, "Jorgelina", "Ramos"));
            _profesores.Add(new Profesor(6, "Juan", "Gutierrez"));

            _materias.Add(new Materia(1, "Matemática Discreta I"));
            _materias.Add(new Materia(1, "Algoritmos I"));
            _materias.Add(new Materia(1, "Electromagnetismo I"));

        }

        public Profesor GetProfesor(int legajo)
        {
            int IndexBuscado = -1;
            foreach(Profesor p in this._profesores)
            {
                if(p.Legajo == legajo)
                {
                    IndexBuscado = this._profesores.IndexOf(p);
                }
            }

            if(IndexBuscado!=-1)
            {
                return this._profesores.ElementAt(IndexBuscado);
            }
            else
            {
                throw new Exception("No se encontró Profesor con legajo " + Convert.ToString(legajo));
            }
        }

        public List<Materia> GetMaterias()
        {
            return this._materias;
        }

        public List<Estudiante> GetEstudiantes()
        {
            return this._estudiantes;
        }

        public void CargarInscripcion(Inscripcion i)
        {
            Estudiante YaInscripto = (_inscripciones.Find(inscr => ((inscr.Estudiante.Registro == i.Estudiante.Registro) && (inscr.Materia.Codigo == i.Materia.Codigo)))).Estudiante;
            if(!(YaInscripto is null))
            {
                throw new EstudianteInscriptoException(YaInscripto, i.Materia);
            }

            else
            {
                if (i.Estudiante is EstudianteRecursante)
                {
                    if(((EstudianteRecursante)i.Estudiante).CantidadCursosTomados >= 3)
                    {
                        throw new EstudianteInhabilitadoException(i.Estudiante);
                    }

                    else
                    {
                        this._inscripciones.Add(i);
                    }
                }
                else
                {
                    this._inscripciones.Add(i);
                }
            }
            
        }

        public List<Inscripcion> GetInscripcionesPorFecha (DateTime Fecha)
        {
            return this._inscripciones.FindAll(c => c.FechaInscripcion == Fecha);
        }

    }
}
