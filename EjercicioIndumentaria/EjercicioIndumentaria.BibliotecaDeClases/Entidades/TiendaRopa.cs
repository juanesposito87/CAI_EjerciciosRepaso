using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioIndumentaria.BibliotecaDeClases.Entidades.Abstractas;
using EjercicioIndumentaria.BibliotecaDeClases.Enum;

namespace EjercicioIndumentaria.BibliotecaDeClases.Entidades
{
    public static class TiendaRopa
    {
        private static List<Indumentaria> _inventario;
        private static List<Venta> _ventas;
        private static int _ultimoCodigo;

        
        /*
        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _ultimoCodigo = 0;
        }
       
        */

        public static List<Indumentaria> Inventario
        {
            get
            {
                return _inventario;
            }

            set
            {
                _inventario = value;
            }
        }

        public static List<Venta> Ventas
        {
            get
            {
                return _ventas;
            }

        }

        public static int GetProximoCodigo()
        {
            return (_ultimoCodigo + 1);
        }

        public static void Agregar(Indumentaria i)
        {
            _inventario.Add(i);
        }

        public static void Quitar(Indumentaria i)
        {
            _inventario.Remove(i);
        }

        public static void IngresarOrden(Venta v)
        {
            v.Estado = (int)EstadoVenta.Procesada;
            _ventas.Add(v);
            _ultimoCodigo = v.Codigo;
        }

        public static List<Indumentaria> Listar()
        {
            return _inventario;
        }

        public static List<Venta> ListarOrden()
        {
            return _ventas;
        }

        public static void DevolverOrden(Venta v)
        {
            v.Estado = (int)EstadoVenta.Devuelto;    
        }
    }
}
