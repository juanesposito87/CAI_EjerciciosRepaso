using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaParcial.Datos;

namespace PracticaParcial.Negocio
{
    public class TarjetaNegocio
    {
        private MapperTarjeta _mapperTarjeta;

        public TarjetaNegocio()
        {
            _mapperTarjeta = new MapperTarjeta();
        }

    }
}
