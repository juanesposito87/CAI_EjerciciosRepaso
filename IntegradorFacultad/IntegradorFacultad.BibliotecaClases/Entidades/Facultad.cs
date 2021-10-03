using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegradorFacultad.BibliotecaClases.Enum;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public class Facultad
    {
        //atributos
        List<Alumno> _alumnos;
        private int _cantidadSedes;
        List<Empleado> _empleados;
        private string _nombre;

        //propiedades
        public int CantidadSedes
        {
            get
            {
                return _cantidadSedes;
            }
            set
            {
                _cantidadSedes = value;
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

        public Facultad (string Nombre)
        {
            _nombre = Nombre;
            _alumnos = new List<Alumno>();
            _cantidadSedes = 1;
            _empleados = new List<Empleado>();
        }

        public Facultad (string Nombre, int Cant)
        {
            _nombre = Nombre;
            _alumnos = new List<Alumno>();
            _cantidadSedes = Cant;
            _empleados = new List<Empleado>();
        }


        public void AgregarAlumno(Alumno a)
        {
            this._alumnos.Add(a);
        }

        public void AgregarAlumno(DateTime Nacimiento, string Ape, string Nom, int Cod)
        {
            Alumno a = new Alumno(Nacimiento, Ape, Nom, Cod);
            this.AgregarAlumno(a);
        }

        public void AgregarEmpleado(Empleado e)
        {
            this._empleados.Add(e);
        }

        public void AgregarEmpleado(EmpleadoTipo Tipo, DateTime Nac, DateTime Ing, string Ap, string No, string Apo)
        {
            switch(Tipo)
            {
                case EmpleadoTipo.Bedel:
                    {
                        Bedel b = new Bedel(Nac, Ing, Ap, No, Apo);
                        this.AgregarEmpleado(b);
                        break;
                    }
                case EmpleadoTipo.Directivo:
                    {
                        Directivo di = new Directivo(Nac, Ing, Ap, No);
                        this.AgregarEmpleado(di);
                        break;
                    }
                case EmpleadoTipo.Docente:
                    {
                        Docente doc = new Docente(Nac, Ing, Ap, No);
                        this.AgregarEmpleado(doc);
                        break;
                    }
                default:
                    {
                        break;
                    }
                    
            }
        }

        public void EliminarAlumno(int Cod)
        {
            int Index = -1;
            foreach (Alumno a in _alumnos)
                {
                    if (a.Codigo == Cod)
                    {
                    Index = _alumnos.IndexOf(a);
                    }
                }
            if (Index != -1)
            {
                _alumnos.RemoveAt(Index);
            }
            
        }

        public void EliminarEmpleado (int Cod)
        {
            Empleado buscado = _empleados.Find(e => e.Legajo == Cod);
            _empleados.Remove(buscado);
        }

        public List<Alumno> TraerAlumnos()
        {
            return this._alumnos.ToList();
        }

        public List<Empleado> TraerEmpleados()
        {
            return this._empleados.ToList();
        }

        public Empleado TraerEmpleadoPorLegajo (int Leg)
        {
            Empleado buscado = _empleados.Find(e => e.Legajo == Leg);
            return buscado;
        }

        public List<Empleado> TraerEmpleadosPorNombre(string Nombre)
        {
            return _empleados.FindAll(e => e.Nombre == Nombre);
        }

    }
}
