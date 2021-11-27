using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspositoSegundoParcial.Datos;
using EspositoSegundoParcial.Entidades.Utilidades;
using EspositoSegundoParcial.Entidades.Dominio;
using EspositoSegundoParcial.Entidades.Excepciones;


namespace EspositoSegundoParcial.Negocio
{
    public class NegocioPlazoFijo
    {
        private MapperPlazoFIjo _servicioPlazoFijo;

        public NegocioPlazoFijo()
        {
            _servicioPlazoFijo = new MapperPlazoFIjo();
        }

        public List<PlazoFijo> TraerPlazoFijoPorUsuario()
        {
            return _servicioPlazoFijo.GetPlazosFijosPorUsuario(DatosLogin._usuario);
        }

        public ResultadoTransaccion CargarPlazoFijo(TipoPlazoFijo tpf, int IdCliente, int Dias, double KInicial)
        {
            PlazoFijo pf = new PlazoFijo(tpf, IdCliente, Dias, KInicial);
            return _servicioPlazoFijo.PostPlazoFijo(pf, DatosLogin._usuario);
        }

        public List<TipoPlazoFijo> TipoPFS()
        {
            List<TipoPlazoFijo> TPFS = new List<TipoPlazoFijo>();
            TipoPlazoFijo z = new TipoPlazoFijo(0, "Seleccione", 0);
            TipoPlazoFijo a = new TipoPlazoFijo(1, "Plazo Fijo Web", 43);
            TipoPlazoFijo b = new TipoPlazoFijo(2, "Plazo Fijo UVA", 2);
            TPFS.Add(z);
            TPFS.Add(a);
            TPFS.Add(b);

            return TPFS;
        }

        public PlazoFijo Simular(TipoPlazoFijo tpf, double KInvertir, int Dias)
        {
            int Minimo = 0;
            switch(tpf.Id)
            {
                case (1):
                    {
                        Minimo = 30;
                        break;
                    }
                    
                case (2):
                    {
                        Minimo = 180;
                        break;
                    }
                default:
                    break;
            }

            if(Dias<Minimo)
            {
                throw new PlazoMinimoException(tpf, Minimo);
            }

            else if (Dias>365)
            {
                throw new PlazoMaximoException();
            }

            else
            {
                PlazoFijo pf = new PlazoFijo(tpf, DatosLogin._cliente, Dias, KInvertir);
                return pf;
            }
          

        }


    }
}
