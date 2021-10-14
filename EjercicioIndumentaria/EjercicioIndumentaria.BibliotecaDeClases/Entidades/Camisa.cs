using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public class Camisa : Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        public Camisa(TipoIndumentaria Tipo, bool Estampado, string Manga) : base(Tipo)
        {
            _tieneEstampado = Estampado;
            _tipoManga = Manga;
        }

        public Camisa(TipoIndumentaria Tipo, bool Estampado, string Manga, int Stock, string Talle) : base(Tipo, Stock, Talle)
        {
            _tieneEstampado = Estampado;
            _tipoManga = Manga;
        }

        public Camisa(TipoIndumentaria Tipo, bool Estampado, string Manga, int Stock, string Talle, double Precio) : base(Tipo, Stock, Talle, Precio)
        {
            _tieneEstampado = Estampado;
            _tipoManga = Manga;
        }

        public Camisa(int Codigo) : base(Codigo)
        {

        }
        public override string GetDetalle()
        {
            return String.Format("Código {0} - Camisa {1} {2} - Talle {3}", _codigo, _tipoManga, StrEstampado(), _talle);
        }

        internal string StrEstampado()
        {
            if (_tieneEstampado)
            {
                return "Estampada";
            }
            else
            {
                return "Lisa";
            }
        }

        public bool TieneEstampado
        {
            get
            {
                return _tieneEstampado;
            }
        }

        public string TipoManga
        {
            get
            {
                return _tipoManga;
            }
        }


    }
}
