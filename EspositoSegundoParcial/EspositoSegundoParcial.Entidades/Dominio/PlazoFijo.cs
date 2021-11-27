using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspositoSegundoParcial.Entidades.Utilidades;

namespace EspositoSegundoParcial.Entidades.Dominio
{
    public class PlazoFijo
    {
        private int _id;
        private int _idCliente;
        private int _tipo;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;
        private double _interes;
        private double _montoFinal;
        private string _usuario;
        private static int Numero = 1;
        private TipoPlazoFijo _tpf;

        public int id { get => _id; set => _id = value; }
        public int idCliente { get => _idCliente; set => _idCliente = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public int Dias { get => _dias; set => _dias = value; }
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        public double Interes { get => _interes; set => _interes = value; }
        public double MontoFinal { get => _montoFinal; set => _montoFinal = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        public PlazoFijo(TipoPlazoFijo Tpf, int Cliente, int Dias, double CapitalInicial)
        {
            _id = Numero;
            Numero++;
            _idCliente = Cliente;
            _tipo = Tpf.Id;
            _tasa = Tpf.Tasa;
            _dias = Dias;
            _capitalInicial = CapitalInicial;
            _interes = (((_tasa / 365 * _dias) * _capitalInicial) / 100);
            _montoFinal = _capitalInicial + _interes;
            _usuario = DatosLogin._usuario;
        }

        public override string ToString()
        {
            return String.Format("{0}) {1} días - ARS {2} (interés {3}) - {4}", id, Dias, CapitalInicial, Interes, _tpf.Descripcion);
        }

    }
}
