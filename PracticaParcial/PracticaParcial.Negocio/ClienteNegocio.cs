using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaParcial.Datos;
using PracticaParcial.Entidades.Clases;

namespace PracticaParcial.Negocio
{
    public class ClienteNegocio
    {
        private MapperCliente _mapperCliente;

        public ClienteNegocio()
        {
            _mapperCliente = new MapperCliente();
        }
        
        public List<Cliente> TraerClientes()
        {
            return _mapperCliente.GetClientes();
        }

    }
}
