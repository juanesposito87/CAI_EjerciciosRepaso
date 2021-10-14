using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.BibliotecaDeClases.Excepciones
{
    public class SinStockException : Exception
    {
        public SinStockException(string Prenda) : base(String.Format("No hay stock suficiente para la prenda {0}",Prenda))
        {

        }
    }
}
