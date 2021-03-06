using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public abstract class Empleado : Persona

    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;
        private static int LegajoActual = 1;

        public Empleado (DateTime FechaNac, DateTime FechaIngreso, string Apellido, string Nombre) : base(FechaNac, Apellido, Nombre)
        {
            _legajo = LegajoActual;
            LegajoActual++;
            _salarios = new List<Salario>();
        }
        

        public void AgregarSalario(Salario S)
        {
            this._salarios.Add(S);
        }

        public override bool Equals(object obj)
        {
            if (this.GetType().Equals(obj.GetType()))
            {
                Empleado e = (Empleado)obj;
                return (this.Legajo == e.Legajo);
            }
            return false;
        }

        public override string GetCredencial()
        {
            return String.Format("{0} - {1} salario $ {2}", _legajo, GetNombreCompleto(), UltimoSalario().GetSalarioNeto());

        }

        public Salario UltimoSalario()
        {
            return _salarios.Last();
        }
       
        public abstract override string GetNombreCompleto();

        public override string ToString()
        {
            return GetCredencial();
        }

        public int Antiguedad
        {
                get
            {
                    if ((DateTime.Now.Month >= _fechaIngreso.Month) && (DateTime.Now.Day >= _fechaIngreso.Day))
                    {
                        return (DateTime.Now.Year - _fechaIngreso.Year);
                    }
                    else 
                    {
                        return (DateTime.Now.Year - _fechaIngreso.Year - 1);
                    }
            }

        }

        public DateTime FechaIngreso
        {
            get
            {
                return _fechaIngreso;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return this._fechaNac;
            }
        }

        public int Legajo
        {
            get
            {
                return _legajo;
            }
        }

        public List<Salario> Salarios
        {
            get
            {
                return _salarios;
            }
            set
            {
                _salarios = new List<Salario>();
            }
        }

    }

}
