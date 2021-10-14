using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Enum;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public class Venta
    {
        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;

        public Venta(Cliente C)
        {
            _items = new List<VentaItem>();
            _cliente = C;
            _estado = ((int)EstadoVenta.Iniciada);
            _codigo = TiendaRopa.GetProximoCodigo();
        }

        public double GetTotalPedido()
        {
            double Suma = 0;
            foreach (VentaItem i in this._items)
            {
                Suma += i.GetTotal();
            }
            return Suma;
        }

        public int GetCantidadTotal()
        {
            int Suma = 0;
            foreach (VentaItem i in this._items)
            {
                Suma += i.Cantidad;
            }
            return Suma;
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        
        public int Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
        }

        public List<VentaItem> Items
        {
            get
            {
                return _items;
            }
        }
    }
}
