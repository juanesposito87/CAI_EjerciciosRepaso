using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
