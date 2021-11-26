using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaParcial.Entidades.Enum;
using PracticaParcial.Entidades.Utilidades;

namespace PracticaParcial.Entidades.Clases
{
    public class TarjetaCredito
    {
        private int _tipo;
        private int _periodoVencimiento;
        private double _limiteCompra;
        private string _nroPlastico;
        private string _usuario;
        private int _idCliente;


        public TarjetaCredito(TipoTarjeta tt, PeriodoCierre pc, double lc, string np, Cliente c)
        {
            _tipo = Convert.ToInt32(tt.GetTypeCode());
            _periodoVencimiento = Convert.ToInt32(pc.GetTypeCode());
            _limiteCompra = lc;
            _nroPlastico = np;
            _usuario = DatosLogin._usuario;
            _idCliente = c.Id;
        }

        public int Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }

        public int PeriodoVencimiento
        {
            get
            {
                return _periodoVencimiento;
            }

            set
            {
                _periodoVencimiento = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return _idCliente;
            }

            set
            {
                _idCliente = value;
            }
        }

        public double LimiteCompra 
        { 
            get
            {
                return _limiteCompra;
            }
            set
            {
                _limiteCompra = value;
            }
        }

        public string NroPlastico { get => _nroPlastico; set => _nroPlastico = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        public override string ToString()
        {
            return String.Format("{0} - Tarjeta {1} - Número {2} - {3}", IdCliente, Tipo, LimiteCompra.ToString("0.00"));
        }
    }
}
