using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaParcial.Entidades.Utilidades;

namespace PracticaParcial.Entidades.Clases
{
    public class Cliente
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private string _usuario;
        private string _host;
        private int _id;
        private static int Numero = 1;

        public int Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Host { get => _host; set => _host = value; }
        public int Id { get => _id; set => _id = value; }

        public Cliente(int Dni, string Nombre, string Apellido, string Direccion, string Email, string Telefono, DateTime FechaNacimiento)
        {
            _dni = Dni;
            _nombre = Nombre;
            _apellido = Apellido;
            _direccion = Direccion;
            _email = Email;
            _telefono = Telefono;
            _fechaNacimiento = FechaNacimiento;
            _fechaAlta = DateTime.Now;
            _activo = true;
            _usuario = DatosLogin._usuario;
            _host = DatosLogin._host;
            _id = Numero;
            Numero++;
        }

        public string Display
        {
            get
            {
                return String.Format("{0} - {1}, {2}", Id, Apellido, Nombre);
            }
        }
    }
}
