using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFacultad.BibliotecaClases.Entidades
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;
        private static int CodTransAct = 1;

        public Salario (double Bruto)
        {

            DateTime Hoy = DateTime.Now;
            _bruto = Bruto;
            _descuentos = Descuentos;
            _fecha = Hoy;
            _codigoTransferencia = Convert.ToString(CodTransAct);
            CodTransAct++;

        }

        public double GetSalarioNeto()
        {
            return (_bruto - _descuentos);
        }

        public double Bruto
        {
            get
            {
                return _bruto;
            }
            set
            {
                _bruto = value;
            }
        }

        public string CodigoTransferencia
        {
            get
            {
                return _codigoTransferencia;
            }
        }

        public double Descuentos
        {
            get
            {
                return _descuentos;
            }
            set
            {
                _descuentos = _bruto * 0.17;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = DateTime.Now;
            }
        }
    }
}
