using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspositoSegundoParcial.Entidades.Dominio
{
    public class TipoPlazoFijo
    {
        private int _id;
        private double _tasa;
        private string _descripcion;

        public int Id { get => _id; set => _id = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public TipoPlazoFijo(int Numero, string Descripcion, double Tasa)
        {
            _id = Numero;
            _descripcion = Descripcion;
            _tasa = Tasa;
        }

        public string Display()
        {
            return String.Format("{0} - {1}", Id, Descripcion);
        }

        

    }
}
