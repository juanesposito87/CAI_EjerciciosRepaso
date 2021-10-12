using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas
{
    public abstract class Indumentaria
    {
        protected TipoIndumentaria _tipo;
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;
        private static int CodigoActual;

        public Indumentaria(TipoIndumentaria Tipo)
        {
            _tipo = Tipo;
            _codigo = CodigoActual;
            CodigoActual++;
            _stock = 3;
        }

        public Indumentaria(TipoIndumentaria Tipo, int Stock, string Talle)
        {
            _tipo = Tipo;
            _codigo = CodigoActual;
            CodigoActual++;
            _stock = Stock;
            _talle = Talle;
        }

        public Indumentaria(TipoIndumentaria Tipo, int Stock, string Talle, double Precio)
        {
            _tipo = Tipo;
            _codigo = CodigoActual;
            CodigoActual++;
            _stock = Stock;
            _talle = Talle;
            _precio = Precio;
        }

        public TipoIndumentaria Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }

        public string Talle
        {
            get
            {
                return _talle;
            }
            set
            {
                _talle = value;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public override string ToString()
        {
            return this.GetDetalle();
        }

        public abstract string GetDetalle();

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                if (((Indumentaria)obj)._codigo == this._codigo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
