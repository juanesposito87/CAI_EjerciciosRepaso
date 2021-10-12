using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public class VentaItem

    {
        private Indumentaria _prenda;
        private int _cantidad;

        public VentaItem(Indumentaria P, int Q)
        {
            _prenda = P;
            _cantidad = Q;
        }

        public Indumentaria Prenda
        {
            get
            {
                return _prenda;
            }

            set
            {
                _prenda = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }

        public double GetTotal()
        {
            return (_cantidad * _prenda.Precio);
        }
    }
}
