using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspositoSegundoParcial.Entidades.Excepciones
{
    public class PlazoMaximoException : Exception
    {
        public PlazoMaximoException() : base("El plazo máximo para cualquier plazo fijo es de 365 días.")
        {

        }
    }
}
