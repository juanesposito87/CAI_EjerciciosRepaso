using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public class Cliente
    {
        private int _codigo;
        private string _apellido;
        private string _nombre;

        public Cliente(int Cod, string Ape, string Nom)
        {
            _codigo = Cod;
            _apellido = Ape;
            _nombre = Nom;
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
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

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
    }
}
