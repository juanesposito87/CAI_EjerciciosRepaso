using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PracticaParcial.Entidades.Clases;

namespace PracticaParcial.Datos
{
    public class MapperCliente
    {
        public List<Cliente> GetClientes()
        {
            string Ser = WebHelper.Get("cliente");
            List<Cliente> Todos = JsonConvert.DeserializeObject<List<Cliente>>(Ser);
            return Todos; 
        }

        public ResultadoTransaccion Insertar(Cliente c)
        {

        }

    }
}
