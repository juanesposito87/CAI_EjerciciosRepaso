using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspositoSegundoParcial.Entidades.Dominio
{
    public class OperadorModel
    {
        public List<PlazoFijo> PlazoFijo;
        public double MontoTotal;
        public double Comision;


        public void SumarPlazosFijos(List<PlazoFijo> listado)
        {
            PlazoFijo = listado;
            double Total = 0.00;
            foreach (PlazoFijo pf in PlazoFijo)
            {
                Total += pf.CapitalInicial; 
            }

            MontoTotal = Total;
        }

        public void CalcularComision(List<PlazoFijo> listado)
        {
            PlazoFijo = listado;
            double ComisionTotal = 0.00;
            foreach (PlazoFijo pf in PlazoFijo)
            {
                ComisionTotal += 15 + pf.Interes;
            }
            Comision = ComisionTotal;
        }



    }
}
