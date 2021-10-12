using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas
{
    public abstract class TipoIndumentaria
    {
        protected string _origen;
        protected double _porcentajeAlgodon;

        public TipoIndumentaria(string Origen, double PorcentajeAlgodon)
        {
            _origen = Origen;
            _porcentajeAlgodon = PorcentajeAlgodon;
        }

        public string Origen
        {
            get
            {
                return _origen;
            }
        }

        public double PorcentajeAlgodon
        {
            get
            {
                return _porcentajeAlgodon;
            }
        }

    }
}
