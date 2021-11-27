using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspositoSegundoParcial.Entidades.Dominio;

namespace EspositoSegundoParcial.Entidades.Excepciones
{
    public class PlazoMinimoException : Exception
    {
        public PlazoMinimoException(TipoPlazoFijo TPF, int Minimo) : base(String.Format("El plazo mínimo para un plazo fijo {0} es de {1} días.", TPF.Descripcion, Minimo))
        {

        }
    }
}
