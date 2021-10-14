using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public class Pantalon : Indumentaria
    {
        protected string _material;
        protected bool _tieneBolsillos;

        public string Material
        {
            get
            {
                return _material;
            }
        }

        public bool TieneBolsillos
        {
            get
            {
                return _tieneBolsillos;
            }
        }

        internal string StrBolsillos()
        {
            if(_tieneBolsillos)
            {
                return "Con bolsillos";
            }
            else
            {
                return "Sin bolsillos";
            }
        }

        public Pantalon(int Codigo) : base(Codigo)
        {

        }
        public Pantalon(TipoIndumentaria Tipo, bool Bolsillos, string Material) : base(Tipo)
        {
            _tieneBolsillos = Bolsillos;
            _material = Material;
        }

        public Pantalon(TipoIndumentaria Tipo, bool Bolsillos, string Material, int Stock, string Talle) : base(Tipo, Stock, Talle)
        {
            _tieneBolsillos = Bolsillos;
            _material = Material;
        }

        public Pantalon(TipoIndumentaria Tipo, bool Bolsillos, string Material, int Stock, string Talle, double Precio) : base(Tipo, Stock, Talle, Precio)
        {
            _tieneBolsillos = Bolsillos;
            _material = Material;
        }

        public override string GetDetalle()
        {
            return String.Format("Código {0} - Pantalón de {1} {2} - Talle {3}", _codigo, _material, StrBolsillos(), _talle);
        }

    }
}
