using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal(string Origen, double Porcentaje) : base (Origen, Porcentaje)
        {

        }
    }
}
