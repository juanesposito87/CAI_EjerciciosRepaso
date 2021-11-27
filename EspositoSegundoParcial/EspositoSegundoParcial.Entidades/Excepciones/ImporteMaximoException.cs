using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspositoSegundoParcial.Entidades.Excepciones
{
    public class ImporteMaximoException : Exception
    {
        public ImporteMaximoException() : base("El importe del plazo fijo no puede superar ARS 1.000.000.")
        {

        }
    }
}
