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
    public class MapperTarjeta
    {
        public List<TarjetaCredito> GetTarjetas()
        {
            string json = WebHelper.Get("tarjetacredito");
            List<TarjetaCredito> devolver = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);
            return devolver;
        }
    }
}
